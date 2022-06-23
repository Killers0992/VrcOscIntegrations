using VrcOscIntegrations.Services;

namespace VrcOscIntegrations
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHostedService<OscActions>();
            services.AddHostedService<IntegrationsFetch>();
            services.AddHostedService<AutoUpdater>();

            IntegrationsManager.Manager.RegisterIntegrations(ref services);

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(ends =>
            {
                ends.MapControllers();
            });
            IntegrationsManager.Manager.EnableIntegrations();
        }
    }
}
