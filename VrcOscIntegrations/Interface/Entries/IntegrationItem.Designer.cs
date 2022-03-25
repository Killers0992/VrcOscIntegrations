namespace VrcOscIntegrations.Interface.Entries
{
    partial class IntegrationItem
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.integrationName = new ReaLTaiizor.Controls.PoisonLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.interactionButton = new ReaLTaiizor.Controls.PoisonButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.integrationAuthor = new ReaLTaiizor.Controls.PoisonLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.integrationName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(644, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // integrationName
            // 
            this.integrationName.AutoSize = true;
            this.integrationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.integrationName.Location = new System.Drawing.Point(3, 0);
            this.integrationName.Name = "integrationName";
            this.integrationName.Size = new System.Drawing.Size(638, 29);
            this.integrationName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.integrationName.TabIndex = 0;
            this.integrationName.Text = "Integration name";
            this.integrationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.integrationName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.interactionButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(655, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(155, 94);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // interactionButton
            // 
            this.interactionButton.Location = new System.Drawing.Point(3, 50);
            this.interactionButton.Name = "interactionButton";
            this.interactionButton.Size = new System.Drawing.Size(149, 41);
            this.interactionButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.interactionButton.TabIndex = 0;
            this.interactionButton.Text = "View";
            this.interactionButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.interactionButton.UseSelectable = true;
            this.interactionButton.Click += new System.EventHandler(this.interactionButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.poisonLabel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.integrationAuthor, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(149, 41);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonLabel1.Location = new System.Drawing.Point(3, 0);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(143, 20);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Author";
            this.poisonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // integrationAuthor
            // 
            this.integrationAuthor.AutoSize = true;
            this.integrationAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.integrationAuthor.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.integrationAuthor.Location = new System.Drawing.Point(3, 20);
            this.integrationAuthor.Name = "integrationAuthor";
            this.integrationAuthor.Size = new System.Drawing.Size(143, 21);
            this.integrationAuthor.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.integrationAuthor.TabIndex = 1;
            this.integrationAuthor.Text = "Unknown";
            this.integrationAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.integrationAuthor.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // IntegrationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IntegrationItem";
            this.Size = new System.Drawing.Size(814, 105);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PoisonButton interactionButton;
        private TableLayoutPanel tableLayoutPanel4;
        private PoisonLabel poisonLabel1;
        private PoisonLabel integrationAuthor;
        private PoisonLabel integrationName;
    }
}
