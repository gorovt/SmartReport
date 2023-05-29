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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using static System.Windows.Forms.ListView;
using Form = System.Windows.Forms.Form;

namespace SmartReport
{
    public partial class frmMain : Form
    {
        public Tools.processes _processes;
        public BackgroundWorker _work;

        public frmMain()
        {
            InitializeComponent();
            this.Text = Main.Name;
            this.lblVersion.Text = "Version " + Main.Version.ToString();
            this.txtReportName.Text = Main._doc.Title;
            Tools._elements = new List<Element>();
            Tools._params = new List<UbParam>();
            Tools._props = new List<UbProperty>();
            Tools._selectedElements = new List<Element>();
            Tools._selectedParams = new List<UbParam>();
            Tools._selectedProperties = new List<UbProperty>();
            Tools._filterRules = FilterRules();
            Tools._filterCases = Tools.FilterCases.Filter0;
            Tools._groupCases = Tools.GroupCases.Group0;
            this.lstAvailable.Clear();
            this.lstProperties.Clear();
            this.lstSelected.Clear();
            // Create ListView Group
            this.lstSelected.Groups.Add("0", "Parameter");
            this.lstSelected.Groups.Add("1", "Property");
            this.lblProgress.Text = "";
            this.dgvPreview.BackgroundColor = System.Drawing.Color.LightGray;
            ActualizarTreeReport();
            //LaunchWork(Tools.processes.ActualizarTreeReport);
        }

        #region General
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            if (Tools._update)
            {
                FillAvailableListView();
                //FillDataGridPreview();
            }
            // TAB Report Selected
            if (index == 0)
            {

            }

            // TAB Fields selected
            if (index == 1)
            {

            }

            // TAB Filter Selected
            if (index == 2)
            {
                
            }

            // TAB Group Selected
            if (index == 3)
            {
                //FillGroupCombos();
            }

            // TAB Preview Selected
            if (index == 4)
            {
                FillDataGridPreview();
            }
        }

        #endregion  

        #region TAB Report
        private List<TreeItem> TreeItemCategoriesFromElements(List<Element> elems)
        {
            List<TreeItem> categories = new List<TreeItem>();
            //int count = 0;
            foreach (Element elem in Tools._elements)
            {
                // Check if Element is a Family Instance
                if (elem.Category != null)
                {
                    if (!categories.Exists(x => x.name == elem.Category.Id.IntegerValue.ToString()))
                    {
                        TreeItem item = new TreeItem();
                        item.name = elem.Category.Id.IntegerValue.ToString();
                        item.text = elem.Category.Name;
                        item.parentName = "Model Instances";
                        item.elements.Add(elem);
                        categories.Add(item);
                    }
                    else
                    {
                        // Get the TreeItem
                        TreeItem item = categories.First(x => x.name == elem.Category.Id.IntegerValue.ToString());
                        item.elements.Add(elem);
                    }
                }
                // Check if Element is a Family
                if (elem as Family != null)
                {
                    Family fam = elem as Family;
                    if (!categories.Exists(x => x.name == fam.FamilyCategory.Id.ToString()))
                    {
                        TreeItem item = new TreeItem();
                        item.name = fam.FamilyCategory.Id.IntegerValue.ToString();
                        item.text = fam.FamilyCategory.Name;
                        item.parentName = "Families";
                        item.elements.Add(elem);
                        categories.Add(item);
                    }
                    else
                    {
                        // Get the TreeItem
                        TreeItem item = categories.First(x => x.name == fam.FamilyCategory.Id.IntegerValue.ToString());
                        item.elements.Add(elem);
                    }
                }
            }

            return categories;
        }

        private void UpdateReportChecksInTools()
        {
            Tools._chkIncludeInstances = this.chkIncludeInstances.Checked;
            Tools._chkAnnotationInstances = this.chkAnnotationInstances.Checked;
            Tools._chkFamilies = this.chkFamilies.Checked;
            Tools._chkMaterials = this.chkMaterials.Checked;
            Tools._chkFamilyTypes = this.chkFamilyTypes.Checked;
            Tools._chkSpecialInstancies = this.chkAllInstances.Checked;
        }

        public void ActualizarTreeReport()
        {
            UpdateReportChecksInTools();
            // Create ProgressBar Form
            frmProcess _frmProcess = new frmProcess(Tools.processes.ActualizarTreeReport, "Processing, please Wait...");
            _frmProcess.ShowDialog();
            // TAB Report
            TreeNode node0 = Tools._treeReport.Nodes[0].Clone() as TreeNode;
            node0.Expand();
            this.trvElements.Nodes.Clear();
            this.trvElements.Nodes.Add(node0);

            FillAvailableListView();
            FillDataGridPreview();
            FillGroupCombos();
            FillComboFilters();
            Tools._update = false;
        }

        public void UpdateReportFromFile(SmrtReport report)
        {
            // Reset Report
            this.chkIncludeInstances.Checked = false;
            this.chkAnnotationInstances.Checked = false;
            this.chkAllInstances.Checked = false;
            this.chkFamilyTypes.Checked = false;
            this.chkFamilies.Checked = false;
            this.chkMaterials.Checked = false;

            // TAB REPORT
            this.txtReportName.Text = report.reportName;
            this.chkIncludeInstances.Checked = report.includeModelInstances;
            this.chkAnnotationInstances.Checked = report.includeAnnotationInstances;
            this.chkAllInstances.Checked = report.includeSpecialInstances;
            this.chkFamilyTypes.Checked = report.includeFamilyTypes;
            this.chkMaterials.Checked = report.includeMaterials;
            this.chkFamilies.Checked = report.includeFamilies;
            // Elements selected
            if (report.selectedElementsId[0].ToString() == "Elements")
            {
                this.trvElements.Nodes[0].Checked = true;
            }
            else
            {
                foreach (TreeNode node in trvElements.Nodes[0].Nodes)
                {
                    foreach (string item in report.selectedElementsId)
                    {
                        if (node.Name == item)
                        {
                            node.Checked = true;
                        }
                    }
                }
            }
            FillAvailableListView();
            // TAB FIELDS
            List<ListViewItem> itmsP = new List<ListViewItem>();
            foreach (string id in report.selectedFieldsId)
            {
                foreach (ListViewItem item in this.lstAvailable.Items)
                {
                    if (item.Name == id)
                    {
                        ListViewItem itm = new ListViewItem();
                        itm.Name = item.Name;
                        itm.Tag = item.Tag;
                        itm.Text = item.Text;
                        itm.Group = this.lstSelected.Groups[0];
                        itmsP.Add(itm);
                    }
                }
                foreach (ListViewItem item in this.lstProperties.Items)
                {
                    if (item.Name == id)
                    {
                        ListViewItem itm = new ListViewItem();
                        itm.Name = item.Name;
                        itm.Tag = item.Tag;
                        itm.Text = item.Text;
                        itm.Group = this.lstSelected.Groups[1];
                        itmsP.Add(itm);
                    }
                }
            }
            // Parameters
            foreach (ListViewItem item in itmsP)
            {
                this.lstSelected.Items.Add(item);
            }
            this.grpSelected.Text = "Selected Fields (" + this.lstSelected.Items.Count.ToString() + ")";
            // Update _selectedParams
            Tools._params = Tools.CollectParameters(Tools._selectedElements);
            Tools._props = Tools.CollectProperties(Tools._selectedElements);
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                // Parameter
                if (item.Group == this.lstSelected.Groups[0])
                {
                    int id = Convert.ToInt32(item.Name);
                    UbParam pa = Tools._params.First(x => x.id == id);
                    Tools._selectedParams.Add(pa);
                }
                // Property
                if (item.Group == this.lstSelected.Groups[1])
                {
                    string name = item.Name;
                    UbProperty prop = Tools._props.First(x => x.name == name);
                    Tools._selectedProperties.Add(prop);
                }
            }

            // TAB FILTER
            FillComboFilters();
            // Filter 01
            this.cmbFilterParam01.SelectedItem = report.cmbFilterParam01;
            this.cmbFilterRule01.SelectedItem = report.cmbFilterRule01;
            Tools.UpdateComboFromString(this.cmbFilterRule01, report.cmbFilterRule01);
            Tools.UpdateComboFromString(this.cmbFilterText01, report.cmbFilterText01);

            // Filter 02
            this.cmbFilterParam02.SelectedItem = report.cmbFilterParam02;
            this.cmbFilterRule02.SelectedItem = report.cmbFilterRule02;
            this.cmbFilterText02.SelectedItem = report.cmbFilterText02;

            // Filter 03
            this.cmbFilterParam03.SelectedItem = report.cmbFilterParam03;
            this.cmbFilterRule03.SelectedItem = report.cmbFilterRule03;
            this.cmbFilterText03.SelectedItem = report.cmbFilterText03;

            // Filter 04
            this.cmbFilterParam04.SelectedItem = report.cmbFilterParam04;
            this.cmbFilterRule04.SelectedItem = report.cmbFilterRule04;
            this.cmbFilterText04.SelectedItem = report.cmbFilterText04;

            // Filter 05
            this.cmbFilterParam05.SelectedItem = report.cmbFilterParam05;
            this.cmbFilterRule05.SelectedItem = report.cmbFilterRule05;
            this.cmbFilterText05.SelectedItem = report.cmbFilterText05;

            // Filter 06
            this.cmbFilterParam06.SelectedItem = report.cmbFilterParam06;
            this.cmbFilterRule06.SelectedItem = report.cmbFilterRule06;
            this.cmbFilterText06.SelectedItem = report.cmbFilterText06;

            // Filter 07
            this.cmbFilterParam07.SelectedItem = report.cmbFilterParam07;
            this.cmbFilterRule07.SelectedItem = report.cmbFilterRule07;
            this.cmbFilterText07.SelectedItem = report.cmbFilterText07;

            // Filter 08
            this.cmbFilterParam08.SelectedItem = report.cmbFilterParam08;
            this.cmbFilterRule08.SelectedItem = report.cmbFilterRule08;
            this.cmbFilterText08.SelectedItem = report.cmbFilterText08;

            // TAB GROUP
            FillGroupCombos();
            // Group 01
            this.cmbGrp01.SelectedItem = report.cmbGrp01;
            this.rdb01Ascending.Checked = report.rdb01Ascending;
            this.rdb01Descending.Checked = report.rdb01Descending;
            this.chk01BlankLine.Checked = report.chk01BlankLine;

            // Group 02
            this.cmbGrp02.SelectedItem = report.cmbGrp02;
            this.rdb02Ascending.Checked = report.rdb02Ascending;
            this.rdb02Descending.Checked = report.rdb02Descending;
            this.chk02BlankLine.Checked = report.chk02BlankLine;

            // Group 03
            this.cmbGrp03.SelectedItem = report.cmbGrp03;
            this.rdb03Ascending.Checked = report.rdb03Ascending;
            this.rdb03Descending.Checked = report.rdb03Descending;
            this.chk03BlankLine.Checked = report.chk03BlankLine;

            // Group 04
            this.cmbGrp04.SelectedItem = report.cmbGrp04;
            this.rdb04Ascending.Checked = report.rdb04Ascending;
            this.rdb04Descending.Checked = report.rdb04Descending;
            this.chk04BlankLine.Checked = report.chk04BlankLine;

