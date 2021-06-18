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
    public class EditEquipmentInRoomViewModel : ViewModelBase
    {
        EditEquipmentInRoomWindow editEquipmentInRoomWindow;
        private RelayCommand cancelCommand;
        private RelayCommand okCommand;
        private List<ComboData<HCI_Bolnica.Model.Equipment>> equipments = new List<ComboData<HCI_Bolnica.Model.Equipment>>();
        private HCI_Bolnica.Model.Equipment selectedItem;

        

        public EditEquipmentInRoomViewModel(EditEquipmentInRoomWindow editEquipmentInRoomWindow, HCI_Bolnica.Model.Equipment equipment)
        {
            this.editEquipmentInRoomWindow = editEquipmentInRoomWindow;
            selectedItem = equipment;
            LoadEquipments();
        }
        public List<ComboData<HCI_Bolnica.Model.Equipment>> Equipments
        {
            get { return equipments; }
            set
            {
                equipments = value;
                OnPropertyChanged(nameof(Equipments));
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
        public void LoadEquipments()
        {
            List<ComboData<HCI_Bolnica.Model.Equipment>> result = new List<ComboData<HCI_Bolnica.Model.Equipment>>();

            foreach (HCI_Bolnica.Model.Equipment equipment in ApplicationContext.Instance.EquipmentsStatic)
            {
                result.Add(new ComboData<HCI_Bolnica.Model.Equipment>() { Name = equipment.EquipmentName, Value = equipment });
            }
            foreach(HCI_Bolnica.Model.Equipment equipment1 in ApplicationContext.Instance.EquipmentsConsumable)
            {
                result.Add(new ComboData<HCI_Bolnica.Model.Equipment>() { Name = equipment1.EquipmentName, Value = equipment1 });
            }
            Equipments = result;
        }
        public void CancelCommandExecute()
        {
            editEquipmentInRoomWindow.Close();
        }
        public bool CanCancelCommandExecute() { return true; }

        public void OKCommandExecute()
        {
            ApplicationContext.Instance.Save();
            editEquipmentInRoomWindow.Close();
        }
        public bool CanOkCommandExecute()
        {
            return true;
        }

    }
}
