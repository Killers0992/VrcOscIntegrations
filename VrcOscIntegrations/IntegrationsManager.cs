using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;

namespace VrcOscIntegrations
{
    public class IntegrationsManager
    {
        static IntegrationsManager _manager;
        public static IntegrationsManager Manager
        {
            get
            {
                if (_manager == null)
                    _manager = new IntegrationsManager();

                return _manager;
            }
        }

        public string MainPath;

        public void RegisterIntegrations(ref IServiceCollection services)
        {
            var integrationsToEnable = Integrations
                .Where(p => p.Value.Status == IntegrationStatus.Loaded)
                .Select(p => p.Key)
                .ToArray();

            int enabled = 0;

            Logger.Info("Loader", $"Register {integrationsToEnable.Length} integrations...", Color.Crimson, Color.White);

            List<Assembly> registeredAssemblies = new List<Assembly>();

            for (int x = 0; x < integrationsToEnable.Length; x++)
            {
                if (!Integrations.TryGetValue(integrationsToEnable[x], out IVrcIntegration<IConfig> integration))
                {
                    Logger.Info("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Skipped register of integration with id \"{integrationsToEnable[x]}\". ( integration is not loaded )", Color.Crimson, Color.White);
                    continue;
                }

                Logger.Info("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Register integration \"{integration.Name}\" ({integration.Version})...", Color.Crimson, Color.White);
                try
                {
                    integration.OnRegister(ref services);
                    var assembly = integration.GetType().Assembly;

                    services.AddControllersWithViews()
                        .AddApplicationPart(assembly);

                    integration.Status = IntegrationStatus.Registered;
                }
                catch (Exception ex)
                {
                    Logger.Warn("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Error while invoking OnRegister in integration \"{integration.Name}\" ({integration.Version}).\n{ex}", Color.Crimson, Color.White);
                    continue;
                }

                Logger.Info("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Registered integration \"{integration.Name}\" ({integration.Version}).", Color.Crimson, Color.White);
                enabled++;
            }

            Logger.Info("Loader", $"Registered {enabled}/{integrationsToEnable.Length} integrations.", Color.Crimson, Color.White);
        }

        public void EnableIntegrations()
        {
            var integrationsToEnable = Integrations
                .Where(p => p.Value.Status == IntegrationStatus.Registered)
                .Select(p => p.Key)
                .ToArray();

            int enabled = 0;

            Logger.Info("Loader", $"Enabling {integrationsToEnable.Length} integrations...", Color.Crimson, Color.White);

            for (int x = 0; x < integrationsToEnable.Length; x++)
            {
                if (!Integrations.TryGetValue(integrationsToEnable[x], out IVrcIntegration<IConfig> integration))
                {
                    Logger.Info("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Skipped enabling integration with id \"{integrationsToEnable[x]}\". ( integration is not registered )", Color.Crimson, Color.White);
                    continue;
                }

                Logger.Info("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Enabling integration \"{integration.Name}\" ({integration.Version})...", Color.Crimson, Color.White);
                try
                {
                    integration.OnEnable();
                    integration.Status = IntegrationStatus.Enabled;
                }
                catch (Exception ex)
                {
                    Logger.Warn("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Error while invoking OnEnable in integration \"{integration.Name}\" ({integration.Version}).\n{ex}", Color.Crimson, Color.White);
                    continue;
                }

                Logger.Info("Loader", $"[{x + 1}/{integrationsToEnable.Length}] Enabled integration \"{integration.Name}\" ({integration.Version}).", Color.Crimson, Color.White);
                enabled++;
            }
            Logger.Info("Loader", $"Enabled {enabled}/{integrationsToEnable.Length} integrations.", Color.Crimson, Color.White);
        }

        public void LoadIntegrations()
        {
            MainPath = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(MainPath);
            LoadDependencies(Path.Combine(MainPath, "Dependencies"));
            LoadIntegrationAssemblies(Path.Combine(MainPath, "Integrations"));
        }

        public void LoadDependencies(string directory)
        {
            var totalDependencies = new DirectoryInfo(directory).GetFiles("*.dll");
            int loaded = 0;

            Logger.Info("Loader", $"Loading {totalDependencies.Length} dependencies...", Color.Crimson, Color.White);

            for (int x = 0; x < totalDependencies.Length; x++)
            {
                var fileName = Path.GetFileNameWithoutExtension(totalDependencies[x].FullName);
                if (LoadedAssemblies.ContainsKey(fileName))
                {
                    Logger.Info("Loader", $"[{x + 1}/{totalDependencies.Length}] Skipped loading dependency \"{fileName}\". ( already loaded )", Color.Crimson, Color.White);
                }
                else
                {
                    Logger.Info("Loader", $"[{x + 1}/{totalDependencies.Length}] Loading dependency \"{fileName}\"...", Color.Crimson, Color.White);
                    try
                    {
                        var ass = Assembly.LoadFrom(totalDependencies[x].FullName);
                        LoadedAssemblies.Add(fileName, ass);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Loader", $"[{x + 1}/{totalDependencies.Length}] Error while loading dependency \"{fileName}\".\n {ex}", Color.Crimson, Color.White);
                        continue;
                    }
                    Logger.Info("Loader", $"[{x + 1}/{totalDependencies.Length}] Loaded dependency \"{fileName}\".", Color.Crimson, Color.White);
                    loaded++;
                }
            }
            Logger.Info("Loader", $"Loaded {loaded}/{totalDependencies.Length} dependencies.", Color.Crimson, Color.White);
        }

