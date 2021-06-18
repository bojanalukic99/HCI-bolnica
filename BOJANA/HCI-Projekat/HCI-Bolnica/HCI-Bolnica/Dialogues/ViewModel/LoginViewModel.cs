using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.View;
using HCIBolnica.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        LoginWindow loginWindow;
        private RelayCommand loginCommand;

        public LoginViewModel(LoginWindow loginWindow)
        {
            this.loginWindow = loginWindow;
        }
        public RelayCommand LoginCommand
        {
            get { return loginCommand ?? (loginCommand = new RelayCommand(param => LoginCommandExecute(), param => CanLoginCommandExecute())); }
        }
       

        public void LoginCommandExecute() { }
        public bool CanLoginCommandExecute() { return true; }

    }
}
