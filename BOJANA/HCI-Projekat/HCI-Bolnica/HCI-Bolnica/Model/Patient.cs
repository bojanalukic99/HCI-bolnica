using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
  public  class Patient : User
    {

        public System.Collections.ArrayList appointment;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetAppointment()
        {
            if (appointment == null)
                appointment = new System.Collections.ArrayList();
            return appointment;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetAppointment(System.Collections.ArrayList newAppointment)
        {
            RemoveAllAppointment();
            foreach (Appointment oAppointment in newAppointment)
                AddAppointment(oAppointment);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddAppointment(Appointment newAppointment)
        {
            if (newAppointment == null)
                return;
            if (this.appointment == null)
                this.appointment = new System.Collections.ArrayList();
            if (!this.appointment.Contains(newAppointment))
            {
                this.appointment.Add(newAppointment);
                newAppointment.SetPatient(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveAppointment(Appointment oldAppointment)
        {
            if (oldAppointment == null)
                return;
            if (this.appointment != null)
                if (this.appointment.Contains(oldAppointment))
                {
                    this.appointment.Remove(oldAppointment);
                    oldAppointment.SetPatient((Patient)null);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllAppointment()
        {
            if (appointment != null)
            {
                System.Collections.ArrayList tmpAppointment = new System.Collections.ArrayList();
                foreach (Appointment oldAppointment in appointment)
                    tmpAppointment.Add(oldAppointment);
                appointment.Clear();
                foreach (Appointment oldTermin in tmpAppointment)
                    oldTermin.SetPatient((Patient)null);
                tmpAppointment.Clear();
            }
        }
        public Patient() { }
        public Patient(String name, String surename, String jmbg, DateTime dateOfBirth, String placeOfBirth, String phoneNumber, String email, String residentialAddress)
        {
            Name = name;
            Surename = surename;
            Jmbg = jmbg;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            ResidentialAddress = residentialAddress;
        }
        public Patient(String patientId, String name, String surename, String jmbg, DateTime dateOfBirth, String placeOfBirth, String phoneNumber, String email, String residentialAddress, String allergens)
        {
            PatientId = patientId;
            Name = name;
            Surename = surename;
            Jmbg = jmbg;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            ResidentialAddress = residentialAddress;
            Allergens = allergens;
        }
        public Patient(String fullName)
        {
            this.fullName = fullName;
        }
        private String name;
        private String surename;
        private String jmbg;
        private DateTime dateOfBirth;
        private String placeOfBirth;
        private String phoneNumber;
        private String eMail;
        private String residentialAddress;
        private String patientId;
        private String allergens;
        private String fullName;

        public String Allergens
        {
            get { return allergens; }
            set
            {
                allergens = value;
                OnPropertyChanged(nameof(Allergens));
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }
        public String FullName 
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
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
        public String PlaceOfBirth
        {
            get { return placeOfBirth; }
            set
            {
                placeOfBirth = value;
                OnPropertyChanged(nameof(PlaceOfBirth));
            }
        }
        public string Email
        {
            get { return eMail; }
            set
            {
                eMail = value;
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
        public String PatientId
        {
            get { return patientId; }
            set
            {
                patientId = value;
                OnPropertyChanged(nameof(PatientId));
            }
        }
    }
}
