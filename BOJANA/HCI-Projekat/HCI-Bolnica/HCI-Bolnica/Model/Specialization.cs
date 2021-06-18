using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
    public class Specialization : Entity
    {
        private String name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public override string Validate(string columName)
        {
            return "";
        }
        public override void InitExportList()
        {

        }
    }
}
