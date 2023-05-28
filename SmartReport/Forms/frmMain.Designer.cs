/*   SmartReport License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2023 Luciano Gorosito <lucianogorosito@hotmail.com>        *
*                                                                             *
*    This file is part of SmartReport                                         *
*                                                                             *
*    SamrtReport is free software: you can redistribute it and/or modify      *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    SmartReport is distributed in the hope that it will be useful,           *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/
namespace SmartReport
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Instance Parameters", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Type Parameters", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Instance Parameters", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Type Parameters", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("4");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trvElements = new System.Windows.Forms.TreeView();
            this.conextElement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextShowElements = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblImageAnnotationInstances = new System.Windows.Forms.Label();
            this.chkIncludeInstances = new System.Windows.Forms.CheckBox();
            this.chkAnnotationInstances = new System.Windows.Forms.CheckBox();
            this.lblImageModelInstances = new System.Windows.Forms.Label();
            this.chkAllInstances = new System.Windows.Forms.CheckBox();
            this.chkFamilyTypes = new System.Windows.Forms.CheckBox();
            this.chkFamilies = new System.Windows.Forms.CheckBox();
            this.chkMaterials = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.tabFields = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grpSelected = new System.Windows.Forms.GroupBox();
            this.lstSelected = new System.Windows.Forms.ListView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddField = new System.Windows.Forms.Button();
            this.btnRemoveField = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.grpAvailable = new System.Windows.Forms.GroupBox();
            this.lstAvailable = new System.Windows.Forms.ListView();
            this.grpProperties = new System.Windows.Forms.GroupBox();
            this.lstProperties = new System.Windows.Forms.ListView();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbFilterParam08 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule08 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText08 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilterParam01 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule01 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText01 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbFilterParam02 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule02 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText02 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFilterParam03 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule03 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText03 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbFilterParam04 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule04 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText04 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbFilterParam05 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule05 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText05 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbFilterParam06 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule06 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText06 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbFilterParam07 = new System.Windows.Forms.ComboBox();
            this.cmbFilterRule07 = new System.Windows.Forms.ComboBox();
            this.cmbFilterText07 = new System.Windows.Forms.ComboBox();
            this.tabGroup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrp01 = new System.Windows.Forms.ComboBox();
            this.rdb01Ascending = new System.Windows.Forms.RadioButton();
            this.rdb01Descending = new System.Windows.Forms.RadioButton();
            this.chk01BlankLine = new System.Windows.Forms.CheckBox();
            this.chkGrpItemize = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGrp02 = new System.Windows.Forms.ComboBox();
            this.rdb02Ascending = new System.Windows.Forms.RadioButton();
            this.rdb02Descending = new System.Windows.Forms.RadioButton();
            this.chk02BlankLine = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGrp03 = new System.Windows.Forms.ComboBox();
            this.rdb03Ascending = new System.Windows.Forms.RadioButton();
            this.rdb03Descending = new System.Windows.Forms.RadioButton();
            this.chk03BlankLine = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGrp04 = new System.Windows.Forms.ComboBox();
            this.rdb04Ascending = new System.Windows.Forms.RadioButton();
            this.rdb04Descending = new System.Windows.Forms.RadioButton();
            this.chk04BlankLine = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.chkGrandTotal = new System.Windows.Forms.CheckBox();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolExportExcel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuOpenReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUniversoBim = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.conextElement.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabFields.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpSelected.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.grpAvailable.SuspendLayout();
            this.grpProperties.SuspendLayout();
            this.tabFilter.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.tabGroup.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tabPreview.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel13, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Controls.Add(this.tabFields);
            this.tabControl1.Controls.Add(this.tabFilter);
            this.tabControl1.Controls.Add(this.tabGroup);
            this.tabControl1.Controls.Add(this.tabPreview);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 621);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tableLayoutPanel2);
            this.tabReport.ImageIndex = 3;
            this.tabReport.Location = new System.Drawing.Point(4, 27);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(992, 590);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "Reports";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(986, 584);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trvElements);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(497, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(483, 572);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elements";
            // 
            // trvElements
            // 
            this.trvElements.CheckBoxes = true;
            this.trvElements.ContextMenuStrip = this.conextElement;
            this.trvElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvElements.HideSelection = false;
            this.trvElements.ImageIndex = 0;
            this.trvElements.ImageList = this.imageList1;
            this.trvElements.Location = new System.Drawing.Point(6, 23);
            this.trvElements.Name = "trvElements";
            this.trvElements.SelectedImageIndex = 0;
            this.trvElements.Size = new System.Drawing.Size(471, 543);
            this.trvElements.TabIndex = 0;
            this.trvElements.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvElements_AfterCheck);
            // 
            // conextElement
            // 
            this.conextElement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conextElement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextShowElements});
            this.conextElement.Name = "conextElement";
            this.conextElement.Size = new System.Drawing.Size(183, 30);
            // 
            // contextShowElements
            // 
            this.contextShowElements.Image = global::SmartReport.Properties.Resources.lupa16;
            this.contextShowElements.Name = "contextShowElements";
            this.contextShowElements.Size = new System.Drawing.Size(182, 26);
            this.contextShowElements.Text = "Show Elements";
            this.contextShowElements.Click += new System.EventHandler(this.contextShowElements_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cajas.png");
            this.imageList1.Images.SetKeyName(1, "box.png");
            this.imageList1.Images.SetKeyName(2, "Ribbon_Shaded_16.png");
            this.imageList1.Images.SetKeyName(3, "document_prepare.png");
            this.imageList1.Images.SetKeyName(4, "selection-tree-std.png");
            this.imageList1.Images.SetKeyName(5, "Funnel.png");
            this.imageList1.Images.SetKeyName(6, "ViewPlan-32.png");
            this.imageList1.Images.SetKeyName(7, "lupa16.png");
            this.imageList1.Images.SetKeyName(8, "Muro36.png");
            this.imageList1.Images.SetKeyName(9, "Texto32.png");
            this.imageList1.Images.SetKeyName(10, "Tag16.png");
            this.imageList1.Images.SetKeyName(11, "license-key.png");
            this.imageList1.Images.SetKeyName(12, "UniBim_logo_24.png");
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(488, 578);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(476, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options for Elements";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblImageAnnotationInstances, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkIncludeInstances, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkAnnotationInstances, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblImageModelInstances, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkAllInstances, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkFamilyTypes, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.chkFamilies, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.chkMaterials, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(456, 307);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Image = global::SmartReport.Properties.Resources.ViewPlan_32;
            this.label5.Location = new System.Drawing.Point(9, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 45);
            this.label5.TabIndex = 12;
            // 
            // lblImageAnnotationInstances
            // 
            this.lblImageAnnotationInstances.AutoSize = true;
            this.lblImageAnnotationInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImageAnnotationInstances.Image = global::SmartReport.Properties.Resources.Texto32;
            this.lblImageAnnotationInstances.Location = new System.Drawing.Point(9, 51);
            this.lblImageAnnotationInstances.Name = "lblImageAnnotationInstances";
            this.lblImageAnnotationInstances.Size = new System.Drawing.Size(34, 45);
            this.lblImageAnnotationInstances.TabIndex = 9;
            // 
            // chkIncludeInstances
            // 
            this.chkIncludeInstances.AutoSize = true;
            this.chkIncludeInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIncludeInstances.Location = new System.Drawing.Point(49, 9);
            this.chkIncludeInstances.Name = "chkIncludeInstances";
            this.chkIncludeInstances.Size = new System.Drawing.Size(398, 39);
            this.chkIncludeInstances.TabIndex = 2;
            this.chkIncludeInstances.Text = "Include Model Instances";
            this.chkIncludeInstances.UseVisualStyleBackColor = true;
            this.chkIncludeInstances.CheckedChanged += new System.EventHandler(this.chkIncludeInstances_CheckedChanged);
            // 
            // chkAnnotationInstances
            // 
            this.chkAnnotationInstances.AutoSize = true;
            this.chkAnnotationInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAnnotationInstances.Location = new System.Drawing.Point(49, 54);
            this.chkAnnotationInstances.Name = "chkAnnotationInstances";
            this.chkAnnotationInstances.Size = new System.Drawing.Size(398, 39);
            this.chkAnnotationInstances.TabIndex = 3;
            this.chkAnnotationInstances.Text = "Include Annotation Instances";
            this.chkAnnotationInstances.UseVisualStyleBackColor = true;
            this.chkAnnotationInstances.CheckedChanged += new System.EventHandler(this.chkAnnotationInstances_CheckedChanged);
            // 
            // lblImageModelInstances
            // 
            this.lblImageModelInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImageModelInstances.Image = global::SmartReport.Properties.Resources.Muro36;
            this.lblImageModelInstances.Location = new System.Drawing.Point(9, 6);
            this.lblImageModelInstances.Name = "lblImageModelInstances";
            this.lblImageModelInstances.Size = new System.Drawing.Size(34, 45);
            this.lblImageModelInstances.TabIndex = 8;
            // 
            // chkAllInstances
            // 
            this.chkAllInstances.AutoSize = true;
            this.chkAllInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAllInstances.Location = new System.Drawing.Point(49, 99);
            this.chkAllInstances.Name = "chkAllInstances";
            this.chkAllInstances.Size = new System.Drawing.Size(398, 39);
            this.chkAllInstances.TabIndex = 13;
            this.chkAllInstances.Text = "Include Special Instances (Must Wait)";
            this.chkAllInstances.UseVisualStyleBackColor = true;
            this.chkAllInstances.CheckedChanged += new System.EventHandler(this.chkAllInstances_CheckedChanged);
            // 
            // chkFamilyTypes
            // 
            this.chkFamilyTypes.AutoSize = true;
            this.chkFamilyTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFamilyTypes.Location = new System.Drawing.Point(49, 144);
            this.chkFamilyTypes.Name = "chkFamilyTypes";
            this.chkFamilyTypes.Size = new System.Drawing.Size(398, 39);
            this.chkFamilyTypes.TabIndex = 6;
            this.chkFamilyTypes.Text = "Include Family Types";
            this.chkFamilyTypes.UseVisualStyleBackColor = true;
            this.chkFamilyTypes.CheckedChanged += new System.EventHandler(this.chkFamilyTypes_CheckedChanged);
            // 
            // chkFamilies
            // 
            this.chkFamilies.AutoSize = true;
            this.chkFamilies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFamilies.Location = new System.Drawing.Point(49, 189);
            this.chkFamilies.Name = "chkFamilies";
            this.chkFamilies.Size = new System.Drawing.Size(398, 39);
            this.chkFamilies.TabIndex = 4;
            this.chkFamilies.Text = "Include Families";
            this.chkFamilies.UseVisualStyleBackColor = true;
            this.chkFamilies.CheckedChanged += new System.EventHandler(this.chkFamilies_CheckedChanged);
            // 
            // chkMaterials
            // 
            this.chkMaterials.AutoSize = true;
            this.chkMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMaterials.Location = new System.Drawing.Point(49, 234);
            this.chkMaterials.Name = "chkMaterials";
            this.chkMaterials.Size = new System.Drawing.Size(398, 39);
            this.chkMaterials.TabIndex = 7;
            this.chkMaterials.Text = "Include Materials";
            this.chkMaterials.UseVisualStyleBackColor = true;
            this.chkMaterials.CheckedChanged += new System.EventHandler(this.chkMaterials_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Image = global::SmartReport.Properties.Resources.FamilyCatalog32;
            this.label21.Location = new System.Drawing.Point(9, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 45);
            this.label21.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Image = global::SmartReport.Properties.Resources.box_32x32;
            this.label4.Location = new System.Drawing.Point(9, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 45);
            this.label4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Image = global::SmartReport.Properties.Resources.Section_32;
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 45);
            this.label3.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtReportName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(476, 59);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report Name";
            // 
            // txtReportName
            // 
            this.txtReportName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReportName.Location = new System.Drawing.Point(10, 27);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(456, 24);
            this.txtReportName.TabIndex = 1;
            this.txtReportName.Text = "Report 01";
            // 
            // tabFields
            // 
            this.tabFields.Controls.Add(this.tableLayoutPanel4);
            this.tabFields.ImageIndex = 4;
            this.tabFields.Location = new System.Drawing.Point(4, 27);
            this.tabFields.Name = "tabFields";
            this.tabFields.Padding = new System.Windows.Forms.Padding(3);
            this.tabFields.Size = new System.Drawing.Size(992, 590);
            this.tabFields.TabIndex = 1;
            this.tabFields.Text = "Fields";
            this.tabFields.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 415F));
            this.tableLayoutPanel4.Controls.Add(this.grpSelected, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(986, 584);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // grpSelected
            // 
            this.grpSelected.Controls.Add(this.lstSelected);
            this.grpSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSelected.Location = new System.Drawing.Point(571, 6);
            this.grpSelected.Name = "grpSelected";
            this.grpSelected.Padding = new System.Windows.Forms.Padding(10);
            this.grpSelected.Size = new System.Drawing.Size(409, 572);
            this.grpSelected.TabIndex = 1;
            this.grpSelected.TabStop = false;
            this.grpSelected.Text = "Selected Fields (0)";
            // 
            // lstSelected
            // 
            this.lstSelected.CheckBoxes = true;
            this.lstSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelected.GridLines = true;
            this.lstSelected.HideSelection = false;
            this.lstSelected.Location = new System.Drawing.Point(10, 27);
            this.lstSelected.MultiSelect = false;
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.ShowItemToolTips = true;
            this.lstSelected.Size = new System.Drawing.Size(389, 535);
            this.lstSelected.TabIndex = 0;
            this.lstSelected.UseCompatibleStateImageBehavior = false;
            this.lstSelected.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnAddField, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnRemoveField, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnUp, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.BtnDown, 0, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(512, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(50, 572);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnAddField
            // 
            this.btnAddField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddField.Location = new System.Drawing.Point(3, 59);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(44, 39);
            this.btnAddField.TabIndex = 0;
            this.btnAddField.Text = ">>";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnRemoveField
            // 
            this.btnRemoveField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveField.Location = new System.Drawing.Point(3, 104);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(44, 39);
            this.btnRemoveField.TabIndex = 1;
            this.btnRemoveField.Text = "<<";
            this.btnRemoveField.UseVisualStyleBackColor = true;
            this.btnRemoveField.Click += new System.EventHandler(this.btnRemoveField_Click);
            // 
            // btnUp
            // 
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp.Image = global::SmartReport.Properties.Resources.arrow_090_medium;
            this.btnUp.Location = new System.Drawing.Point(3, 189);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(44, 39);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDown.Image = global::SmartReport.Properties.Resources.arrow_270_medium;
            this.BtnDown.Location = new System.Drawing.Point(3, 234);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(44, 39);
            this.BtnDown.TabIndex = 3;
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.grpAvailable, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.grpProperties, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(497, 572);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // grpAvailable
            // 
            this.grpAvailable.Controls.Add(this.lstAvailable);
            this.grpAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAvailable.Location = new System.Drawing.Point(3, 3);
            this.grpAvailable.Name = "grpAvailable";
            this.grpAvailable.Padding = new System.Windows.Forms.Padding(10);
            this.grpAvailable.Size = new System.Drawing.Size(491, 387);
            this.grpAvailable.TabIndex = 0;
            this.grpAvailable.TabStop = false;
            this.grpAvailable.Text = "Available Parameters";
            // 
            // lstAvailable
            // 
            this.lstAvailable.CheckBoxes = true;
            this.lstAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAvailable.GridLines = true;
            listViewGroup5.Header = "Instance Parameters";
            listViewGroup5.Name = "0";
            listViewGroup5.Tag = "0";
            listViewGroup6.Header = "Type Parameters";
            listViewGroup6.Name = "1";
            listViewGroup6.Tag = "1";
            this.lstAvailable.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.lstAvailable.HideSelection = false;
            listViewItem9.Group = listViewGroup5;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.Group = listViewGroup5;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.Group = listViewGroup6;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.Group = listViewGroup6;
            listViewItem12.StateImageIndex = 0;
            this.lstAvailable.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lstAvailable.Location = new System.Drawing.Point(10, 27);
            this.lstAvailable.MultiSelect = false;
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.ShowItemToolTips = true;
            this.lstAvailable.Size = new System.Drawing.Size(471, 350);
            this.lstAvailable.TabIndex = 0;
            this.lstAvailable.UseCompatibleStateImageBehavior = false;
            this.lstAvailable.View = System.Windows.Forms.View.List;
            // 
            // grpProperties
            // 
            this.grpProperties.Controls.Add(this.lstProperties);
            this.grpProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProperties.Location = new System.Drawing.Point(3, 396);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Padding = new System.Windows.Forms.Padding(10);
            this.grpProperties.Size = new System.Drawing.Size(491, 162);
            this.grpProperties.TabIndex = 1;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Available Properties";
            // 
            // lstProperties
            // 
            this.lstProperties.CheckBoxes = true;
            this.lstProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProperties.GridLines = true;
            listViewGroup7.Header = "Instance Parameters";
            listViewGroup7.Name = "0";
            listViewGroup7.Tag = "0";
            listViewGroup8.Header = "Type Parameters";
            listViewGroup8.Name = "1";
            listViewGroup8.Tag = "1";
            this.lstProperties.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8});
            this.lstProperties.HideSelection = false;
            listViewItem13.Group = listViewGroup7;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.Group = listViewGroup7;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.Group = listViewGroup8;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.Group = listViewGroup8;
            listViewItem16.StateImageIndex = 0;
            this.lstProperties.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.lstProperties.Location = new System.Drawing.Point(10, 27);
            this.lstProperties.MultiSelect = false;
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(471, 125);
            this.lstProperties.TabIndex = 1;
            this.lstProperties.UseCompatibleStateImageBehavior = false;
            this.lstProperties.View = System.Windows.Forms.View.List;
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.tableLayoutPanel15);
            this.tabFilter.ImageIndex = 5;
            this.tabFilter.Location = new System.Drawing.Point(4, 27);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Size = new System.Drawing.Size(992, 590);
            this.tabFilter.TabIndex = 2;
            this.tabFilter.Text = "Filter";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel15.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel27, 0, 7);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel16, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel21, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel22, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel23, 0, 3);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel24, 0, 4);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel25, 0, 5);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel26, 0, 6);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 9;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(992, 590);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 4;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel27.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.cmbFilterParam08, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.cmbFilterRule08, 2, 0);
            this.tableLayoutPanel27.Controls.Add(this.cmbFilterText08, 3, 0);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(6, 307);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 1;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel27.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(239, 34);
            this.label20.TabIndex = 0;
            this.label20.Text = "And:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam08
            // 
            this.cmbFilterParam08.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam08.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam08.FormattingEnabled = true;
            this.cmbFilterParam08.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam08.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam08.Name = "cmbFilterParam08";
            this.cmbFilterParam08.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam08.TabIndex = 1;
            this.cmbFilterParam08.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam08_SelectedIndexChanged);
            // 
            // cmbFilterRule08
            // 
            this.cmbFilterRule08.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule08.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule08.FormattingEnabled = true;
            this.cmbFilterRule08.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule08.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule08.Name = "cmbFilterRule08";
            this.cmbFilterRule08.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule08.TabIndex = 5;
            this.cmbFilterRule08.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule08_SelectedIndexChanged);
            // 
            // cmbFilterText08
            // 
            this.cmbFilterText08.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText08.FormattingEnabled = true;
            this.cmbFilterText08.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText08.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText08.Name = "cmbFilterText08";
            this.cmbFilterText08.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText08.TabIndex = 6;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 4;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.cmbFilterParam01, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.cmbFilterRule01, 2, 0);
            this.tableLayoutPanel16.Controls.Add(this.cmbFilterText01, 3, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Filter By:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam01
            // 
            this.cmbFilterParam01.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam01.FormattingEnabled = true;
            this.cmbFilterParam01.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam01.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam01.Name = "cmbFilterParam01";
            this.cmbFilterParam01.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam01.TabIndex = 1;
            this.cmbFilterParam01.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam01_SelectedIndexChanged);
            // 
            // cmbFilterRule01
            // 
            this.cmbFilterRule01.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule01.FormattingEnabled = true;
            this.cmbFilterRule01.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule01.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule01.Name = "cmbFilterRule01";
            this.cmbFilterRule01.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule01.TabIndex = 5;
            this.cmbFilterRule01.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule01_SelectedIndexChanged);
            // 
            // cmbFilterText01
            // 
            this.cmbFilterText01.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText01.FormattingEnabled = true;
            this.cmbFilterText01.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText01.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText01.Name = "cmbFilterText01";
            this.cmbFilterText01.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText01.TabIndex = 6;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 4;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel21.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.cmbFilterParam02, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.cmbFilterRule02, 2, 0);
            this.tableLayoutPanel21.Controls.Add(this.cmbFilterText02, 3, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(6, 49);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel21.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "And:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam02
            // 
            this.cmbFilterParam02.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam02.FormattingEnabled = true;
            this.cmbFilterParam02.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam02.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam02.Name = "cmbFilterParam02";
            this.cmbFilterParam02.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam02.TabIndex = 1;
            this.cmbFilterParam02.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam02_SelectedIndexChanged);
            // 
            // cmbFilterRule02
            // 
            this.cmbFilterRule02.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule02.FormattingEnabled = true;
            this.cmbFilterRule02.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule02.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule02.Name = "cmbFilterRule02";
            this.cmbFilterRule02.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule02.TabIndex = 5;
            this.cmbFilterRule02.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule02_SelectedIndexChanged);
            // 
            // cmbFilterText02
            // 
            this.cmbFilterText02.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText02.FormattingEnabled = true;
            this.cmbFilterText02.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText02.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText02.Name = "cmbFilterText02";
            this.cmbFilterText02.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText02.TabIndex = 6;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 4;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel22.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.cmbFilterParam03, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.cmbFilterRule03, 2, 0);
            this.tableLayoutPanel22.Controls.Add(this.cmbFilterText03, 3, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(6, 92);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel22.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(239, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "And:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam03
            // 
            this.cmbFilterParam03.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam03.FormattingEnabled = true;
            this.cmbFilterParam03.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam03.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam03.Name = "cmbFilterParam03";
            this.cmbFilterParam03.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam03.TabIndex = 1;
            this.cmbFilterParam03.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam03_SelectedIndexChanged);
            // 
            // cmbFilterRule03
            // 
            this.cmbFilterRule03.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule03.FormattingEnabled = true;
            this.cmbFilterRule03.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule03.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule03.Name = "cmbFilterRule03";
            this.cmbFilterRule03.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule03.TabIndex = 5;
            this.cmbFilterRule03.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule03_SelectedIndexChanged);
            // 
            // cmbFilterText03
            // 
            this.cmbFilterText03.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText03.FormattingEnabled = true;
            this.cmbFilterText03.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText03.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText03.Name = "cmbFilterText03";
            this.cmbFilterText03.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText03.TabIndex = 6;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 4;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel23.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.cmbFilterParam04, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.cmbFilterRule04, 2, 0);
            this.tableLayoutPanel23.Controls.Add(this.cmbFilterText04, 3, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(6, 135);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel23.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(239, 34);
            this.label16.TabIndex = 0;
            this.label16.Text = "And:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam04
            // 
            this.cmbFilterParam04.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam04.FormattingEnabled = true;
            this.cmbFilterParam04.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam04.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam04.Name = "cmbFilterParam04";
            this.cmbFilterParam04.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam04.TabIndex = 1;
            this.cmbFilterParam04.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam04_SelectedIndexChanged);
            // 
            // cmbFilterRule04
            // 
            this.cmbFilterRule04.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule04.FormattingEnabled = true;
            this.cmbFilterRule04.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule04.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule04.Name = "cmbFilterRule04";
            this.cmbFilterRule04.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule04.TabIndex = 5;
            this.cmbFilterRule04.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule04_SelectedIndexChanged);
            // 
            // cmbFilterText04
            // 
            this.cmbFilterText04.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText04.FormattingEnabled = true;
            this.cmbFilterText04.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText04.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText04.Name = "cmbFilterText04";
            this.cmbFilterText04.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText04.TabIndex = 6;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 4;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel24.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.cmbFilterParam05, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.cmbFilterRule05, 2, 0);
            this.tableLayoutPanel24.Controls.Add(this.cmbFilterText05, 3, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(6, 178);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel24.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(239, 34);
            this.label17.TabIndex = 0;
            this.label17.Text = "And:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam05
            // 
            this.cmbFilterParam05.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam05.FormattingEnabled = true;
            this.cmbFilterParam05.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam05.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam05.Name = "cmbFilterParam05";
            this.cmbFilterParam05.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam05.TabIndex = 1;
            this.cmbFilterParam05.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam05_SelectedIndexChanged);
            // 
            // cmbFilterRule05
            // 
            this.cmbFilterRule05.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule05.FormattingEnabled = true;
            this.cmbFilterRule05.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule05.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule05.Name = "cmbFilterRule05";
            this.cmbFilterRule05.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule05.TabIndex = 5;
            this.cmbFilterRule05.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule05_SelectedIndexChanged);
            // 
            // cmbFilterText05
            // 
            this.cmbFilterText05.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText05.FormattingEnabled = true;
            this.cmbFilterText05.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText05.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText05.Name = "cmbFilterText05";
            this.cmbFilterText05.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText05.TabIndex = 6;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 4;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel25.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.cmbFilterParam06, 1, 0);
            this.tableLayoutPanel25.Controls.Add(this.cmbFilterRule06, 2, 0);
            this.tableLayoutPanel25.Controls.Add(this.cmbFilterText06, 3, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(6, 221);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel25.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(239, 34);
            this.label18.TabIndex = 0;
            this.label18.Text = "And:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam06
            // 
            this.cmbFilterParam06.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam06.FormattingEnabled = true;
            this.cmbFilterParam06.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam06.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam06.Name = "cmbFilterParam06";
            this.cmbFilterParam06.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam06.TabIndex = 1;
            this.cmbFilterParam06.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam06_SelectedIndexChanged);
            // 
            // cmbFilterRule06
            // 
            this.cmbFilterRule06.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule06.FormattingEnabled = true;
            this.cmbFilterRule06.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule06.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule06.Name = "cmbFilterRule06";
            this.cmbFilterRule06.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule06.TabIndex = 5;
            this.cmbFilterRule06.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule06_SelectedIndexChanged);
            // 
            // cmbFilterText06
            // 
            this.cmbFilterText06.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText06.FormattingEnabled = true;
            this.cmbFilterText06.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText06.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText06.Name = "cmbFilterText06";
            this.cmbFilterText06.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText06.TabIndex = 6;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 4;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel26.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.cmbFilterParam07, 1, 0);
            this.tableLayoutPanel26.Controls.Add(this.cmbFilterRule07, 2, 0);
            this.tableLayoutPanel26.Controls.Add(this.cmbFilterText07, 3, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(6, 264);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(980, 34);
            this.tableLayoutPanel26.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(239, 34);
            this.label19.TabIndex = 0;
            this.label19.Text = "And:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterParam07
            // 
            this.cmbFilterParam07.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterParam07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterParam07.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterParam07.FormattingEnabled = true;
            this.cmbFilterParam07.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterParam07.Location = new System.Drawing.Point(248, 3);
            this.cmbFilterParam07.Name = "cmbFilterParam07";
            this.cmbFilterParam07.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterParam07.TabIndex = 1;
            this.cmbFilterParam07.SelectedIndexChanged += new System.EventHandler(this.cmbFilterParam07_SelectedIndexChanged);
            // 
            // cmbFilterRule07
            // 
            this.cmbFilterRule07.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterRule07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterRule07.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRule07.FormattingEnabled = true;
            this.cmbFilterRule07.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterRule07.Location = new System.Drawing.Point(493, 3);
            this.cmbFilterRule07.Name = "cmbFilterRule07";
            this.cmbFilterRule07.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterRule07.TabIndex = 5;
            this.cmbFilterRule07.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRule07_SelectedIndexChanged);
            // 
            // cmbFilterText07
            // 
            this.cmbFilterText07.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilterText07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterText07.FormattingEnabled = true;
            this.cmbFilterText07.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterText07.Location = new System.Drawing.Point(738, 3);
            this.cmbFilterText07.Name = "cmbFilterText07";
            this.cmbFilterText07.Size = new System.Drawing.Size(239, 26);
            this.cmbFilterText07.TabIndex = 6;
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.tableLayoutPanel9);
            this.tabGroup.ImageIndex = 6;
            this.tabGroup.Location = new System.Drawing.Point(4, 27);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Size = new System.Drawing.Size(992, 590);
            this.tabGroup.TabIndex = 3;
            this.tabGroup.Text = "Group";
            this.tabGroup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.chkGrpItemize, 0, 6);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel17, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel18, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel19, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel20, 0, 5);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 8;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(992, 590);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.cmbGrp01, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.rdb01Ascending, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.rdb01Descending, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.chk01BlankLine, 1, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(980, 74);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classify by:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGrp01
            // 
            this.cmbGrp01.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGrp01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGrp01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrp01.FormattingEnabled = true;
            this.cmbGrp01.Items.AddRange(new object[] {
            "None"});
            this.cmbGrp01.Location = new System.Drawing.Point(248, 3);
            this.cmbGrp01.Name = "cmbGrp01";
            this.cmbGrp01.Size = new System.Drawing.Size(239, 26);
            this.cmbGrp01.TabIndex = 1;
            this.cmbGrp01.SelectedIndexChanged += new System.EventHandler(this.cmbGrp01_SelectedIndexChanged);
            // 
            // rdb01Ascending
            // 
            this.rdb01Ascending.AutoSize = true;
            this.rdb01Ascending.Checked = true;
            this.rdb01Ascending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb01Ascending.Location = new System.Drawing.Point(493, 3);
            this.rdb01Ascending.Name = "rdb01Ascending";
            this.rdb01Ascending.Size = new System.Drawing.Size(239, 31);
            this.rdb01Ascending.TabIndex = 2;
            this.rdb01Ascending.TabStop = true;
            this.rdb01Ascending.Text = "Ascending";
            this.rdb01Ascending.UseVisualStyleBackColor = true;
            // 
            // rdb01Descending
            // 
            this.rdb01Descending.AutoSize = true;
            this.rdb01Descending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb01Descending.Location = new System.Drawing.Point(738, 3);
            this.rdb01Descending.Name = "rdb01Descending";
            this.rdb01Descending.Size = new System.Drawing.Size(239, 31);
            this.rdb01Descending.TabIndex = 3;
            this.rdb01Descending.Text = "Descending";
            this.rdb01Descending.UseVisualStyleBackColor = true;
            // 
            // chk01BlankLine
            // 
            this.chk01BlankLine.AutoSize = true;
            this.chk01BlankLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk01BlankLine.Location = new System.Drawing.Point(248, 40);
            this.chk01BlankLine.Name = "chk01BlankLine";
            this.chk01BlankLine.Size = new System.Drawing.Size(239, 31);
            this.chk01BlankLine.TabIndex = 4;
            this.chk01BlankLine.Text = "Add Blank Line";
            this.chk01BlankLine.UseVisualStyleBackColor = true;
            // 
            // chkGrpItemize
            // 
            this.chkGrpItemize.AutoSize = true;
            this.chkGrpItemize.Checked = true;
            this.chkGrpItemize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGrpItemize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkGrpItemize.Location = new System.Drawing.Point(6, 504);
            this.chkGrpItemize.Name = "chkGrpItemize";
            this.chkGrpItemize.Size = new System.Drawing.Size(980, 34);
            this.chkGrpItemize.TabIndex = 1;
            this.chkGrpItemize.Text = "Itemize every Instance";
            this.chkGrpItemize.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 4;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.cmbGrp02, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.rdb02Ascending, 2, 0);
            this.tableLayoutPanel17.Controls.Add(this.rdb02Descending, 3, 0);
            this.tableLayoutPanel17.Controls.Add(this.chk02BlankLine, 1, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(6, 89);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(980, 74);
            this.tableLayoutPanel17.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Then By:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGrp02
            // 
            this.cmbGrp02.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGrp02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGrp02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrp02.FormattingEnabled = true;
            this.cmbGrp02.Items.AddRange(new object[] {
            "None"});
            this.cmbGrp02.Location = new System.Drawing.Point(248, 3);
            this.cmbGrp02.Name = "cmbGrp02";
            this.cmbGrp02.Size = new System.Drawing.Size(239, 26);
            this.cmbGrp02.TabIndex = 1;
            this.cmbGrp02.SelectedIndexChanged += new System.EventHandler(this.cmbGrp02_SelectedIndexChanged);
            // 
            // rdb02Ascending
            // 
            this.rdb02Ascending.AutoSize = true;
            this.rdb02Ascending.Checked = true;
            this.rdb02Ascending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb02Ascending.Location = new System.Drawing.Point(493, 3);
            this.rdb02Ascending.Name = "rdb02Ascending";
            this.rdb02Ascending.Size = new System.Drawing.Size(239, 31);
            this.rdb02Ascending.TabIndex = 2;
            this.rdb02Ascending.TabStop = true;
            this.rdb02Ascending.Text = "Ascending";
            this.rdb02Ascending.UseVisualStyleBackColor = true;
            // 
            // rdb02Descending
            // 
            this.rdb02Descending.AutoSize = true;
            this.rdb02Descending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb02Descending.Location = new System.Drawing.Point(738, 3);
            this.rdb02Descending.Name = "rdb02Descending";
            this.rdb02Descending.Size = new System.Drawing.Size(239, 31);
            this.rdb02Descending.TabIndex = 3;
            this.rdb02Descending.Text = "Descending";
            this.rdb02Descending.UseVisualStyleBackColor = true;
            // 
            // chk02BlankLine
            // 
            this.chk02BlankLine.AutoSize = true;
            this.chk02BlankLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk02BlankLine.Location = new System.Drawing.Point(248, 40);
            this.chk02BlankLine.Name = "chk02BlankLine";
            this.chk02BlankLine.Size = new System.Drawing.Size(239, 31);
            this.chk02BlankLine.TabIndex = 4;
            this.chk02BlankLine.Text = "Add Blank Line";
            this.chk02BlankLine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 4;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel18.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.cmbGrp03, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.rdb03Ascending, 2, 0);
            this.tableLayoutPanel18.Controls.Add(this.rdb03Descending, 3, 0);
            this.tableLayoutPanel18.Controls.Add(this.chk03BlankLine, 1, 1);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(6, 172);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(980, 74);
            this.tableLayoutPanel18.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Then By:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGrp03
            // 
            this.cmbGrp03.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGrp03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGrp03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrp03.FormattingEnabled = true;
            this.cmbGrp03.Items.AddRange(new object[] {
            "None"});
            this.cmbGrp03.Location = new System.Drawing.Point(248, 3);
            this.cmbGrp03.Name = "cmbGrp03";
            this.cmbGrp03.Size = new System.Drawing.Size(239, 26);
            this.cmbGrp03.TabIndex = 1;
            this.cmbGrp03.SelectedIndexChanged += new System.EventHandler(this.cmbGrp03_SelectedIndexChanged);
            // 
            // rdb03Ascending
            // 
            this.rdb03Ascending.AutoSize = true;
            this.rdb03Ascending.Checked = true;
            this.rdb03Ascending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb03Ascending.Location = new System.Drawing.Point(493, 3);
            this.rdb03Ascending.Name = "rdb03Ascending";
            this.rdb03Ascending.Size = new System.Drawing.Size(239, 31);
            this.rdb03Ascending.TabIndex = 2;
            this.rdb03Ascending.TabStop = true;
            this.rdb03Ascending.Text = "Ascending";
            this.rdb03Ascending.UseVisualStyleBackColor = true;
            // 
            // rdb03Descending
            // 
            this.rdb03Descending.AutoSize = true;
            this.rdb03Descending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb03Descending.Location = new System.Drawing.Point(738, 3);
            this.rdb03Descending.Name = "rdb03Descending";
            this.rdb03Descending.Size = new System.Drawing.Size(239, 31);
            this.rdb03Descending.TabIndex = 3;
            this.rdb03Descending.Text = "Descending";
            this.rdb03Descending.UseVisualStyleBackColor = true;
            // 
            // chk03BlankLine
            // 
            this.chk03BlankLine.AutoSize = true;
            this.chk03BlankLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk03BlankLine.Location = new System.Drawing.Point(248, 40);
            this.chk03BlankLine.Name = "chk03BlankLine";
            this.chk03BlankLine.Size = new System.Drawing.Size(239, 31);
            this.chk03BlankLine.TabIndex = 4;
            this.chk03BlankLine.Text = "Add Blank Line";
            this.chk03BlankLine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 4;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel19.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.cmbGrp04, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.rdb04Ascending, 2, 0);
            this.tableLayoutPanel19.Controls.Add(this.rdb04Descending, 3, 0);
            this.tableLayoutPanel19.Controls.Add(this.chk04BlankLine, 1, 1);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(6, 255);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 2;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(980, 74);
            this.tableLayoutPanel19.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "Then By:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGrp04
            // 
            this.cmbGrp04.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGrp04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGrp04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrp04.FormattingEnabled = true;
            this.cmbGrp04.Items.AddRange(new object[] {
            "None"});
            this.cmbGrp04.Location = new System.Drawing.Point(248, 3);
            this.cmbGrp04.Name = "cmbGrp04";
            this.cmbGrp04.Size = new System.Drawing.Size(239, 26);
            this.cmbGrp04.TabIndex = 1;
            this.cmbGrp04.SelectedIndexChanged += new System.EventHandler(this.cmbGrp04_SelectedIndexChanged);
            // 
            // rdb04Ascending
            // 
            this.rdb04Ascending.AutoSize = true;
            this.rdb04Ascending.Checked = true;
            this.rdb04Ascending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb04Ascending.Location = new System.Drawing.Point(493, 3);
            this.rdb04Ascending.Name = "rdb04Ascending";
            this.rdb04Ascending.Size = new System.Drawing.Size(239, 31);
            this.rdb04Ascending.TabIndex = 2;
            this.rdb04Ascending.TabStop = true;
            this.rdb04Ascending.Text = "Ascending";
            this.rdb04Ascending.UseVisualStyleBackColor = true;
            // 
            // rdb04Descending
            // 
            this.rdb04Descending.AutoSize = true;
            this.rdb04Descending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb04Descending.Location = new System.Drawing.Point(738, 3);
            this.rdb04Descending.Name = "rdb04Descending";
            this.rdb04Descending.Size = new System.Drawing.Size(239, 31);
            this.rdb04Descending.TabIndex = 3;
            this.rdb04Descending.Text = "Descending";
            this.rdb04Descending.UseVisualStyleBackColor = true;
            // 
            // chk04BlankLine
            // 
            this.chk04BlankLine.AutoSize = true;
            this.chk04BlankLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk04BlankLine.Location = new System.Drawing.Point(248, 40);
            this.chk04BlankLine.Name = "chk04BlankLine";
            this.chk04BlankLine.Size = new System.Drawing.Size(239, 31);
            this.chk04BlankLine.TabIndex = 4;
            this.chk04BlankLine.Text = "Add Blank Line";
            this.chk04BlankLine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 4;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.chkGrandTotal, 0, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(6, 421);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(980, 74);
            this.tableLayoutPanel20.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 37);
            this.label13.TabIndex = 6;
            this.label13.Text = "(Still in development)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkGrandTotal
            // 
            this.chkGrandTotal.AutoSize = true;
            this.chkGrandTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkGrandTotal.Location = new System.Drawing.Point(3, 3);
            this.chkGrandTotal.Name = "chkGrandTotal";
            this.chkGrandTotal.Size = new System.Drawing.Size(239, 31);
            this.chkGrandTotal.TabIndex = 4;
            this.chkGrandTotal.Text = "Grand Total";
            this.chkGrandTotal.UseVisualStyleBackColor = true;
            // 
            // tabPreview
            // 
            this.tabPreview.Controls.Add(this.tableLayoutPanel14);
            this.tabPreview.ImageIndex = 7;
            this.tabPreview.Location = new System.Drawing.Point(4, 27);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Size = new System.Drawing.Size(992, 590);
            this.tabPreview.TabIndex = 4;
            this.tabPreview.Text = "Preview";
            this.tabPreview.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.dgvPreview, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(992, 590);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPreview.ColumnHeadersHeight = 29;
            this.dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreview.Location = new System.Drawing.Point(3, 38);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(986, 549);
            this.dgvPreview.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExportExcel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(992, 35);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolExportExcel
            // 
            this.toolExportExcel.Image = global::SmartReport.Properties.Resources.excel_exports;
            this.toolExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExportExcel.Name = "toolExportExcel";
            this.toolExportExcel.Size = new System.Drawing.Size(132, 32);
            this.toolExportExcel.Text = "Export to Excel";
            this.toolExportExcel.Click += new System.EventHandler(this.toolExportExcel_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1006, 60);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(80, 60);
            this.toolStrip1.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.AutoSize = false;
            this.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenReport,
            this.mnuSaveReport,
            this.mnuExport,
            this.mnuChangeLog,
            this.mnuExit});
            this.mnuFile.Image = global::SmartReport.Properties.Resources.menu32;
            this.mnuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(70, 50);
            this.mnuFile.Text = "toolStripDropDownButton1";
            // 
            // mnuOpenReport
            // 
            this.mnuOpenReport.Image = global::SmartReport.Properties.Resources.abrir;
            this.mnuOpenReport.Name = "mnuOpenReport";
            this.mnuOpenReport.Size = new System.Drawing.Size(187, 36);
            this.mnuOpenReport.Text = "Open Report";
            this.mnuOpenReport.Click += new System.EventHandler(this.mnuOpenReport_Click);
            // 
            // mnuSaveReport
            // 
            this.mnuSaveReport.Image = global::SmartReport.Properties.Resources.save;
            this.mnuSaveReport.Name = "mnuSaveReport";
            this.mnuSaveReport.Size = new System.Drawing.Size(187, 36);
            this.mnuSaveReport.Text = "Save Report";
            this.mnuSaveReport.Click += new System.EventHandler(this.mnuSaveReport_Click);
            // 
            // mnuExport
            // 
            this.mnuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportExcel});
            this.mnuExport.Image = global::SmartReport.Properties.Resources.document_export;
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(187, 36);
            this.mnuExport.Text = "Export";
            // 
            // mnuExportExcel
            // 
            this.mnuExportExcel.Image = global::SmartReport.Properties.Resources.excel_exports;
            this.mnuExportExcel.Name = "mnuExportExcel";
            this.mnuExportExcel.Size = new System.Drawing.Size(156, 36);
            this.mnuExportExcel.Text = "To Excel";
            this.mnuExportExcel.Click += new System.EventHandler(this.mnuExportExcel_Click_1);
            // 
            // mnuChangeLog
            // 
            this.mnuChangeLog.Image = global::SmartReport.Properties.Resources.Ingresos32;
            this.mnuChangeLog.Name = "mnuChangeLog";
            this.mnuChangeLog.Size = new System.Drawing.Size(187, 36);
            this.mnuChangeLog.Text = "Change Log";
            this.mnuChangeLog.Click += new System.EventHandler(this.mnuChangeLog_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::SmartReport.Properties.Resources.door_out;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(187, 36);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.lblVersion, 0, 1);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(80, 0);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(200, 60);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "SmartReport";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(5, 40);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(192, 20);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "label3";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 4;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel13.Controls.Add(this.lblUniversoBim, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.progressBar1, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.lblProgress, 3, 0);
            this.tableLayoutPanel13.Controls.Add(this.lblStatus, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 687);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1006, 34);
            this.tableLayoutPanel13.TabIndex = 3;
            // 
            // lblUniversoBim
            // 
            this.lblUniversoBim.AutoSize = true;
            this.lblUniversoBim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniversoBim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUniversoBim.ImageIndex = 12;
            this.lblUniversoBim.ImageList = this.imageList1;
            this.lblUniversoBim.Location = new System.Drawing.Point(3, 0);
            this.lblUniversoBim.Name = "lblUniversoBim";
            this.lblUniversoBim.Size = new System.Drawing.Size(194, 34);
            this.lblUniversoBim.TabIndex = 0;
            this.lblUniversoBim.Text = "     www.universobim.com";
            this.lblUniversoBim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUniversoBim.Click += new System.EventHandler(this.lblUniversoBim_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(659, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(294, 28);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgress.Location = new System.Drawing.Point(959, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(44, 34);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "99";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgress.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(203, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(450, 34);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatus.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.conextElement.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabFields.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grpSelected.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.grpAvailable.ResumeLayout(false);
            this.grpProperties.ResumeLayout(false);
            this.tabFilter.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.tabGroup.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tabPreview.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabFields;
        private System.Windows.Forms.TabPage tabFilter;
        private System.Windows.Forms.TabPage tabGroup;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox grpAvailable;
        private System.Windows.Forms.ListView lstAvailable;
        private System.Windows.Forms.GroupBox grpSelected;
        private System.Windows.Forms.ListView lstSelected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnRemoveField;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox grpProperties;
        private System.Windows.Forms.ListView lstProperties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrp01;
        private System.Windows.Forms.RadioButton rdb01Ascending;
        private System.Windows.Forms.RadioButton rdb01Descending;
        private System.Windows.Forms.CheckBox chk01BlankLine;
        private System.Windows.Forms.CheckBox chkGrpItemize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label lblUniversoBim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolExportExcel;
        private System.Windows.Forms.ContextMenuStrip conextElement;
        private System.Windows.Forms.ToolStripMenuItem contextShowElements;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenReport;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFilterParam01;
        private System.Windows.Forms.ComboBox cmbFilterRule01;
        private System.Windows.Forms.ComboBox cmbFilterText01;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGrp02;
        private System.Windows.Forms.RadioButton rdb02Ascending;
        private System.Windows.Forms.RadioButton rdb02Descending;
        private System.Windows.Forms.CheckBox chk02BlankLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGrp03;
        private System.Windows.Forms.RadioButton rdb03Ascending;
        private System.Windows.Forms.RadioButton rdb03Descending;
        private System.Windows.Forms.CheckBox chk03BlankLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGrp04;
        private System.Windows.Forms.RadioButton rdb04Ascending;
        private System.Windows.Forms.RadioButton rdb04Descending;
        private System.Windows.Forms.CheckBox chk04BlankLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.CheckBox chkGrandTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbFilterParam08;
        private System.Windows.Forms.ComboBox cmbFilterRule08;
        private System.Windows.Forms.ComboBox cmbFilterText08;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbFilterParam02;
        private System.Windows.Forms.ComboBox cmbFilterRule02;
        private System.Windows.Forms.ComboBox cmbFilterText02;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbFilterParam03;
        private System.Windows.Forms.ComboBox cmbFilterRule03;
        private System.Windows.Forms.ComboBox cmbFilterText03;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbFilterParam04;
        private System.Windows.Forms.ComboBox cmbFilterRule04;
        private System.Windows.Forms.ComboBox cmbFilterText04;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbFilterParam05;
        private System.Windows.Forms.ComboBox cmbFilterRule05;
        private System.Windows.Forms.ComboBox cmbFilterText05;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbFilterParam06;
        private System.Windows.Forms.ComboBox cmbFilterRule06;
        private System.Windows.Forms.ComboBox cmbFilterText06;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbFilterParam07;
        private System.Windows.Forms.ComboBox cmbFilterRule07;
        private System.Windows.Forms.ComboBox cmbFilterText07;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView trvElements;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImageAnnotationInstances;
        private System.Windows.Forms.CheckBox chkIncludeInstances;
        private System.Windows.Forms.CheckBox chkAnnotationInstances;
        private System.Windows.Forms.CheckBox chkFamilies;
        private System.Windows.Forms.CheckBox chkFamilyTypes;
        private System.Windows.Forms.CheckBox chkMaterials;
        private System.Windows.Forms.Label lblImageModelInstances;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeLog;
        private System.Windows.Forms.CheckBox chkAllInstances;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblStatus;
    }
}