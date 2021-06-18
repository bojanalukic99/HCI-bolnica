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
    public class VacationViewModel :ViewModelBase
    {
        VacationPage vacationPage;
        private RelayCommand okCommand;
        public VacationViewModel(VacationPage vacationPage)
        {
            this.vacationPage = vacationPage;
        }
        public RelayCommand OkCommand
        {
            get { return okCommand ?? (okCommand = new RelayCommand(param => OkCommandExecute(), param => CanOkCommandExecute())); }
        }


        public void OkCommandExecute()
        {
           
        }
        public bool CanOkCommandExecute() { return true; }
    }
}
