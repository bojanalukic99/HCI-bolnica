using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.Model;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCIBolnica.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    class EditRoomViewModel : ViewModelBase
    {
        EditRoomWindow editRoomWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        private List<ComboData<RoomType>> roomTypes;
        private Room selectedItem;

        public EditRoomViewModel(EditRoomWindow editRoomWindow, Room room)
        {
            this.editRoomWindow = editRoomWindow;
            LoadRoomTypes();
            selectedItem = room;
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
        public List<ComboData<RoomType>> RoomTypes
        {

            get { return roomTypes; }
            set
            {
                roomTypes = value;
                OnPropertyChanged(nameof(RoomTypes));
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

        public void CancelCommandExecute() { }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            ApplicationContext.Instance.Save();
            editRoomWindow.Close();
        }
        public bool CanOkCommandExecute() { return true; }

        public void LoadRoomTypes()
        {
            List<ComboData<RoomType>> result = new List<ComboData<RoomType>>();

            result.Add(new ComboData<RoomType>() { Name = "Soba za pregled", Value = RoomType.SobaZaPregled });
            result.Add(new ComboData<RoomType>() { Name = "Operaciona", Value = RoomType.OperacionaSala });
            result.Add(new ComboData<RoomType>() { Name = "Soba za odmor", Value = RoomType.SobaZaOdmor });

            RoomTypes = result;
        }
    }
}
