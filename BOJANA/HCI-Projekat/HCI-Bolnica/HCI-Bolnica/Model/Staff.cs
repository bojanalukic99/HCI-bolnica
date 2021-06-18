using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
    public class Staff : Entity
    {
        private String name;
        private String surename;
        private String jmbg;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Surename
        {
            get { return surename; }
            set
            {
                surename = value;
                OnPropertyChanged(nameof(Surename));
            }
        }
        public String Jmbg
        {
            get { return jmbg; }
            set
            {
                jmbg = value;
                OnPropertyChanged(nameof(Jmbg));
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
