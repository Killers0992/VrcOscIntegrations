namespace VrcOscIntegrations.Interface.Entries
{
    partial class ConsoleLogEntry
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
            this.message = new ReaLTaiizor.Controls.PoisonLabel();
            this.tag = new ReaLTaiizor.Controls.PoisonLabel();
            this.type = new ReaLTaiizor.Controls.PoisonLabel();
            this.time = new ReaLTaiizor.Controls.PoisonLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.message, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tag, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.type, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.time, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 25);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(264, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(607, 25);
            this.message.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.message.TabIndex = 0;
            this.message.Text = "Test message.";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.message.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.message.UseCustomForeColor = true;
            // 
            // tag
            // 
            this.tag.AutoSize = true;
            this.tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tag.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.tag.ForeColor = System.Drawing.Color.Teal;
            this.tag.Location = new System.Drawing.Point(177, 0);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(81, 25);
            this.tag.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.tag.TabIndex = 1;
            this.tag.Text = "Loader";
            this.tag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tag.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.tag.UseCustomForeColor = true;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.type.Location = new System.Drawing.Point(90, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(81, 25);
            this.type.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.type.TabIndex = 2;
            this.type.Text = "INFO";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.type.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.type.UseCustomForeColor = true;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.time.ForeColor = System.Drawing.Color.Silver;
            this.time.Location = new System.Drawing.Point(3, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(81, 25);
            this.time.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.time.TabIndex = 3;
            this.time.Text = "00:00:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.time.UseCustomForeColor = true;
            // 
            // ConsoleLogEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConsoleLogEntry";
            this.Size = new System.Drawing.Size(874, 25);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PoisonLabel message;
        private PoisonLabel tag;
        private PoisonLabel type;
        private PoisonLabel time;
    }
}
