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

namespace SmartReport
{
    public class SmrtReport
    {
        // TAB REPORT
        public string reportName { get; set; }
        public bool includeModelInstances { get; set; }
        public bool includeAnnotationInstances { get; set; }
        public bool includeFamilyTypes { get; set; }
        public bool includeMaterials { get; set; }
        public bool includeFamilies { get; set; }
        public List<string> selectedElementsId { get; set; }
        
        // TAB FIELDS
        public List<string> selectedFieldsId { get; set; }

        // TAB FILTER
        // Filter 01
        public string cmbFilterParam01 { get; set; }
        public string cmbFilterRule01 { get; set; }
        public string cmbFilterText01 { get; set; }

        // Filter 02
        public string cmbFilterParam02 { get; set; }
        public string cmbFilterRule02 { get; set; }
        public string cmbFilterText02 { get; set; }

        // Filter 03
        public string cmbFilterParam03 { get; set; }
        public string cmbFilterRule03 { get; set; }
        public string cmbFilterText03 { get; set; }

        // Filter 04
        public string cmbFilterParam04 { get; set; }
        public string cmbFilterRule04 { get; set; }
        public string cmbFilterText04 { get; set; }

        // Filter 05
        public string cmbFilterParam05 { get; set; }
        public string cmbFilterRule05 { get; set; }
        public string cmbFilterText05 { get; set; }

        // Filter 06
        public string cmbFilterParam06 { get; set; }
        public string cmbFilterRule06 { get; set; }
        public string cmbFilterText06 { get; set; }

        // Filter 07
        public string cmbFilterParam07 { get; set; }
        public string cmbFilterRule07 { get; set; }
        public string cmbFilterText07 { get; set; }

        // Filter 08
        public string cmbFilterParam08 { get; set; }
        public string cmbFilterRule08 { get; set; }
        public string cmbFilterText08 { get; set; }

        // TAB GROUP
        // Group 01
        public string cmbGrp01 { get; set; }
        public bool rdb01Ascending { get; set; }
        public bool rdb01Descending { get; set; }
        public bool chk01BlankLine { get; set; }

        // Group 02
        public string cmbGrp02 { get; set; }
        public bool rdb02Ascending { get; set; }
        public bool rdb02Descending { get; set; }
        public bool chk02BlankLine { get; set; }

        // Group 03
        public string cmbGrp03 { get; set; }
        public bool rdb03Ascending { get; set; }
        public bool rdb03Descending { get; set; }
        public bool chk03BlankLine { get; set; }

        // Group 04
        public string cmbGrp04 { get; set; }
        public bool rdb04Ascending { get; set; }
        public bool rdb04Descending { get; set; }
        public bool chk04BlankLine { get; set; }
        
        public bool chkGrandTotal { get; set; }
        public bool chkGrpItemize { get; set; }

