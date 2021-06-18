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

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class MedicinePageViewModel : ViewModelBase
    {
        MedicinePage medicinePage;
        private RelayCommand addMedicineCommand;
        private RelayCommand editMedicineCommand;
        private RelayCommand deleteMedicineCommand;
        ObservableCollection<Entity> medicines = new ObservableCollection<Entity>();
         ObservableCollection<Entity> medicinesApproved = new ObservableCollection<Entity>();

        private Medicine selectedItem;
        private string searchTerm = string.Empty;

        public MedicinePageViewModel()
        {
            Initialize();
            InitializeMedicinesApproved();
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

        public Medicine SelectedItem 
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged(nameof(SelectedItem)); }
        }

        public ObservableCollection<Entity> Medicines
        {
            get { return medicines; }
            set
            {
                medicines = value;
                OnPropertyChanged(nameof(Medicines));
            }
        }
        public ObservableCollection<Entity> MedicinesApproved
        {
            get { return medicinesApproved; }
            set
            {
                medicinesApproved = value;
                OnPropertyChanged(nameof(MedicinesApproved));
            }
        }
        
        public void Initialize()
        {
            Medicines = new ObservableCollection<Entity>(ApplicationContext.Instance.Medicines);
        }
        public void InitializeMedicinesApproved()
        {
            MedicinesApproved = new ObservableCollection<Entity>(ApplicationContext.Instance.MedicinesApproved);
            
        }
        public MedicinePageViewModel(MedicinePage medicinePage)
        {
            this.medicinePage = medicinePage;
            Initialize();
            InitializeMedicinesApproved();
        }
        public RelayCommand AddMedicineCommand
        {
            get { return addMedicineCommand ?? (addMedicineCommand = new RelayCommand(param => AddMedicineCommandExecute(), param => CanAddMedicineCommandExecute())); }
        }
        public RelayCommand EditMedicineCommand
        {
            get { return editMedicineCommand ?? (editMedicineCommand = new RelayCommand(param => EditMedicineCommandExecute(), param => CanEditMedicineCommandExecute())); }
        }
        public RelayCommand DeleteMedicineCommand
        {
            get { return deleteMedicineCommand ?? (deleteMedicineCommand = new RelayCommand(param => DeleteMedicineCommandExecute(), param => CanDeleteMedicinetCommandExecute())); }
        }

        public void AddMedicineCommandExecute()
        {
            AddMedicineWindow addMedicineWindow = new AddMedicineWindow(this);
            addMedicineWindow.ShowDialog();
        }
        public bool CanAddMedicineCommandExecute() { return true; }

        public void EditMedicineCommandExecute()
        {
            EditMedicineWindow editMedicineWindow = new EditMedicineWindow(selectedItem,this);
            editMedicineWindow.ShowDialog();
        }
        public bool CanEditMedicineCommandExecute() { return SelectedItem != null; }

        public void DeleteMedicineCommandExecute()
        {
           MessageBoxResult result =  MessageBox.Show("Da li ste sigurni da zelite da obrisete lek?", "Brisanje leka", MessageBoxButton.YesNo);

            if (result != MessageBoxResult.Yes) 
            {
                return;
            }

            foreach (Medicine medicine in ApplicationContext.Instance.Medicines)
            {
                if (medicine.ID == selectedItem.ID)
                {
                    selectedItem = medicine;
                }
            }
            ApplicationContext.Instance.Medicines.Remove(selectedItem);
            ApplicationContext.Instance.Save();
            Initialize();
        }
        public bool CanDeleteMedicinetCommandExecute() { return SelectedItem != null; }

        public void SearchExecute() 
        {
            MedicineRepository repository = new MedicineRepository();

            Medicines = new ObservableCollection<Entity>(repository.SearchStatic(searchTerm));
        }

    }
}
