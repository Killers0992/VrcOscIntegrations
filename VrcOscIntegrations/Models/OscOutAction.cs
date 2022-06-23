using CoreOSC;

namespace VrcOscIntegrations.Models
{
    public class OscOutAction
    {
        [YamlMember(Description = "Name of OSC action.")]
        public string ActionName { get; set; } = "/avatar/parameters/VRCEmote";
        [YamlMember(Description = "How long in seconds that action is executed. ( 0 means instant )")]
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
        public OscMessage RawMessage { get; set; }

        [YamlIgnore]
        public DateTime ExecutionTime => _assignedTime;

        [YamlMember(Description = "Default value is set after \"ExecutionDuration\". ( Supported values: true/false (bool), 0/1 (integer), 0.1/0.0 (float) and if set to \"null\" it does nothing )")]
        public object DefaultValue { get; set; }
        [YamlMember(Description = "Value of action. ( Supported values: true/false (bool), 0/1 (integer), 0.1/0.0 (float) and if set to \"null\" it does nothing )")]
        public object Value { get; set; }
    }
}
