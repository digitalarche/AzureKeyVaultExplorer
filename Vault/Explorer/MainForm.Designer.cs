﻿namespace Microsoft.PS.Common.Vault.Explorer
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            System.Windows.Forms.ToolStripLabel toolStripLabel1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripStatusLabel usStatusLabelSpring;
            this.uxListViewSecrets = new System.Windows.Forms.ListView();
            this.uxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemAddSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemAddCertificate = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.uxPropertyGridSecret = new System.Windows.Forms.PropertyGrid();
            this.uxToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxComboBoxVaultAlias = new System.Windows.Forms.ToolStripComboBox();
            this.uxButtonAdd = new System.Windows.Forms.ToolStripSplitButton();
            this.uxAddSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddCertificate = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.uxButtonToggle = new System.Windows.Forms.ToolStripButton();
            this.uxButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.uxImageSearch = new System.Windows.Forms.ToolStripLabel();
            this.uxTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.uxButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.uxButtonSave = new System.Windows.Forms.ToolStripButton();
            this.uxButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.uxButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.uxStatusStrip = new System.Windows.Forms.StatusStrip();
            this.uxStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxStatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.uxStatusLabelSecertsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxStatusLabelSecretsSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxTimerSearchTextTypingCompleted = new System.Windows.Forms.Timer(this.components);
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxTimerClearClipboard = new System.Windows.Forms.Timer(this.components);
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            usStatusLabelSpring = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            this.uxContextMenuStrip.SuspendLayout();
            this.uxToolStrip.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.uxStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.uxListViewSecrets);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.uxPropertyGridSecret);
            splitContainer1.Size = new System.Drawing.Size(1372, 562);
            splitContainer1.SplitterDistance = 285;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 8;
            // 
            // uxListViewSecrets
            // 
            this.uxListViewSecrets.AllowColumnReorder = true;
            this.uxListViewSecrets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            this.uxListViewSecrets.ContextMenuStrip = this.uxContextMenuStrip;
            this.uxListViewSecrets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxListViewSecrets.FullRowSelect = true;
            this.uxListViewSecrets.HideSelection = false;
            this.uxListViewSecrets.Location = new System.Drawing.Point(0, 0);
            this.uxListViewSecrets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxListViewSecrets.Name = "uxListViewSecrets";
            this.uxListViewSecrets.ShowItemToolTips = true;
            this.uxListViewSecrets.Size = new System.Drawing.Size(1372, 285);
            this.uxListViewSecrets.SmallImageList = this.uxSmallImageList;
            this.uxListViewSecrets.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.uxListViewSecrets.TabIndex = 0;
            this.uxListViewSecrets.UseCompatibleStateImageBehavior = false;
            this.uxListViewSecrets.View = System.Windows.Forms.View.Details;
            this.uxListViewSecrets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.uxListViewSecrets_ColumnClick);
            this.uxListViewSecrets.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.uxListViewSecrets_ItemDrag);
            this.uxListViewSecrets.SelectedIndexChanged += new System.EventHandler(this.uxListViewSecrets_SelectedIndexChanged);
            this.uxListViewSecrets.DragDrop += new System.Windows.Forms.DragEventHandler(this.uxListViewSecrets_DragDrop);
            this.uxListViewSecrets.DragEnter += new System.Windows.Forms.DragEventHandler(this.uxListViewSecrets_DragEnter);
            this.uxListViewSecrets.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.uxListViewSecrets_GiveFeedback);
            this.uxListViewSecrets.DoubleClick += new System.EventHandler(this.uxButtonEdit_Click);
            this.uxListViewSecrets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxListViewSecrets_KeyDown);
            this.uxListViewSecrets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxListViewSecrets_KeyUp);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Updated";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Changed by";
            columnHeader3.Width = 200;
            // 
            // uxContextMenuStrip
            // 
            this.uxContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuItemAdd,
            this.uxMenuItemEdit,
            this.uxMenuItemToggle,
            this.uxMenuItemDelete,
            toolStripSeparator5,
            this.uxMenuItemCopy,
            this.uxMenuItemSave,
            toolStripSeparator4,
            this.uxMenuItemRefresh});
            this.uxContextMenuStrip.Name = "uxContextMenuStrip";
            this.uxContextMenuStrip.Size = new System.Drawing.Size(144, 198);
            // 
            // uxMenuItemAdd
            // 
            this.uxMenuItemAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuItemAddSecret,
            this.uxMenuItemAddCertificate,
            this.uxMenuItemAddFile});
            this.uxMenuItemAdd.Enabled = false;
            this.uxMenuItemAdd.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_add;
            this.uxMenuItemAdd.Name = "uxMenuItemAdd";
            this.uxMenuItemAdd.Size = new System.Drawing.Size(143, 26);
            this.uxMenuItemAdd.Text = "&Add";
            this.uxMenuItemAdd.ToolTipText = "Add secret";
            this.uxMenuItemAdd.Click += new System.EventHandler(this.uxButtonAdd_Click);
            // 
            // uxMenuItemAddSecret
            // 
            this.uxMenuItemAddSecret.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.key;
            this.uxMenuItemAddSecret.Name = "uxMenuItemAddSecret";
            this.uxMenuItemAddSecret.Size = new System.Drawing.Size(161, 26);
            this.uxMenuItemAddSecret.Text = "&Secret...";
            this.uxMenuItemAddSecret.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxMenuItemAddCertificate
            // 
            this.uxMenuItemAddCertificate.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.certificate;
            this.uxMenuItemAddCertificate.Name = "uxMenuItemAddCertificate";
            this.uxMenuItemAddCertificate.Size = new System.Drawing.Size(161, 26);
            this.uxMenuItemAddCertificate.Text = "Certificate...";
            this.uxMenuItemAddCertificate.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxMenuItemAddFile
            // 
            this.uxMenuItemAddFile.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.folder_key;
            this.uxMenuItemAddFile.Name = "uxMenuItemAddFile";
            this.uxMenuItemAddFile.Size = new System.Drawing.Size(161, 26);
            this.uxMenuItemAddFile.Text = "&File...";
            this.uxMenuItemAddFile.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxMenuItemEdit
            // 
            this.uxMenuItemEdit.Enabled = false;
            this.uxMenuItemEdit.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_edit;
            this.uxMenuItemEdit.Name = "uxMenuItemEdit";
            this.uxMenuItemEdit.Size = new System.Drawing.Size(143, 26);
            this.uxMenuItemEdit.Text = "&Edit...";
            this.uxMenuItemEdit.ToolTipText = "Edit secret";
            this.uxMenuItemEdit.Click += new System.EventHandler(this.uxButtonEdit_Click);
            // 
            // uxMenuItemToggle
            // 
            this.uxMenuItemToggle.Enabled = false;
            this.uxMenuItemToggle.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_break;
            this.uxMenuItemToggle.Name = "uxMenuItemToggle";
            this.uxMenuItemToggle.Size = new System.Drawing.Size(143, 26);
            this.uxMenuItemToggle.Text = "Disabl&e...";
            this.uxMenuItemToggle.ToolTipText = "Disable secret";
            this.uxMenuItemToggle.Click += new System.EventHandler(this.uxButtonToggle_Click);
            // 
            // uxMenuItemDelete
            // 
            this.uxMenuItemDelete.Enabled = false;
            this.uxMenuItemDelete.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_delete;
            this.uxMenuItemDelete.Name = "uxMenuItemDelete";
            this.uxMenuItemDelete.Size = new System.Drawing.Size(143, 26);
            this.uxMenuItemDelete.Text = "&Delete...";
            this.uxMenuItemDelete.ToolTipText = "Delete secret";
            this.uxMenuItemDelete.Click += new System.EventHandler(this.uxButtonDelete_Click);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(140, 6);
            // 
            // uxMenuItemCopy
            // 
            this.uxMenuItemCopy.Enabled = false;
            this.uxMenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("uxMenuItemCopy.Image")));
            this.uxMenuItemCopy.Name = "uxMenuItemCopy";
            this.uxMenuItemCopy.Size = new System.Drawing.Size(143, 26);
            this.uxMenuItemCopy.Text = "&Copy";
            this.uxMenuItemCopy.ToolTipText = "Copy secret value to clipboard for 30 seconds";
            this.uxMenuItemCopy.Click += new System.EventHandler(this.uxButtonCopy_Click);
            // 
            // uxMenuItemSave
            // 
            this.uxMenuItemSave.Enabled = false;
            this.uxMenuItemSave.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.disk;
            this.uxMenuItemSave.Name = "uxMenuItemSave";
            this.uxMenuItemSave.Size = new System.Drawing.Size(143, 26);
            this.uxMenuItemSave.Text = "&Save...";
            this.uxMenuItemSave.ToolTipText = "Save secret to file";
            this.uxMenuItemSave.Click += new System.EventHandler(this.uxButtonSave_Click);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(140, 6);
            // 
            // uxMenuItemRefresh
            // 
            this.uxMenuItemRefresh.Enabled = false;
            this.uxMenuItemRefresh.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_go;
            this.uxMenuItemRefresh.Name = "uxMenuItemRefresh";
            this.uxMenuItemRefresh.Size = new System.Drawing.Size(143, 26);
            this.uxMenuItemRefresh.Text = "&Refresh";
            this.uxMenuItemRefresh.ToolTipText = "Refresh all secrets";
            this.uxMenuItemRefresh.Click += new System.EventHandler(this.uxMenuItemRefresh_Click);
            // 
            // uxSmallImageList
            // 
            this.uxSmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("uxSmallImageList.ImageStream")));
            this.uxSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.uxSmallImageList.Images.SetKeyName(0, "empty.png");
            this.uxSmallImageList.Images.SetKeyName(1, "key.png");
            this.uxSmallImageList.Images.SetKeyName(2, "key_delete.png");
            this.uxSmallImageList.Images.SetKeyName(3, "medal_bronze_1.png");
            this.uxSmallImageList.Images.SetKeyName(4, "medal_bronze_delete.png");
            // 
            // uxPropertyGridSecret
            // 
            this.uxPropertyGridSecret.DisabledItemForeColor = System.Drawing.SystemColors.WindowText;
            this.uxPropertyGridSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPropertyGridSecret.HelpVisible = false;
            this.uxPropertyGridSecret.Location = new System.Drawing.Point(0, 0);
            this.uxPropertyGridSecret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPropertyGridSecret.Name = "uxPropertyGridSecret";
            this.uxPropertyGridSecret.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.uxPropertyGridSecret.Size = new System.Drawing.Size(1372, 271);
            this.uxPropertyGridSecret.TabIndex = 0;
            this.uxPropertyGridSecret.ToolbarVisible = false;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(42, 25);
            toolStripLabel1.Text = "Vault";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // usStatusLabelSpring
            // 
            usStatusLabelSpring.Name = "usStatusLabelSpring";
            usStatusLabelSpring.Size = new System.Drawing.Size(1165, 20);
            usStatusLabelSpring.Spring = true;
            // 
            // uxToolStrip
            // 
            this.uxToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.uxToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripLabel1,
            this.uxComboBoxVaultAlias,
            toolStripSeparator1,
            this.uxButtonAdd,
            this.uxButtonEdit,
            this.uxButtonToggle,
            this.uxButtonDelete,
            toolStripSeparator2,
            this.uxImageSearch,
            this.uxTextBoxSearch,
            this.uxButtonCopy,
            this.uxButtonSave,
            toolStripSeparator3,
            this.uxButtonHelp,
            this.uxButtonSettings});
            this.uxToolStrip.Location = new System.Drawing.Point(3, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(1043, 28);
            this.uxToolStrip.TabIndex = 0;
            // 
            // uxComboBoxVaultAlias
            // 
            this.uxComboBoxVaultAlias.DropDownHeight = 200;
            this.uxComboBoxVaultAlias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComboBoxVaultAlias.IntegralHeight = false;
            this.uxComboBoxVaultAlias.Name = "uxComboBoxVaultAlias";
            this.uxComboBoxVaultAlias.Size = new System.Drawing.Size(250, 28);
            this.uxComboBoxVaultAlias.DropDown += new System.EventHandler(this.uxComboBoxVaultAlias_DropDown);
            this.uxComboBoxVaultAlias.DropDownClosed += new System.EventHandler(this.uxComboBoxVaultAlias_DropDownClosed);
            // 
            // uxButtonAdd
            // 
            this.uxButtonAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxAddSecret,
            this.uxAddCertificate,
            this.uxAddFile});
            this.uxButtonAdd.Enabled = false;
            this.uxButtonAdd.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_add;
            this.uxButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonAdd.Name = "uxButtonAdd";
            this.uxButtonAdd.Size = new System.Drawing.Size(76, 25);
            this.uxButtonAdd.Text = "&Add";
            this.uxButtonAdd.ToolTipText = "Add secret";
            this.uxButtonAdd.Click += new System.EventHandler(this.uxButtonAdd_Click);
            // 
            // uxAddSecret
            // 
            this.uxAddSecret.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.key;
            this.uxAddSecret.Name = "uxAddSecret";
            this.uxAddSecret.Size = new System.Drawing.Size(161, 26);
            this.uxAddSecret.Text = "&Secret...";
            this.uxAddSecret.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxAddCertificate
            // 
            this.uxAddCertificate.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.certificate;
            this.uxAddCertificate.Name = "uxAddCertificate";
            this.uxAddCertificate.Size = new System.Drawing.Size(161, 26);
            this.uxAddCertificate.Text = "Ce&rtificate...";
            this.uxAddCertificate.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxAddFile
            // 
            this.uxAddFile.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.folder_key;
            this.uxAddFile.Name = "uxAddFile";
            this.uxAddFile.Size = new System.Drawing.Size(161, 26);
            this.uxAddFile.Text = "&File...";
            this.uxAddFile.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxButtonEdit
            // 
            this.uxButtonEdit.Enabled = false;
            this.uxButtonEdit.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_edit;
            this.uxButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonEdit.Name = "uxButtonEdit";
            this.uxButtonEdit.Size = new System.Drawing.Size(59, 25);
            this.uxButtonEdit.Text = "&Edit";
            this.uxButtonEdit.ToolTipText = "Edit secret";
            this.uxButtonEdit.Click += new System.EventHandler(this.uxButtonEdit_Click);
            // 
            // uxButtonToggle
            // 
            this.uxButtonToggle.Enabled = false;
            this.uxButtonToggle.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_break;
            this.uxButtonToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonToggle.Name = "uxButtonToggle";
            this.uxButtonToggle.Size = new System.Drawing.Size(83, 25);
            this.uxButtonToggle.Text = "Disabl&e";
            this.uxButtonToggle.ToolTipText = "Disable secret";
            this.uxButtonToggle.Click += new System.EventHandler(this.uxButtonToggle_Click);
            // 
            // uxButtonDelete
            // 
            this.uxButtonDelete.Enabled = false;
            this.uxButtonDelete.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_delete;
            this.uxButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonDelete.Name = "uxButtonDelete";
            this.uxButtonDelete.Size = new System.Drawing.Size(77, 25);
            this.uxButtonDelete.Text = "&Delete";
            this.uxButtonDelete.ToolTipText = "Delete secret";
            this.uxButtonDelete.Click += new System.EventHandler(this.uxButtonDelete_Click);
            // 
            // uxImageSearch
            // 
            this.uxImageSearch.Enabled = false;
            this.uxImageSearch.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.magnifier;
            this.uxImageSearch.Name = "uxImageSearch";
            this.uxImageSearch.Size = new System.Drawing.Size(20, 25);
            this.uxImageSearch.ToolTipText = "Search";
            // 
            // uxTextBoxSearch
            // 
            this.uxTextBoxSearch.Enabled = false;
            this.uxTextBoxSearch.Name = "uxTextBoxSearch";
            this.uxTextBoxSearch.Size = new System.Drawing.Size(120, 28);
            this.uxTextBoxSearch.ToolTipText = "Search";
            this.uxTextBoxSearch.TextChanged += new System.EventHandler(this.uxTextBoxSearch_TextChanged);
            // 
            // uxButtonCopy
            // 
            this.uxButtonCopy.Enabled = false;
            this.uxButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("uxButtonCopy.Image")));
            this.uxButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonCopy.Name = "uxButtonCopy";
            this.uxButtonCopy.Size = new System.Drawing.Size(67, 25);
            this.uxButtonCopy.Text = "&Copy";
            this.uxButtonCopy.ToolTipText = "Copy secret value to clipboard for 30 seconds";
            this.uxButtonCopy.Click += new System.EventHandler(this.uxButtonCopy_Click);
            // 
            // uxButtonSave
            // 
            this.uxButtonSave.Enabled = false;
            this.uxButtonSave.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.disk;
            this.uxButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonSave.Name = "uxButtonSave";
            this.uxButtonSave.Size = new System.Drawing.Size(64, 25);
            this.uxButtonSave.Text = "&Save";
            this.uxButtonSave.ToolTipText = "Save secret to file";
            this.uxButtonSave.Click += new System.EventHandler(this.uxButtonSave_Click);
            // 
            // uxButtonHelp
            // 
            this.uxButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("uxButtonHelp.Image")));
            this.uxButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonHelp.Name = "uxButtonHelp";
            this.uxButtonHelp.Size = new System.Drawing.Size(65, 25);
            this.uxButtonHelp.Text = "&Help";
            this.uxButtonHelp.ToolTipText = "Tip:\r\nYou can drag & drop secret as file to or from\r\nWindows Explorer or another " +
    "instance of Vault Explorer.\r\nHold CTRL key to copy all secret information.";
            this.uxButtonHelp.Click += new System.EventHandler(this.uxButtonHelp_Click);
            // 
            // uxButtonSettings
            // 
            this.uxButtonSettings.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.wrench;
            this.uxButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonSettings.Name = "uxButtonSettings";
            this.uxButtonSettings.Size = new System.Drawing.Size(86, 25);
            this.uxButtonSettings.Text = "&Settings";
            this.uxButtonSettings.Click += new System.EventHandler(this.uxButtonSettings_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.uxStatusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1372, 562);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1372, 615);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.uxToolStrip);
            // 
            // uxStatusStrip
            // 
            this.uxStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.uxStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxStatusLabel,
            usStatusLabelSpring,
            this.uxStatusProgressBar,
            this.uxStatusLabelSecertsCount,
            this.uxStatusLabelSecretsSelected});
            this.uxStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.uxStatusStrip.Name = "uxStatusStrip";
            this.uxStatusStrip.ShowItemToolTips = true;
            this.uxStatusStrip.Size = new System.Drawing.Size(1372, 25);
            this.uxStatusStrip.TabIndex = 0;
            // 
            // uxStatusLabel
            // 
            this.uxStatusLabel.Name = "uxStatusLabel";
            this.uxStatusLabel.Size = new System.Drawing.Size(50, 20);
            this.uxStatusLabel.Text = "Ready";
            this.uxStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxStatusProgressBar
            // 
            this.uxStatusProgressBar.AutoSize = false;
            this.uxStatusProgressBar.Margin = new System.Windows.Forms.Padding(1, 3, 0, 3);
            this.uxStatusProgressBar.Name = "uxStatusProgressBar";
            this.uxStatusProgressBar.Size = new System.Drawing.Size(200, 19);
            this.uxStatusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.uxStatusProgressBar.Visible = false;
            // 
            // uxStatusLabelSecertsCount
            // 
            this.uxStatusLabelSecertsCount.Name = "uxStatusLabelSecertsCount";
            this.uxStatusLabelSecertsCount.Size = new System.Drawing.Size(66, 20);
            this.uxStatusLabelSecertsCount.Text = "0 secrets";
            this.uxStatusLabelSecertsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uxStatusLabelSecretsSelected
            // 
            this.uxStatusLabelSecretsSelected.Name = "uxStatusLabelSecretsSelected";
            this.uxStatusLabelSecretsSelected.Size = new System.Drawing.Size(76, 20);
            this.uxStatusLabelSecretsSelected.Text = "0 selected";
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.Filter = resources.GetString("uxOpenFileDialog.Filter");
            this.uxOpenFileDialog.Title = "Open file";
            // 
            // uxTimerSearchTextTypingCompleted
            // 
            this.uxTimerSearchTextTypingCompleted.Interval = 250;
            this.uxTimerSearchTextTypingCompleted.Tick += new System.EventHandler(this.uxTimerSearchTextTypingCompleted_Tick);
            // 
            // uxSaveFileDialog
            // 
            this.uxSaveFileDialog.Filter = resources.GetString("uxSaveFileDialog.Filter");
            this.uxSaveFileDialog.Title = "Save As";
            // 
            // uxTimerClearClipboard
            // 
            this.uxTimerClearClipboard.Tick += new System.EventHandler(this.uxTimerClearClipboard_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 615);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(797, 589);
            this.Name = "MainForm";
            this.Text = "Azure Key Vault Explorer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            this.uxContextMenuStrip.ResumeLayout(false);
            this.uxToolStrip.ResumeLayout(false);
            this.uxToolStrip.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.uxStatusStrip.ResumeLayout(false);
            this.uxStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip uxStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel uxStatusLabel;
        private System.Windows.Forms.ListView uxListViewSecrets;
        private System.Windows.Forms.PropertyGrid uxPropertyGridSecret;
        private System.Windows.Forms.ToolStripComboBox uxComboBoxVaultAlias;
        private System.Windows.Forms.ToolStripButton uxButtonCopy;
        private System.Windows.Forms.ToolStripButton uxButtonHelp;
        private System.Windows.Forms.ToolStripButton uxButtonEdit;
        private System.Windows.Forms.ToolStripButton uxButtonDelete;
        private System.Windows.Forms.ToolStripSplitButton uxButtonAdd;
        private System.Windows.Forms.ToolStripMenuItem uxAddSecret;
        private System.Windows.Forms.ToolStripMenuItem uxAddCertificate;
        private System.Windows.Forms.ToolStripButton uxButtonSettings;
        private System.Windows.Forms.ContextMenuStrip uxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemCopy;
        private System.Windows.Forms.ToolStripButton uxButtonToggle;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemToggle;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAddSecret;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAddCertificate;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAddFile;
        private System.Windows.Forms.ToolStripMenuItem uxAddFile;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.ImageList uxSmallImageList;
        private System.Windows.Forms.ToolStripTextBox uxTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel uxImageSearch;
        private System.Windows.Forms.Timer uxTimerSearchTextTypingCompleted;
        private System.Windows.Forms.ToolStrip uxToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel uxStatusLabelSecertsCount;
        private System.Windows.Forms.ToolStripButton uxButtonSave;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemSave;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.ToolStripProgressBar uxStatusProgressBar;
        private System.Windows.Forms.Timer uxTimerClearClipboard;
        private System.Windows.Forms.ToolStripStatusLabel uxStatusLabelSecretsSelected;
    }
}

