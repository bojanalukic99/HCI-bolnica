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
using System.Windows;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class AddEquipmentViewModel : ViewModelBase
    {
        AddEquipmentWindow addEquipmentWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        private EquipmentType equipmentType;
        HCI_Bolnica.Model.Equipment selectedItem = new HCI_Bolnica.Model.Equipment();
        EquipmentViewModel viewModel;

        public AddEquipmentViewModel(AddEquipmentWindow addEquipmentWindow, EquipmentType typeOfEquipment, EquipmentViewModel equipmentViewModel)
        {
            this.addEquipmentWindow = addEquipmentWindow;
            equipmentType = typeOfEquipment;
            viewModel = equipmentViewModel;
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
        public HCI_Bolnica.Model.Equipment SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
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
            addEquipmentWindow.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            foreach (HCI_Bolnica.Model.Equipment e in ApplicationContext.Instance.EquipmentsStatic)
            {
                if (SelectedItem.ID == e.ID)
                {
                    MessageBox.Show("Oprema sa ovim ID vec postoji!");
                    return;
                }
            }
            if (equipmentType == EquipmentType.Static)
            {
                ApplicationContext.Instance.EquipmentsStatic.Add(SelectedItem);
                ApplicationContext.Instance.Save();
                addEquipmentWindow.Close();
                viewModel.InitializeStatic();
            }
            else
            {
                ApplicationContext.Instance.EquipmentsConsumable.Add(SelectedItem);
                ApplicationContext.Instance.Save();
                addEquipmentWindow.Close();
                viewModel.InitializeConsumable();
            }
        }
        public bool CanOkCommandExecute()
        {
            if (string.IsNullOrWhiteSpace(SelectedItem.ID) || string.IsNullOrWhiteSpace(SelectedItem.EquipmentName) || string.IsNullOrWhiteSpace(SelectedItem.Quantity) || string.IsNullOrWhiteSpace(SelectedItem.Manufacturer))
            {
                
                var s = SelectedItem.ID as string;
                var st = SelectedItem.Quantity as string;
                Regex regex = new Regex(@"[\d]");
                int r;
                if (!regex.IsMatch(s) || !int.TryParse(st, out r) || Regex.IsMatch(SelectedItem.EquipmentName, @"^[a-zA-Z]+$"))
                { return false; }
                return false;
            }
            
            return true; 
        }

    }
}
