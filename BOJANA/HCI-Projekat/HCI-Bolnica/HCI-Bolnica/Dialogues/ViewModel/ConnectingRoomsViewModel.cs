using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.Model;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCIBolnica.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class ConnectingRoomsViewModel : ViewModelBase
    {
        ConnectingRoomsWindow connectingRoomsWindow;
        private RelayCommand okCommand;
        private RelayCommand cancelCommand;
        private Room selectedItemOne = new Room();
        private Room selectedItemTwo = new Room();
        private Renovation selectedItem = new Renovation();
        private List<ComboData<Room>> rooms;
        private RenovationViewModel viewModel = new RenovationViewModel();
   
        public ConnectingRoomsViewModel(ConnectingRoomsWindow connectingRoomsWindow, RenovationViewModel renovationViewModel)
        {
            SelectedItem.Room = new Room();
            LoadRooms();
            viewModel = renovationViewModel;
            this.connectingRoomsWindow = connectingRoomsWindow;
        }
        public Room SelectedItemOne
        {
            get { return selectedItemOne; }
            set
            {
                selectedItemOne = value;
                OnPropertyChanged(nameof(SelectedItemOne));
            }
        }
        public Renovation SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        public Room SelectedItemTwo
        {
            get { return selectedItemTwo; }
            set
            {
                selectedItemTwo = value;
                OnPropertyChanged(nameof(SelectedItemTwo));
            }
        }
        public List<ComboData<Room>> Rooms
        {
            get { return rooms; }
            set
            {
                rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }
        }
        public RelayCommand OkCommand
        {
            get { return okCommand ?? (okCommand = new RelayCommand(param => OkCommandExecute(), param => CanOkCommandExecute())); }
        }
        public RelayCommand CancelCommand
        {
            get { return cancelCommand ?? (cancelCommand = new RelayCommand(param => CancelCommandExecute(), param => CanCancelCommandExecute())); }
        }
        public void CancelCommandExecute()
        {
            connectingRoomsWindow.Close();
        }

        public bool CanCancelCommandExecute() { return true; }
        public void OkCommandExecute()
        {
            foreach (Room room in ApplicationContext.Instance.Rooms)
            {
                if (room.ID == selectedItemOne.ID)
                {
                    selectedItemOne = room;
                }
            }
            foreach (Room room in ApplicationContext.Instance.Rooms)
            {
                if (room.ID == selectedItemTwo.ID)
                {
                    selectedItemTwo = room;
                }
            }
            foreach (Room e in ApplicationContext.Instance.Rooms)
            {
                if (SelectedItem.Room.ID == e.ID)
                {
                    MessageBox.Show("Soba sa ovim ID vec postoji!");
                    return;
                }
            }
            SelectedItem.Room.Floor = SelectedItemOne.Floor;
            SelectedItem.Room.RoomType = SelectedItemOne.RoomType;
            ApplicationContext.Instance.Rooms.Remove(selectedItemOne);
            ApplicationContext.Instance.Rooms.Remove(selectedItemTwo);
            ApplicationContext.Instance.Rooms.Add(SelectedItem.Room);
            ApplicationContext.Instance.Renovations.Add(selectedItem);
            ApplicationContext.Instance.Save();
            connectingRoomsWindow.Close();
            viewModel.Initialize();
        }
        public bool CanOkCommandExecute()
        {
            if (string.IsNullOrWhiteSpace(SelectedItem.ID) || string.IsNullOrWhiteSpace(SelectedItem.DateOfRenovationStart) || string.IsNullOrWhiteSpace(SelectedItem.DateOfRenovationEnd))
            {

                var s = SelectedItem.ID as string;
               
                Regex regex = new Regex(@"[\d]");
                int r;
                if (!regex.IsMatch(s) )
                { return false; }

                var s1 = SelectedItem.DateOfRenovationStart as string;
                var s2 = SelectedItem.DateOfRenovationEnd as string;
                DateTime date = new DateTime();
                if (!DateTimeHelper.StringToDate(s1, out date) || !DateTimeHelper.StringToDate(s2, out date))
                {
                    return false;
                }
                return false;
            }
            return true;
        }

        public void LoadRooms()
        {
            List<ComboData<Room>> result = new List<ComboData<Room>>();

            foreach (Room room in ApplicationContext.Instance.Rooms)
            {
                result.Add(new ComboData<Room>() { Name = room.ID, Value = room });
            }
            Rooms = result;
        }
    }
}
