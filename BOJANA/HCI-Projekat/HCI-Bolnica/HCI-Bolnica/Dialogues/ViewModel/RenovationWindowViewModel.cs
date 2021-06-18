using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.Model;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCIBolnica.CompositeComon;
using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class RenovationWindowViewModel : ViewModelBase
    {
        RenovationWindow renovationWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        private List<ComboData<Room>> rooms;
        private Renovation selectedItem = new Renovation();
        private RenovationViewModel renovationViewModel = new RenovationViewModel();
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now;
        public RenovationWindowViewModel(RenovationWindow renovationWindow, RenovationViewModel viewModel)
        {
            this.renovationWindow = renovationWindow;
            renovationViewModel = viewModel;
            LoadRooms();
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
            renovationWindow.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            
            foreach (Entity entity in ApplicationContext.Instance.Renovations)
            {
                Renovation renovation = entity as Renovation;

                DateTime date = DateTime.ParseExact(renovation.DateOfRenovationStart, "MM/dd/yyyy", null);

                DateTime start = DateTime.ParseExact(selectedItem.DateOfRenovationStart, "MM/dd/yyyy", null);
                DateTime end = DateTime.ParseExact(selectedItem.DateOfRenovationStart, "MM/dd/yyyy", null);

                if (date > start && date < end) 
                {
                    MessageBox.Show("Prostorija je zauzeta u izabranom periodu!");
                    return;
                }


            }
            ApplicationContext.Instance.Renovations.Add(selectedItem);
            ApplicationContext.Instance.Save();
            renovationWindow.Close();
            renovationViewModel.Initialize();
        }
        public bool CanOkCommandExecute()
        {
       
            
            if (string.IsNullOrWhiteSpace(SelectedItem.ID) || string.IsNullOrWhiteSpace(SelectedItem.DateOfRenovationStart) || string.IsNullOrWhiteSpace(SelectedItem.DateOfRenovationEnd))
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
