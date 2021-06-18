using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.View;
using HCI_Bolnica.Model;
using HCIBolnica.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class WizardViewModel : ViewModelBase
    {
        private WizardWindow window;
        private RelayCommand nextCommand;
        private RelayCommand cancelCommand;
        private string selectedText;
        private WizardSteps wizardSteps;
        private string image = string.Empty;

        public WizardViewModel(WizardWindow wizardWindow)
        {
            window = wizardWindow;
            wizardSteps = WizardSteps.Step1;
            SelectedText = "Ukoliko želite da dodate opremu u prostoriju potrebno je prvo da pritisnete na dugme PROSTORIJE!";
            Image = @"C:\Users\ljubi\Desktop\HCI-Projekat\HCI-Bolnica\HCI-Bolnica\Pictures\step1.png";
        }
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public string SelectedText
        {
            get { return selectedText; }
            set
            {
                selectedText = value;
                OnPropertyChanged(nameof(SelectedText));
            }
        }
        public RelayCommand NextCommand
        {
            get { return nextCommand ?? (nextCommand = new RelayCommand(param => NextCommandExecute(), param => CanNextCommandExecute())); }
        }
        public RelayCommand CancelCommand
        {
            get { return cancelCommand ?? (cancelCommand = new RelayCommand(param => CancelCommandExecute(), param => CanCancelCommandExecute())); }
        }
        public void NextCommandExecute()
        {
            if (wizardSteps == WizardSteps.Step1)
            {
                SelectedText = "Zatim je potrebno da da selektujete prostoriju(1) u koju želite da dodate opmremu i pritisnete na dugme OPREMA(2)!";
                Image = @"C:\Users\ljubi\Desktop\HCI-Projekat\HCI-Bolnica\HCI-Bolnica\Pictures\step2.png";
                wizardSteps = WizardSteps.Step2;
            }
            else if (wizardSteps == WizardSteps.Step2)
            {
                SelectedText = "Zatim je potrebno da pritisnete na dugme DODAJ!";
                Image = @"C:\Users\ljubi\Desktop\HCI-Projekat\HCI-Bolnica\HCI-Bolnica\Pictures\step3.png";
                wizardSteps = WizardSteps.Step3;
            }
            else if (wizardSteps == WizardSteps.Step3)
            {
                SelectedText = "Nakon što Vam se prikaže prozor za dodavanje opreme, potrebno je da izaberete(1) opremu i količinu koji želite da dodate i pritisnete na dugme DODAJ(2)!";
                Image = @"C:\Users\ljubi\Desktop\HCI-Projekat\HCI-Bolnica\HCI-Bolnica\Pictures\step4.png";
                wizardSteps = WizardSteps.Step4;
            }
            else
            {
                window.Close();
            }

            
        }
        public bool CanNextCommandExecute() { return true; }
        public void CancelCommandExecute()
        {
            window.Close();
        }
        public bool CanCancelCommandExecute() { return true; }
    }
}
