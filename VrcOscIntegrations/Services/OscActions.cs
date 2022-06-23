using CoreOSC;
using CoreOSC.IO;
using VrcOscIntegrations.Models;

namespace VrcOscIntegrations.Services
{
    public class OscActions : BackgroundService
    {
        static UdpClient _receiver;
        static UdpClient _sender;
        static IPEndPoint _senderEndpoint;
        static IPEndPoint _receiverEndpoint;

        public static ConcurrentDictionary<string, Queue<OscOutAction>> ActionsQueue = new ConcurrentDictionary<string, Queue<OscOutAction>>();

        public ConcurrentDictionary<string, OscOutAction> CurrentlyRunningActions = new ConcurrentDictionary<string, OscOutAction>();

        public static void SendAction(OscMessage message)
        {
            EnqueueAction(new OscOutAction()
            {
                ActionName = String.Empty,
                RawMessage = message,
            });
        }

        public static void EnqueueAction(OscOutAction action)
        {
            Logger.Debug("OsrActions", $"Add new action {action.ActionName} to queue.", Color.Yellow, Color.White);
            if (ActionsQueue.TryGetValue(action.ActionName, out Queue<OscOutAction> queue))
                queue.Enqueue(action);
            else
                ActionsQueue.TryAdd(action.ActionName, new Queue<OscOutAction>(new[] { action }));
        }

        private async Task SendOcsData(string action, object obj)
        {
            if (obj is int _int)
                await _sender.SendMessageAsync(new OscMessage(new Address(action), new object[] { _int }));
            else if (obj is long _long)
                await _sender.SendMessageAsync(new OscMessage(new Address(action), new object[] { (int)_long }));
            else if (obj is double _double)
                await _sender.SendMessageAsync(new OscMessage(new Address(action), new object[] { (float)_double }));
            else if (obj is bool _bool)
                await _sender.SendMessageAsync(new OscMessage(new Address(action), new object[] { _bool }));
        }

        public async Task TryExecuting()
        {
            foreach (var action in ActionsQueue)
            {
                if (action.Value.Count == 0)
                {
                    ActionsQueue.TryRemove(action.Key, out _);
                    continue;
                }

                if (!CurrentlyRunningActions.ContainsKey(action.Key) || action.Key == String.Empty)
                {
                    var newAction = action.Value.Dequeue();

                    if (action.Key == String.Empty)
                    {
                        await _sender.SendMessageAsync(newAction.RawMessage);
                        continue;
                    }

                    if (newAction.Value != null)
                    {
                        await SendOcsData(action.Key, newAction.Value);
                        Logger.Debug("OscActions", $"On execution start send value {newAction.Value} ({newAction.Value.GetType().FullName}) for action {newAction.ActionName}", Color.Yellow, Color.White);
                    }

                    newAction.AssignedTime = DateTime.Now;
                    Logger.Debug("OscActions", $"Execution time for action {action.Key} ends in {(int)(newAction.ExecutionTime - DateTime.Now).TotalSeconds} seconds", Color.Yellow, Color.White);
                    CurrentlyRunningActions.TryAdd(action.Key, newAction);
                }
            }

            foreach (var running in CurrentlyRunningActions)
            {
                if (running.Value.ExecutionTime < DateTime.Now)
                {
                    if (running.Value.DefaultValue != null)
                    {
                        await SendOcsData(running.Key, running.Value.DefaultValue);
                        Logger.Debug("OscActions", $"On execution end send default value {running.Value.DefaultValue} for action {running.Key}", Color.Yellow, Color.White);
                    }
                    Logger.Debug("OscActions", $"Execution time for action {running.Key} ended.", Color.Yellow, Color.White);
                    CurrentlyRunningActions.TryRemove(running.Key, out _);
                }
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _sender = new UdpClient();
            _receiver = new UdpClient();

            _senderEndpoint = new IPEndPoint(IPAddress.Parse(MainConfig.Instance.OscClient.IpAddress), MainConfig.Instance.OscClient.Port);
            Logger.Info("OscSender", $"Connect to IP: {MainConfig.Instance.OscClient.IpAddress}, Port: {MainConfig.Instance.OscClient.Port}.", Color.Yellow, Color.White);
            _sender.Connect(_senderEndpoint);

            _receiverEndpoint = new IPEndPoint(IPAddress.Parse(MainConfig.Instance.OscServer.IpAddress), MainConfig.Instance.OscServer.Port);
            Logger.Info("OscReceiver", $"Start listening on IP: {MainConfig.Instance.OscServer.IpAddress}, Port: 9001.", Color.Yellow, Color.White);
            _receiver.Connect(_receiverEndpoint);

            await Task.WhenAll(new Task[]
            {
                Runner1(),
                Runner2()
            });
        }

        private async Task Runner1()
        {
            Logger.Info("OscSender", "Start runner...", Color.Yellow, Color.White);
            while (true)
            {
                try
                {
                    await TryExecuting();
                }
                catch (Exception ex)
                {
                    Logger.Error("OscSender", ex.Message, Color.Yellow, Color.White);
                }
                await Task.Delay(1);
            }
        }

        private async Task Runner2()
        {
            Logger.Info("OscReceiver", "Start runner...", Color.Yellow, Color.White);
            while (true)
            {
                try
                {
                    var message = await _receiver.ReceiveMessageAsync();
                    foreach(var integration in IntegrationsManager.Integrations.Values)
                    {
                        Logger.Info("LOG", (message.Address + " " + message.Address.Value), Color.White, Color.White);
                        integration.OnReceiveOscMessage(message.Address.Value, message);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error("OscReceiver", ex.Message, Color.Yellow, Color.White);
                }
                await Task.Delay(1);
            }
        }
    }
}
