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

namespace HCI_Bolnica.Dialogues.ViewModel
{
   public class DivideTheRoomViewModel : ViewModelBase
    {
        DivideTheRoom divideTheRoom;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        private List<ComboData<Room>> rooms;
        private Room selectedRoom = new Room();
        private Renovation selectedItem = new Renovation();
        private RenovationViewModel viewModel = new RenovationViewModel();
        public DivideTheRoomViewModel(DivideTheRoom divideTheRoom, RenovationViewModel renovationViewModel)
        {
            this.divideTheRoom = divideTheRoom;
            viewModel = renovationViewModel;
            LoadRooms();
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
        public Renovation SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
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
        public RelayCommand CancelCommand
        {
            get { return cancelCommand ?? (cancelCommand = new RelayCommand(param => CancelCommandExecute(), param => CanCancelCommandExecute())); }
        }
        public RelayCommand OkCommand
        {
            get { return okCommand ?? (okCommand = new RelayCommand(param => OKCommandExecute(), param => CanOkCommandExecute())); }
        }

        public void CancelCommandExecute()
        {
            divideTheRoom.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            SelectedRoom.Floor = SelectedItem.Room.Floor;
            SelectedRoom.RoomType = SelectedItem.Room.RoomType;
            ApplicationContext.Instance.Rooms.Add(selectedRoom);
            ApplicationContext.Instance.Renovations.Add(selectedItem);
            ApplicationContext.Instance.Save();
            divideTheRoom.Close();
            viewModel.Initialize();
        }
        public bool CanOkCommandExecute()
        {
            if (string.IsNullOrWhiteSpace(SelectedRoom.ID) || string.IsNullOrWhiteSpace(SelectedItem.DateOfRenovationStart) || string.IsNullOrWhiteSpace(SelectedItem.DateOfRenovationEnd))
            {

                var s = SelectedItem.ID as string;

                Regex regex = new Regex(@"[\d]");
                int r;
                if (!regex.IsMatch(s))
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
