using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System.Windows.Forms;

namespace VrcOscIntegrations.Interface
{
    partial class MainPanel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.main = new ReaLTaiizor.Controls.PoisonTabControl();
            this.homeTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.integrationsBrowserTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.integrationsBrowser = new System.Windows.Forms.FlowLayoutPanel();
            this.integrationsBrowserSearch = new ReaLTaiizor.Controls.PoisonTextBox();
            this.myIntegrationsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.header = new VrcOscIntegrations.Interface.Entries.IntegrationHeader();
            this.myIntegrations = new System.Windows.Forms.FlowLayoutPanel();
            this.consoleTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.consoleLogs = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.debugSwitch = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.poisonToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
            this.poisonStyleExtender = new ReaLTaiizor.Controls.PoisonStyleExtender(this.components);
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.main.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.integrationsBrowserTab.SuspendLayout();
            this.myIntegrationsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.consoleTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Controls.Add(this.homeTab);
            this.main.Controls.Add(this.integrationsBrowserTab);
            this.main.Controls.Add(this.myIntegrationsTab);
            this.main.Controls.Add(this.consoleTab);
            this.main.Controls.Add(this.settingsTab);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(20, 60);
            this.main.Name = "main";
            this.main.Padding = new System.Drawing.Point(6, 8);
            this.main.SelectedIndex = 0;
            this.main.Size = new System.Drawing.Size(882, 397);
            this.main.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.main.TabIndex = 0;
            this.main.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.main.UseSelectable = true;
            // 
            // homeTab
            // 
            this.homeTab.AutoScroll = true;
            this.homeTab.Controls.Add(this.bigLabel1);
            this.homeTab.HorizontalScrollbar = true;
            this.homeTab.HorizontalScrollbarBarColor = true;
            this.homeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.homeTab.HorizontalScrollbarSize = 10;
            this.homeTab.Location = new System.Drawing.Point(4, 38);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(25);
            this.homeTab.Size = new System.Drawing.Size(874, 355);
            this.homeTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.homeTab.VerticalScrollbar = true;
            this.homeTab.VerticalScrollbarBarColor = true;
            this.homeTab.VerticalScrollbarHighlightOnWheel = false;
            this.homeTab.VerticalScrollbarSize = 10;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(25, 25);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(634, 46);
            this.bigLabel1.TabIndex = 2;
            this.bigLabel1.Text = "Info about usage can be found on github";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // integrationsBrowserTab
            // 
            this.integrationsBrowserTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.integrationsBrowserTab.Controls.Add(this.integrationsBrowser);
            this.integrationsBrowserTab.Controls.Add(this.integrationsBrowserSearch);
            this.integrationsBrowserTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.integrationsBrowserTab.HorizontalScrollbarBarColor = true;
            this.integrationsBrowserTab.HorizontalScrollbarHighlightOnWheel = false;
            this.integrationsBrowserTab.HorizontalScrollbarSize = 10;
            this.integrationsBrowserTab.Location = new System.Drawing.Point(4, 35);
            this.integrationsBrowserTab.Name = "integrationsBrowserTab";
            this.integrationsBrowserTab.Size = new System.Drawing.Size(874, 358);
            this.integrationsBrowserTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Lime;
            this.integrationsBrowserTab.TabIndex = 4;
            this.integrationsBrowserTab.Text = "Integrations Browser";
            this.integrationsBrowserTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.integrationsBrowserTab.VerticalScrollbarBarColor = true;
            this.integrationsBrowserTab.VerticalScrollbarHighlightOnWheel = false;
            this.integrationsBrowserTab.VerticalScrollbarSize = 10;
            // 
            // integrationsBrowser
            // 
            this.integrationsBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.integrationsBrowser.AutoScroll = true;
            this.integrationsBrowser.BackColor = System.Drawing.Color.Transparent;
            this.integrationsBrowser.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.integrationsBrowser.Location = new System.Drawing.Point(3, 37);
            this.integrationsBrowser.Name = "integrationsBrowser";
            this.integrationsBrowser.Size = new System.Drawing.Size(868, 322);
            this.integrationsBrowser.TabIndex = 3;
            this.integrationsBrowser.WrapContents = false;
            // 
            // integrationsBrowserSearch
            // 
            // 
            // 
            // 
            this.integrationsBrowserSearch.CustomButton.Image = null;
            this.integrationsBrowserSearch.CustomButton.Location = new System.Drawing.Point(846, 1);
            this.integrationsBrowserSearch.CustomButton.Name = "";
            this.integrationsBrowserSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.integrationsBrowserSearch.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.integrationsBrowserSearch.CustomButton.TabIndex = 1;
            this.integrationsBrowserSearch.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.integrationsBrowserSearch.CustomButton.UseSelectable = true;
            this.integrationsBrowserSearch.CustomButton.Visible = false;
            this.integrationsBrowserSearch.Lines = new string[0];
            this.integrationsBrowserSearch.Location = new System.Drawing.Point(3, 8);
            this.integrationsBrowserSearch.MaxLength = 32767;
            this.integrationsBrowserSearch.Name = "integrationsBrowserSearch";
            this.integrationsBrowserSearch.PasswordChar = '\0';
            this.integrationsBrowserSearch.PromptText = "Search integration by name...";
            this.integrationsBrowserSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.integrationsBrowserSearch.SelectedText = "";
            this.integrationsBrowserSearch.SelectionLength = 0;
            this.integrationsBrowserSearch.SelectionStart = 0;
            this.integrationsBrowserSearch.ShortcutsEnabled = true;
            this.integrationsBrowserSearch.Size = new System.Drawing.Size(868, 23);
            this.integrationsBrowserSearch.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.integrationsBrowserSearch.TabIndex = 2;
            this.integrationsBrowserSearch.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.integrationsBrowserSearch.UseSelectable = true;
            this.integrationsBrowserSearch.WaterMark = "Search integration by name...";
            this.integrationsBrowserSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.integrationsBrowserSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.integrationsBrowserSearch.TextChanged += new System.EventHandler(this.integrationsBrowserSearch_TextChanged);
            // 
            // myIntegrationsTab
            // 
            this.myIntegrationsTab.Controls.Add(this.tableLayoutPanel1);
            this.myIntegrationsTab.HorizontalScrollbarBarColor = true;
            this.myIntegrationsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.myIntegrationsTab.HorizontalScrollbarSize = 10;
            this.myIntegrationsTab.Location = new System.Drawing.Point(4, 35);
            this.myIntegrationsTab.Name = "myIntegrationsTab";
            this.myIntegrationsTab.Size = new System.Drawing.Size(874, 358);
            this.myIntegrationsTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.myIntegrationsTab.TabIndex = 5;
            this.myIntegrationsTab.Text = "My Integrations";
            this.myIntegrationsTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.myIntegrationsTab.VerticalScrollbarBarColor = true;
            this.myIntegrationsTab.VerticalScrollbarHighlightOnWheel = false;
            this.myIntegrationsTab.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myIntegrations, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.51087F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 358);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.IntegrationId = null;
            this.header.IntegrationName = null;
            this.header.Location = new System.Drawing.Point(3, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(868, 35);
            this.header.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.header.TabIndex = 0;
            this.header.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.header.UseSelectable = true;
            this.header.Visible = false;
            // 
            // myIntegrations
            // 
            this.myIntegrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myIntegrations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.myIntegrations.Location = new System.Drawing.Point(3, 44);
            this.myIntegrations.Name = "myIntegrations";
            this.myIntegrations.Size = new System.Drawing.Size(868, 311);
            this.myIntegrations.TabIndex = 1;
            this.myIntegrations.WrapContents = false;
            // 
            // consoleTab
            // 
            this.consoleTab.Controls.Add(this.consoleLogs);
            this.consoleTab.HorizontalScrollbarBarColor = true;
            this.consoleTab.HorizontalScrollbarHighlightOnWheel = false;
            this.consoleTab.HorizontalScrollbarSize = 10;
            this.consoleTab.Location = new System.Drawing.Point(4, 35);
            this.consoleTab.Name = "consoleTab";
            this.consoleTab.Size = new System.Drawing.Size(874, 358);
            this.consoleTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.consoleTab.TabIndex = 6;
            this.consoleTab.Text = "Console";
            this.consoleTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.consoleTab.VerticalScrollbarBarColor = true;
            this.consoleTab.VerticalScrollbarHighlightOnWheel = false;
            this.consoleTab.VerticalScrollbarSize = 10;
            // 
            // consoleLogs
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.consoleLogs, true);
            this.consoleLogs.AutoScroll = true;
            this.consoleLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.consoleLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleLogs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.consoleLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.consoleLogs.Location = new System.Drawing.Point(0, 0);
            this.consoleLogs.Name = "consoleLogs";
            this.consoleLogs.Size = new System.Drawing.Size(874, 358);
            this.consoleLogs.TabIndex = 3;
            this.consoleLogs.WrapContents = false;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.debugSwitch);
            this.settingsTab.Controls.Add(this.poisonLabel2);
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 35);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(25);
            this.settingsTab.Size = new System.Drawing.Size(874, 358);
            this.settingsTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "Settings";
            this.settingsTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
            this.settingsTab.Visible = false;
            // 
            // debugSwitch
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.debugSwitch, true);
            this.debugSwitch.BackColor = System.Drawing.Color.Transparent;
            this.debugSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.debugSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.debugSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.debugSwitch.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.debugSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.debugSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.debugSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.debugSwitch.IsDerivedStyle = true;
            this.debugSwitch.Location = new System.Drawing.Point(13, 37);
            this.debugSwitch.Name = "debugSwitch";
            this.debugSwitch.Size = new System.Drawing.Size(58, 22);
            this.debugSwitch.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.debugSwitch.StyleManager = null;
            this.debugSwitch.Switched = false;
            this.debugSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.debugSwitch.TabIndex = 13;
            this.debugSwitch.ThemeAuthor = "Them3";
            this.debugSwitch.ThemeName = "MetroDark5";
            this.debugSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(11, 11);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(87, 19);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel2.TabIndex = 12;
            this.poisonLabel2.Text = "Debug mode";
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonStyleManager
            // 
            this.poisonStyleManager.Owner = this;
            this.poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonToolTip
            // 
            this.poisonToolTip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip.StyleManager = null;
            this.poisonToolTip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonStyleExtender
            // 
            this.poisonStyleExtender.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "Log";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox2.TabIndex = 0;
            this.materialCheckBox2.Text = "Log1";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(922, 477);
            this.Controls.Add(this.main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPanel";
            this.Resizable = false;
            this.ShadowType = ReaLTaiizor.Enum.Poison.FormShadowType.DropShadow;
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.StyleManager = this.poisonStyleManager;
            this.Text = "VRC OSC Integrations";
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.main.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.integrationsBrowserTab.ResumeLayout(false);
            this.myIntegrationsTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.consoleTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PoisonTabControl main;
        private PoisonStyleManager poisonStyleManager;
        private PoisonTabPage homeTab;
        private PoisonToolTip poisonToolTip;
        private PoisonTabPage settingsTab;
        private PoisonStyleExtender poisonStyleExtender;
        private MaterialCheckBox materialCheckBox1;
        private MaterialCheckBox materialCheckBox2;
        private PoisonLabel poisonLabel2;
        private MetroSwitch debugSwitch;
        private PoisonTabPage integrationsBrowserTab;
        private PoisonTabPage myIntegrationsTab;
        private PoisonTabPage consoleTab;
        private FlowLayoutPanel consoleLogs;
        private FlowLayoutPanel integrationsBrowser;
        private PoisonTextBox integrationsBrowserSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private IntegrationHeader header;
        private FlowLayoutPanel myIntegrations;
        private BigLabel bigLabel1;
    }
}
