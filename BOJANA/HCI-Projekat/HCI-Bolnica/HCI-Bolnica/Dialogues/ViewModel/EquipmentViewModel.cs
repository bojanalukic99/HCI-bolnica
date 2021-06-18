using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCI_Bolnica.Repository;
using HCIBolnica.CompositeComon;
using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class EquipmentViewModel : ViewModelBase
    {
        View.Equipment equipment;
        private RelayCommand addEquipmentCommand;
        private RelayCommand editEquimpentCommand;
        private RelayCommand deleteEquipmentCommand;
        private RelayCommand addInRoomCommand;
        private int tabs;
        ObservableCollection<Entity> consumableEquipments = new ObservableCollection<Entity>();
        ObservableCollection<Entity> staticEquipments = new ObservableCollection<Entity>();
        private HCI_Bolnica.Model.Equipment selectedItem;
        private string searchTerm = string.Empty;

        public EquipmentViewModel(View.Equipment equipment)
        {
            this.equipment = equipment;
            InitializeStatic();
            InitializeConsumable();
        }
        public string SearchTerm
        {
            get { return searchTerm; }
            set
            {
                searchTerm = value;
                OnPropertyChanged(nameof(SearchTerm));

                SearchExecute();
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

        public int Tabs
        {
            get { return tabs; }
            set
            {
                tabs = value;
                OnPropertyChanged(nameof(Tabs));
            }
        }
        public ObservableCollection<Entity> ConsumableEquipments
        {
            get { return consumableEquipments; }
            set
            {
                consumableEquipments = value;
                OnPropertyChanged(nameof(ConsumableEquipments));
            }
        }
        public ObservableCollection<Entity> StaticEquipments
        {
            get { return staticEquipments; }
            set
            {
                staticEquipments = value;
                OnPropertyChanged(nameof(StaticEquipments));
            }
        }

        public void InitializeStatic()
        {
            StaticEquipments = new ObservableCollection<Entity>(ApplicationContext.Instance.EquipmentsStatic);
        }
        public void InitializeConsumable()
        {
            ConsumableEquipments = new ObservableCollection<Entity>(ApplicationContext.Instance.EquipmentsConsumable);
        }
        public RelayCommand AddEquipmentCommand
        {
            get { return addEquipmentCommand ?? (addEquipmentCommand = new RelayCommand(param => AddEquipmentCommandExecute(), param => CanAddEquipmentCommandExecute())); }
        }
        public RelayCommand EditEquipmentCommand
        {
            get { return editEquimpentCommand ?? (editEquimpentCommand = new RelayCommand(param => EditEquipmentCommandExecute(), param => CanEditEquipmentCommandExecute())); }
        }
        public RelayCommand DeleteEquipmentCommand
        {
            get { return deleteEquipmentCommand ?? (deleteEquipmentCommand = new RelayCommand(param => DeleteEquipmentCommandExecute(), param => CanDeleteEquipmentCommandExecute())); }
        }
        public RelayCommand AddInRoomCommand
        {
            get { return addInRoomCommand ?? (addInRoomCommand = new RelayCommand(param => AddInRoomCommandExecute(), param => CanAddInRoomCommandExecute())); }
        }
        public EquipmentType findEquipmentType()
        {
            if (Tabs == 0)
            {
                return EquipmentType.Static;
            }
            return EquipmentType.Consumable;
        }

        public void AddEquipmentCommandExecute()
        {
            AddEquipmentWindow addEquipmentWindow = new AddEquipmentWindow(findEquipmentType(), this);
            addEquipmentWindow.ShowDialog();
        }
        public bool CanAddEquipmentCommandExecute() { return true; }

        public void EditEquipmentCommandExecute()
        {
            EditEquipmentWindow editEquipmentWindow = new EditEquipmentWindow(selectedItem);
            editEquipmentWindow.ShowDialog();
        }
        public bool CanEditEquipmentCommandExecute() { return selectedItem != null; }

        public void DeleteEquipmentCommandExecute()
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da zelite da obrisete opremu?", "Brisanje opreme", MessageBoxButton.YesNo);

            if (result != MessageBoxResult.Yes)
            {
                return;
            }

            foreach (HCI_Bolnica.Model.Equipment equipment in ApplicationContext.Instance.EquipmentsStatic)
            {
                if (equipment.ID == selectedItem.ID)
                {
                    selectedItem = equipment;
                }
            }
            foreach (HCI_Bolnica.Model.Equipment equipment in ApplicationContext.Instance.EquipmentsConsumable)
            {
                if (equipment.ID == selectedItem.ID)
                {
                    selectedItem = equipment;
                }
            }
            ApplicationContext.Instance.EquipmentsConsumable.Remove(selectedItem);
            ApplicationContext.Instance.EquipmentsStatic.Remove(selectedItem);
            ApplicationContext.Instance.Save();
            InitializeConsumable();
            InitializeStatic();
        }
        public bool CanDeleteEquipmentCommandExecute() { return SelectedItem != null; }

        public void AddInRoomCommandExecute() { }
        public bool CanAddInRoomCommandExecute() { return true; }

        public void SearchExecute()
        {
            EquipmentRepository equipmentRepository = new EquipmentRepository();

            if (findEquipmentType() == EquipmentType.Static)
            {
                StaticEquipments = new ObservableCollection<Entity>(equipmentRepository.SearchStatic(searchTerm));
            }
            else
            {
                ConsumableEquipments = new ObservableCollection<Entity>(equipmentRepository.SearchDinamic(searchTerm));
            }
        }

    }
}
