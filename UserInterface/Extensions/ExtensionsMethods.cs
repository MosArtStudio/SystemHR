using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SystemHR.UserInterface.Extensions
{
    public static class ExtensionsMethods
    {
        public static void SetDateTimePickerValue(this DateTimePicker dtp, DateTime? dt )
        {
            if (dt.HasValue)
            {
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Value = dt.Value;
            }
            else
            {
                //dtp.Format = 0;
                dtp.Format = DateTimePickerFormat.Custom;
            }
        }
        
        public static void DatePickerValueChanged(this DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Short;
        }
    }
}
