namespace VrcOscIntegrations.Interface.Entries
{
    public partial class ConsoleLogExtendEntry : PoisonUserControl
    {
        public ConsoleLogExtendEntry()
        {
            InitializeComponent();
        }

        Color _messageColor;
        public Color MessageColor
        {
            get
            {
                return _messageColor;
            }
            set
            {
                _messageColor = value;
                message.ForeColor = _messageColor;
            }
        }

        string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                message.Text = _message;
            }
        }
    }
}
