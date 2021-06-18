using HCI_Bolnica.CompositeComon;
using HCI_Bolnica.Dialogues.Model;
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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using System.Diagnostics;

namespace HCI_Bolnica.Dialogues.ViewModel
{
    public class RenovationViewModel : ViewModelBase
    {
        RenovationPage renovationPage;
        private RelayCommand renovationCommand;
        private RelayCommand divideRoomCommand;
        private RelayCommand connetingRoomsCommand;
        private RelayCommand searchCommand;
        private RelayCommand reportCommand;
        ObservableCollection<Entity> renovations = new ObservableCollection<Entity>();
        private DateTime starOfRenovation = DateTime.Now;
        private DateTime endOfRenovation = DateTime.Now;

        public RenovationViewModel()
        {
            Initialize();
        }
        public RenovationViewModel(RenovationPage renovationPage)
        {
            this.renovationPage = renovationPage;
            Initialize();
        }
        public DateTime StartOfRenovation
        {
            get { return starOfRenovation; }
            set
            {
                starOfRenovation = value;
                OnPropertyChanged(nameof(starOfRenovation));
            }
        }
        public DateTime EndOfRenovation
        {
            get { return endOfRenovation; }
            set
            {
                endOfRenovation = value;
                OnPropertyChanged(nameof(EndOfRenovation));
            }
        }
        public ObservableCollection<Entity> Renovations
        {
            get { return renovations; }
            set
            {
                renovations = value;
                OnPropertyChanged(nameof(Renovations));
            }
        }
        public RelayCommand ReportCommand
        {
            get { return reportCommand ?? (reportCommand = new RelayCommand(param => ReportCommandExecute(), param => CanReportCommandExecute())); }
           
        }
        public RelayCommand RenovationCommand
        {
            get { return renovationCommand ?? (renovationCommand = new RelayCommand(param => RenovationCommandExecute(), param => CanRenovationCommandExecute())); }

        }
        public RelayCommand ConnectingRoomsCommand
        {
            get { return connetingRoomsCommand ?? (connetingRoomsCommand = new RelayCommand(param => ConnectingRoomsExecute(), param => CanConnectingRoomsExecute())); }
        }
        public RelayCommand DivideTheRoomCommand
        {
            get { return divideRoomCommand ?? (divideRoomCommand = new RelayCommand(param => DivideTheRoomCommandExecute(), param => CanDivideTheRoomCommandExecute())); }
        }
        public RelayCommand SearchCommand
        {
            get { return searchCommand ?? (searchCommand = new RelayCommand(param => SearchCommandExecute(), param => CanSearchCommandExecute())); }
        }
        public void DivideTheRoomCommandExecute()
        {
            DivideTheRoom divideTheRoom = new DivideTheRoom(this);
            divideTheRoom.ShowDialog();
        }
        public bool CanDivideTheRoomCommandExecute()
        {
            return true;
        }

        public void ConnectingRoomsExecute()
        {
            ConnectingRoomsWindow connectingRoomsWindow = new ConnectingRoomsWindow(this);
            connectingRoomsWindow.ShowDialog();
        }
        public bool CanConnectingRoomsExecute() { return true; }
        public void Initialize()
        {
            Renovations = new ObservableCollection<Entity>(ApplicationContext.Instance.Renovations);
        }
        public void RenovationCommandExecute()
        {
            RenovationWindow renovationWindow = new RenovationWindow(this);
            renovationWindow.ShowDialog();
        }
        public bool CanRenovationCommandExecute() { return true; }
        public void SearchCommandExecute()
        {
            RenovationRepository repository = new RenovationRepository();          
            Renovations = new ObservableCollection<Entity>(repository.SearchRenovation(starOfRenovation, endOfRenovation));
        }
        public bool CanSearchCommandExecute()
        {
            return true;
        }
        public void ReportCommandExecute()
        {

            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter(@"C:\Users\ljubi\Desktop\reports\demoBojana.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Report")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);

            Table table = new Table(3, false);

            table.AddCell(new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Broj sobe")));

            table.AddCell(new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)

               .Add(new Paragraph("Datum pocetka")));

            table.AddCell(new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Datum kraja")));


            foreach (Renovation renovation in Renovations)
            {
                table.AddCell(new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(renovation.Room.ID)));

                table.AddCell(new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(renovation.DateOfRenovationStart)));

                table.AddCell(new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(renovation.DateOfRenovationEnd)));
            }

            document.Add(table);

            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "acroRd32.exe"; //not the full application path
            myProcess.StartInfo.Arguments = "/A \"page=2=OpenActions\" C:\\Users\\ljubi\\Desktop\\reports\\demoBojana.pdf";
            myProcess.Start();

            document.Close();
        }
        public bool CanReportCommandExecute() { return true; }
    }
}