        #region Constructors
        public SmrtReport()
        {
            // TAB REPORT
            this.reportName = "Smart Report 01";
            this.includeModelInstances = false;
            this.includeAnnotationInstances = false;
            this.includeFamilyTypes = false;
            this.includeMaterials = false;
            this.includeFamilies = false;
            this.selectedElementsId = new List<string>();

            // TAB FIELDS
            this.selectedFieldsId = new List<string>();

            // TAB FILTER
            // Filter 01
            this.cmbFilterParam01 = "None";
            this.cmbFilterRule01 = "None";
            this.cmbFilterText01 = string.Empty;

            // Filter 02
            this.cmbFilterParam02 = "None";
            this.cmbFilterRule02 = "None";
            this.cmbFilterText02 = string.Empty;

            // Filter 03
            this.cmbFilterParam03 = "None";
            this.cmbFilterRule03 = "None";
            this.cmbFilterText03 = string.Empty;

            // Filter 04
            this.cmbFilterParam04 = "None";
            this.cmbFilterRule04 = "None";
            this.cmbFilterText04 = string.Empty;

            // Filter 05
            this.cmbFilterParam05 = "None";
            this.cmbFilterRule05 = "None";
            this.cmbFilterText05 = string.Empty;

            // Filter 06
            this.cmbFilterParam06 = "None";
            this.cmbFilterRule06 = "None";
            this.cmbFilterText06 = string.Empty;

            // Filter 07
            this.cmbFilterParam07 = "None";
            this.cmbFilterRule07 = "None";
            this.cmbFilterText07 = string.Empty;

            // Filter 08
            this.cmbFilterParam08 = "None";
            this.cmbFilterRule08 = "None";
            this.cmbFilterText08 = string.Empty;

            // TAB GROUP
            // Group 01
            this.cmbGrp01 = "None";
            this.rdb01Ascending = true;
            this.rdb01Descending = false;
            this.chk01BlankLine = false;

            // Group 02
            this.cmbGrp02 = "None";
            this.rdb02Ascending = true;
            this.rdb02Descending = false;
            this.chk02BlankLine = false;

            // Group 03
            this.cmbGrp03 = "None";
            this.rdb03Ascending = true;
            this.rdb03Descending = false;
            this.chk03BlankLine = false;

            // Group 04
            this.cmbGrp04 = "None";
            this.rdb04Ascending = true;
            this.rdb04Descending = false;
            this.chk04BlankLine = false;

            this.chkGrandTotal = false;
            this.chkGrpItemize = true;
        }
        #endregion
        #region Convert
        public string ToStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            // TAB REPORT
            sb.AppendLine(this.reportName);
            sb.AppendLine(this.includeModelInstances.ToString());
            sb.AppendLine(this.includeAnnotationInstances.ToString());
            sb.AppendLine(this.includeFamilyTypes.ToString());
            sb.AppendLine(this.includeMaterials.ToString());
            sb.AppendLine(this.includeFamilies.ToString());
            string selectedElementsIdLine = string.Empty;
            for (int i = 0; i < this.selectedElementsId.Count; i++)
            {
                if (i == this.selectedElementsId.Count - 1)
                {
                    selectedElementsIdLine += this.selectedElementsId[i];
                }
                else
                {
                    selectedElementsIdLine += this.selectedElementsId[i] + ";";
                }
            }
            sb.AppendLine(selectedElementsIdLine);
            // TAB FIELDS
            string selectedFieldsIdLine = string.Empty;
            for (int i = 0; i < this.selectedFieldsId.Count; i++)
            {
                if (i == this.selectedFieldsId.Count - 1)
                {
                    selectedFieldsIdLine += this.selectedFieldsId[i];
                }
                else
                {
                    selectedFieldsIdLine += this.selectedFieldsId[i] + ";";
                }
            }
            sb.AppendLine(selectedFieldsIdLine);
            // TAB FILTER
            // Filter 01
            sb.AppendLine(this.cmbFilterParam01.ToString());
            sb.AppendLine(this.cmbFilterRule01.ToString());
            sb.AppendLine(this.cmbFilterText01.ToString());

            // Filter 02
            sb.AppendLine(this.cmbFilterParam02.ToString());
            sb.AppendLine(this.cmbFilterRule02.ToString());
            sb.AppendLine(this.cmbFilterText02.ToString());

            // Filter 03
            sb.AppendLine(this.cmbFilterParam03.ToString());
            sb.AppendLine(this.cmbFilterRule03.ToString());
            sb.AppendLine(this.cmbFilterText03.ToString());

            // Filter 04
            sb.AppendLine(this.cmbFilterParam04.ToString());
            sb.AppendLine(this.cmbFilterRule04.ToString());
            sb.AppendLine(this.cmbFilterText04.ToString());

            // Filter 05
            sb.AppendLine(this.cmbFilterParam05.ToString());
            sb.AppendLine(this.cmbFilterRule05.ToString());
            sb.AppendLine(this.cmbFilterText05.ToString());

            // Filter 06
            sb.AppendLine(this.cmbFilterParam06.ToString());
            sb.AppendLine(this.cmbFilterRule06.ToString());
            sb.AppendLine(this.cmbFilterText06.ToString());

            // Filter 07
            sb.AppendLine(this.cmbFilterParam07.ToString());
            sb.AppendLine(this.cmbFilterRule07.ToString());
            sb.AppendLine(this.cmbFilterText07.ToString());

            // Filter 08
            sb.AppendLine(this.cmbFilterParam08.ToString());
            sb.AppendLine(this.cmbFilterRule08.ToString());
            sb.AppendLine(this.cmbFilterText08.ToString());

            // TAB GROUP
            // Group 01
            sb.AppendLine(this.cmbGrp01);
            sb.AppendLine(this.rdb01Ascending.ToString());
            sb.AppendLine(this.rdb01Descending.ToString());
            sb.AppendLine(this.chk01BlankLine.ToString());

            // Group 02
            sb.AppendLine(this.cmbGrp02);
            sb.AppendLine(this.rdb02Ascending.ToString());
            sb.AppendLine(this.rdb02Descending.ToString());
            sb.AppendLine(this.chk02BlankLine.ToString());

