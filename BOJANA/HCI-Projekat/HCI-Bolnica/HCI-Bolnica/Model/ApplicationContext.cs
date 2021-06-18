using HCI_Bolnica.Repository;
using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
    public class ApplicationContext
    {
        private static ApplicationContext instance = null;
        private List<Entity> accounts = new List<Entity>();
        private List<Entity> appointments = new List<Entity>();
        private List<Entity> doctors = new List<Entity>();
        private List<Entity> equipmentsStatic = new List<Entity>();
        private List<Entity> equipmentsConsumable = new List<Entity>();
        private List<Entity> managers = new List<Entity>();
        private List<Entity> medicines = new List<Entity>();
        private List<Entity> patients = new List<Entity>();
        private List<Entity> rooms = new List<Entity>();
        private List<Entity> specializations = new List<Entity>();
        private List<Entity> staffs = new List<Entity>();
        private List<Entity> users = new List<Entity>() ;
        private List<Entity> renovations = new List<Entity>();
        private List<Entity> medicinesApproved = new List<Entity>();

        public ApplicationContext()
        {
            
        }

        public static ApplicationContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationContext();
                    instance.Load();
                }
                return instance;
            }
        }
        public List<Entity> MedicinesApproved
        {
            get { return medicinesApproved; }
            set { medicinesApproved = value; }
        }
        public List<Entity> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public List<Entity> Appointments
        {
            get { return appointments; }
            set { appointments = value; }
        }
        public List<Entity> Doctors
        {
            get { return doctors; }
            set { doctors = value; }
        }
        public List<Entity> EquipmentsStatic
        {
            get { return equipmentsStatic; }
            set { equipmentsStatic = value; }
        }
        public List<Entity> EquipmentsConsumable
        {
            get { return equipmentsConsumable; }
            set { equipmentsConsumable = value; }
        }
        public List<Entity> Managers
        {
            get { return managers; }
            set { managers = value; }
        }
        public List<Entity> Medicines
        {
            get { return medicines; }
            set { medicines = value; }
        }
        public List<Entity> Patients
        {
            get { return patients; }
            set { patients = value; }
        }
        public List<Entity> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
        public List<Entity> Specializations
        {
            get { return specializations; }
            set { specializations = value; }
        }
        public List<Entity> Staffs
        {
            get { return staffs; }
            set { staffs = value; }
        }
        public List<Entity> Users
        {
            get { return users; }
            set { users = value; }
        }
        public List<Entity> Renovations
        {
            get { return renovations; }
            set { renovations = value; }

        }
        public AppointmentType GetAppointmentType(string value)
        {
            if (value == "Examination")
            {
                return AppointmentType.Examination;
            }
            return AppointmentType.Operation;
        }
        public EquipmentType GetEquipmentType(string value)
        {
            if (value == "Static")
            {
                return EquipmentType.Static;
            }
            return EquipmentType.Consumable;
        }
        public RoomType GetRoomType(string value)
        {
            if (value == "OperationRoom")
            {
                return RoomType.OperacionaSala;
            }
            else if (value == "ExaminationRoom")
            {
                return RoomType.SobaZaPregled;
            }
            return RoomType.SobaZaOdmor;
        }

        public void LoadAccounts()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("accounts.txt"))
            {
                accounts = result;
                return;
            }
            StreamReader reader = new StreamReader("accounts.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');

                Account account = new Account();
                account.ID = data[0];
                account.Name = data[1];
                account.Surename = data[2];
                account.Email = data[3];
                account.Number = data[4];
                account.ResidentialAddress = data[5];
                result.Add(account);
            }
            reader.Close();
            accounts = result;
        }
        public void LoadAppointments()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("appointments.txt"))
            {
                appointments = result;
                return;
            }
            StreamReader reader = new StreamReader("appointments.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Appointment appointment = new Appointment();
                appointment.ID = data[0];
                appointment.StartTime = data[1];
                appointment.AppointmentType = GetAppointmentType(data[2]);
                appointment.Date = data[3];
                appointment.AppointmentPatient = data[4];
                appointment.AppointmentDoctora = data[5];
                appointment.RoomNumber = data[6];
                appointment.RoomType = data[7];
                appointment.StartDate = data[8];
                appointment.CompletionDate = data[9];
                result.Add(appointment);
            }
            reader.Close();
            appointments = result;
        }
        public void LoadDoctors()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("doctors.txt"))
            {
                doctors = result;
                return;
            }
            StreamReader reader = new StreamReader("doctors.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Doctor doctor = new Doctor();
                doctor.ID = data[0];
                doctor.Name = data[1];
                doctor.Surename = data[2];
                doctor.PlaceOdBirth = data[3];
                doctor.Jmbg = data[4];
                doctor.Email = data[5];
                doctor.PhoneNumber = data[6];
                doctor.ResidentialAddress = data[7];
                result.Add(doctor);
            }
            reader.Close();
            doctors = result;
        }
        public void LoadEquipmentsStatic()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("equipments.txt"))
            {
                equipmentsStatic = result;
                return;
            }
            StreamReader reader = new StreamReader("equipments.txt");
            string line;
            RoomRepository roomRepository = new RoomRepository();
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Equipment equipment = new Equipment();
                equipment.ID = data[0];
                equipment.EquipmentName = data[1];
                equipment.EquipmentType = GetEquipmentType(data[2]);
                equipment.Quantity = data[3];
                equipment.Manufacturer = data[4];
                equipment.Room = roomRepository.Get(data[5]) as Room;

                if (equipment.Room != null) 
                {
                    result.Add(equipment);
                }

            }
            reader.Close();
            equipmentsStatic = result;
        }
        public void LoadEquipmentsConsumable()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("equipmentsConsumable.txt"))
            {
                equipmentsConsumable = result;
                return;
            }
            StreamReader reader = new StreamReader("equipmentsConsumable.txt");
            string line;
            RoomRepository roomRepository = new RoomRepository();
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Equipment equipment = new Equipment();
                equipment.ID = data[0];
                equipment.EquipmentName = data[1];
                equipment.EquipmentType = GetEquipmentType(data[2]);
                equipment.Quantity = data[3];
                equipment.Manufacturer = data[4];
                equipment.Room = roomRepository.Get(data[5]) as Room; 
                result.Add(equipment);
            }
            reader.Close();
            equipmentsConsumable = result;
        }

        public void LoadManagers()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("managers.txt"))
            {
                managers = result;
                return;
            }
            StreamReader reader = new StreamReader("managers.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Manager manager = new Manager();
                manager.ID = data[0];
                manager.Name = data[1];
                manager.Surename = data[2];
                manager.Jmbg = data[3];
                manager.Email = data[4];
                manager.PhoneNumber = data[5];
                manager.ResidentialAddress = data[6];
                result.Add(manager);
            }
            reader.Close();
            managers = result;
        }
        public void LoadMedicines()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("medicines.txt"))
            {
                medicines = result;
                return;
            }
            StreamReader reader = new StreamReader("medicines.txt");
            string line;
            while((line=reader.ReadLine())!=null)
            {
                String[] data = line.Split('|');
                Medicine medicine = new Medicine();
                medicine.ID = data[0];
                medicine.Name = data[1];
                medicine.Grams = data[2];
                medicine.Composition = data[3];
                medicine.Comment = data[4];
                medicine.Replacment = data[5];
                medicine.IsCertified = bool.Parse(data[6]);
                result.Add(medicine);
            }
            reader.Close();
            medicines = result;
        }
        public void LoadMedicinesApproved()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("medicinesApproved.txt"))
            {
                medicinesApproved = result;
                return;
            }
            StreamReader reader = new StreamReader("medicinesApproved.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                String[] data = line.Split('|');
                Medicine medicine = new Medicine();
                medicine.ID = data[0];
                medicine.Name = data[1];
                medicine.Grams = data[2];
                medicine.Composition = data[3];
                medicine.Comment = data[4];
                medicine.Replacment = data[5];
                medicine.IsCertified = bool.Parse(data[6]);
                result.Add(medicine);
            }
            reader.Close();
            medicinesApproved = result;
        }

        public void LoadPatients()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("patients.txt"))
            {
                patients = result;
                return;
            }
            StreamReader reader = new StreamReader("patients.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                String[] data = line.Split('|');
                Patient patient = new Patient();
                patient.ID = data[0];
                patient.Name = data[1];
                patient.Surename = data[2];
                patient.Jmbg = data[3];
                patient.DateOfBirth = DateTime.Parse((data[4]));
                patient.PlaceOfBirth = data[5];
                patient.PhoneNumber = data[6];
                patient.Email = data[7];
                patient.ResidentialAddress = data[8];
                patient.Allergens = data[9];
                patient.FullName = data[10];
                result.Add(patient);
            }
            reader.Close();
            patients = result;
        }
        public void LoadRooms()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("rooms.txt"))
            {
                rooms = result;
                return;
            }
            StreamReader reader = new StreamReader("rooms.txt");
            string line;
            while((line=reader.ReadLine())!=null)
            {
                String[] data = line.Split('|');
                Room room = new Room();
                room.ID = data[0];
                room.Floor = int.Parse(data[1]);
                room.RoomNumber = data[2];
                room.RoomType = GetRoomType(data[3]);
                room.DateOfRenovationStart = data[4];
                room.DateOfRenovationEnd = data[5];
                result.Add(room);
            }
            reader.Close();
            rooms = result;
        }

        public void LoadStaff()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("staffs.txt"))
            {
                staffs = result;
                return;
            }
            StreamReader reader = new StreamReader("staffs.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                String[] data = line.Split('|');
                Staff staff = new Staff();
                staff.ID = data[0];
                staff.Name = data[1];
                staff.Surename = data[2];
                staff.Jmbg = data[3];
                result.Add(staff);
            }
            reader.Close();
            staffs = result;
        }
        public void LoadUser()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("users.txt"))
            {
                users = result;
                return;
            }
            StreamReader reader = new StreamReader("users.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                String[] data = line.Split('|');
                User user = new User();
                user.ID = data[0];
                user.Username = data[1];
                user.Password = data[2];
                result.Add(user);
            }
            reader.Close();
            users = result;
        }
        public void LoadRenovations()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("renovations.txt"))
            {
                renovations = result;
                return;
            }
            StreamReader reader = new StreamReader("renovations.txt");
            string line;
            RoomRepository repository = new RoomRepository();

            while ((line = reader.ReadLine()) != null)
            {
                String[] data = line.Split('|');
                Renovation renovation = new Renovation();
                renovation.ID = data[0];
                renovation.Room = repository.Get(data[1]) as Room;
                renovation.DateOfRenovationStart = data[2];
                renovation.DateOfRenovationEnd = data[3];
                result.Add(renovation);
            }
            reader.Close();
            renovations = result;
        }

        public void SaveRenovations()
        {
            if (renovations == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("renovations.txt"))
            {
                foreach (Entity entity in renovations)
                {
                    string line = string.Empty;
                    line += ((Renovation)entity).ID + "|";
                    line += ((Renovation)entity).Room.ID + "|";
                    line += ((Renovation)entity).DateOfRenovationStart + "|";
                    line += ((Renovation)entity).DateOfRenovationEnd + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveUsers()
        {
            if (users == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("users.txt"))
            {
                foreach (Entity entity in users)
                {
                    string line = string.Empty;
                    line += ((User)entity).ID + "|";
                    line += ((User)entity).Username + "|";
                    line += ((User)entity).Password + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveStaff()
        {
            if (staffs == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("staffs.txt"))
            {
                foreach (Entity entity in staffs)
                {
                    string line = string.Empty;
                    line += ((Staff)entity).ID + "|";
                    line += ((Staff)entity).Name + "|";
                    line += ((Staff)entity).Surename + "|";
                    line += ((Staff)entity).Jmbg + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveRooms()
        {
            if (rooms == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("rooms.txt"))
            {
                foreach (Entity entity in rooms)
                {
                    string line = string.Empty;
                    line += ((Room)entity).ID + "|";
                    line += ((Room)entity).Floor + "|";
                    line += ((Room)entity).RoomNumber + "|";
                    line += ((Room)entity).RoomType + "|";
                    line += ((Room)entity).DateOfRenovationStart + "|";
                    line += ((Room)entity).DateOfRenovationEnd + "|";
                    file.WriteLine(line);
                }
            }
        }
        public void SavePatients()
        {
            if (patients == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("patients.txt"))
            {
                foreach (Entity entity in patients)
                {
                    string line = string.Empty;
                    line += ((Patient)entity).ID + "|";
                    line += ((Patient)entity).Name + "|";
                    line += ((Patient)entity).Surename + "|";
                    line += ((Patient)entity).Jmbg + "|";
                    line += ((Patient)entity).DateOfBirth + "|";
                    line += ((Patient)entity).PlaceOfBirth + "|";
                    line += ((Patient)entity).PhoneNumber + "|";
                    line += ((Patient)entity).Email + "|";
                    line += ((Patient)entity).ResidentialAddress + "|";
                    line += ((Patient)entity).Allergens + "|";
                    line += ((Patient)entity).FullName + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveMedicines()
        {
            if (medicines == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("medicines.txt"))
            {
                foreach (Entity entity in medicines)
                {
                    string line = string.Empty;
                    line += ((Medicine)entity).ID + "|";
                    line += ((Medicine)entity).Name + "|";
                    line += ((Medicine)entity).Grams + "|";
                    line += ((Medicine)entity).Composition + "|";
                    line += ((Medicine)entity).Comment + "|";
                    line += ((Medicine)entity).Replacment + "|";
                    line += ((Medicine)entity).IsCertified + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveMedicinesApproved()
        {
            if (medicinesApproved == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("medicinesApproved.txt"))
            {
                foreach (Entity entity in medicinesApproved)
                {
                    string line = string.Empty;
                    line += ((Medicine)entity).ID + "|";
                    line += ((Medicine)entity).Name + "|";
                    line += ((Medicine)entity).Grams + "|";
                    line += ((Medicine)entity).Composition + "|";
                    line += ((Medicine)entity).Comment + "|";
                    line += ((Medicine)entity).Replacment + "|";
                    line += ((Medicine)entity).IsCertified + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveManagers()
        {
            if (managers == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("managers.txt"))
            {
                foreach (Entity entity in managers)
                {
                    string line = string.Empty;
                    line += ((Manager)entity).ID + "|";
                    line += ((Manager)entity).Name + "|";
                    line += ((Manager)entity).Surename + "|";
                    line += ((Manager)entity).Jmbg + "|";
                    line += ((Manager)entity).Email + "|";
                    line += ((Manager)entity).PhoneNumber + "|";
                    line += ((Manager)entity).ResidentialAddress + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveEquipmentsStatic()
        {
            if (equipmentsStatic == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("equipments.txt"))
            {
                foreach (Entity entity in equipmentsStatic)
                {
                    string line = string.Empty;
                    line += ((Equipment)entity).ID + "|";
                    line += ((Equipment)entity).EquipmentName + "|";
                    line += ((Equipment)entity).EquipmentType + "|";
                    line += ((Equipment)entity).Quantity + "|";
                    line += ((Equipment)entity).Manufacturer + "|";
                    if (((Equipment)entity).Room == null)
                    {
                        line += ((Equipment)entity).Manufacturer + "-1|";
                    }
                    else 
                    {
                        line += ((Equipment)entity).Room.ID + "|";
                    }
                    


                    file.WriteLine(line);
                }
            }
        }
        public void SaveEquipmentsConsumable()
        {
            if (equipmentsConsumable == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("equipmentsConsumable.txt"))
            {
                foreach (Entity entity in equipmentsConsumable)
                {
                    string line = string.Empty;
                    line += ((Equipment)entity).ID + "|";
                    line += ((Equipment)entity).EquipmentName + "|";
                    line += ((Equipment)entity).EquipmentType + "|";
                    line += ((Equipment)entity).Quantity + "|";
                    line += ((Equipment)entity).Manufacturer + "|";
                    if (((Equipment)entity).Room == null)
                    {
                        line += ((Equipment)entity).Manufacturer + "-1|";
                    }
                    else
                    {
                        line += ((Equipment)entity).Room.ID + "|";
                    }

                    file.WriteLine(line);
                }
            }
        }
        public void SaveDoctor()
        { 
            if(doctors==null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("doctors.txt"))
            {
                foreach (Entity entity in doctors)
                {
                    string line = string.Empty;
                    line += ((Doctor)entity).ID + "|";
                    line += ((Doctor)entity).Name + "|";
                    line += ((Doctor)entity).Surename + "|";
                    line += ((Doctor)entity).PlaceOdBirth + "|";
                    line += ((Doctor)entity).Jmbg + "|";
                    line += ((Doctor)entity).Email + "|";
                    line += ((Doctor)entity).PhoneNumber + "|";
                    line += ((Doctor)entity).ResidentialAddress + "|";

                    file.WriteLine(line);
                }
            }
        }
        public void SaveAppointmens()
        {
            if (appointments == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("appointments.txt"))
            {
                foreach (Entity entity in appointments)
                {
                    string line = string.Empty;
                    line += ((Appointment)entity).ID + "|";
                    line += ((Appointment)entity).StartTime + "|";
                    line += ((Appointment)entity).AppointmentType + "|";
                    line += ((Appointment)entity).Date + "|";
                    line += ((Appointment)entity).AppointmentPatient + "|";
                    line += ((Appointment)entity).AppointmentDoctora + "|";
                    line += ((Appointment)entity).RoomNumber + "|";
                    line += ((Appointment)entity).RoomType + "|";
                    line += ((Appointment)entity).StartDate + "|";
                    line += ((Appointment)entity).CompletionDate + "|";

                    file.WriteLine(line);

                }
            }
        }
        public void SaveAccounts()
        {
            if (accounts == null)
            {
                return;
            }
            using (StreamWriter file = new StreamWriter("accounts.txt"))
            {
                foreach (Entity entity in accounts)
                {
                    string line = string.Empty;
                    line += ((Account)entity).ID + "|";
                    line += ((Account)entity).Name + "|";
                    line += ((Account)entity).Surename + "|";
                    line += ((Account)entity).Email + "|";
                    line += ((Account)entity).Number + "|";
                    line += ((Account)entity).ResidentialAddress + "|";

                    file.WriteLine(line);
                }
            }
        }

        public List<Entity> Get(Type type)
        {
            if (type == typeof(Account))
            {
                return Accounts;
            }
            if (type == typeof(Appointment))
            {
                return Appointments;
            }
            if (type == typeof(Doctor))
            {
                return Doctors;
            }
            if (type == typeof(Equipment))
            {
                return EquipmentsStatic;
            }
            if (type == typeof(Manager))
            {
                return Managers;
            }
            if (type == typeof(Medicine))
            {
                return Medicines;
            }
            if (type == typeof(Patient))
            {
                return Patients;
            }
            if (type == typeof(Room))
            {
                return Rooms;
            }
            if (type == typeof(Specialization))
            {
                return Specializations;
            }
            if (type == typeof(Staff))
            {
                return Staffs;
            }
            if (type == typeof(Renovation))
            {
                return Renovations;
            }
            return Users;
        }
        public void Set(Type type, List<Entity> entities)
        {
            if (type == typeof(Account))
            {
                Accounts = entities;
                return;
            }
            if (type == typeof(Appointment))
            {
                Appointments = entities;
                return;
            }
            if (type == typeof(Doctor))
            {
                Doctors = entities;
                return;
            }
            if (type == typeof(Equipment))
            {
                EquipmentsStatic = entities;
                return;
            }
            if (type == typeof(Manager))
            {
                Managers = entities;
                return;
            }
            if (type == typeof(Medicine))
            {
                Medicines = entities;
                return;
            }
            if (type == typeof(Patient))
            {
                Patients = entities;
                return;
            }
            if (type == typeof(Room))
            {
                Rooms = entities;
                return;
            }
            if (type == typeof(Specialization))
            {
                Specializations = entities;
                return;
            }
            if (type == typeof(Staff))
            {
                Staffs = entities;
                return;
            }
            if (type == typeof(Renovation))
            {
                Renovations = entities;
                return;
            }
            Users = entities;
        }
        public void Save()
        {
            SaveRooms();
            SaveAccounts();
            SaveAppointmens();
            SaveDoctor();
            SaveEquipmentsStatic();
            SaveEquipmentsConsumable();
            SaveManagers();
            SaveMedicines();
            SavePatients();
            SaveStaff();
            SaveUsers();
            SaveRenovations();
            SaveMedicinesApproved();
        }
        public void Load()
        {
            LoadRooms();
            LoadAccounts();
            LoadAppointments();
            LoadDoctors();
            LoadEquipmentsStatic();
            LoadEquipmentsConsumable();
            LoadManagers();
            LoadMedicines();
            LoadPatients();
            LoadStaff();
            LoadUser();
            LoadRenovations();
            LoadMedicinesApproved();
        }
    }
}
