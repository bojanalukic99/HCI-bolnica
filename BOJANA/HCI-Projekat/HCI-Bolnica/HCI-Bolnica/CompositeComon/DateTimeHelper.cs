using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.CompositeComon
{
    public class DateTimeHelper
    {
        public static bool DateToString(DateTime date, out string result)
        {
            result = string.Empty;
            try
            {
                result = date.ToString("MM/dd/yyyy");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool StringToDate(string date, out DateTime result)
        {
            result = new DateTime();
            try
            {
                result = DateTime.ParseExact(date, "MM/dd/yyyy", null);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