            // Group 03
            sb.AppendLine(this.cmbGrp03);
            sb.AppendLine(this.rdb03Ascending.ToString());
            sb.AppendLine(this.rdb03Descending.ToString());
            sb.AppendLine(this.chk03BlankLine.ToString());

            // Group 04
            sb.AppendLine(this.cmbGrp04);
            sb.AppendLine(this.rdb04Ascending.ToString());
            sb.AppendLine(this.rdb04Descending.ToString());
            sb.AppendLine(this.chk04BlankLine.ToString());

            sb.AppendLine(this.chkGrandTotal.ToString());
            sb.AppendLine(this.chkGrpItemize.ToString());
            return sb.ToString();
        }

        public static SmrtReport FromStringFile(string path)
        {
            string[] text = System.IO.File.ReadAllLines(path, Encoding.UTF8);
            SmrtReport report = new SmrtReport();
            // TAB REPORT
            report.reportName = text[0];
            report.includeModelInstances = Convert.ToBoolean(text[1]);
            report.includeAnnotationInstances = Convert.ToBoolean(text[2]);
            report.includeFamilyTypes = Convert.ToBoolean(text[3]);
            report.includeMaterials = Convert.ToBoolean(text[4]);
            report.includeFamilies = Convert.ToBoolean(text[5]);
            // Selected Elements
            List<string> _selectedElementsId = new List<string>();
            string[] elements = text[6].Split(';');
            for (int i = 0; i < elements.Length; i++)
            {
                _selectedElementsId.Add(elements[i]);
            }
            report.selectedElementsId = _selectedElementsId;

            // TAB FIELDS
            List<string> _selectedFieldsId = new List<string>();
            string[] fields = text[7].Split(';');
            for (int i = 0; i < fields.Length; i++)
            {
                _selectedFieldsId.Add(fields[i]);
            }
            report.selectedFieldsId = _selectedFieldsId;

            // TAB FILTERS
            // Filter 01
            report.cmbFilterParam01 = text[8];
            report.cmbFilterRule01 = text[9];
            report.cmbFilterText01 = text[10];

            // Filter 02
            report.cmbFilterParam02 = text[11];
            report.cmbFilterRule02 = text[12];
            report.cmbFilterText02 = text[13];

            // Filter 03
            report.cmbFilterParam03 = text[14];
            report.cmbFilterRule03 = text[15];
            report.cmbFilterText03 = text[16];

            // Filter 04
            report.cmbFilterParam04 = text[17];
            report.cmbFilterRule04 = text[18];
            report.cmbFilterText04 = text[19];

            // Filter 05
            report.cmbFilterParam05 = text[20];
            report.cmbFilterRule05 = text[21];
            report.cmbFilterText05 = text[22];

            // Filter 06
            report.cmbFilterParam06 = text[23];
            report.cmbFilterRule06 = text[24];
            report.cmbFilterText06 = text[25];

            // Filter 07
            report.cmbFilterParam07 = text[26];
            report.cmbFilterRule07 = text[27];
            report.cmbFilterText07 = text[28];

            // Filter 08
            report.cmbFilterParam08 = text[29];
            report.cmbFilterRule08 = text[30];
            report.cmbFilterText08 = text[31];

            // TAB GROUPS
            // Group 01
            report.cmbGrp01 = text[32];
            report.rdb01Ascending = Convert.ToBoolean(text[33]);
            report.rdb01Descending = Convert.ToBoolean(text[34]);
            report.chk01BlankLine = Convert.ToBoolean(text[35]);

            // Group 02
            report.cmbGrp02 = text[36];
            report.rdb02Ascending = Convert.ToBoolean(text[37]);
            report.rdb02Descending = Convert.ToBoolean(text[38]);
            report.chk02BlankLine = Convert.ToBoolean(text[39]);

            // Group 03
            report.cmbGrp03 = text[40];
            report.rdb03Ascending = Convert.ToBoolean(text[41]);
            report.rdb03Descending = Convert.ToBoolean(text[42]);
            report.chk03BlankLine = Convert.ToBoolean(text[43]);

            // Group 04
            report.cmbGrp04 = text[44];
            report.rdb04Ascending = Convert.ToBoolean(text[45]);
            report.rdb04Descending = Convert.ToBoolean(text[46]);
            report.chk04BlankLine = Convert.ToBoolean(text[47]);

            report.chkGrandTotal = Convert.ToBoolean(text[48]);
            report.chkGrpItemize = Convert.ToBoolean(text[49]);
            return report;
        }
        #endregion
    }
}
