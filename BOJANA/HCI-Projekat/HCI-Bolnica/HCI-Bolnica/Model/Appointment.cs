using HCIBolnica.Model;
using System;

namespace HCI_Bolnica.Model
{
   public class Appointment : Entity
    {
        public Room room;
        public Doctor doctor;

        /// <pdGenerated>default parent getter</pdGenerated>
        public Doctor GetDoctor()
        {
            return doctor;
        }

        /// <pdGenerated>default parent setter</pdGenerated>
        /// <param>newLekar</param>
        public void SetDoctor(Doctor newDoctor)
        {
            if (this.doctor != newDoctor)
            {
                if (this.doctor != null)
                {
                    Doctor oldDoctor = this.doctor;
                    this.doctor = null;
                    oldDoctor.RemoveAppointment(this);
                }
                if (newDoctor != null)
                {
                    this.doctor = newDoctor;
                    this.doctor.AddAppointment(this);
                }
            }
        }
        public Patient patient;

        /// <pdGenerated>default parent getter</pdGenerated>
        public Patient GetPatient()
        {
            return patient;
        }

        /// <pdGenerated>default parent setter</pdGenerated>
        /// <param>newPacijent</param>
        public void SetPatient(Patient newPatient)
        {
            if (this.patient != newPatient)
            {
                if (this.patient != null)
                {
                    Patient oldPacijent = this.patient;
                    this.patient = null;
                    oldPacijent.RemoveAppointment(this);
                }
                if (newPatient != null)
                {
                    this.patient = newPatient;
                    this.patient.AddAppointment(this);
                }
            }
        }
        String appointmentId;
        private String startTime;
        private AppointmentType appointmentType;
        private String date;
        private String appointmentPatient;
        private String appointmentDoctor;
        private String roomNumber;
        private String roomType;
        private String startDate;
        private String completionDate;
        public String StartTime 
        { get { return startTime; }
          set 
            {
                startTime = value;
                OnPropertyChanged(nameof(StartTime));
            } 
        }
        public String CompletionDate 
        {
            get { return completionDate; }
            set
            {
                completionDate = value;
                OnPropertyChanged(nameof(CompletionDate));
            }
        }

        public String RoomType
        { get { return roomType; }
            set
            {
                roomType = value;
                OnPropertyChanged(nameof(RoomType));
            }
        }
        public String RoomNumber 
        {   get { return roomNumber; }
            set 
            {
                roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            } 
        }
        public String AppointmentPatient
        {   get { return appointmentPatient; }
            set 
            {
                appointmentPatient = value;
                OnPropertyChanged(nameof(AppointmentPatient));
            }
        }

        public String AppointmentDoctora 
        { 
          get { return appointmentDoctor; }
            set 
            {
                appointmentDoctor = value;
                OnPropertyChanged(nameof(AppointmentDoctora));
            }
        }

        public Room Room
        {
            get { return room;  }
            set 
            {
                room = value;
                OnPropertyChanged(nameof(Room));
            }
        }

        public Doctor Doctor 
        {
            get { return doctor; }
            set 
            {
                doctor = value;
                OnPropertyChanged(nameof(Doctor));
            }
        }
        public String Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        public String StartDate 
        {
            get { return startDate; }
            set 
            {
                startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        
        }
        public AppointmentType AppointmentType
        {
            get { return appointmentType; }
            set 
            {
                appointmentType = value;
                OnPropertyChanged(nameof(AppointmentType));
            }
        }

        public String AppointmentId
        {
            get { return appointmentId; }
            set 
            {
                appointmentId = value;
                OnPropertyChanged(nameof(AppointmentId));
            }
        }


        public Appointment() { }
        public Appointment(String appointmentId, String time, String date, Doctor doctor)

        {
            AppointmentId = appointmentId;
            StartTime = time;
            Date = date;
            Doctor = doctor;
        }
        public Appointment(String startTime, AppointmentType appointmentType, String date, String appointmentPatient, String appointmentDoctor, String roomNumber, String roomType)
        {
            StartTime = startTime;
            AppointmentType = appointmentType;
            Date = date;
            AppointmentPatient = appointmentPatient;
            AppointmentDoctora = appointmentDoctor;
            RoomNumber = roomNumber;
            RoomType = roomType;
        }
        public Appointment(String appointmentId, String startTime, String date, String appointmentPatient, Doctor doctor)
        {
            AppointmentId = appointmentId;
            StartTime = startTime;
            Date = date;
            AppointmentDoctora = appointmentPatient;
            Doctor = doctor;

        }
        public Appointment(String startDate, String completionDate, String roomNumber) { StartDate = startDate; CompletionDate = completionDate; RoomNumber = roomNumber; }
        public Appointment(String date, String roomNumber) { Date = date; RoomNumber = roomNumber; }
        public override string Validate(string columName)
        {
            return "";
        }
        public override void InitExportList()
        {

        }
    }
}
