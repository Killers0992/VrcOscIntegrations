using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VrcOscIntegrations.Interface.Entries
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class IntegrationHeader : PoisonUserControl
    {
        public IntegrationHeader()
        {
            InitializeComponent();
        }

        public string IntegrationId { get; set; }

        string _name;
        public string IntegrationName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                integrationName.Text = _name;
            }
        }

        private void moveBack_Click(object sender, EventArgs e)
        {
            Visible = false;

            if (ParentForm is not MainPanel panel) return;

            panel.myIntegrations.Controls.Remove(IntegrationsManager.Integrations[IntegrationId].MainPanel);
            foreach(IntegrationItem inter in panel.myIntegrations.Controls)
            {
                inter.Visible = true;
            }
        }
    }
}