            this.chkGrandTotal.Checked = report.chkGrandTotal;
            this.chkGrpItemize.Checked = report.chkGrpItemize;
        }

        private void chkIncludeInstances_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTreeReport();
        }

        private void chkAnnotationInstances_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTreeReport();
        }

        private void chkFamilies_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTreeReport();
        }

        private void chkFamilySymbol_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTreeReport();
        }

        private void chkElemType_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkFamilyTypes_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTreeReport();
        }

        private void chkMaterials_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTreeReport();
        }

        private void chkAllInstances_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTreeReport();
        }

        private void trvElements_AfterCheck(object sender, TreeViewEventArgs e)
        {
            int level = e.Node.Level;
            // Principal Node
            if (level == 0)
            {
                foreach (TreeNode node1 in e.Node.Nodes)
                {
                    if (e.Node.Checked)
                    {
                        node1.Checked = true;
                    }
                    else
                    {
                        node1.Checked = false;
                    }
                }
            }
            // Categories Nodes
            if (level == 1)
            {
                foreach (TreeNode node2 in e.Node.Nodes)
                {
                    if (e.Node.Checked)
                    {
                        node2.Checked = true;
                    }
                    else
                    {
                        node2.Checked = false;
                    }
                }
            }
            Tools._update = true;
        }

        private void CollectSelectedElements()
        {
            Tools._selectedElements = new List<Element>();
            List<string> selectedCat = new List<string>();
            foreach (TreeNode node in this.trvElements.Nodes[0].Nodes)
            {
                if (node.Checked)
                {
                    selectedCat.Add(node.Name);
                }
            }
            foreach (Element elem in Tools._elements)
            {
                // Check if Element is a Family Instance
                if (elem.Category != null)
                {
                    if (selectedCat.Exists(x => x == elem.Category.Id.IntegerValue.ToString()))
                    {
                        Tools._selectedElements.Add(elem);
                    }
                }
                // Check if Element is a Family
                if (elem as Family != null)
                {
                    Family fam = elem as Family;
                    if (selectedCat.Exists(x => x == fam.FamilyCategory.Id.IntegerValue.ToString()))
                    {
                        Tools._selectedElements.Add(elem);
                    }
                }
            }
        }

        private SmrtReport CreateActualReport()
        {
            SmrtReport report = new SmrtReport();

            // TAB REPORT
            report.reportName = this.txtReportName.Text;
            report.includeModelInstances = this.chkIncludeInstances.Checked;
            report.includeAnnotationInstances = this.chkAnnotationInstances.Checked;
            report.includeSpecialInstances = this.chkAllInstances.Checked;
            report.includeFamilyTypes = this.chkFamilyTypes.Checked;
            report.includeMaterials = this.chkMaterials.Checked;
            report.includeFamilies = this.chkFamilies.Checked;
            List<string> selectedElementsId = new List<string>();
            if (this.trvElements.Nodes[0].Checked)
            {
                selectedElementsId.Add(this.trvElements.Nodes[0].Name);
            }
            else
            {
                foreach (TreeNode node in this.trvElements.Nodes[0].Nodes)
                {
                    if (node.Checked)
                    {
                        selectedElementsId.Add(node.Name);
                    }
                }
            }
            report.selectedElementsId = selectedElementsId;

            //TAB FIELDS
            List<string> selectedFieldsId = new List<string>();
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                selectedFieldsId.Add(item.Name);
            }
            report.selectedFieldsId = selectedFieldsId;

            // TAB FILTER
            // Filter 01
            report.cmbFilterParam01 = this.cmbFilterParam01.SelectedItem.ToString();
            report.cmbFilterRule01 = this.cmbFilterRule01.SelectedItem.ToString();
            report.cmbFilterText01 = Tools.GetStringFromComboBox(this.cmbFilterText01);

            // Filter 02
            report.cmbFilterParam02 = this.cmbFilterParam02.SelectedItem.ToString();
            report.cmbFilterRule02 = this.cmbFilterRule02.SelectedItem.ToString();
            report.cmbFilterText02 = Tools.GetStringFromComboBox(this.cmbFilterText02);

            // Filter 03
            report.cmbFilterParam03 = this.cmbFilterParam03.SelectedItem.ToString();
            report.cmbFilterRule03 = this.cmbFilterRule03.SelectedItem.ToString();
            report.cmbFilterText03 = Tools.GetStringFromComboBox(this.cmbFilterText03);

            // Filter 04
            report.cmbFilterParam04 = this.cmbFilterParam04.SelectedItem.ToString();
            report.cmbFilterRule04 = this.cmbFilterRule04.SelectedItem.ToString();
            report.cmbFilterText04 = Tools.GetStringFromComboBox(this.cmbFilterText04);

            // Filter 05
            report.cmbFilterParam05 = this.cmbFilterParam05.SelectedItem.ToString();
            report.cmbFilterRule05 = this.cmbFilterRule05.SelectedItem.ToString();
            report.cmbFilterText05 = Tools.GetStringFromComboBox(this.cmbFilterText05);

            // Filter 06
            report.cmbFilterParam06 = this.cmbFilterParam06.SelectedItem.ToString();
            report.cmbFilterRule06 = this.cmbFilterRule06.SelectedItem.ToString();
            report.cmbFilterText06 = Tools.GetStringFromComboBox(this.cmbFilterText06);

            // Filter 07
            report.cmbFilterParam07 = this.cmbFilterParam07.SelectedItem.ToString();
            report.cmbFilterRule07 = this.cmbFilterRule07.SelectedItem.ToString();
            report.cmbFilterText07 = Tools.GetStringFromComboBox(this.cmbFilterText07);

            // Filter 08
            report.cmbFilterParam08 = this.cmbFilterParam08.SelectedItem.ToString();
            report.cmbFilterRule08 = this.cmbFilterRule08.SelectedItem.ToString();
            report.cmbFilterText08 = Tools.GetStringFromComboBox(this.cmbFilterText08);

            // TAB GROUPS
            // Group 01
            report.cmbGrp01 = this.cmbGrp01.SelectedItem.ToString();
            report.rdb01Ascending = this.rdb01Ascending.Checked;
            report.rdb01Descending = this.rdb01Descending.Checked;
            report.chk01BlankLine = this.chk01BlankLine.Checked;

            // Group 02
            report.cmbGrp02 = this.cmbGrp02.SelectedItem.ToString();
            report.rdb02Ascending = this.rdb02Ascending.Checked;
            report.rdb02Descending = this.rdb02Descending.Checked;
            report.chk02BlankLine = this.chk02BlankLine.Checked;

            // Group 03
            report.cmbGrp03 = this.cmbGrp03.SelectedItem.ToString();
            report.rdb03Ascending = this.rdb03Ascending.Checked;
            report.rdb03Descending = this.rdb03Descending.Checked;
            report.chk03BlankLine = this.chk03BlankLine.Checked;

            // Group 04
            report.cmbGrp04 = this.cmbGrp04.SelectedItem.ToString();
            report.rdb04Ascending = this.rdb04Ascending.Checked;
            report.rdb04Descending = this.rdb04Descending.Checked;
            report.chk04BlankLine = this.chk04BlankLine.Checked;

            report.chkGrandTotal = this.chkGrandTotal.Checked;
            report.chkGrpItemize = this.chkGrpItemize.Checked;

            return report;
        }
        #endregion

        #region TAB Fields
        private void UpdateSelectedGroupText()
        {
            int count = this.lstSelected.Items.Count;
            this.grpSelected.Text = "Selected Fields (" + count.ToString() + ")";
        }

        private void UpdateListViewsInTools()
        {
            Tools._lstAvailable = this.lstAvailable;
            //Tools._lstProperties = this.lstProperties;
            Tools._lstSelected = this.lstSelected;

            //Tools._lstAvailable.Clear();
            Tools._lstProperties.Clear();
            //Tools._lstSelected.Clear();

            //Tools._lstAvailable.Items.AddRange(this.lstAvailable.Items);
            foreach (ListViewItem item in this.lstAvailable.Items)
            {
                Tools._lstAvailable.Items.Add(item.Clone() as ListViewItem);
            }
            //Tools._lstSelected.Items.AddRange(this.lstSelected.Items);
        }

        private void UpdateListViewsFromTools()
        {
            this.lstAvailable = Tools._lstAvailable;
            //this.lstProperties = Tools._lstProperties;
            this.lstSelected = Tools._lstSelected;

            //this.lstAvailable.Clear();
            this.lstProperties.Clear();
            //this.lstSelected.Clear();

            //this.lstAvailable.Items.AddRange(Tools._lstAvailable.Items);
            foreach (ListViewItem item in Tools._lstAvailable.Items)
            {
                this.lstAvailable.Items.Add(item.Clone() as ListViewItem);
            }
            //this.lstSelected.Items.AddRange(Tools._lstSelected.Items);
        }

        private void FillAvailableListView()
        {
            //UpdateListViewsInTools();

            //// Create ProgressBar Form
            //frmProcess _frmProcess = new frmProcess(Tools.processes.FillAvailableListView, 
            //    "Obtaining Parameters, please Wait...");
            //_frmProcess.ShowDialog();

            //// TAB FIELDS
            //UpdateListViewsFromTools();

            //FillGroupCombos();
            //Tools._update = false;

            //Collect Selected Elements
            CollectSelectedElements();
            //Collect Params
            this.lstAvailable.Items.Clear();
            this.lstProperties.Items.Clear();

            List<UbParam> _params = Tools.CollectParameters(Tools._selectedElements);

            foreach (UbParam p in _params)
            {
                // Parameters
                if (p.paramType == UbParam.ParamType.Parameter)
                {
                    // Get Element from Parameter
                    Element elem1 = p.GetElement();

                    ListViewItem itm = new ListViewItem();
                    itm.Tag = p.name;
                    itm.Name = p.id.ToString();
                    itm.Text = p.name;// + " <" + p.id + ">";
                    itm.ToolTipText = "ID <" + p.id + ">";

                    if (elem1.GetTypeId().IntegerValue == -1)
                    {
                        // Is Type Param
                        itm.Group = this.lstAvailable.Groups[1];
                    }
                    else
                    {
                        // Is Instance Param
                        itm.Group = this.lstAvailable.Groups[0];
                    }
                    this.lstAvailable.Items.Add(itm);
                }
            }
            this.grpAvailable.Text = "Available Parameters (" + _params.Count.ToString() + ")";
            // Check selected params
            if (this.lstSelected.Groups[0].Items.Count > 0)
            {
                List<ListViewItem> removeItems = new List<ListViewItem>();
                foreach (ListViewItem item in this.lstSelected.Groups[0].Items)
                {
                    if (!_params.Exists(x => x.id.ToString() == item.Name))
                    {
                        removeItems.Add(item);
                    }
                }
                // Remove Items
                if (removeItems.Count > 0)
                {
                    foreach (ListViewItem item in removeItems)
                    {
                        ListViewItem item2 = this.lstSelected.Groups[0].Items.Find(item.Name, false)[0];
                        this.lstSelected.Items.Remove(item2);
                    }
                }
            }
            // Properties
            List<UbProperty> _props = Tools.CollectProperties(Tools._selectedElements);
            foreach (UbProperty prop in _props)
            {
                ListViewItem itm = new ListViewItem();
                itm.Tag = prop.name;
                itm.Name = prop.name;
                itm.Text = prop.name;

                this.lstProperties.Items.Add(itm);
            }
            this.grpProperties.Text = "Available Properties (" + _props.Count.ToString() + ")";
            // Check selected Properties
            if (this.lstSelected.Groups[1].Items.Count > 0)
            {
                List<ListViewItem> removeItems = new List<ListViewItem>();
                foreach (ListViewItem item in this.lstSelected.Groups[1].Items)
                {
                    if (!_props.Exists(x => x.name == item.Name))
                    {
                        removeItems.Add(item);
                    }
                }
                // Remove Items
                if (removeItems.Count > 0)
                {
                    foreach (ListViewItem item in removeItems)
                    {
                        ListViewItem item2 = this.lstSelected.Groups[1].Items.Find(item.Name, false)[0];
                        this.lstSelected.Items.Remove(item2);
                    }
                }
            }
            this.lstSelected.Update();
            FillGroupCombos();
            Tools._update = false;
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            List<ListViewItem> itmsPA = new List<ListViewItem>();
            List<ListViewItem> itmsPP = new List<ListViewItem>();
            foreach (ListViewItem pa in this.lstAvailable.CheckedItems)
            {
                itmsPA.Add(pa);
            }
            foreach (ListViewItem pp in this.lstProperties.CheckedItems)
            {
                itmsPP.Add(pp);
            }
            //this.lstSelected.Items.Clear();
            // Parameters
            foreach (ListViewItem item in itmsPA)
            {
                ListViewItemCollection itmParams = this.lstSelected.Groups[0].Items;
                if (!itmParams.ContainsKey(item.Name))
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Name = item.Name;
                    itm.Tag = item.Tag;
                    itm.Text = item.Text;
                    itm.Group = this.lstSelected.Groups[0];
                    this.lstSelected.Items.Add(itm);
                }
            }
            // Properties
            foreach (ListViewItem item in itmsPP)
            { 
                ListViewItemCollection itmProps = this.lstSelected.Groups[1].Items;
                if (!itmProps.ContainsKey(item.Name))
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Name = item.Name;
                    itm.Tag = item.Tag;
                    itm.Text = item.Text;
                    itm.Group = this.lstSelected.Groups[1];
                    this.lstSelected.Items.Add(itm);
                }
            }
            this.grpSelected.Text = "Selected Fields (" + this.lstSelected.Items.Count.ToString() + ")";
            FillDataGridPreview();
            FillGroupCombos();
            FillComboFilters();
        }

        private void btnRemoveField_Click(object sender, EventArgs e)
        {
            List<ListViewItem> removes = new List<ListViewItem>();
            foreach (ListViewItem item in lstSelected.CheckedItems)
            {
                this.lstSelected.Items.Remove(item);
            }
            // Reconstruct Available List
            //FillAvailableListView();
            // Check same Params
            foreach (ListViewItem item in lstAvailable.Items)
            {
                item.Checked = false;
                foreach (ListViewItem item1 in lstSelected.Items)
                {
                    if (item.Name == item1.Name)
                    {
                        item.Checked = true;
                    }
                }
            }
            // Check same Properties
            foreach (ListViewItem item in lstProperties.Items)
            {
                item.Checked = false;
                foreach (ListViewItem item1 in lstSelected.Items)
                {
                    if (item.Name == item1.Name)
                    {
                        item.Checked = true;
                    }
                }
            }
            this.grpSelected.Text = "Selected Fields (" + this.lstSelected.Items.Count.ToString() + ")";
            FillDataGridPreview();
            FillGroupCombos();
            FillComboFilters();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.lstSelected.SelectedItems.Count >0)
            {
                ListViewItem item = this.lstSelected.SelectedItems[0];
                if (item.Index > 0)
                {
                    var _group = item.Group;
                    int newIndex = item.Index - 1;
                    ListViewItem item2 = item;
                    this.lstSelected.Items.RemoveAt(item.Index);
                    this.lstSelected.Items.Insert(newIndex, item2);
                    item2.Group = _group;
                }
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (this.lstSelected.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lstSelected.SelectedItems[0];
                if (item.Index < this.lstSelected.Items.Count - 1)
                {
                    var _group = item.Group;
                    int newIndex = item.Index + 1;
                    ListViewItem item2 = item;
                    this.lstSelected.Items.RemoveAt(item.Index);
                    this.lstSelected.Items.Insert(newIndex, item2);
                    item2.Group = _group;
                }
            }
        }

        #endregion

        #region TAB Filter
        private List<string> FilterRules()
        {
            List<string> rules = new List<string>();
            rules.Add("Is equal to");
            rules.Add("Is not equal to");
            rules.Add("Contains");
            rules.Add("Not contains");
            rules.Add("Start by");
            rules.Add("Does not start with");
            return rules;
        }

        private void ResetComboWithNone(System.Windows.Forms.ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("None");
            combo.SelectedIndex = 0;
        }

        private void ResetComboWithEmpty(System.Windows.Forms.ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add(string.Empty);
            combo.SelectedIndex = 0;
        }

        private void FillComboWithList(System.Windows.Forms.ComboBox combo, List<string> lista)
        {
            combo.Items.Clear();
            foreach (string item in lista)
            {
                if (item != null)
                {
                    combo.Items.Add(item);
                }
            }
            if (combo.Items.Count > 0)
            {
                combo.SelectedIndex = 0;
            }
        }

        private void FillComboWithListNone(System.Windows.Forms.ComboBox combo, List<string> lista)
        {
            combo.Items.Clear();
            combo.Items.Add("None");
            foreach (string item in lista)
            {
                if (item != null)
                {
                    combo.Items.Add(item);
                }
            }
            combo.SelectedIndex = 0;
        }

        private void FillComboWithItemCollection(System.Windows.Forms.ComboBox combo, ListViewItemCollection items)
        {
            combo.Items.Clear();
            combo.Items.Add("None");
            foreach (ListViewItem item in items)
            {
                combo.Items.Add(item.Tag.ToString());
            }
            combo.SelectedIndex = 0;
        }

        private void FillComboFilters()
        {
            // FILTER 01
            // Filter 01 Parameters
            FillComboWithItemCollection(this.cmbFilterParam01, this.lstSelected.Items);
            // Filter 01 Rules
            FillComboWithListNone(this.cmbFilterRule01, Tools._filterRules);
            this.cmbFilterRule01.Enabled = false;
            // Filter 01 Text
            this.cmbFilterText01.Items.Clear();
            this.cmbFilterText01.Items.Add(string.Empty);
            this.cmbFilterText01.SelectedIndex = 0;
            this.cmbFilterText01.Enabled = false;

            // FILTER 02
            // Filter 02 Parameters
            FillComboWithItemCollection(this.cmbFilterParam02, this.lstSelected.Items);
            this.cmbFilterParam02.Enabled = false;
            // Filter 02 Rules
            FillComboWithListNone(this.cmbFilterRule02, Tools._filterRules);
            this.cmbFilterRule02.Enabled = false;
            // Filter 02 Text
            this.cmbFilterText02.Items.Clear();
            this.cmbFilterText02.Items.Add(string.Empty);
            this.cmbFilterText02.SelectedIndex = 0;
            this.cmbFilterText02.Enabled = false;

            // FILTER 03
            // Filter 03 Parameters
            FillComboWithItemCollection(this.cmbFilterParam03, this.lstSelected.Items);
            this.cmbFilterParam03.Enabled = false;
            // Filter 03 Rules
            FillComboWithListNone(this.cmbFilterRule03, Tools._filterRules);
            this.cmbFilterRule03.Enabled = false;
            // Filter 03 Text
            this.cmbFilterText03.Items.Clear();
            this.cmbFilterText03.Items.Add(string.Empty);
            this.cmbFilterText03.SelectedIndex = 0;
            this.cmbFilterText03.Enabled = false;

            // FILTER 04
            // Filter 04 Parameters
            FillComboWithItemCollection(this.cmbFilterParam04, this.lstSelected.Items);
            this.cmbFilterParam04.Enabled = false;
            // Filter 04 Rules
            FillComboWithListNone(this.cmbFilterRule04, Tools._filterRules);
            this.cmbFilterRule04.Enabled = false;
            // Filter 04 Text
            this.cmbFilterText04.Items.Clear();
            this.cmbFilterText04.Items.Add(string.Empty);
            this.cmbFilterText04.SelectedIndex = 0;
            this.cmbFilterText04.Enabled = false;

            // FILTER 05
            // Filter 05 Parameters
            FillComboWithItemCollection(this.cmbFilterParam05, this.lstSelected.Items);
            this.cmbFilterParam05.Enabled = false;
            // Filter 05 Rules
            FillComboWithListNone(this.cmbFilterRule05, Tools._filterRules);
            this.cmbFilterRule05.Enabled = false;
            // Filter 05 Text
            this.cmbFilterText05.Items.Clear();
            this.cmbFilterText05.Items.Add(string.Empty);
            this.cmbFilterText05.SelectedIndex = 0;
            this.cmbFilterText05.Enabled = false;

            // FILTER 06
            // Filter 06 Parameters
            FillComboWithItemCollection(this.cmbFilterParam06, this.lstSelected.Items);
            this.cmbFilterParam06.Enabled = false;
            // Filter 06 Rules
            FillComboWithListNone(this.cmbFilterRule06, Tools._filterRules);
            this.cmbFilterRule06.Enabled = false;
            // Filter 06 Text
            this.cmbFilterText06.Items.Clear();
            this.cmbFilterText06.Items.Add(string.Empty);
            this.cmbFilterText06.SelectedIndex = 0;
            this.cmbFilterText06.Enabled = false;

            // FILTER 07
            // Filter 07 Parameters
            FillComboWithItemCollection(this.cmbFilterParam07, this.lstSelected.Items);
            this.cmbFilterParam07.Enabled = false;
            // Filter 07 Rules
            FillComboWithListNone(this.cmbFilterRule07, Tools._filterRules);
            this.cmbFilterRule07.Enabled = false;
            // Filter 07 Text
            this.cmbFilterText07.Items.Clear();
            this.cmbFilterText07.Items.Add(string.Empty);
            this.cmbFilterText07.SelectedIndex = 0;
            this.cmbFilterText07.Enabled = false;

            // FILTER 08
            // Filter 08 Parameters
            FillComboWithItemCollection(this.cmbFilterParam08, this.lstSelected.Items);
            this.cmbFilterParam08.Enabled = false;
            // Filter 08 Rules
            FillComboWithListNone(this.cmbFilterRule08, Tools._filterRules);
            this.cmbFilterRule08.Enabled = false;
            // Filter 08 Text
            this.cmbFilterText08.Items.Clear();
            this.cmbFilterText08.Items.Add(string.Empty);
            this.cmbFilterText08.SelectedIndex = 0;
            this.cmbFilterText08.Enabled = false;
        }

        private void FillComboRules(System.Windows.Forms.ComboBox comboParameter, System.Windows.Forms.ComboBox comboRules,
            System.Windows.Forms.ComboBox comboText)
        {
            string idParam = string.Empty;
            string param = comboParameter.SelectedItem.ToString();
            foreach (UbParam pa in Tools._selectedParams)
            {
                if (pa.name == param)
                {
                    idParam = pa.id.ToString();
                }
            }
            foreach (UbProperty prop in Tools._selectedProperties)
            {
                if (prop.name == param)
                {
                    idParam = prop.name;
                }
            }
            List<string> values = Tools.GetParameterValuesFromElements(Tools._selectedElements, idParam);
            values = values.OrderBy(x => x).ToList();
            FillComboWithList(comboText, values);
            comboText.Enabled = true;
        }

        private void ComboFilterParam_SelectedIndexChanged(System.Windows.Forms.ComboBox comboFilterParam_A,
            System.Windows.Forms.ComboBox comboFilterRules_A)
        {
            if (comboFilterParam_A.SelectedIndex == 0)
            {
                ResetComboWithNone(comboFilterRules_A);
                comboFilterRules_A.Enabled = false;
            }
            else
            {
                FillComboWithListNone(comboFilterRules_A, Tools._filterRules);
                comboFilterRules_A.Enabled = true;
            }
        }

        private void ComboFilterRules_SelectedIndexChanged(System.Windows.Forms.ComboBox comboParam_A,
            System.Windows.Forms.ComboBox comboRules_A, System.Windows.Forms.ComboBox comboText_A,
            System.Windows.Forms.ComboBox comboParam_B, Tools.FilterCases _filterCase_A0, Tools.FilterCases _filterCase_A)
        {
            int index = comboRules_A.SelectedIndex;
            string param = comboParam_A.SelectedItem.ToString();
            string idParam = string.Empty;
            switch (index)
            {
                case 0: // None
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = false;
                    comboParam_B.Enabled = false;
                    comboParam_B.SelectedIndex = 0;
                    Tools._filterCases = _filterCase_A0;
                    break;
                case 1: // Is equal to
                    FillComboRules(comboParam_A, comboRules_A, comboText_A);
                    Tools._filterCases = _filterCase_A;
                    comboParam_B.Enabled = true;
                    break;
                case 2: // Is not equal to
                    FillComboRules(comboParam_A, comboRules_A, comboText_A);
                    Tools._filterCases = _filterCase_A;
                    comboParam_B.Enabled = true;
                    break;
                case 3: // Contains
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    comboParam_B.Enabled = true;
                    break;
                case 4: // Not contains
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    comboParam_B.Enabled = true;
                    break;
                case 5: // Start by
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    comboParam_B.Enabled = true;
                    break;
                case 6: // Does not start with
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    comboParam_B.Enabled = true;
                    break;
            }
        }

        private void ComboLastFilterRules_SelectedIndexChanged(System.Windows.Forms.ComboBox comboParam_A,
            System.Windows.Forms.ComboBox comboRules_A, System.Windows.Forms.ComboBox comboText_A,
            Tools.FilterCases _filterCase_A0, Tools.FilterCases _filterCase_A)
        {
            int index = comboRules_A.SelectedIndex;
            string param = comboParam_A.SelectedItem.ToString();
            string idParam = string.Empty;
            switch (index)
            {
                case 0: // None
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = false;
                    Tools._filterCases = _filterCase_A0;
                    break;
                case 1: // Is equal to
                    FillComboRules(comboParam_A, comboRules_A, comboText_A);
                    Tools._filterCases = _filterCase_A;
                    break;
                case 2: // Is not equal to
                    FillComboRules(comboParam_A, comboRules_A, comboText_A);
                    Tools._filterCases = _filterCase_A;
                    break;
                case 3: // Contains
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    break;
                case 4: // Not contains
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    break;
                case 5: // Start by
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    break;
                case 6: // Does not start with
                    ResetComboWithEmpty(comboText_A);
                    comboText_A.Enabled = true;
                    Tools._filterCases = _filterCase_A;
                    break;
            }
        }

        private void cmbFilterParam01_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam01, this.cmbFilterRule01);
        }

        private void cmbFilterRule01_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterRules_SelectedIndexChanged(this.cmbFilterParam01, this.cmbFilterRule01, this.cmbFilterText01,
                this.cmbFilterParam02, Tools.FilterCases.Filter0, Tools.FilterCases.Filter1);
        }

        private void cmbFilterParam02_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam02, this.cmbFilterRule02);
        }

        private void cmbFilterRule02_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterRules_SelectedIndexChanged(this.cmbFilterParam02, this.cmbFilterRule02, this.cmbFilterText02,
                this.cmbFilterParam03, Tools.FilterCases.Filter1, Tools.FilterCases.Filter2);
        }

        private void cmbFilterParam03_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam03, this.cmbFilterRule03);
        }

        private void cmbFilterRule03_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterRules_SelectedIndexChanged(this.cmbFilterParam03, this.cmbFilterRule03, this.cmbFilterText03,
                this.cmbFilterParam04, Tools.FilterCases.Filter2, Tools.FilterCases.Filter3);
        }

        private void cmbFilterParam04_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam04, this.cmbFilterRule04);
        }

        private void cmbFilterRule04_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterRules_SelectedIndexChanged(this.cmbFilterParam04, this.cmbFilterRule04, this.cmbFilterText04,
                this.cmbFilterParam05, Tools.FilterCases.Filter3, Tools.FilterCases.Filter4);
        }

        private void cmbFilterParam05_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam05, this.cmbFilterRule05);
        }

        private void cmbFilterRule05_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterRules_SelectedIndexChanged(this.cmbFilterParam05, this.cmbFilterRule05, this.cmbFilterText05,
                this.cmbFilterParam06, Tools.FilterCases.Filter4, Tools.FilterCases.Filter5);
        }

        private void cmbFilterParam06_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam06, this.cmbFilterRule06);
        }

        private void cmbFilterRule06_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterRules_SelectedIndexChanged(this.cmbFilterParam06, this.cmbFilterRule06, this.cmbFilterText06,
                this.cmbFilterParam07, Tools.FilterCases.Filter5, Tools.FilterCases.Filter6);
        }

        private void cmbFilterParam07_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam07, this.cmbFilterRule07);
        }

        private void cmbFilterRule07_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterRules_SelectedIndexChanged(this.cmbFilterParam07, this.cmbFilterRule07, this.cmbFilterText07,
                this.cmbFilterParam08, Tools.FilterCases.Filter6, Tools.FilterCases.Filter7);
        }

        private void cmbFilterParam08_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboFilterParam_SelectedIndexChanged(this.cmbFilterParam08, this.cmbFilterRule08);
        }

        private void cmbFilterRule08_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboLastFilterRules_SelectedIndexChanged(this.cmbFilterParam08, this.cmbFilterRule08, this.cmbFilterText08,
                Tools.FilterCases.Filter7, Tools.FilterCases.Filter8);
        }

        #endregion

        #region TAB Group
        private void FillGroupCombos()
        {
            // GROUP 01
            this.cmbGrp01.Items.Clear();
            this.cmbGrp01.Items.Add("None");
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                this.cmbGrp01.Items.Add(item.Tag.ToString());
            }
            this.cmbGrp01.SelectedIndex = 0;
            this.rdb01Ascending.Enabled = false;
            this.rdb01Descending.Enabled = false;
            this.chk01BlankLine.Enabled = false;
            this.chkGrp01Header.Enabled = false;
            this.chkGrp01Footer.Enabled = false;

            this.rdb01Ascending.Checked = true;
            this.rdb01Descending.Checked = false;
            this.chk01BlankLine.Checked = false;
            this.chkGrp01Header.Checked = false;
            this.chkGrp01Footer.Checked = false;

            // GROUP 02
            this.cmbGrp02.Items.Clear();
            this.cmbGrp02.Items.Add("None");
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                this.cmbGrp02.Items.Add(item.Tag.ToString());
            }
            this.cmbGrp02.SelectedIndex = 0;
            this.cmbGrp02.Enabled = false;
            this.rdb02Ascending.Enabled = false;
            this.rdb02Descending.Enabled = false;
            this.chk02BlankLine.Enabled = false;
            //this.chkGrp02Header.Enabled = false;
            //this.chkGrp02Footer.Enabled = false;

            this.rdb02Ascending.Checked = true;
            this.rdb02Descending.Checked = false;
            this.chk02BlankLine.Checked = false;
            //this.chkGrp02Header.Checked = false;
            //this.chkGrp02Footer.Checked = false;
            

            // GROUP 03
            this.cmbGrp03.Items.Clear();
            this.cmbGrp03.Items.Add("None");
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                this.cmbGrp03.Items.Add(item.Tag.ToString());
            }
            this.cmbGrp03.SelectedIndex = 0;
            this.cmbGrp03.Enabled = false;
            this.rdb03Ascending.Enabled = false;
            this.rdb03Descending.Enabled = false;
            this.chk03BlankLine.Enabled = false;
            //this.chkGrp03Header.Enabled = false;
            //this.chkGrp03Footer.Enabled = false;

            this.rdb03Ascending.Checked = true;
            this.rdb03Descending.Checked = false;
            this.chk03BlankLine.Checked = false;
            //this.chkGrp03Header.Checked = false;
            //this.chkGrp03Footer.Checked = false;

            // GROUP 04
            this.cmbGrp04.Items.Clear();
            this.cmbGrp04.Items.Add("None");
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                this.cmbGrp04.Items.Add(item.Tag.ToString());
            }
            this.cmbGrp04.SelectedIndex = 0;
            this.cmbGrp04.Enabled = false;
            this.rdb04Ascending.Enabled = false;
            this.rdb04Descending.Enabled = false;
            this.chk04BlankLine.Enabled = false;
            //this.chkGrp04Header.Enabled = false;
            //this.chkGrp04Footer.Enabled = false;

            this.rdb04Ascending.Checked = true;
            this.rdb04Descending.Checked = false;
            this.chk04BlankLine.Checked = false;
            //this.chkGrp04Header.Checked = false;
            //this.chkGrp04Footer.Checked = false;

            // GRAND TOTAL
            this.chkGrandTotal.Checked = false;
            this.chkGrandTotal.Enabled = false;

            // ITEMIZE EVERY INSTANCE
            this.chkGrpItemize.Checked = true;
            this.chkGrpItemize.Enabled = false;

            Tools._groupCases = Tools.GroupCases.Group0;
        }

        private void cmbGrp01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbGrp01.SelectedIndex > 0)
            {
                Tools._groupCases = Tools.GroupCases.Group1;
                this.rdb01Ascending.Enabled = true;
                this.rdb01Descending.Enabled = true;
                this.chk01BlankLine.Enabled = true;
                this.chkGrp01Header.Enabled = true;
                this.chkGrp01Footer.Enabled = true;

                this.cmbGrp02.Enabled = true;
            }
            else
            {
                Tools._groupCases = Tools.GroupCases.Group0;
                this.rdb01Ascending.Enabled = false;
                this.rdb01Descending.Enabled = false;
                this.chk01BlankLine.Enabled = false;
                this.chkGrp01Header.Enabled = false;
                this.chkGrp01Footer.Enabled = false;

                this.cmbGrp02.Enabled = false;
                this.cmbGrp02.SelectedIndex = 0;
            }
        }

        private void cmbGrp02_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbGrp02.SelectedIndex > 0)
            {
                Tools._groupCases = Tools.GroupCases.Group2;
                this.rdb02Ascending.Enabled = true;
                this.rdb02Descending.Enabled = true;
                this.chk02BlankLine.Enabled = true;
                this.chkGrp02Header.Enabled = true;
                this.chkGrp02Footer.Enabled = true;

                this.cmbGrp03.Enabled = true;
            }
            else
            {
                Tools._groupCases = Tools.GroupCases.Group1;
                this.rdb02Ascending.Enabled = false;
                this.rdb02Descending.Enabled = false;
                this.chk02BlankLine.Enabled = false;
                this.chkGrp02Header.Enabled = false;
                this.chkGrp02Footer.Enabled = false;

                this.cmbGrp03.Enabled = false;
                this.cmbGrp03.SelectedIndex = 0;
            }
        }

        private void cmbGrp03_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbGrp03.SelectedIndex > 0)
            {
                Tools._groupCases = Tools.GroupCases.Group3;
                this.rdb03Ascending.Enabled = true;
                this.rdb03Descending.Enabled = true;
                this.chk03BlankLine.Enabled = true;
                //this.chkGrp03Header.Enabled = true;
                //this.chkGrp03Footer.Enabled = true;

                this.cmbGrp04.Enabled = true;
            }
            else
            {
                Tools._groupCases = Tools.GroupCases.Group2;
                this.rdb03Ascending.Enabled = false;
                this.rdb03Descending.Enabled = false;
                this.chk03BlankLine.Enabled = false;
                //this.chkGrp03Header.Enabled = false;
                //this.chkGrp03Footer.Enabled = false;

                this.cmbGrp04.Enabled = false;
                this.cmbGrp04.SelectedIndex = 0;
            }
        }

        private void cmbGrp04_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbGrp04.SelectedIndex > 0)
            {
                Tools._groupCases = Tools.GroupCases.Group4;
                this.rdb04Ascending.Enabled = true;
                this.rdb04Descending.Enabled = true;
                this.chk04BlankLine.Enabled = true;
                //this.chkGrp04Header.Enabled = true;
                //this.chkGrp04Footer.Enabled = true;
            }
            else
            {
                Tools._groupCases = Tools.GroupCases.Group3;
                this.rdb04Ascending.Enabled = false;
                this.rdb04Descending.Enabled = false;
                this.chk04BlankLine.Enabled = false;
                //this.chkGrp04Header.Enabled = false;
                //this.chkGrp04Footer.Enabled = false;
            }
        }

        #endregion

        #region TAB Preview
        public List<List<string>> CreatePreviewRows()
        {
            this.lstSelected.Refresh();
            List<List<string>> lstRows = new List<List<string>>();
            // Classify Elements
            // Itemize Every Instance
            foreach (Element elem in Tools._selectedElements)
            {
                List<string> values = new List<string>();
                foreach (ListViewItem item in this.lstSelected.Items)
                {
                    // Parameter
                    if (item.Group == this.lstSelected.Groups[0])
                    {
                        string value = string.Empty;
                        int _id = Convert.ToInt32(item.Name);
                        // Get parameter value
                        ParameterSet pSet = elem.Parameters;
                        List<Parameter> parameters = new List<Parameter>();
                        foreach (Parameter pa in pSet)
                        {
                            parameters.Add(pa);
                        }
                        // Instance Parameter
                        Parameter elemP = null;
                        try
                        {
                            elemP = parameters.First(x => x.Id.IntegerValue == _id);
                        }
                        catch (Exception)
                        {

                        }

                        if (elemP != null)
                        {
                            value = Tools.GetValueFromParameter(elemP);
                        }
                        // Type Parameter
                        ElementType type = null;
                        try
                        {
                            type = Main._doc.GetElement(elem.GetTypeId()) as ElementType;
                        }
                        catch (Exception)
                        {

                        }
                        if (type != null)
                        {
                            // Get parameter value
                            ParameterSet pSet2 = type.Parameters;
                            List<Parameter> parameters2 = new List<Parameter>();
                            foreach (Parameter pa in pSet2)
                            {
                                parameters2.Add(pa);
                            }
                            try
                            {
                                Parameter typeParam = parameters2.First(x => x.Id.IntegerValue == _id);
                                if (typeParam != null)
                                {
                                    if (value == string.Empty || value == null)
                                    {
                                        value = Tools.GetValueFromParameter(typeParam);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                
                            }

                        }
                        // Family Parameter
                        if (elem as Family != null)
                        {
                            Family fam = elem as Family;
                            ElementType famType = null;
                            foreach (ElementId id in fam.GetFamilySymbolIds())
                            {
                                famType = Main._doc.GetElement(id) as ElementType;
                            }
                            if (famType != null)
                            {
                                ParameterSet pSet3 = famType.Parameters;
                                List<Parameter> parameters3 = new List<Parameter>();
                                foreach (Parameter pa in pSet3)
                                {
                                    parameters3.Add(pa);
                                }
                                Parameter famP = null;
                                try
                                {
                                    famP = parameters3.First(x => x.Id.IntegerValue == _id);
                                    value = Tools.GetValueFromParameter(famP);
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                        values.Add(value);
                    }
                    // Property
                    if (item.Group == this.lstSelected.Groups[1])
                    {
                        List<UbProperty> _props = Tools.GetPropertiesFromElement(elem);
                        if (!_props.Exists(x => x.name == item.Name))
                        {
                            values.Add(string.Empty);
                        }
                        else
                        {
                            UbProperty _prop = _props.First(x => x.name == item.Name);
                            values.Add(_prop.value);
                        }
                        //UbProperty _prop = _props.First(x => x.name == item.Name);
                        //values.Add(_prop.value);
                    }
                }
                lstRows.Add(values);
            }

            return lstRows;
        }

        private List<List<string>> FilterCase(DataGridView grid, List<List<string>> lista, 
            System.Windows.Forms.ComboBox comboParam_A, System.Windows.Forms.ComboBox comboRule_A,
            System.Windows.Forms.ComboBox comboText_A)
        {
            List<List<string>> lista2 = new List<List<string>>();
            string fParam1 = comboParam_A.SelectedItem.ToString();
            int fRule1 = comboRule_A.SelectedIndex;

            // Obtain Column index
            int index1 = -1;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.Tag.ToString() == fParam1)
                {
                    index1 = col.Index;
                }
            }
            if (index1 > -1)
            {
                foreach (List<string> line in lista)
                {
                    // Filter Rules
                    switch (fRule1)
                    {
                        case 0:
                            lista2.Add(line);
                            break;
                        case 1: // Is equal to
                            string fText1 = string.Empty;
                            if (comboText_A.SelectedItem != null)
                            {
                                fText1 = comboText_A.SelectedItem.ToString();
                            }
                            else
                            {
                                fText1 = comboText_A.Text;
                            }
                            if (line[index1] == fText1)
                            {
                                lista2.Add(line);
                            }
                            break;
                        case 2: // Is not equal to
                            string fText2 = string.Empty;
                            if (comboText_A.SelectedItem != null)
                            {
                                fText2 = comboText_A.SelectedItem.ToString();
                            }
                            else
                            {
                                fText2 = comboText_A.Text;
                            }
                            if (line[index1] != fText2)
                            {
                                lista2.Add(line);
                            }
                            break;
                        case 3: // Contains
                            string fText3 = comboText_A.Text;
                            if (line[index1].Contains(fText3))
                            {
                                lista2.Add(line);
                            }
                            break;
                        case 4: // Not Contains
                            string fText4 = comboText_A.Text;
                            if (!line[index1].Contains(fText4))
                            {
                                lista2.Add(line);
                            }
                            break;
                        case 5: // Start By
                            string fText5 = comboText_A.Text;
                            if (line[index1].StartsWith(fText5))
                            {
                                lista2.Add(line);
                            }
                            break;
                        case 6: // Does not start with
                            string fText6 = comboText_A.Text;
                            if (!line[index1].StartsWith(fText6))
                            {
                                lista2.Add(line);
                            }
                            break;
                    }
                }
            }
            else
            {
                lista2.AddRange(lista);
            }
            return lista2;
        }

        private List<List<string>> FilterGrid(DataGridView grid, List<List<string>> lista)
        {
            List<List<string>> lista2 = new List<List<string>>();
            switch (Tools._filterCases)
            {
                case Tools.FilterCases.Filter0:
                    lista2.AddRange(lista);
                    break;
                case Tools.FilterCases.Filter1:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    break;
                case Tools.FilterCases.Filter2:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam02, this.cmbFilterRule02,
                         this.cmbFilterText02);
                    break;
                case Tools.FilterCases.Filter3:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam02, this.cmbFilterRule02,
                         this.cmbFilterText02);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam03, this.cmbFilterRule03,
                         this.cmbFilterText03);
                    break;
                case Tools.FilterCases.Filter4:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam02, this.cmbFilterRule02,
                         this.cmbFilterText02);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam03, this.cmbFilterRule03,
                         this.cmbFilterText03);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam04, this.cmbFilterRule04,
                         this.cmbFilterText04);
                    break;
                case Tools.FilterCases.Filter5:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam02, this.cmbFilterRule02,
                         this.cmbFilterText02);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam03, this.cmbFilterRule03,
                         this.cmbFilterText03);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam04, this.cmbFilterRule04,
                         this.cmbFilterText04);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam05, this.cmbFilterRule05,
                         this.cmbFilterText05);
                    break;
                case Tools.FilterCases.Filter6:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam02, this.cmbFilterRule02,
                         this.cmbFilterText02);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam03, this.cmbFilterRule03,
                         this.cmbFilterText03);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam04, this.cmbFilterRule04,
                         this.cmbFilterText04);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam05, this.cmbFilterRule05,
                         this.cmbFilterText05);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam06, this.cmbFilterRule06,
                         this.cmbFilterText06);
                    break;
                case Tools.FilterCases.Filter7:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam02, this.cmbFilterRule02,
                         this.cmbFilterText02);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam03, this.cmbFilterRule03,
                         this.cmbFilterText03);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam04, this.cmbFilterRule04,
                         this.cmbFilterText04);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam05, this.cmbFilterRule05,
                         this.cmbFilterText05);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam06, this.cmbFilterRule06,
                         this.cmbFilterText06);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam07, this.cmbFilterRule07,
                         this.cmbFilterText07);
                    break;
                case Tools.FilterCases.Filter8:
                    lista2 = FilterCase(this.dgvPreview, lista, this.cmbFilterParam01, this.cmbFilterRule01,
                         this.cmbFilterText01);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam02, this.cmbFilterRule02,
                         this.cmbFilterText02);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam03, this.cmbFilterRule03,
                         this.cmbFilterText03);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam04, this.cmbFilterRule04,
                         this.cmbFilterText04);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam05, this.cmbFilterRule05,
                         this.cmbFilterText05);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam06, this.cmbFilterRule06,
                         this.cmbFilterText06);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam07, this.cmbFilterRule07,
                         this.cmbFilterText07);
                    lista2 = FilterCase(this.dgvPreview, lista2, this.cmbFilterParam08, this.cmbFilterRule08,
                         this.cmbFilterText08);
                    break;
                default:
                    lista2.AddRange(lista);
                    break;
            }
            
            return lista2;
        }

        private int GetIndexColumnFromGrid(DataGridView grid, string name)
        {
            int index = -1;
            string columnName = string.Empty;
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                if (item.Tag.ToString() == name)
                {
                    columnName = item.Name;
                }
            }
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.Name == columnName)
                {
                    index = col.Index;
                }
            }
            return index;
        }

        private List<List<string>> GroupCase1(DataGridView grid, List<List<string>> lista,
            System.Windows.Forms.ComboBox comboGroup, bool ascending, bool blankLine)
        {
            List<List<string>> lista2 = new List<List<string>>();
            // Combo 01
            if (this.cmbGrp01.SelectedIndex > 0)
            {
                string combo01Selected = comboGroup.SelectedItem.ToString();
                string columnName = string.Empty;
                foreach (ListViewItem item in this.lstSelected.Items)
                {
                    if (item.Tag.ToString() == combo01Selected)
                    {
                        columnName = item.Name;
                    }
                }
                int index01 = -1;
                if (columnName != string.Empty)
                {
                    foreach (DataGridViewColumn col in grid.Columns)
                    {
                        if (col.Name == columnName)
                        {
                            index01 = col.Index;
                        }
                    }
                    if (index01 != -1)
                    {
                        if (ascending)
                        {
                            // Ascending
                            lista2 = lista.OrderBy(x => x[index01]).ToList();
                        }
                        else
                        {
                            // Descending
                            lista2 = lista.OrderByDescending(x => x[index01]).ToList();
                        }
                    }
                    // Blank Lines 01
                    if (blankLine)
                    {
                        List<List<string>> lista3 = new List<List<string>>();
                        for (int i = 0; i < lista2.Count; i++)
                        {
                            if (i > 0)
                            {
                                string actualValue = lista2[i][index01];
                                if (actualValue != lista2[i - 1][index01])
                                {
                                    List<string> blank = new List<string>();
                                    for (int j = 0; j < lista2[i].Count; j++)
                                    {
                                        blank.Add(string.Empty);
                                    }
                                    lista3.Add(blank);
                                    lista3.Add(lista2[i]);
                                }
                                else
                                {
                                    lista3.Add(lista2[i]);
                                }
                            }
                            else
                            {
                                lista3.Add(lista2[i]);
                            }
                        }
                        lista2 = new List<List<string>>();
                        lista2 = lista3.ToList();
                    }
                }
            }
            return lista2;
        }

        private List<List<string>> GroupCase2(DataGridView grid, List<List<string>> lista)
        {
            List<List<string>> listaF = new List<List<string>>();
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);
            string combo02Selected = this.cmbGrp02.SelectedItem.ToString();
            int index02 = GetIndexColumnFromGrid(grid, combo02Selected);

            if (index02 != -1)
            {
                if (this.rdb01Ascending.Checked)
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ToList();
                    }
                    else
                    {
                        lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ToList();
                    }
                }
                else
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ToList();
                    }
                    else
                    {
                        lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ToList();
                    }
                }
                listaF = lista;
            }

            // Blank Lines
            if (this.chk01BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index01];
                        if (actualValue != listaF[i - 1][index01])
                        {
                            List<string> blank = new List<string>();
                            for (int j = 0; j < listaF[i].Count; j++)
                            {
                                blank.Add(string.Empty);
                            }
                            lista3.Add(blank);
                            lista3.Add(listaF[i]);
                        }
                        else
                        {
                            lista3.Add(listaF[i]);
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            if (this.chk02BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index02];
                        if (actualValue == string.Empty)
                        {
                            //lista3.Add(listaF[i]);
                        }
                        else
                        {
                            if (actualValue != listaF[i - 1][index02])
                            {
                                List<string> blank = new List<string>();
                                for (int j = 0; j < listaF[i].Count; j++)
                                {
                                    blank.Add(string.Empty);
                                }
                                lista3.Add(blank);
                                lista3.Add(listaF[i]);
                            }
                            else
                            {
                                lista3.Add(listaF[i]);
                            }
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }

            return listaF;
        }

        private List<List<string>> GroupCase3(DataGridView grid, List<List<string>> lista)
        {
            List<List<string>> listaF = new List<List<string>>();
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);
            string combo02Selected = this.cmbGrp02.SelectedItem.ToString();
            int index02 = GetIndexColumnFromGrid(grid, combo02Selected);
            string combo03Selected = this.cmbGrp03.SelectedItem.ToString();
            int index03 = GetIndexColumnFromGrid(grid, combo03Selected);

            if (index03 != -1)
            {
                if (this.rdb01Ascending.Checked)
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 ASC - 2 ASC - 3 ASC
                            lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 ASC - 2 ASC - 3 DESC
                            lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 ASC - 2 DESC - 3 ASC
                            lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 ASC - 2 DESC - 3 DESC
                            lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                }
                else
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 DESC - 2 ASC - 3 ASC
                            lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 DESC - 2 ASC - 3 DESC
                            lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 DESC - 2 DESC - 3 ASC
                            lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 DESC - 2 DESC - 3 DESC
                            lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                }
                listaF = lista;
            }

            // Blank Lines
            if (this.chk01BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index01];
                        if (actualValue != listaF[i - 1][index01])
                        {
                            List<string> blank = new List<string>();
                            for (int j = 0; j < listaF[i].Count; j++)
                            {
                                blank.Add(string.Empty);
                            }
                            lista3.Add(blank);
                            lista3.Add(listaF[i]);
                        }
                        else
                        {
                            lista3.Add(listaF[i]);
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            if (this.chk02BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index02];
                        if (actualValue == string.Empty)
                        {
                            //lista3.Add(listaF[i]);
                        }
                        else
                        {
                            if (actualValue != listaF[i - 1][index02])
                            {
                                List<string> blank = new List<string>();
                                for (int j = 0; j < listaF[i].Count; j++)
                                {
                                    blank.Add(string.Empty);
                                }
                                lista3.Add(blank);
                                lista3.Add(listaF[i]);
                            }
                            else
                            {
                                lista3.Add(listaF[i]);
                            }
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            if (this.chk03BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index03];
                        if (actualValue == string.Empty)
                        {
                            //lista3.Add(listaF[i]);
                        }
                        else
                        {
                            if (actualValue != listaF[i - 1][index02])
                            {
                                List<string> blank = new List<string>();
                                for (int j = 0; j < listaF[i].Count; j++)
                                {
                                    blank.Add(string.Empty);
                                }
                                lista3.Add(blank);
                                lista3.Add(listaF[i]);
                            }
                            else
                            {
                                lista3.Add(listaF[i]);
                            }
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            return listaF;
        }

        private List<List<string>> GroupCase4(DataGridView grid, List<List<string>> lista)
        {
            List<List<string>> listaF = new List<List<string>>();
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);
            string combo02Selected = this.cmbGrp02.SelectedItem.ToString();
            int index02 = GetIndexColumnFromGrid(grid, combo02Selected);
            string combo03Selected = this.cmbGrp03.SelectedItem.ToString();
            int index03 = GetIndexColumnFromGrid(grid, combo03Selected);
            string combo04Selected = this.cmbGrp04.SelectedItem.ToString();
            int index04 = GetIndexColumnFromGrid(grid, combo04Selected);

            if (index04 != -1)
            {
                if (this.rdb01Ascending.Checked)
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 ASC - 3 ASC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x => 
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 ASC - 3 ASC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 ASC - 3 DESC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 ASC - 3 DESC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 DESC - 3 ASC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 DESC - 3 ASC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 DESC - 3 DESC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 DESC - 3 DESC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                }
                else
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 ASC - 3 ASC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 ASC - 3 ASC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 ASC - 3 DESC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 ASC - 3 DESC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 DESC - 3 ASC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 DESC - 3 ASC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 DESC - 3 DESC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => 
                                x[index02]).ThenByDescending(x => x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 DESC - 3 DESC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => 
                                x[index02]).ThenByDescending(x => x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                }
                listaF = lista;
            }

            // Blank Lines
            if (this.chk01BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index01];
                        if (actualValue != listaF[i - 1][index01])
                        {
                            List<string> blank = new List<string>();
                            for (int j = 0; j < listaF[i].Count; j++)
                            {
                                blank.Add(string.Empty);
                            }
                            lista3.Add(blank);
                            lista3.Add(listaF[i]);
                        }
                        else
                        {
                            lista3.Add(listaF[i]);
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            if (this.chk02BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index02];
                        if (actualValue == string.Empty)
                        {
                            //lista3.Add(listaF[i]);
                        }
                        else
                        {
                            if (actualValue != listaF[i - 1][index02])
                            {
                                List<string> blank = new List<string>();
                                for (int j = 0; j < listaF[i].Count; j++)
                                {
                                    blank.Add(string.Empty);
                                }
                                lista3.Add(blank);
                                lista3.Add(listaF[i]);
                            }
                            else
                            {
                                lista3.Add(listaF[i]);
                            }
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            if (this.chk03BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index03];
                        if (actualValue == string.Empty)
                        {
                            //lista3.Add(listaF[i]);
                        }
                        else
                        {
                            if (actualValue != listaF[i - 1][index03])
                            {
                                List<string> blank = new List<string>();
                                for (int j = 0; j < listaF[i].Count; j++)
                                {
                                    blank.Add(string.Empty);
                                }
                                lista3.Add(blank);
                                lista3.Add(listaF[i]);
                            }
                            else
                            {
                                lista3.Add(listaF[i]);
                            }
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            if (this.chk04BlankLine.Checked)
            {
                List<List<string>> lista3 = new List<List<string>>();
                for (int i = 0; i < listaF.Count; i++)
                {
                    if (i > 0)
                    {
                        string actualValue = listaF[i][index04];
                        if (actualValue == string.Empty)
                        {
                            //lista3.Add(listaF[i]);
                        }
                        else
                        {
                            if (actualValue != listaF[i - 1][index04])
                            {
                                List<string> blank = new List<string>();
                                for (int j = 0; j < listaF[i].Count; j++)
                                {
                                    blank.Add(string.Empty);
                                }
                                lista3.Add(blank);
                                lista3.Add(listaF[i]);
                            }
                            else
                            {
                                lista3.Add(listaF[i]);
                            }
                        }
                    }
                    else
                    {
                        lista3.Add(listaF[i]);
                    }
                }
                listaF = lista3.ToList();
            }
            return listaF;
        }

        private List<List<string>> ClassifyGrid(DataGridView grid, List<List<string>> lista)
        {
            List<List<string>> lista2 = new List<List<string>>();
            switch (Tools._groupCases)
            {
                case Tools.GroupCases.Group0:
                    lista2.AddRange(lista);
                    break;
                case Tools.GroupCases.Group1:
                    lista2 = GroupCase1(grid, lista, this.cmbGrp01, this.rdb01Ascending.Checked, 
                        this.chk01BlankLine.Checked);
                    break;
                case Tools.GroupCases.Group2:
                    lista2 = GroupCase2(grid, lista);
                    break;
                case Tools.GroupCases.Group3:
                    lista2 = GroupCase3(grid, lista);
                    break;
                case Tools.GroupCases.Group4:
                    lista2 = GroupCase4(grid, lista);
                    break;
                default:
                    break;
            }
            
            return lista2;
        }

        private List<List<string>> GroupOrder01(DataGridView grid, List<List<string>> lista)
        {
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);
            if (index01 != -1)
            {
                if (this.rdb01Ascending.Checked)
                {
                     lista = lista.OrderBy(x => x[index01]).ToList();
                }
                else
                {
                    lista = lista.OrderByDescending(x => x[index01]).ToList();
                }
            }

            return lista;
        }

        private List<List<string>> GroupOrder02(DataGridView grid, List<List<string>> lista)
        {
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);
            string combo02Selected = this.cmbGrp02.SelectedItem.ToString();
            int index02 = GetIndexColumnFromGrid(grid, combo02Selected);

            if (index02 != -1)
            {
                if (this.rdb01Ascending.Checked)
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        // 1 Asc - 2 Asc
                        lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ToList();
                    }
                    else
                    {
                        // 1 Asc - 2 DESC
                        lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ToList();
                    }
                }
                else
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        // 1 DES - 2 ASC
                        lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ToList();
                    }
                    else
                    {
                        // 1 DESC - 2 DESC
                        lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ToList();
                    }
                }
            }

            return lista;
        }

        private List<List<string>> GroupOrder03(DataGridView grid, List<List<string>> lista)
        {
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);
            string combo02Selected = this.cmbGrp02.SelectedItem.ToString();
            int index02 = GetIndexColumnFromGrid(grid, combo02Selected);
            string combo03Selected = this.cmbGrp03.SelectedItem.ToString();
            int index03 = GetIndexColumnFromGrid(grid, combo03Selected);

            if (index03 != -1)
            {
                if (this.rdb01Ascending.Checked)
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 ASC - 2 ASC - 3 ASC
                            lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 ASC - 2 ASC - 3 DESC
                            lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 ASC - 2 DESC - 3 ASC
                            lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 ASC - 2 DESC - 3 DESC
                            lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                }
                else
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 DESC - 2 ASC - 3 ASC
                            lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 DESC - 2 ASC - 3 DESC
                            lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            // 1 DESC - 2 DESC - 3 ASC
                            lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x => x[index03]).ToList();
                        }
                        else
                        {
                            // 1 DESC - 2 DESC - 3 DESC
                            lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x => x[index03]).ToList();
                        }
                    }
                }
            }

            return lista;
        }

        private List<List<string>> GroupOrder04(DataGridView grid, List<List<string>> lista)
        {
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);
            string combo02Selected = this.cmbGrp02.SelectedItem.ToString();
            int index02 = GetIndexColumnFromGrid(grid, combo02Selected);
            string combo03Selected = this.cmbGrp03.SelectedItem.ToString();
            int index03 = GetIndexColumnFromGrid(grid, combo03Selected);
            string combo04Selected = this.cmbGrp04.SelectedItem.ToString();
            int index04 = GetIndexColumnFromGrid(grid, combo04Selected);

            if (index04 != -1)
            {
                if (this.rdb01Ascending.Checked)
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 ASC - 3 ASC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 ASC - 3 ASC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 ASC - 3 DESC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 ASC - 3 DESC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 DESC - 3 ASC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 DESC - 3 ASC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 ASC - 2 DESC - 3 DESC - 4 ASC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 ASC - 2 DESC - 3 DESC - 4 DESC
                                lista = lista.OrderBy(x => x[index01]).ThenByDescending(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                }
                else
                {
                    if (this.rdb02Ascending.Checked)
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 ASC - 3 ASC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 ASC - 3 ASC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 ASC - 3 DESC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 ASC - 3 DESC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenBy(x => x[index02]).ThenByDescending(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                    else
                    {
                        if (this.rdb03Ascending.Checked)
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 DESC - 3 ASC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 DESC - 3 ASC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x => x[index02]).ThenBy(x =>
                                x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                        else
                        {
                            if (this.rdb04Ascending.Checked)
                            {
                                // 1 DESC - 2 DESC - 3 DESC - 4 ASC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x =>
                                x[index02]).ThenByDescending(x => x[index03]).ThenBy(x => x[index04]).ToList();
                            }
                            else
                            {
                                // 1 DESC - 2 DESC - 3 DESC - 4 DESC
                                lista = lista.OrderByDescending(x => x[index01]).ThenByDescending(x =>
                                x[index02]).ThenByDescending(x => x[index03]).ThenByDescending(x => x[index04]).ToList();
                            }
                        }
                    }
                }
            }

            return lista;
        }

        private List<List<string>> OrderRows(DataGridView grid, List<List<string>> lista)
        {
            List<List<string>> listaF = new List<List<string>>();
            switch (Tools._groupCases)
            {
                case Tools.GroupCases.Group0:
                    listaF = lista;
                    break;
                case Tools.GroupCases.Group1:
                    listaF = GroupOrder01(grid, lista);
                    break;
                case Tools.GroupCases.Group2:
                    listaF = GroupOrder02(grid, lista);
                    break;
                case Tools.GroupCases.Group3:
                    listaF = GroupOrder03(grid, lista);
                    break;
                case Tools.GroupCases.Group4:
                    listaF = GroupOrder04(grid, lista);
                    break;
                default:
                    listaF = lista;
                    break;
            }

            return listaF;
        }

        private List<UbRow> GroupRows01(DataGridView grid, List<List<string>> lista)
        {
            List<UbRow> listaF = new List<UbRow>();
            string combo01Selected = this.cmbGrp01.SelectedItem.ToString();
            int index01 = GetIndexColumnFromGrid(grid, combo01Selected);

            if (index01 != -1)
            {
                int count01 = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    count01++;
                    if (i == 0) //First row
                    {
                        //Header
                        if (this.chkGrp01Header.Checked)
                        {
                            List<string> header = new List<string>();
                            for (int j = 0; j < lista[i].Count; j++)
                            {
                                if (j == 0)
                                {
                                    header.Add(lista[i][index01].ToUpper() + ":");
                                }
                                else
                                {
                                    header.Add(string.Empty);
                                }
                            }
                            UbRow rowHeader = new UbRow(header, UbRow.RowType.Header);
                            UbRow row = new UbRow(lista[i], UbRow.RowType.Row);
                            listaF.Add(rowHeader);
                            listaF.Add(row);
                        }
                        else
                        {
                            UbRow row = new UbRow(lista[i], UbRow.RowType.Row);
                            listaF.Add(row);
                        }
                    }
                    else
                    {
                        string actualValue = lista[i][index01];
                        string previousValue = lista[i - 1][index01];
                        if (actualValue == previousValue)
                        {
                            UbRow row = new UbRow(lista[i], UbRow.RowType.Row);
                            listaF.Add(row);
                        }
                        else
                        {
                            //Value Changed
                            // Footer
                            if (this.chkGrp01Footer.Checked)
                            {
                                List<string> footer = new List<string>();
                                for (int j = 0; j < lista[i].Count; j++)
                                {
                                    if (j == 0)
                                    {
                                        footer.Add(previousValue.ToUpper() + ": " + (count01 - 1).ToString());
                                    }
                                    else
                                    {
                                        footer.Add(string.Empty);
                                    }
                                }
                                UbRow rowFooter = new UbRow(footer, UbRow.RowType.Footer);
                                listaF.Add(rowFooter);
                                count01 = 1;
                            }
                            // Blank Line
                            if (this.chk01BlankLine.Checked)
                            {
                                List<string> blank = new List<string>();
                                for (int j = 0; j < lista[i].Count; j++)
                                {
                                    blank.Add(string.Empty);
                                }
                                UbRow rowBlank = new UbRow(blank, UbRow.RowType.Blank);
                                listaF.Add(rowBlank);
                            }

                            //Header
                            if (this.chkGrp01Header.Checked)
                            {
                                List<string> header = new List<string>();
                                for (int j = 0; j < lista[i].Count; j++)
                                {
                                    if (j == 0)
                                    {
                                        header.Add(lista[i][index01].ToUpper() + ":");
                                    }
                                    else
                                    {
                                        header.Add(string.Empty);
                                    }
                                }
                                UbRow rowHeader = new UbRow(header, UbRow.RowType.Header);
                                listaF.Add(rowHeader);
                            }
                            UbRow row = new UbRow(lista[i], UbRow.RowType.Row);
                            listaF.Add(row);
                            
                        }
                        
                    }
                    if (i == lista.Count - 1) // Last Line
                    {
                        // Footer
                        if (this.chkGrp01Footer.Checked)
                        {
                            List<string> footer = new List<string>();
                            for (int j = 0; j < lista[i].Count; j++)
                            {
                                if (j == 0)
                                {
                                    string actualValue = lista[i][index01];
                                    footer.Add(actualValue.ToUpper() + ": " + (count01).ToString());
                                }
                                else
                                {
                                    footer.Add(string.Empty);
                                }
                            }
                            UbRow rowFooter = new UbRow(footer, UbRow.RowType.Footer);
                            listaF.Add(rowFooter);
                            count01 = 0;
                        }
                    }
                }
            }
            else
            {
                listaF = UbRow.ConvertList(lista);
            }

            return listaF;
        }

        private List<UbRow> GroupRows02(DataGridView grid, List<List<string>> lista)
        {
            List<UbRow> listaF = new List<UbRow>();
            string combo02Selected = this.cmbGrp02.SelectedItem.ToString();
            int index02 = GetIndexColumnFromGrid(grid, combo02Selected);

            if (index02 != -1)
            {
                List<UbRow> listaF1 = GroupRows01(grid, lista);

                int count02 = 0;
                for (int i = 0; i < listaF1.Count; i++)
                {
                    count02++;
                    if (i == 0) //First row
                    {
                        if (listaF1[i].rowType == UbRow.RowType.Row)
                        {
                            //Header
                            if (this.chkGrp02Header.Checked)
                            {
                                List<string> header = new List<string>();
                                for (int j = 0; j < listaF1[i].values.Count; j++)
                                {
                                    if (j == 0)
                                    {
                                        header.Add(listaF1[i].values[index02].ToUpper() + ":");
                                    }
                                    else
                                    {
                                        header.Add(string.Empty);
                                    }
                                }
                                UbRow rowHeader = new UbRow(header, UbRow.RowType.Header);
                                listaF.Add(rowHeader);
                            }
                            listaF.Add(listaF1[i]);
                        }
                        if (listaF1[i].rowType == UbRow.RowType.Header)
                        {
                            UbRow row = new UbRow(listaF1[i].values, UbRow.RowType.Header);
                            listaF.Add(row);
                            count02 = 0;
                        }
                    }
                    else
                    {
                        if (i == listaF1.Count - 1) // Last Line
                        {
                            if (listaF1[i].rowType == UbRow.RowType.Row)
                            {
                                listaF.Add(listaF1[i]);
                                // Footer
                                if (this.chkGrp02Footer.Checked)
                                {
                                    List<string> footer = new List<string>();
                                    for (int j = 0; j < listaF1[i].values.Count; j++)
                                    {
                                        if (j == 0)
                                        {
                                            string actualValue = listaF1[i].values[index02];
                                            footer.Add(actualValue.ToUpper() + ": " + (count02).ToString());
                                        }
                                        else
                                        {
                                            footer.Add(string.Empty);
                                        }
                                    }
                                    UbRow rowFooter = new UbRow(footer, UbRow.RowType.Footer);
                                    listaF.Add(rowFooter);
                                    count02 = 0;
                                }
                            }
                            if (listaF1[i].rowType == UbRow.RowType.Footer)
                            {
                                // Footer
                                if (this.chkGrp02Footer.Checked)
                                {
                                    List<string> footer = new List<string>();
                                    for (int j = 0; j < listaF1[i].values.Count; j++)
                                    {
                                        if (j == 0)
                                        {
                                            string previousValue = listaF1[i - 1].values[index02];
                                            footer.Add(previousValue.ToUpper() + ": " + (count02 - 1).ToString());
                                        }
                                        else
                                        {
                                            footer.Add(string.Empty);
                                        }
                                    }
                                    UbRow rowFooter = new UbRow(footer, UbRow.RowType.Footer);
                                    listaF.Add(rowFooter);
                                    listaF.Add(listaF1[i]);
                                    count02 = 0;
                                }
                                else
                                {
                                    listaF.Add(listaF1[i]);
                                }
                            }
                        }
                        else
                        {
                            if (listaF1[i].rowType == UbRow.RowType.Header)
                            {
                                UbRow row = new UbRow(listaF1[i].values, UbRow.RowType.Header);
                                listaF.Add(row);
                                count02 = 0;
                            }
                            if (listaF1[i].rowType == UbRow.RowType.Row)
                            {
                                string actualValue = listaF1[i].values[index02];
                                UbRow previousRow = listaF1[i - 1];
                                if (previousRow.rowType == UbRow.RowType.Row)
                                {
                                    string previousValue = listaF1[i - 1].values[index02];
                                    if (actualValue == previousValue)
                                    {
                                        //
                                    }
                                    else
                                    {
                                        //Value Changed
                                        // Footer
                                        if (this.chkGrp02Footer.Checked)
                                        {
                                            List<string> footer = new List<string>();
                                            for (int j = 0; j < listaF1[i].values.Count; j++)
                                            {
                                                if (j == 0)
                                                {
                                                    footer.Add(previousValue.ToUpper() + ": " + (count02 - 1).ToString());
                                                }
                                                else
                                                {
                                                    footer.Add(string.Empty);
                                                }
                                            }
                                            UbRow rowFooter = new UbRow(footer, UbRow.RowType.Footer);
                                            listaF.Add(rowFooter);
                                            count02 = 1;
                                        }
                                        // Blank Line
                                        if (this.chk02BlankLine.Checked)
                                        {
                                            List<string> blank = new List<string>();
                                            for (int j = 0; j < listaF1[i].values.Count; j++)
                                            {
                                                blank.Add(string.Empty);
                                            }
                                            UbRow rowBlank = new UbRow(blank, UbRow.RowType.Blank);
                                            listaF.Add(rowBlank);
                                        }

                                        //Header
                                        if (this.chkGrp02Header.Checked)
                                        {
                                            List<string> header = new List<string>();
                                            for (int j = 0; j < listaF1[i].values.Count; j++)
                                            {
                                                if (j == 0)
                                                {
                                                    header.Add(listaF1[i].values[index02].ToUpper() + ":");
                                                }
                                                else
                                                {
                                                    header.Add(string.Empty);
                                                }
                                            }
                                            UbRow rowHeader = new UbRow(header, UbRow.RowType.Header);
                                            listaF.Add(rowHeader);
                                        }

                                    }

                                }
                                if (previousRow.rowType == UbRow.RowType.Header)
                                {
                                    //Header
                                    if (this.chkGrp02Header.Checked)
                                    {
                                        List<string> header = new List<string>();
                                        for (int j = 0; j < listaF1[i].values.Count; j++)
                                        {
                                            if (j == 0)
                                            {
                                                header.Add(listaF1[i].values[index02].ToUpper() + ":");
                                            }
                                            else
                                            {
                                                header.Add(string.Empty);
                                            }
                                        }
                                        UbRow rowHeader = new UbRow(header, UbRow.RowType.Header);
                                        listaF.Add(rowHeader);
                                    }
                                }
                                listaF.Add(listaF1[i]);
                            }
                            if (listaF1[i].rowType == UbRow.RowType.Blank)
                            {
                                UbRow row = new UbRow(listaF1[i].values, UbRow.RowType.Blank);
                                listaF.Add(row);
                            }
                            if (listaF1[i].rowType == UbRow.RowType.Footer)
                            {
                                // Footer
                                if (this.chkGrp02Footer.Checked)
                                {
                                    UbRow previousRow = listaF1[i - 1];
                                    if (previousRow.rowType == UbRow.RowType.Row)
                                    {
                                        string previousValue = listaF1[i - 1].values[index02];
                                        List<string> footer = new List<string>();
                                        for (int j = 0; j < listaF1[i].values.Count; j++)
                                        {
                                            if (j == 0)
                                            {
                                                footer.Add(previousValue.ToUpper() + ": " + (count02 - 1).ToString());
                                            }
                                            else
                                            {
                                                footer.Add(string.Empty);
                                            }
                                        }
                                        UbRow rowFooter = new UbRow(footer, UbRow.RowType.Footer);
                                        listaF.Add(rowFooter);
                                        count02 = 0;
                                    }
                                }
                                UbRow row = new UbRow(listaF1[i].values, UbRow.RowType.Footer);
                                listaF.Add(row);
                            }
                        }
                        
                    }
                    
                }
            }
            else
            {
                listaF = UbRow.ConvertList(lista);
            }

            return listaF;
        }

        private List<UbRow> ClassifyGridRows(DataGridView grid, List<List<string>> lista)
        {
            List<UbRow> listaF = new List<UbRow>();
            switch (Tools._groupCases)
            {
                case Tools.GroupCases.Group0:
                    listaF = UbRow.ConvertList(lista);
                    break;
                case Tools.GroupCases.Group1:
                    listaF = GroupRows01(grid, lista);
                    break;
                case Tools.GroupCases.Group2:
                    listaF = GroupRows02(grid, lista);
                    break;
                case Tools.GroupCases.Group3:
                    listaF = GroupRows02(grid, lista);
                    break;
                case Tools.GroupCases.Group4:
                    listaF = GroupRows02(grid, lista);
                    break;
                default:
                    listaF = UbRow.ConvertList(lista);
                    break;
            }

            return listaF;
        }

        private void FillDataGridPreview()
        {
            this.dgvPreview.DataSource = null;
            this.dgvPreview.Columns.Clear();
            this.dgvPreview.Rows.Clear();
            this.dgvPreview.Refresh();
            // Get Selected Parameters
            Tools._params = Tools.CollectParameters(Tools._selectedElements);
            Tools._props = Tools.CollectProperties(Tools._selectedElements);
            List<UbParam> _all = new List<UbParam>();
            this.lstSelected.Refresh();

            foreach (ListViewItem item in this.lstSelected.Items)
            {
                // Parameter
                if (item.Group == this.lstSelected.Groups[0])
                {
                    int id = Convert.ToInt32(item.Name);
                    UbParam pa = Tools._params.First(x => x.id == id);
                    Tools._selectedParams.Add(pa);
                }
                // Property
                if (item.Group == this.lstSelected.Groups[1])
                {
                    string name = item.Name;
                    UbProperty prop = Tools._props.First(x => x.name == name);
                    Tools._selectedProperties.Add(prop);
                }
            }
            // Create Columns
            foreach (ListViewItem item in this.lstSelected.Items)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cel = new DataGridViewTextBoxCell();
                col.Name = item.Name;
                col.Tag = item.Tag;
                col.HeaderText = item.Tag.ToString();
                col.CellTemplate = cel;
                this.dgvPreview.Columns.Add(col);
            }
            List<List<string>> rows = CreatePreviewRows();
            // Filter Rows
            DataGridView grid = this.dgvPreview;
            rows = FilterGrid(grid, rows);
            // Order Rows
            rows = OrderRows(grid, rows);
            // Group Rows
            List<UbRow> groupRows = new List<UbRow>();
            groupRows = ClassifyGridRows(grid, rows);
            //rows = ClassifyGrid(grid, rows);

            // Add Rows
            for (int i = 0; i < groupRows.Count; i++)
            {
                if (groupRows[i].values.Count > 0)
                {
                    int count = groupRows[i].values.Count();
                    string[] vals = new string[count];
                    for (int j = 0; j < count; j++)
                    {
                        vals[j] = groupRows[i].values[j];
                    }
                    // Style
                    DataGridViewCellStyle cellStyleBold = new DataGridViewCellStyle();
                    cellStyleBold.Font = new Font(FontFamily.GenericSansSerif.Name, 9, FontStyle.Bold);
                    DataGridViewCellStyle cellStyleBoldGray = new DataGridViewCellStyle();
                    cellStyleBoldGray.Font = new Font(FontFamily.GenericSansSerif.Name, 9, FontStyle.Bold);
                    cellStyleBoldGray.BackColor = System.Drawing.Color.LightGray;

                    if (groupRows[i].rowType == UbRow.RowType.Row)
                    {
                        this.dgvPreview.Rows.Add(vals);
                    }
                    if (groupRows[i].rowType == UbRow.RowType.Header)
                    {
                        this.dgvPreview.Rows.Add(vals);
                        this.dgvPreview.Rows[i].DefaultCellStyle = cellStyleBoldGray;
                    }
                    if (groupRows[i].rowType == UbRow.RowType.Footer)
                    {
                        this.dgvPreview.Rows.Add(vals);
                        this.dgvPreview.Rows[i].DefaultCellStyle = cellStyleBoldGray;
                    }
                    if (groupRows[i].rowType == UbRow.RowType.Blank)
                    {
                        this.dgvPreview.Rows.Add(vals);
                        this.dgvPreview.Rows[i].DefaultCellStyle = cellStyleBoldGray;
                    }
                }
            }
            //foreach (UbRow row in groupRows)
            //{
            //    if (row.values.Count > 0)
            //    {
            //        int count = row.values.Count();
            //        string[] vals = new string[count];
            //        for (int i = 0; i < count; i++)
            //        {
            //            vals[i] = row.values[i];
            //        }
            //        this.dgvPreview.Rows.Add(vals);
            //    }
            //}
            this.dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.dgvPreview.AutoResizeColumns();
            this.dgvPreview.AllowUserToResizeColumns = true;
            this.dgvPreview.AllowUserToOrderColumns = true;
            Tools._update = false;
        }

        #endregion

        #region Menu
        private void mnuExportExcel_Click_1(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportToExcel()
        {
            string folderPath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Document|*.xlsx";
            string title = this.txtReportName.Text;
            sfd.FileName = title + ".xlsx";
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderPath = sfd.FileName;
                try
                {
                    Tools.ExportGridToExcel(title, folderPath, this.dgvPreview);
                    DialogResult result2 = MessageBox.Show("The document has been created successfully." +
                         "Do you want to open it?",
                        Main.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result2)
                    {
                        case DialogResult.Yes:
                            System.Diagnostics.Process.Start(folderPath);
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Cannot create document. Verify that the document is not open");
                    sb.AppendLine(ex.Message);
                    MessageBox.Show(sb.ToString(), Main.Name,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void contextShowElements_Click(object sender, EventArgs e)
        {
            TreeNode selNode = this.trvElements.SelectedNode;
            if (selNode != null && selNode.Level == 1)
            {
                List<TreeItem> categories = TreeItemCategoriesFromElements(Tools._elements);
                TreeItem item = categories.First(x => x.name == selNode.Name);
                
                StringBuilder sb = new StringBuilder();
                //sb.AppendLine(item.text.ToUpper());
                foreach (Element elem in item.elements)
                {
                    sb.AppendLine(elem.Name + " <" + elem.Id.IntegerValue.ToString() + ">");
                }
                sb.AppendLine("");
                sb.AppendLine("List of IDs");
                string ids = string.Empty;
                foreach (Element elem in item.elements)
                {
                    ids += elem.Id.IntegerValue.ToString() + ",";
                }
                sb.AppendLine(ids);
                frmWarning war = new frmWarning("SmartReport",item.text.ToUpper() + ": List of Elements", sb.ToString());
                war.ShowDialog();
            }
        }

        private void mnuSaveReport_Click(object sender, EventArgs e)
        {
            SmrtReport report = CreateActualReport();
            Tools.SaveReport(this.txtReportName.Text, report);
        }

        private void mnuOpenReport_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            System.Windows.Forms.OpenFileDialog open = new System.Windows.Forms.OpenFileDialog();
            open.Filter = "Smart Report|*.srp";
            System.Windows.Forms.DialogResult result = open.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                path = open.FileName;
                try
                {
                    SmrtReport report = SmrtReport.FromStringFile(path);
                    UpdateReportFromFile(report);
                    System.Windows.Forms.MessageBox.Show("Report opened successfully", Main.Name,
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + ex.ToString(), Main.Name,
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }

        private void mnuChangeLog_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(App.AppDirectory, "ChangeLog.txt");
            System.Diagnostics.Process.Start(path);
        }

        private void lblUniversoBim_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.universobim.com");
        }

        #endregion
        
    }
}
