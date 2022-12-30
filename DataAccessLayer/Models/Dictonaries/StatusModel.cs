using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models.Dictonaries
{
    public class StatusModel : EntityModel
    {
        public StatusModel(string value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToUpper();
        }
        public string Value { get; set; }
    }
}
