using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HCI_Bolnica.Validation
{
   public class DateFormatValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                double r;
                DateTime date = new DateTime();
                if (StringToDate(s, out date))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Format za datum MM/dd/YYYY!");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
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
