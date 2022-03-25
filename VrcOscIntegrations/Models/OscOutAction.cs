namespace VrcOscIntegrations.Models
{
    public class OscOutAction
    {
        public string ActionName { get; set; } = "/avatar/parameters/VRCEmote";
        public int ExecutionDuration { get; set; } = 3;

        DateTime _assignedTime;
        public DateTime AssignedTime
        {
            set
            {
                _assignedTime = value.AddSeconds(ExecutionDuration);
            }
        }

        [YamlIgnore]
        public DateTime ExecutionTime => _assignedTime;

        public object DefaultValue { get; set; }
        public object Value { get; set; }
    }
}
