namespace VrcOscIntegrations.Interface.Entries
{
    partial class IntegrationHeader
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.integrationName = new ReaLTaiizor.Controls.PoisonLabel();
            this.moveBack = new ReaLTaiizor.Controls.PoisonButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.24078F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75921F));
            this.tableLayoutPanel1.Controls.Add(this.integrationName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.moveBack, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // integrationName
            // 
            this.integrationName.AutoSize = true;
            this.integrationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.integrationName.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.integrationName.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.integrationName.Location = new System.Drawing.Point(3, 0);
            this.integrationName.Name = "integrationName";
            this.integrationName.Size = new System.Drawing.Size(696, 35);
            this.integrationName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.integrationName.TabIndex = 0;
            this.integrationName.Text = "Integration Name";
            this.integrationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.integrationName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // moveBack
            // 
            this.moveBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveBack.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.moveBack.Location = new System.Drawing.Point(708, 6);
            this.moveBack.Margin = new System.Windows.Forms.Padding(6);
            this.moveBack.Name = "moveBack";
            this.moveBack.Size = new System.Drawing.Size(100, 23);
            this.moveBack.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.moveBack.TabIndex = 1;
            this.moveBack.Text = "Back";
            this.moveBack.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.moveBack.UseSelectable = true;
            this.moveBack.Click += new System.EventHandler(this.moveBack_Click);
            // 
            // IntegrationHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IntegrationHeader";
            this.Size = new System.Drawing.Size(814, 35);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PoisonLabel integrationName;
        private PoisonButton moveBack;
    }
}
