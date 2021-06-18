using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.View;
using HCIBolnica.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class ManagerViewModel : ViewModelBase
    {
        ManagerWindow managerWindow;
        Frame frame;
        private RelayCommand roomCommand;
        private RelayCommand renovationCommand;
        private RelayCommand medicineCommand;
        private RelayCommand equipmentCommand;
        private RelayCommand staffCommand;
        private RelayCommand workHourCommand;
        private RelayCommand vacationCommand;
        private RelayCommand logoutCommand;
        private RelayCommand homeCommand;


        public ManagerViewModel(ManagerWindow managerWindow, Frame mainFrame)
        {
            this.managerWindow = managerWindow;
            frame = mainFrame;
            HomePage homePage = new HomePage();
            frame.Content = homePage;
        }
        public RelayCommand HomeCommand
        {
            get { return homeCommand ?? (homeCommand = new RelayCommand(param => HomeCommandExecute(), param => CanHomeCommandExecute())); }
        }
        public RelayCommand RoomCommand
        {
            get { return roomCommand ?? (roomCommand = new RelayCommand(param => RoomCommandExecute(), param => CanRoomCommandExecute())); }
        }
        public RelayCommand RenovationCommand
        {
            get { return renovationCommand ?? (renovationCommand = new RelayCommand(param => RenovationCommandExecute(), param => CanRenovationCommandExecute())); }
        }
        public RelayCommand MedicineCommand
        {
            get { return medicineCommand ?? (medicineCommand = new RelayCommand(param => MedicineCommandExecute(), param => CanMedicineCommandExecute())); }
        }
        public RelayCommand EquipmentCommand
        {
            get { return equipmentCommand ?? (equipmentCommand = new RelayCommand(param => EquipmentCommandExecute(), param => CanEquipmentCommandExecute())); }
        }
     
        public RelayCommand VacationCommand
        {
            get { return vacationCommand ?? (vacationCommand = new RelayCommand(param => VacationCommandExecute(), param => CanVacationCommandExecute())); }
        }
        public RelayCommand LogoutCommand
        {
            get { return logoutCommand ?? (logoutCommand = new RelayCommand(param => LogoutCommandExecute(), param => CanLogoutCommandExecute())); }
        }
        public void LogoutCommandExecute()
        {
            MainWindow mainWindow = new MainWindow();
            managerWindow.Close();
            mainWindow.ShowDialog();
        }
        public bool CanLogoutCommandExecute() { return true; }
        public void HomeCommandExecute()
        {
            HomePage homePage = new HomePage();
            frame.Content = homePage;
        }
        public bool CanHomeCommandExecute() { return true; }
        public void VacationCommandExecute()
        {
            VacationPage vacationPage = new VacationPage();
            frame.Content = vacationPage;
        }
        public bool CanVacationCommandExecute() { return true; }        
       
        public bool CanStaffCommandExecute() { return true; }
        public void EquipmentCommandExecute()
        {
            Equipment equipment = new Equipment();
            frame.Content = equipment;
        }
        public bool CanEquipmentCommandExecute() { return true; }
        public void MedicineCommandExecute() 
        {
            MedicinePage medicinePage = new MedicinePage();
            frame.Content = medicinePage;
        }
        public bool CanMedicineCommandExecute() { return true; }
        public void RenovationCommandExecute() 
        {
            RenovationPage renovationPage = new RenovationPage();
            frame.Content = renovationPage;
        }
        public bool CanRenovationCommandExecute() { return true; }
        public void RoomCommandExecute() 
        {
            RoomPage roomPage = new RoomPage();
            frame.Content = roomPage;
        }
        public bool CanRoomCommandExecute() { return true; }

    }
}
