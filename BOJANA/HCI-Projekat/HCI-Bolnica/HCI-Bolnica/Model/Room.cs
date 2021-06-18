using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
  public class Room : Entity
    {
        public System.Collections.ArrayList equipment;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetEquipmnet()
        {
            if (equipment == null)
                equipment = new System.Collections.ArrayList();
            return equipment;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetEquipment(System.Collections.ArrayList newEquipment)
        {
            RemoveAllEquipment();
            foreach (Equipment eEquipment in newEquipment)
                AddEquipment(eEquipment);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddEquipment(Equipment newEquipment)
        {
            if (newEquipment == null)
                return;
            if (this.equipment == null)
                this.equipment = new System.Collections.ArrayList();
            if (!this.equipment.Contains(newEquipment))
                this.equipment.Add(newEquipment);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveEquipment(Equipment oldEquipment)
        {
            if (oldEquipment == null)
                return;
            if (this.equipment != null)
                if (this.equipment.Contains(oldEquipment))
                    this.equipment.Remove(oldEquipment);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllEquipment()
        {
            if (equipment != null)
                equipment.Clear();
        }
        public Appointment[] appointments;

        private String roomId;
        private int floor;
        private String roomNumber;
        private String dateOfRenovationStart;
        private String dateOfRenovationEnd;
       

        public String DateOfRenovationStart
        {
            get { return dateOfRenovationStart; }
            set
            {
                dateOfRenovationStart = value;
                OnPropertyChanged(nameof(DateOfRenovationStart));
            }
        }
        public String DateOfRenovationEnd
        {
            get { return dateOfRenovationEnd; }
            set
            {
                dateOfRenovationEnd = value;
                OnPropertyChanged(nameof(DateOfRenovationEnd));
            }
        }
        public String RoomId 
        {
            get { return roomId; }
            set
            {
                roomId = value;
                OnPropertyChanged(nameof(RoomId));
            }
        }
        public int Floor
        {
            get { return floor; }
            set 
            {
                floor = value;
                OnPropertyChanged(nameof(Floor));
            }
        }   
        private RoomType roomType;
        public RoomType RoomType 
        {
            get { return roomType; }
            set
            {
                roomType = value;
                OnPropertyChanged(nameof(RoomType));
            }
        }
        public String RoomNumber 
        {
            get { return roomNumber; }
            set
            {
                roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }
        public Room(String roomId) { RoomId = roomId; }
        public Room() { }
        public override string Validate(string columName)
        {
            return "";
        }
        public override void InitExportList()
        {

        }
        public override string ToString()
        {
            return ID;
        }
    }
}
