using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
    public class Renovation : Entity
    {
        private Room room;
        private String dateOfRenovationStart;
        private String dateOfRenovationEnd;

        public String DateOfRenovationStart
        {
            get { return dateOfRenovationStart; }
            set { dateOfRenovationStart = value; OnPropertyChanged(nameof(DateOfRenovationStart)); }
            
        }
        public String DateOfRenovationEnd
        {
            get { return dateOfRenovationEnd; }
            set { dateOfRenovationEnd = value; OnPropertyChanged(nameof(DateOfRenovationEnd)); }
        }

        public Room Room
        {
            get { return room; }
            set { room = value; OnPropertyChanged(nameof(Room)); }
        }
        public Renovation() { }
        public override string Validate(string columName)
        {
            return "";
        }
        public override void InitExportList()
        {

        }
    }
}