        public void LoadIntegrationAssemblies(string directory)
        {
            var totalIntegrations = new DirectoryInfo(directory).GetFiles("*.dll");
            int loaded = 0;

            Logger.Info("Loader", $"Loading {totalIntegrations.Length} integrations...", Color.Crimson, Color.White);

            for (int x = 0; x < totalIntegrations.Length; x++)
            {
                var fileName = Path.GetFileNameWithoutExtension(totalIntegrations[x].FullName);
                if (LoadedAssemblies.ContainsKey(fileName))
                {
                    Logger.Info("Loader", $"[{x + 1}/{totalIntegrations.Length}] Skipped loading integration \"{fileName}\". ( already loaded )", Color.Crimson, Color.White);
                }
                else
                {
                    IVrcIntegration<IConfig> integration = null;
                    Logger.Info("Loader", $"[{x + 1}/{totalIntegrations.Length}] Loading integration \"{fileName}\"...", Color.Crimson, Color.White);
                    try
                    {
                        var ass = Assembly.LoadFrom(totalIntegrations[x].FullName);
                        var integrationClass = ass.GetTypes().FirstOrDefault(p =>
                            !p.IsInterface &&
                            !p.IsAbstract &&
                            p.BaseType.IsGenericType &&
                            p.BaseType.GetGenericTypeDefinition() == typeof(VrcIntegration<>));

                        if (integrationClass == null)
                        {
                            Logger.Info("Loader", $"[{x + 1}/{totalIntegrations.Length}] Failed loading integration \"{fileName}\". ( integration dont have valid class )", Color.Crimson, Color.White);
                            continue;
                        }

                        var construct = integrationClass.GetConstructor(Type.EmptyTypes);
                        if (construct != null)
                        {
                            integration = construct.Invoke(null) as IVrcIntegration<IConfig>;
                        }
                        else
                        {
                            var value = Array.Find(
                                integrationClass.GetProperties(
                                    BindingFlags.Static |
                                    BindingFlags.NonPublic |
                                    BindingFlags.Public),
                                property => property.PropertyType == integrationClass)?.GetValue(null);

                            if (value != null)
                                integration = value as IVrcIntegration<IConfig>;
                        }

                        if (integration == null)
                        {
                            Logger.Info("Loader", $"[{x + 1}/{totalIntegrations.Length}] Failed loading integration \"{fileName}\". ( invalid constructor )", Color.Crimson, Color.White);
                            continue;
                        }

                        integration.IntegrationPath = Path.Combine(MainPath, "Integrations", integration.Name);

                        if (!Directory.Exists(integration.IntegrationPath))
                            Directory.CreateDirectory(integration.IntegrationPath);

                        if (!File.Exists(Path.Combine(integration.IntegrationPath, "config.yml")))
                            File.WriteAllText(Path.Combine(integration.IntegrationPath, "config.yml"), YDS.Serializer.Serialize(integration.OnCreateDefaultConfig()));
                        
                        integration.Config.CopyProperties((IConfig)YDS.Deserializer.Deserialize(File.ReadAllText(Path.Combine(integration.IntegrationPath, "config.yml")), integration.Config.GetType()));
                        integration.SaveConfig();

                        integration.Status = IntegrationStatus.Loaded;

                        Integrations.Add(integration.Id, integration);
                        IntegrationsAssemblies.Add(ass, integration.Id);
                        LoadedAssemblies.Add(fileName, ass);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Loader", $"[{x + 1}/{totalIntegrations.Length}] Error while loading integration \"{fileName}\".\n {ex}", Color.Crimson, Color.White);
                        continue;
                    }
                    Logger.Info("Loader", $"[{x + 1}/{totalIntegrations.Length}] Loaded integration \"{integration.Name}\" ({integration.Version}) made by {integration.Author}.", Color.Crimson, Color.White);
                    loaded++;
                }
            }
            Logger.Info("Loader", $"Loaded {loaded}/{totalIntegrations.Length} integrations.", Color.Crimson, Color.White);
        }

        public readonly static Dictionary<string, Assembly> LoadedAssemblies = new Dictionary<string, Assembly>();
        public readonly static Dictionary<Assembly, string> IntegrationsAssemblies = new Dictionary<Assembly, string>();
        public readonly static Dictionary<string, IVrcIntegration<IConfig>> Integrations = new Dictionary<string, IVrcIntegration<IConfig>>();
    }
}
