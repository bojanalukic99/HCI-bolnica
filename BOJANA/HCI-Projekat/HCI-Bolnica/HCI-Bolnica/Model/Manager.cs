using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
    public class Manager : User
    {
        private String name;
        private String surename;
        private String jmbg;
        private String email;
        private String phoneNumber;
        private String menagerId;
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
        public String Jmbg
        {
            get { return jmbg; }
            set
            {
                jmbg = value;
                OnPropertyChanged(nameof(Jmbg));
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
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged(nameof(phoneNumber));
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
        public String MenagerId
        {
            get { return menagerId; }
            set
            {
                menagerId = value;
                OnPropertyChanged(nameof(MenagerId));
            }
        }

    }
}
