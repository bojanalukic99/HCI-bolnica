using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCIBolnica.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        MainWindow mainWindow;
        private string password;
        private RelayCommand showManagerCommand;
        private User selectedItem = new User();
        private PasswordBox passwordBox;
        public MainWindowViewModel(MainWindow mainWindow, PasswordBox passwordBox)
        {
            this.mainWindow = mainWindow;
            this.passwordBox = passwordBox;
        }
        public string Password
        { 
            get  { return password; }
            set 
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public User SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        public RelayCommand ShowManagerCommand
        {
            get
            {
                return showManagerCommand ?? (showManagerCommand = new RelayCommand(param => ShowManagerCommandExecute()));
            }
        }
        public void ShowManagerCommandExecute()
        {
            foreach (User user in ApplicationContext.Instance.Users)
            {
                if (user.Username == SelectedItem.Username && user.Password == Password)
                {                 
                    ManagerWindow managerWindow = new ManagerWindow();
                    mainWindow.Close();
                    managerWindow.ShowDialog();
                    return;
                }                
            }
            MessageBox.Show("Korisnicko ime ili lozinka nisu dobro uneseni!");
        }        
    }
}
