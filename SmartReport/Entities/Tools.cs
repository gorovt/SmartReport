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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ClosedXML.Excel;
using System.Data;

namespace SmartReport
{
    /// <summary> This class represents a collection of Project utilities </summary>
    public abstract class Tools
    {
        #region Collectors
        public static List<Element> CollectSpecialInstances()
        {
            FilteredElementCollector collector = new FilteredElementCollector(Main._doc);
            List<Element> elements = collector.WhereElementIsNotElementType().ToList();

            List<Element> lstInstance = (from elem in elements
                                         where elem.Category != null
                                         select elem).ToList();
            List<Element> filtered = new List<Element>();

            List<Element> modelInstances = CollectInstances();
            foreach (Element elem in modelInstances)
            {
                Element el = lstInstance.First(x => x.Id.IntegerValue == elem.Id.IntegerValue);
                lstInstance.Remove(el);
            }
            List<Element> annoInstances = CollectAnnotationInstances();
            foreach (Element elem in annoInstances)
            {
                Element el = lstInstance.First(x => x.Id.IntegerValue == elem.Id.IntegerValue);
                lstInstance.Remove(el);
            }
            List<Element> materiales = CollectMaterials();
            foreach (Element elem in materiales)
            {
                Element el = lstInstance.First(x => x.Id.IntegerValue == elem.Id.IntegerValue);
                lstInstance.Remove(el);
            }
            //return filtered;
            return lstInstance;
        }

        public static List<Element> CollectInstances()
        {
            FilteredElementCollector collector = new FilteredElementCollector(Main._doc);
            List<Element> elements = collector.WhereElementIsNotElementType().ToList();

            List<Element> lstInstance = (from elem in elements
                                         where elem.Category != null
                                         && elem.CreatedPhaseId.IntegerValue != -1
                                         select elem).ToList();

            return lstInstance;
        }

        public static List<Element> CollectAnnotationInstances()
        {
            FilteredElementCollector collector = new FilteredElementCollector(Main._doc);
            List<Element> elements = collector.WhereElementIsNotElementType().ToList();

            List<Element> lstInstance = (from elem in elements
                                         where elem.Category != null
                                         && elem.Category.CategoryType == CategoryType.Annotation
                                         select elem).ToList();
            return lstInstance;
        }

        public static List<Element> CollectFamilies()
        {
            FilteredElementCollector collector = new FilteredElementCollector(Main._doc);
            List<Element> elements = collector.OfClass(typeof(Family)).ToList();

            return elements;
        }

        public static List<Element> CollectMaterials()
        {
            FilteredElementCollector collector = new FilteredElementCollector(Main._doc);
            List<Element> elements = collector.OfClass(typeof(Material)).ToList();

            return elements;
        }

        public static List<Element> CollectFamilyTypes()
        {
            FilteredElementCollector collector = new FilteredElementCollector(Main._doc);
            List<Element> elements = collector.WhereElementIsElementType().ToList();

            List<Element> lstInstance = (from elem in elements
                                         where elem.Category != null
                                         //&& elem.Category.CategoryType == CategoryType.Model
                                         //&& elem.CreatedPhaseId.IntegerValue != -1
                                         //&& elem.Category.Id != (new ElementId(BuiltInCategory.OST_Cameras))
                                         select elem).ToList();

            return lstInstance;
        }

        public static List<Element> CollectFamilySymbols()
        {
            FilteredElementCollector collector = new FilteredElementCollector(Main._doc);
            List<Element> elements = collector.OfClass(typeof(FamilySymbol)).ToList();

            return elements;
        }

