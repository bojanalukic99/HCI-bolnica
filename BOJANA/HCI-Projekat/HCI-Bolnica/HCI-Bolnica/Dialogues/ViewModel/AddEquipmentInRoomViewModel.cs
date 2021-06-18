using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.Model;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCI_Bolnica.Repository;
using HCIBolnica.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class AddEquipmentInRoomViewModel : ViewModelBase
    {
        AddEquipmentInRoomWindow addEquipmentInRoomWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        HCI_Bolnica.Model.Equipment selectedItem = new HCI_Bolnica.Model.Equipment();
        private List<ComboData<HCI_Bolnica.Model.Equipment>> equipments;
        private EquipmentRepository equipmentRepository = new EquipmentRepository();
        private EquipmentDisplayViewModel viewModel = new EquipmentDisplayViewModel();

        public AddEquipmentInRoomViewModel()
        {
            LoadEquipment();
        }
        public AddEquipmentInRoomViewModel(AddEquipmentInRoomWindow addEquipmentInRoomWindow,EquipmentDisplayViewModel equipmentsViewModel)
        {
            this.addEquipmentInRoomWindow = addEquipmentInRoomWindow;
            viewModel = equipmentsViewModel;
            LoadEquipment();
        }
        public EquipmentDisplayViewModel ViewModel
        {
            get { return viewModel; }
            set
            {
                viewModel = value;
                OnPropertyChanged(nameof(ViewModel));
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
        public List<ComboData<HCI_Bolnica.Model.Equipment>> Equpiments
        {
            get { return equipments; }
            set
            {
                equipments = value;
                OnPropertyChanged(nameof(Equpiments));
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
            addEquipmentInRoomWindow.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            viewModel.Equipments.Add(selectedItem);
            addEquipmentInRoomWindow.Close();
            
        }
        public bool CanOkCommandExecute() 
        {
            if (string.IsNullOrWhiteSpace(SelectedItem.Quantity))
            {
                
                var st = SelectedItem.Quantity as string;
                Regex regex = new Regex(@"[\d]");
                int r;
                if (int.TryParse(st, out r))
                { return false; }
                return false;
            }
            return true;
        }
        public void LoadEquipment()
        {
            List<ComboData<HCI_Bolnica.Model.Equipment>> result = new List<ComboData<HCI_Bolnica.Model.Equipment>>();
            foreach (HCI_Bolnica.Model.Equipment equipment in equipmentRepository.GetAll())
            {
                result.Add(new ComboData<HCI_Bolnica.Model.Equipment>() { Name = equipment.EquipmentName , Value = equipment });
            }
            Equpiments = result;
        }

    }
}
