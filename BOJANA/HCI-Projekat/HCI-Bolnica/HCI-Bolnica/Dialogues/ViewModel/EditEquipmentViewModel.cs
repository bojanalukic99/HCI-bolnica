using HCI_Bolnica.CompositeComon;
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
    public class EditEquipmentViewModel : ViewModelBase
    {
        EditEquipmentWindow editEquipmentWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        private HCI_Bolnica.Model.Equipment selectedItem;

        public EditEquipmentViewModel(EditEquipmentWindow editEquipmentWindow, HCI_Bolnica.Model.Equipment selectedMedicine)
        {
            this.editEquipmentWindow = editEquipmentWindow;
            selectedItem = selectedMedicine;
        }

        public HCI_Bolnica.Model.Equipment SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged(nameof(SelectedItem)); }
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
            editEquipmentWindow.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            ApplicationContext.Instance.Save();
            editEquipmentWindow.Close();

        }
        public bool CanOkCommandExecute()
        {
            if ( string.IsNullOrWhiteSpace(SelectedItem.Quantity) || string.IsNullOrWhiteSpace(SelectedItem.EquipmentName) || string.IsNullOrWhiteSpace(SelectedItem.Manufacturer))
            {

                var s = SelectedItem.Quantity as string;
                var s1 = SelectedItem.EquipmentName as string;
                var s2 = SelectedItem.Manufacturer as string;
                Regex regex = new Regex(@"[\d]");
                int r;
                if (!regex.IsMatch(s) || !regex.IsMatch(s1) || !regex.IsMatch(s2) )
                { return false; }
                return false;
            }
            return true;
        }


    }
}
