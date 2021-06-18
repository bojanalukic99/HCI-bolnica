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
    public class EditMedicineViewModel : ViewModelBase
    {
        EditMedicineWindow editMedicineWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        private Medicine selectedItem;
        MedicinePageViewModel medicinePage;

        public EditMedicineViewModel(EditMedicineWindow editMedicineWindow, Medicine selectedMedicine, MedicinePageViewModel medicinePageViewModel)
        {
            this.editMedicineWindow = editMedicineWindow;
            selectedItem = selectedMedicine;
            medicinePage = medicinePageViewModel;
        }

        public Medicine SelectedItem
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
            editMedicineWindow.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            ApplicationContext.Instance.Save();
            editMedicineWindow.Close();
            medicinePage.Initialize();
        }
        public bool CanOkCommandExecute()
        {
            if (string.IsNullOrWhiteSpace(SelectedItem.ID) || string.IsNullOrWhiteSpace(SelectedItem.Name) || string.IsNullOrWhiteSpace(SelectedItem.Grams) || string.IsNullOrWhiteSpace(SelectedItem.Replacment) || string.IsNullOrWhiteSpace(SelectedItem.Composition))
            {

                var s = SelectedItem.ID as string;
                var st = SelectedItem.Grams as string;
                var str = SelectedItem.Name as string;
                var s1 = SelectedItem.Replacment as string;
                var s2 = SelectedItem.Composition as string;
                Regex regex = new Regex(@"[\d]");
                int r;
                if (!regex.IsMatch(s) || !int.TryParse(st, out r) || Regex.IsMatch(str, @"^[a-zA-Z]+$") || Regex.IsMatch(s1, @"^[a-zA-Z]+$") || Regex.IsMatch(s2, @"^[a-zA-Z]+$"))
                { return false; }
                return false;
            }
            return true;
        }
    }
}
