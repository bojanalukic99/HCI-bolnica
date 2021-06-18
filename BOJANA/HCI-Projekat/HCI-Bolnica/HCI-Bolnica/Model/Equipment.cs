using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
   public class Equipment : Entity
    {
        private String equipmentName;
        private EquipmentType equipmentType;
        private String quantity;
        private String manufacturer;
        private bool isStatic;
        private Room room;
        public Room Room
        {
            get { return room; }
            set
            {
                room = value;
                OnPropertyChanged(nameof(Room));
            }
        }
        public bool IsStatic
        {
            get { return isStatic; }
            set 
            {
                isStatic = value;
                OnPropertyChanged(nameof(IsStatic));
            }
        }
        public String Manufacturer 
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }
        public String EquipmentName
        {
            get { return equipmentName; }
            set
            {
                equipmentName = value;
                OnPropertyChanged(nameof(EquipmentName));
            }
        }
        public EquipmentType EquipmentType
        {
            get { return equipmentType; }
            set 
            {
                equipmentType = value;
                OnPropertyChanged(nameof(EquipmentType));
            }
        }
        public String Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public Equipment(){ }

        public Equipment(String name, EquipmentType equipmentType, String quantity, String manufacturer)
        {
            EquipmentName = name;
            EquipmentType = equipmentType;
            Quantity = quantity;
            Manufacturer = manufacturer;
        }
        public override string ToString()
        {
            return EquipmentName;
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
