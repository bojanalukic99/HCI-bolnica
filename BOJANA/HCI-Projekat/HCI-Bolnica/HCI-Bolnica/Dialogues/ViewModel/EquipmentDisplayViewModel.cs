using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCI_Bolnica.Repository;
using HCIBolnica.CompositeComon;
using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class EquipmentDisplayViewModel : ViewModelBase
    {
        EquipmentInRoomWindow equipmentInRoom;
        private RelayCommand addCommand;
        private RelayCommand editCommand;
        private RelayCommand deleteCommand;
        private RelayCommand closeCommand;
        ObservableCollection<HCI_Bolnica.Model.Equipment> equipments = new ObservableCollection<HCI_Bolnica.Model.Equipment>();
        private HCI_Bolnica.Model.Equipment selectedItem;
        private Room selectedRoom = new Room();
        private string searchTerm = string.Empty;
        private EquipmentRepository equipmentRepository = new EquipmentRepository();
        public EquipmentDisplayViewModel()
        {
            Initialize();
        }
        public EquipmentDisplayViewModel(EquipmentInRoomWindow equipmentInRoom, Room room)
        {
            this.equipmentInRoom = equipmentInRoom;
            selectedRoom = room;
            Initialize();
        }
        public string SearchTerm
        {
            get { return searchTerm; }
            set
            {
                searchTerm = value;
                OnPropertyChanged(nameof(SearchTerm));


            }
        }
        public ObservableCollection<HCI_Bolnica.Model.Equipment> Equipments
        {
            get { return equipments; }
            set
            {
                equipments = value;
                OnPropertyChanged(nameof(Equipments));
            }
        }
        public HCI_Bolnica.Model.Equipment SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        public Room SelectedRoom
        {
            get { return selectedRoom; }
            set
            {
                selectedRoom = value;
                OnPropertyChanged(nameof(SelectedRoom));

            }
        }
        public void Initialize()
        {
            Equipments = new ObservableCollection<HCI_Bolnica.Model.Equipment>(equipmentRepository.FilterByRoom(SelectedRoom.ID));
        }
        public RelayCommand CloseCommand
        { 
            get { return closeCommand ?? (closeCommand = new RelayCommand(param => CloseCommandExecute(), param => CanCloseCommandExecute())); }
        }
        public RelayCommand AddCommand
        {
            get { return addCommand ?? (addCommand = new RelayCommand(param => AddCommandExecute(), param => CanAddCommandExecute())); }
        }
        public RelayCommand EditCommand
        {
            get { return editCommand ?? (editCommand = new RelayCommand(param => EditCommandExecute(), param => CanEditCommandExecute())); }
        }
        public RelayCommand DeleteCommand
        {
            get { return deleteCommand ?? (deleteCommand = new RelayCommand(param => DeleteCommandExecute(), param => CanDeleteCommandExecute())); }
        }
        public void CloseCommandExecute()
        {
            equipmentInRoom.Close();
        }
        public bool CanCloseCommandExecute() { return true; }
        public void AddCommandExecute()
        {
            AddEquipmentInRoomWindow equipmentInRoomWindow = new AddEquipmentInRoomWindow(this);
            equipmentInRoomWindow.ShowDialog();
        }
        public bool CanAddCommandExecute() { return true; }

        public void EditCommandExecute()
        {
            EditEquipmentInRoomWindow equipmentInRoomWindow = new EditEquipmentInRoomWindow(selectedItem);
            equipmentInRoomWindow.ShowDialog();
        }
        public bool CanEditCommandExecute() { return true; }
        public void DeleteCommandExecute()
        {
            Equipments.Remove(selectedItem);
        }
        public bool CanDeleteCommandExecute() { return true; }
       
    }
}