        public static List<UbParam> CollectParameters(List<Element> elements)
        {
            List<UbParam> _params = new List<UbParam>();
            foreach (Element elem in elements)
            {
                // Instance Parameters
                foreach (Parameter param in elem.Parameters)
                {
                    if (!_params.Exists(x => x.id == param.Id.IntegerValue))
                    {
                        UbParam _param = new UbParam();
                        _param.id = param.Id.IntegerValue;
                        if (param.Definition == null)
                        {
                            _param.name = "-";
                        }
                        else
                        {
                            _param.name = param.Definition.Name;
                        }
                        _param.paramType = UbParam.ParamType.Parameter;
                        _param.parameter = param;

                        _params.Add(_param);
                    }
                }
                // Type Parameters
                try
                {
                    Element elemType = Main._doc.GetElement(elem.GetTypeId());
                    if (elemType != null)
                    {
                        foreach (Parameter param2 in elemType.Parameters)
                        {
                            if (!_params.Exists(x => x.id == param2.Id.IntegerValue))
                            {
                                UbParam _param = new UbParam();
                                _param.id = param2.Id.IntegerValue;
                                _param.name = param2.Definition.Name;
                                _param.paramType = UbParam.ParamType.Parameter;
                                _param.parameter = param2;
                                _params.Add(_param);
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
                // Family Parameters
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
                        foreach (Parameter param in famType.Parameters)
                        {
                            if (!_params.Exists(x => x.id == param.Id.IntegerValue))
                            {
                                UbParam _param = new UbParam();
                                _param.id = param.Id.IntegerValue;
                                _param.name = param.Definition.Name;
                                _param.paramType = UbParam.ParamType.Parameter;
                                _param.parameter = param;

                                _params.Add(_param);
                            }
                        }
                    }
                }
                // Properties
                foreach  (UbProperty prop in Tools.GetPropertiesFromElement(elem))
                {
                    if (!_params.Exists(x => x.name == prop.name))
                    {
                        UbParam _param = new UbParam();
                        _param.id = -0;
                        _param.name = prop.name;
                        _param.paramType = UbParam.ParamType.Property;

                        _params.Add(_param);
                    }
                }
            }
            _params = _params.OrderBy(x => x.name).ToList();
            return _params;
        }

        public static List<UbProperty> CollectProperties(List<Element> elements)
        {
            List<UbProperty> _props = new List<UbProperty>();
            foreach (Element elem in elements)
            {
                foreach (UbProperty prop in Tools.GetPropertiesFromElement(elem))
                {
                    if (!_props.Exists(x => x.name == prop.name))
                    {
                        _props.Add(prop);
                    }
                }
            }
            _props = _props.OrderBy(x => x.name).ToList();
            return _props;
        }

        public static List<UbProperty> GetPropertiesFromElement(Element elem)
        {
            List<UbProperty> props = new List<UbProperty>();

            // AssemblyInstanceId
            UbProperty _AssemblyInstanceId = new UbProperty("AssemblyInstanceId", elem.AssemblyInstanceId.ToString(), UbProperty.ParamType.ElementId);
            props.Add(_AssemblyInstanceId);

            // CanBeLocked
            UbProperty _CanBeLocked = new UbProperty("CanBeLocked", elem.CanBeLocked().ToString(), UbProperty.ParamType.Integer);
            props.Add(_CanBeLocked);

            // CanHaveTypeAssigned
            UbProperty _CanHaveTypeAssigned = new UbProperty("CanHaveTypeAssigned", elem.CanHaveTypeAssigned().ToString(), UbProperty.ParamType.Integer);
            props.Add(_CanHaveTypeAssigned);

            // Id
            UbProperty _id = new UbProperty("Id", elem.Id.IntegerValue.ToString(), UbProperty.ParamType.ElementId);
            props.Add(_id);

            // IsExternalFileReference
            UbProperty _IsExternalFileReference = new UbProperty("IsExternalFileReference",
                elem.IsExternalFileReference().ToString(), UbProperty.ParamType.Integer);
            props.Add(_IsExternalFileReference);

            // IsInPlace
            if (elem as Family != null)
            {
                Family fam = elem as Family;
                UbProperty _IsInPlace = new UbProperty("IsInPlace", fam.IsInPlace.ToString(), UbProperty.ParamType.Integer);
                props.Add(_IsInPlace);
            }
            else
            {
                UbProperty _IsInPlace = new UbProperty("IsInPlace", string.Empty, UbProperty.ParamType.Integer);
                props.Add(_IsInPlace);
            }

            // IsLinked
            if (elem as ImportInstance != null)
            {
                ImportInstance import = elem as ImportInstance;
                UbProperty _IsLinked = new UbProperty("IsLinked", import.IsLinked.ToString(), UbProperty.ParamType.String);
                props.Add(_IsLinked);
            }
            else
            {
                UbProperty _IsLinked = new UbProperty("IsLinked", string.Empty, UbProperty.ParamType.String);
                props.Add(_IsLinked);
            }

            // Views
            if (elem as Autodesk.Revit.DB.View != null)
            {
                Autodesk.Revit.DB.View view = elem as Autodesk.Revit.DB.View;
                // IsTemplate
                UbProperty _IsTemplate = new UbProperty("IsTemplate", view.IsTemplate.ToString(), UbProperty.ParamType.String);
                props.Add(_IsTemplate);
                // IsAssemblyView
                UbProperty _IsAssemblyView = new UbProperty("IsAssemblyView", view.IsAssemblyView.ToString(), UbProperty.ParamType.String);
                props.Add(_IsAssemblyView);
            }
            else
            {
                // IsTemplate
                UbProperty _IsTemplate = new UbProperty("IsTemplate", string.Empty, UbProperty.ParamType.String);
                props.Add(_IsTemplate);
                // IsAssemblyView
                UbProperty _IsAssemblyView = new UbProperty("IsAssemblyView", string.Empty, UbProperty.ParamType.String);
                props.Add(_IsAssemblyView);
            }
            //// LevelId
            //UbProperty _LevelId = new UbProperty("LevelId", elem.LevelId.ToString(), UbProperty.ParamType.ElementId);
            //props.Add(_LevelId);

            // Location
            Location loc = elem.Location;
            UbProperty _location = new UbProperty("Location", string.Empty, UbProperty.ParamType.None);
            if (loc != null)
            {
                if (loc as LocationPoint != null)
                {
                    LocationPoint locPoint = loc as LocationPoint;
                    _location.value = locPoint.Point.ToString();
                    _location.paramType = UbProperty.ParamType.String;
                }
            }
            props.Add(_location);

            // Name
            UbProperty _name = new UbProperty("Name", elem.Name, UbProperty.ParamType.String);
            props.Add(_name);

            //OwnerViewId
            if (elem.OwnerViewId == null)
            {
                string owner = elem.OwnerViewId.IntegerValue.ToString();
                UbProperty _OwnerViewId = new UbProperty("OwnerViewId", owner, UbProperty.ParamType.ElementId);
                props.Add(_OwnerViewId);
            }
            else
            {
                if (elem.OwnerViewId.IntegerValue == -1)
                {
                    UbProperty _OwnerViewId2 = new UbProperty("OwnerViewId", elem.OwnerViewId.IntegerValue.ToString(), 
                        UbProperty.ParamType.ElementId);
                    props.Add(_OwnerViewId2);
                }
                else
                {
                    ElementId ownerId = elem.OwnerViewId;
                    Element owner = Main._doc.GetElement(ownerId);
                    string ownerResult = ownerId.IntegerValue.ToString() + " (" + owner.Name + ")";
                    UbProperty _OwnerViewId = new UbProperty("OwnerViewId", ownerResult, UbProperty.ParamType.String);
                    props.Add(_OwnerViewId);
                }
            }
            

            // Pinned
            UbProperty _Pinned = new UbProperty("Pinned", elem.Pinned.ToString(), UbProperty.ParamType.String);
            props.Add(_Pinned);

            // TestNote Text
            if (elem as TextNote != null)
            {
                TextNote text = elem as TextNote;
                UbProperty _Text = new UbProperty("Text", text.Text, UbProperty.ParamType.String);
                props.Add(_Text);
            }
            else
            {
                UbProperty _Text = new UbProperty("Text", string.Empty, UbProperty.ParamType.String);
                props.Add(_Text);
            }

            // Dimmension ValueString
            if (elem as Dimension != null)
            {
                Dimension dim = elem as Dimension;
                UbProperty _ValueString = new UbProperty("ValueString", dim.ValueString, UbProperty.ParamType.String);
                props.Add(_ValueString);
            }
            else
            {
                UbProperty _ValueString = new UbProperty("ValueString", string.Empty, UbProperty.ParamType.String);
                props.Add(_ValueString);
            }

            // ViewSpecific
            UbProperty _ViewSpecific = new UbProperty("ViewSpecific", elem.ViewSpecific.ToString(), UbProperty.ParamType.String);
            props.Add(_ViewSpecific);

            // WorksetId
            UbProperty _WorksetId = new UbProperty("WorksetId", elem.WorksetId.IntegerValue.ToString(), UbProperty.ParamType.ElementId);
            props.Add(_WorksetId);

            return props;
        }

        public static string GetValueFromParameter(Parameter param)
        {
            string value = string.Empty;
            if (param.Definition != null)
            {
                if (param.StorageType == StorageType.Double)
                {
                    //value = typeParam.AsDouble().ToString();
                    value = param.AsValueString();
                }
                if (param.StorageType == StorageType.ElementId)
                {
                    value = param.AsValueString();
                }
                if (param.StorageType == StorageType.Integer)
                {
                    value = param.AsValueString();
                    //if (param.AsValueString().Length > 0)
                    //{
                    //    value += " (" + param.AsValueString() + ")";
                    //}
                }
                if (param.StorageType == StorageType.None)
                {
                    value = "-";
                }
                if (param.StorageType == StorageType.String)
                {
                    value = param.AsString();
                    if (value == null)
                    {
                        value = param.AsValueString();
                    }
                    if (value == string.Empty)
                    {
                        value = param.AsValueString();
                    }
                    if (value == null)
                    {
                        value = param.AsValueString();
                    }
                }
            }
            
            return value;
        }

        public static List<string> GetParameterValuesFromElements(List<Element> elements, string parameterId)
        {
            List<string> values = new List<string>();
            foreach (Element elem in elements)
            {
                // Instance Parameters
                foreach (Parameter param in elem.Parameters)
                {
                    if (param.Id.IntegerValue.ToString() == parameterId)
                    {
                        string value = GetValueFromParameter(param);
                        if (!values.Exists(x => x == value))
                        {
                            values.Add(value);
                        }
                    }
                    
                }
                // Type Parameters
                try
                {
                    Element elemType = Main._doc.GetElement(elem.GetTypeId());
                    if (elemType != null)
                    {
                        foreach (Parameter param2 in elemType.Parameters)
                        {
                            if (param2.Id.IntegerValue.ToString() == parameterId)
                            {
                                string value = GetValueFromParameter(param2);
                                if (!values.Exists(x => x == value))
                                {
                                    values.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
                // Family Parameters
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
                        foreach (Parameter param in famType.Parameters)
                        {
                            if (param.Id.IntegerValue.ToString() == parameterId)
                            {
                                string value = GetValueFromParameter(param);
                                if (!values.Exists(x => x == value))
                                {
                                    values.Add(value);
                                }
                            }
                        }
                    }
                }
                // Properties
                foreach (UbProperty prop in Tools.GetPropertiesFromElement(elem))
                {
                    if (prop.name == parameterId)
                    {
                        string value = prop.value;
                        if (!values.Exists(x => x == value))
                        {
                            values.Add(value);
                        }
                    }
                }
            }

            return values;
        }
        #endregion

        #region Winforms
        public static string GetStringFromComboBox(System.Windows.Forms.ComboBox combo)
        {
            string value = string.Empty;
            if (combo.SelectedItem == null)
            {
                value = combo.Text;
            }
            else
            {
                value = combo.SelectedItem.ToString();
            }
            return value;
        }

        public static void UpdateComboFromString(System.Windows.Forms.ComboBox combo, string text)
        {
            int index = -1;
            if (combo.Items.Count == 0)
            {
                combo.Text = text;
            }
            else
            {
                if (combo.Items.Contains(text))
                {
                    for (int i = 0; i < combo.Items.Count; i++)
                    {
                        if (combo.Items[i].ToString() == text)
                        {
                            index = i;
                        }
                    }
                    if (index > -1)
                    {
                        combo.SelectedIndex = index;
                    }
                }
                else
                {
                    combo.Items.Add(text);
                    combo.SelectedItem = text;
                }
            }
            
        }
        #endregion

        #region Export
        public static void ExportGridToExcel(string title, string filename, DataGridView grid)
        {
            // Creating DataTable
            DataTable dt = new DataTable();
            // Adding the Columns
            foreach (DataGridViewColumn col in grid.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }
            // Adding Rows
            foreach (DataGridViewRow row in grid.Rows)
            {
                string[] values = new string[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    //values[i] = row.Cells[i].Value.ToString();
                    if (row.Cells[i].Value == null)
                    {
                        values[i] = string.Empty;
                    }
                    else
                    {
                        values[i] = row.Cells[i].Value.ToString();
                    }
                }
                dt.Rows.Add(values);
            }
            // Creating WorkSheet
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "Report");
            var ws = wb.Worksheet(1);

            // Setting Column Width
            foreach (DataGridViewColumn col in grid.Columns)
            {
                ws.Column(col.Index + 1).Width = col.Width * 0.15;
            }

            wb.SaveAs(filename);
        }

        public static void SaveReport(string filename, SmrtReport report)
        {
            string path = string.Empty;
            System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog();
            save.Filter = "Smart Report|*.srp";
            string title = report.reportName;
            save.FileName = title + ".srp";
            System.Windows.Forms.DialogResult result = save.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                path = save.FileName;
                try
                {
                    string sb = report.ToStringBuilder();
                    System.IO.File.WriteAllText(path, sb);
                    System.Windows.Forms.MessageBox.Show("File saved successfully", Main.Name,
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    //System.Diagnostics.Process.Start(path);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + ex.ToString(), Main.Name,
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
