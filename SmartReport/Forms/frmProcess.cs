using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.DB;

namespace SmartReport
{
    public partial class frmProcess : System.Windows.Forms.Form
    {
        public Tools.processes _processes;

        public frmProcess(Tools.processes processes, string title)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            _processes = processes;
            this.prgBar.Value = 0;
    }

        #region Work
        private void frmProcessTreeReport_Load(object sender, EventArgs e)
        {
            this.work1.RunWorkerAsync();
        }

        private void work1_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (_processes)
            {
                case Tools.processes.ActualizarTreeReport:
                    this.work1.ReportProgress(0, "Processing...");
                    ActualizarTreeReport();
                    break;
                case Tools.processes.FillAvailableListView:
                    this.work1.ReportProgress(0, "Obtaining Parameters, please Wait...");
                    FillAvailableListView();
                    break;
                case Tools.processes.FillDataGridPreview:
                    break;
                case Tools.processes.FillGroupCombos:
                    break;
                case Tools.processes.FillComboFilters:
                    break;
                default:
                    break;
            }
        }

        private void work1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.prgBar.Value += 1;
            //this.lblValue.Text = this.prgBar.Value.ToString();
            this.prgBar.Value = e.ProgressPercentage;
            this.lblValue.Text = e.ProgressPercentage.ToString() + " %";
            this.lblStatus.Text = e.UserState.ToString();
        }

        private void work1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        #region Process
        public void FillTreeViewReport()
        {
            //LEVEL 0 Title
            TreeNode node0 = new TreeNode();
            node0.Name = "Elements";
            node0.Text = "Elements " + "(" + Tools._elements.Count.ToString() + ")";
            node0.ImageIndex = 0;
            node0.SelectedImageIndex = 0;
            node0.Checked = false;
            node0.Expand();

            //Categories list
            List<TreeItem> categories = Tools.TreeItemCategoriesFromElements(Tools._elements);

            //LEVEL 1 Categories
            categories = categories.OrderBy(x => x.text).ToList();
            int actual = 0;
            work1.ReportProgress(100, "Creating Nodes");
            foreach (TreeItem item in categories)
            {
                actual++;
                //this.lblStatus.Text = item.text;
                TreeNode node1 = new TreeNode();
                node1.Name = item.name;
                node1.Text = item.text + " (" + item.elements.Count + ")";
                node1.ImageIndex = 1;
                node1.SelectedImageIndex = 1;
                node1.Checked = false;
                node0.Nodes.Add(node1);
                //work1.ReportProgress(0);
                //work1.ReportProgress(100 * actual / categories.Count, "Creating Nodes");
            }

            Tools._treeReport.Nodes.Clear();
            Tools._treeReport.Nodes.Add(node0);
        }

        public void ActualizarTreeReport()
        {
            Tools._elements = new List<Element>();
            if (Tools._chkIncludeInstances)
            {
                Tools._elements.AddRange(Tools.CollectInstances());
            }
            if (Tools._chkAnnotationInstances)
            {
                Tools._elements.AddRange(Tools.CollectAnnotationInstances());
            }
            if (Tools._chkFamilies)
            {
                Tools._elements.AddRange(Tools.CollectFamilies());
            }
            if (Tools._chkMaterials)
            {
                Tools._elements.AddRange(Tools.CollectMaterials());
            }
            if (Tools._chkFamilyTypes)
            {
                Tools._elements.AddRange(Tools.CollectFamilyTypes());
            }
            if (Tools._chkSpecialInstancies)
            {
                Tools._elements.AddRange(Tools.CollectSpecialInstances(this.work1));
            }
            FillTreeViewReport();
            //FillAvailableListView();
            //FillDataGridPreview();
            //FillGroupCombos();
            //FillComboFilters();
            Tools._update = false;
        }

        private void CollectSelectedElements()
        {
            Tools._selectedElements = new List<Element>();
            List<string> selectedCat = new List<string>();
            foreach (TreeNode node in Tools._treeReport.Nodes[0].Nodes)
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

        private void FillAvailableListView()
        {
            //Collect Selected Elements
            CollectSelectedElements();
            //Collect Params
            Tools._lstAvailable.Items.Clear();
            Tools._lstProperties.Items.Clear();

            List<UbParam> _params = Tools.CollectParameters(Tools._selectedElements);
            int actual = 0;
            foreach (UbParam p in _params)
            {
                actual++;
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
                        itm.Group = Tools._lstAvailable.Groups[1];
                    }
                    else
                    {
                        // Is Instance Param
                        itm.Group = Tools._lstAvailable.Groups[0];
                    }
                    Tools._lstAvailable.Items.Add(itm);
                }
                work1.ReportProgress(100 * actual / _params.Count, "Get Parameters");
            }
            //this.grpAvailable.Text = "Available Parameters (" + _params.Count.ToString() + ")";
            // Check selected params
            if (Tools._lstSelected.Groups[0].Items.Count > 0)
            {
                List<ListViewItem> removeItems = new List<ListViewItem>();
                foreach (ListViewItem item in Tools._lstSelected.Groups[0].Items)
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
                        ListViewItem item2 = Tools._lstSelected.Groups[0].Items.Find(item.Name, false)[0];
                        Tools._lstSelected.Items.Remove(item2);
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

                Tools._lstProperties.Items.Add(itm);
            }
            //this.grpProperties.Text = "Available Properties (" + _props.Count.ToString() + ")";
            // Check selected Properties
            if (Tools._lstSelected.Groups[1].Items.Count > 0)
            {
                List<ListViewItem> removeItems = new List<ListViewItem>();
                foreach (ListViewItem item in Tools._lstSelected.Groups[1].Items)
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
                        ListViewItem item2 = Tools._lstSelected.Groups[1].Items.Find(item.Name, false)[0];
                        Tools._lstSelected.Items.Remove(item2);
                    }
                }
            }
            Tools._update = false;
        }
        #endregion
    }
}
