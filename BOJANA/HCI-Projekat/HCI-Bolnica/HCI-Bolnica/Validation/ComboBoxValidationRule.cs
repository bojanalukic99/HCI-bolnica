using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HCI_Bolnica.Validation
{
    public class ComboBoxValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as ComboBox;
                double r;
                if (s.SelectedIndex != -1)
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Morate da popunite sva polja!");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }
}
