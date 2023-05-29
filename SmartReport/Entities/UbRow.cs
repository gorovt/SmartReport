using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReport
{
    public class UbRow
    {
        public enum RowType
        {
            Row,
            Header,
            Footer,
            Blank,
            GrandTotal
        }
        public List<string> values { get; set; }
        public RowType rowType { get; set; }

        public UbRow()
        {
            this.values = new List<string>();
            this.rowType = RowType.Row;
        }

        public UbRow(List<string> values, RowType rowType)
        {
            this.values = values;
            this.rowType = rowType;
        }

        public static List<UbRow> ConvertList(List<List<string>> lista)
        {
            List<UbRow> rows = new List<UbRow>();
            foreach (List<string> line in lista)
            {
                UbRow row = new UbRow();
                row.values.AddRange(line);
                rows.Add(row);
            }
            return rows;
        }
    }
}
