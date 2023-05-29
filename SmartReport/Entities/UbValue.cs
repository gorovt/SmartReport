using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReport
{
    public class UbValue
    {
        public enum ValueType
        {
            String,
            Double
        }
        public string value { get; set; }
        public ValueType valueType { get; set; }

        public UbValue()
        {
            this.value = string.Empty;
            this.valueType = ValueType.String;
        }

        public UbValue(string value, ValueType valueType)
        {
            this.value = value;
            this.valueType = valueType;
        }

        public double GetDouble()
        {
            double value = 0;
            if (this.valueType == ValueType.Double)
            {
                value = Convert.ToDouble(this.value);
            }
            return value;
        }
    }
}
