using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
   public class Doctor : User
    {
        public Specialization specialization;
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
            foreach (Appointment oAppoitment in newAppointment)
                AddAppointment(oAppoitment);
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
                newAppointment.SetDoctor(this);
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
                    oldAppointment.SetDoctor((Doctor)null);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllAppointment()
        {
            if (appointment != null)
            {
                System.Collections.ArrayList tmpAppointmnets = new System.Collections.ArrayList();
                foreach (Appointment oldAppointment in appointment)
                    tmpAppointmnets.Add(oldAppointment);
                appointment.Clear();
                foreach (Appointment oldAppointment in tmpAppointmnets)
                    oldAppointment.SetDoctor((Doctor)null);
                tmpAppointmnets.Clear();
            }
        }

        private String name;
        private String surename;
        private String placeOfBirth;
        private String jmbg;
        private String email;
        private String phoneNumber;
        private String residentialAddress;
        private String doctorId;
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
        public String PlaceOdBirth 
        {
            get { return placeOfBirth; }
            set 
            {
                placeOfBirth = value;
                OnPropertyChanged(nameof(PlaceOdBirth));
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
        public String DoctorId 
        {
            get { return doctorId; }
            set 
            {
                doctorId = value;
                OnPropertyChanged(nameof(DoctorId));
            }
        }
        public Doctor() { }
    }
}
