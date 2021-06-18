using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
   public class Account : Entity
    {
        private String name;
        private String surename;
        private String email;
        private String number;
        private String residentialAddress;
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
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public string Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged(nameof(Number));
            }
        }
        public string ResidentialAddress
        { 
            get { return residentialAddress; }
            set
            {
                residentialAddress = value;
                OnPropertyChanged(nameof(ResidentialAddress));
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
