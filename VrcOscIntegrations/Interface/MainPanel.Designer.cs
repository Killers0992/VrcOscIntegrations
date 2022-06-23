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
            this.myIntegrations = new System.Windows.Forms.FlowLayoutPanel();
            this.integrationHeader = new VrcOscIntegrations.Interface.Entries.IntegrationHeader();
            this.consoleTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.consoleLogs = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.webServer = new ReaLTaiizor.Controls.DreamTextBox();
            this.serverIp = new ReaLTaiizor.Controls.DreamTextBox();
            this.serverPort = new ReaLTaiizor.Controls.CrownNumeric();
            this.clientPort = new ReaLTaiizor.Controls.CrownNumeric();
            this.poisonLabel10 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel9 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel7 = new ReaLTaiizor.Controls.PoisonLabel();
            this.clientIp = new ReaLTaiizor.Controls.DreamTextBox();
            this.autoUpdater = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.debugSwitch = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.poisonToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
            this.poisonStyleExtender = new ReaLTaiizor.Controls.PoisonStyleExtender(this.components);
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.versionLabel = new ReaLTaiizor.Controls.PoisonLabel();
            this.checkPendingUpdates = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new ReaLTaiizor.Controls.PoisonProgressBar();
            this.progressText = new ReaLTaiizor.Controls.PoisonLabel();
            this.fileDownloader = new System.ComponentModel.BackgroundWorker();
            this.main.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.integrationsBrowserTab.SuspendLayout();
            this.myIntegrationsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.consoleTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPort)).BeginInit();
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
            this.main.SelectedIndexChanged += new System.EventHandler(this.main_SelectedIndexChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.myIntegrations, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.integrationHeader, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.51087F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 358);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // myIntegrations
            // 
            this.myIntegrations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myIntegrations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.myIntegrations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.myIntegrations.Location = new System.Drawing.Point(3, 44);
            this.myIntegrations.Name = "myIntegrations";
            this.myIntegrations.Size = new System.Drawing.Size(868, 311);
            this.myIntegrations.TabIndex = 1;
            // 
            // integrationHeader
            // 
            this.integrationHeader.BackColor = System.Drawing.Color.Transparent;
            this.integrationHeader.IntegrationId = null;
            this.integrationHeader.IntegrationName = null;
            this.integrationHeader.Location = new System.Drawing.Point(3, 3);
            this.integrationHeader.Name = "integrationHeader";
            this.integrationHeader.Size = new System.Drawing.Size(868, 34);
            this.integrationHeader.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.integrationHeader.TabIndex = 2;
            this.integrationHeader.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.integrationHeader.UseSelectable = true;
            this.integrationHeader.Visible = false;
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
            this.settingsTab.Controls.Add(this.webServer);
            this.settingsTab.Controls.Add(this.serverIp);
            this.settingsTab.Controls.Add(this.serverPort);
            this.settingsTab.Controls.Add(this.clientPort);
            this.settingsTab.Controls.Add(this.poisonLabel10);
            this.settingsTab.Controls.Add(this.poisonLabel9);
            this.settingsTab.Controls.Add(this.poisonLabel8);
            this.settingsTab.Controls.Add(this.poisonLabel7);
            this.settingsTab.Controls.Add(this.clientIp);
            this.settingsTab.Controls.Add(this.autoUpdater);
            this.settingsTab.Controls.Add(this.poisonLabel6);
            this.settingsTab.Controls.Add(this.poisonLabel5);
            this.settingsTab.Controls.Add(this.poisonLabel4);
            this.settingsTab.Controls.Add(this.poisonLabel3);
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
            this.settingsTab.Click += new System.EventHandler(this.settingsTab_Click);
            // 
            // webServer
            // 
            this.webServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.webServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webServer.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.webServer.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.webServer.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.webServer.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.webServer.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.webServer.ColorF = System.Drawing.Color.Black;
            this.webServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.webServer.Location = new System.Drawing.Point(601, 204);
            this.webServer.Name = "webServer";
            this.webServer.Size = new System.Drawing.Size(263, 23);
            this.webServer.TabIndex = 27;
            // 
            // serverIp
            // 
            this.serverIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.serverIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverIp.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.serverIp.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.serverIp.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.serverIp.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serverIp.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serverIp.ColorF = System.Drawing.Color.Black;
            this.serverIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.serverIp.Location = new System.Drawing.Point(601, 133);
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(185, 23);
            this.serverIp.TabIndex = 26;
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(792, 132);
            this.serverPort.Maximum = new decimal(new int[] {
            25565,
            0,
            0,
            0});
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(76, 23);
            this.serverPort.TabIndex = 25;
            // 
            // clientPort
            // 
            this.clientPort.Location = new System.Drawing.Point(792, 52);
            this.clientPort.Maximum = new decimal(new int[] {
            25565,
            0,
            0,
            0});
            this.clientPort.Name = "clientPort";
            this.clientPort.Size = new System.Drawing.Size(72, 23);
            this.clientPort.TabIndex = 24;
            // 
            // poisonLabel10
            // 
            this.poisonLabel10.AutoSize = true;
            this.poisonLabel10.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel10.Location = new System.Drawing.Point(597, 106);
            this.poisonLabel10.Name = "poisonLabel10";
            this.poisonLabel10.Size = new System.Drawing.Size(80, 19);
            this.poisonLabel10.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel10.TabIndex = 23;
            this.poisonLabel10.Text = "Ip Address";
            this.poisonLabel10.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel9
            // 
            this.poisonLabel9.AutoSize = true;
            this.poisonLabel9.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel9.Location = new System.Drawing.Point(788, 108);
            this.poisonLabel9.Name = "poisonLabel9";
            this.poisonLabel9.Size = new System.Drawing.Size(38, 19);
            this.poisonLabel9.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel9.TabIndex = 22;
            this.poisonLabel9.Text = "Port";
            this.poisonLabel9.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonLabel9.Click += new System.EventHandler(this.poisonLabel9_Click);
            // 
            // poisonLabel8
            // 
            this.poisonLabel8.AutoSize = true;
            this.poisonLabel8.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel8.Location = new System.Drawing.Point(788, 30);
            this.poisonLabel8.Name = "poisonLabel8";
            this.poisonLabel8.Size = new System.Drawing.Size(38, 19);
            this.poisonLabel8.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel8.TabIndex = 21;
            this.poisonLabel8.Text = "Port";
            this.poisonLabel8.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel7
            // 
            this.poisonLabel7.AutoSize = true;
            this.poisonLabel7.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel7.Location = new System.Drawing.Point(597, 30);
            this.poisonLabel7.Name = "poisonLabel7";
            this.poisonLabel7.Size = new System.Drawing.Size(80, 19);
            this.poisonLabel7.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel7.TabIndex = 20;
            this.poisonLabel7.Text = "Ip Address";
            this.poisonLabel7.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // clientIp
            // 
            this.clientIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.clientIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientIp.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clientIp.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.clientIp.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.clientIp.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clientIp.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientIp.ColorF = System.Drawing.Color.Black;
            this.clientIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.clientIp.Location = new System.Drawing.Point(601, 52);
            this.clientIp.Name = "clientIp";
            this.clientIp.Size = new System.Drawing.Size(185, 23);
            this.clientIp.TabIndex = 19;
            // 
            // autoUpdater
            // 
            this.autoUpdater.BackColor = System.Drawing.Color.Transparent;
            this.autoUpdater.BackgroundColor = System.Drawing.Color.Empty;
            this.autoUpdater.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.autoUpdater.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.autoUpdater.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.autoUpdater.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.autoUpdater.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.autoUpdater.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.autoUpdater.IsDerivedStyle = true;
            this.autoUpdater.Location = new System.Drawing.Point(13, 108);
            this.autoUpdater.Name = "autoUpdater";
            this.autoUpdater.Size = new System.Drawing.Size(58, 22);
            this.autoUpdater.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.autoUpdater.StyleManager = null;
            this.autoUpdater.Switched = false;
            this.autoUpdater.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.autoUpdater.TabIndex = 18;
            this.autoUpdater.Text = "metroSwitch1";
            this.autoUpdater.ThemeAuthor = "Taiizor";
            this.autoUpdater.ThemeName = "MetroLight";
            this.autoUpdater.UnCheckColor = System.Drawing.Color.Red;
            // 
            // poisonLabel6
            // 
            this.poisonLabel6.AutoSize = true;
            this.poisonLabel6.Location = new System.Drawing.Point(597, 168);
            this.poisonLabel6.Name = "poisonLabel6";
            this.poisonLabel6.Size = new System.Drawing.Size(78, 19);
            this.poisonLabel6.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel6.TabIndex = 17;
            this.poisonLabel6.Text = "Web Server";
            this.poisonLabel6.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel5
            // 
            this.poisonLabel5.AutoSize = true;
            this.poisonLabel5.Location = new System.Drawing.Point(595, 80);
            this.poisonLabel5.Name = "poisonLabel5";
            this.poisonLabel5.Size = new System.Drawing.Size(78, 19);
            this.poisonLabel5.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel5.TabIndex = 16;
            this.poisonLabel5.Text = "OSC Server";
            this.poisonLabel5.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.Location = new System.Drawing.Point(595, 11);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(73, 19);
            this.poisonLabel4.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel4.TabIndex = 15;
            this.poisonLabel4.Text = "OSC Client";
            this.poisonLabel4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.Location = new System.Drawing.Point(11, 77);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(87, 19);
            this.poisonLabel3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel3.TabIndex = 14;
            this.poisonLabel3.Text = "Auto updater";
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
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
            this.debugSwitch.Location = new System.Drawing.Point(13, 33);
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
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(791, 458);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(54, 19);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.poisonLabel1.TabIndex = 1;
            this.poisonLabel1.Text = "Version:";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.versionLabel.Location = new System.Drawing.Point(851, 458);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(41, 19);
            this.versionLabel.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "0.0.0";
            this.versionLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // checkPendingUpdates
            // 
            this.checkPendingUpdates.Enabled = true;
            this.checkPendingUpdates.Interval = 5000;
            // 
            // progressBar
            // 
            this.progressBar.HideProgressText = false;
            this.progressBar.Location = new System.Drawing.Point(298, 427);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(330, 20);
            this.progressBar.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.progressBar.TabIndex = 3;
            this.progressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressBar.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.progressBar.Value = 25;
            this.progressBar.Visible = false;
            // 
            // progressText
            // 
            this.progressText.Location = new System.Drawing.Point(252, 404);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(418, 23);
            this.progressText.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Lime;
            this.progressText.TabIndex = 4;
            this.progressText.Text = "Downloading updates...";
            this.progressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressText.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.progressText.Visible = false;
            // 
            // fileDownloader
            // 
            this.fileDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fileDownloader_DoWork);
            this.fileDownloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fileDownloader_RunWorkerCompleted);
            // 
            // MainPanel
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(922, 477);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.poisonLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private BigLabel bigLabel1;
        public IntegrationHeader integrationHeader;
        public FlowLayoutPanel myIntegrations;
        private PoisonLabel versionLabel;
        private PoisonLabel poisonLabel1;
        private PoisonLabel poisonLabel3;
        private PoisonLabel poisonLabel6;
        private PoisonLabel poisonLabel5;
        private PoisonLabel poisonLabel4;
        private DreamTextBox serverIp;
        private CrownNumeric serverPort;
        private CrownNumeric clientPort;
        private PoisonLabel poisonLabel10;
        private PoisonLabel poisonLabel9;
        private PoisonLabel poisonLabel8;
        private PoisonLabel poisonLabel7;
        private DreamTextBox clientIp;
        private MetroSwitch autoUpdater;
        private DreamTextBox webServer;
        private System.Windows.Forms.Timer checkPendingUpdates;
        private PoisonLabel progressText;
        private PoisonProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker fileDownloader;
    }
}
