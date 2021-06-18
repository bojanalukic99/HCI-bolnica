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
    public class AddRoomViewModel : ViewModelBase
    {
        AddRoomWindow addRoomWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        Room selectedItem = new Room();
        private List<ComboData<RoomType>> roomTypes = new List<ComboData<RoomType>>();
        RoomViewModel viewModel;
        
        public List<ComboData<RoomType>> RoomTypes
        { 
            get  { return roomTypes; }
            set 
            {
                roomTypes = value;
                OnPropertyChanged(nameof(RoomTypes));
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
        public AddRoomViewModel(AddRoomWindow addRoomWindow, RoomViewModel roomViewModel)
        {
            this.addRoomWindow = addRoomWindow;
            viewModel = roomViewModel;
            LoadRoomTypes();
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
            addRoomWindow.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            foreach (Room e in ApplicationContext.Instance.Rooms)
            {
                if (SelectedItem.ID == e.ID)
                {
                    MessageBox.Show("Soba sa ovim ID vec postoji!");
                    return;
                }
            }
            ApplicationContext.Instance.Rooms.Add(SelectedItem);
            ApplicationContext.Instance.Save();
            addRoomWindow.Close();
            viewModel.Initialize();
        }
        public bool CanOkCommandExecute()
        {
            if (string.IsNullOrWhiteSpace(SelectedItem.ID) ||  string.IsNullOrWhiteSpace(SelectedItem.Floor.ToString()) )
            {

                var s = SelectedItem.ID as string;
                var st = SelectedItem.Floor.ToString();
                Regex regex = new Regex(@"[\d]");
                int r;
                if (!regex.IsMatch(s) || !int.TryParse(st, out r) )
                { return false; }
                return false;
            }
            return true;
        }

        public void LoadRoomTypes()
        {
            List<ComboData<RoomType>> result = new List<ComboData<RoomType>>();


            result.Add(new ComboData<RoomType>() { Name ="Soba za pregled", Value = RoomType.SobaZaPregled });
            result.Add(new ComboData<RoomType>() { Name ="Operaciona", Value = RoomType.OperacionaSala });
            result.Add(new ComboData<RoomType>() { Name ="Soba za odmor", Value = RoomType.SobaZaOdmor });

            RoomTypes = result;
        }
    }
}
