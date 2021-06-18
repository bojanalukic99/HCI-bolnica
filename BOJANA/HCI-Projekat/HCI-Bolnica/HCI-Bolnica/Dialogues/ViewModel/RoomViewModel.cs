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
using System.Windows;
using System.Windows.Controls;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class RoomViewModel : ViewModelBase
    {
        RoomPage roomPage;
        private RelayCommand addRoomCommand;
        private RelayCommand editRoomCommand;
        private RelayCommand deleteRoomCommand;
        private RelayCommand equipmentCommand;
        ObservableCollection<Entity> rooms = new ObservableCollection<Entity>();
        Room selectedRoom = new Room();
        private Room selectedItem;
        private string searchTerm = string.Empty;
        public RoomViewModel()
        {
            Initialize();
        }
        
        public RoomViewModel(RoomPage roomPage, Room room)
        {
            this.roomPage = roomPage;
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

                SearchExecute();
            }
        }

        public Room SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public ObservableCollection<Entity> Rooms
        {
            get { return rooms; }
            set
            {
                rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }

        }
        public void Initialize()
        {
            Rooms = new ObservableCollection<Entity>(ApplicationContext.Instance.Rooms);
        }
        public RelayCommand AddRoomCommand
        {
            get { return addRoomCommand ?? (addRoomCommand = new RelayCommand(param => AddRoomCommandExecute(), param => CanAddRoomCommandExecute())); }
        }
        public RelayCommand EditRoomCommand
        {
            get { return editRoomCommand ?? (editRoomCommand = new RelayCommand(param => EditRoomCommandExecute(), param => CanEditRoomCommandExecute())); }
        }
        public RelayCommand DeleteRoomCommand
        {
            get { return deleteRoomCommand ?? (deleteRoomCommand = new RelayCommand(param => DeleteRoomCommandExecute(), param => CanDeleteRoomCommandExecute())); }
        }
       
        public RelayCommand EquipmentCommand
        {
            get { return equipmentCommand ?? (equipmentCommand = new RelayCommand(param => EquipmentCommadnExecute(), param => CanEquipmentCommentExecute())); }
        }
        public void EquipmentCommadnExecute() 
        {
            EquipmentInRoomWindow equipmentInRoomWindow = new EquipmentInRoomWindow(SelectedItem);
            equipmentInRoomWindow.ShowDialog();
        }
        public bool CanEquipmentCommentExecute() { return selectedItem != null; }
        
        public void AddRoomCommandExecute()
        {
            AddRoomWindow addRoomWindow = new AddRoomWindow(this);
            addRoomWindow.ShowDialog();
        }
        public bool CanAddRoomCommandExecute() { return true; }

        public void EditRoomCommandExecute()
        {
            EditRoomWindow editRoomWindow = new EditRoomWindow(selectedItem);
            editRoomWindow.ShowDialog();
        }
        public bool CanEditRoomCommandExecute() { return selectedItem!=null; }

        public void DeleteRoomCommandExecute()
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da zelite da obrisete prostoriju?", "Brisanje prostorije", MessageBoxButton.YesNo);

            if (result != MessageBoxResult.Yes)
            {
                return;
            }

            foreach (Room room in ApplicationContext.Instance.Rooms)
            {
                if (room.ID == selectedItem.ID)
                {
                    selectedItem = room;
                }
            }
            ApplicationContext.Instance.Rooms.Remove(selectedItem);
            ApplicationContext.Instance.Save();
            Initialize();
        }
        public bool CanDeleteRoomCommandExecute() { return SelectedItem!=null; }
        public void SearchExecute()
        {
            RoomRepository repository = new RoomRepository();

            Rooms = new ObservableCollection<Entity>(repository.SearchStatic(searchTerm));
        }

    }
}
