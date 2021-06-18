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
    public class HomePageViewModel : ViewModelBase
    {
        HomePage homePage;
        private RelayCommand wizardCommand;
        public HomePageViewModel(HomePage homePage)
        {
            this.homePage = homePage;
        }
        public RelayCommand WizardCommand
        {
            get { return wizardCommand ?? (wizardCommand = new RelayCommand(param => WizardCommandExecute(), param => CanWizardCommandExecute())); }
        }
        public void WizardCommandExecute()
        {
            WizardWindow wizardWindow = new WizardWindow();
            wizardWindow.ShowDialog();
        }
        public bool CanWizardCommandExecute()
        { return true; }
    }
}
