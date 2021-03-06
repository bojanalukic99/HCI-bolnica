using HCI_Bolnica.Dialogues.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HCI_Bolnica.Dialogues.View
{
    /// <summary>
    /// Interaction logic for AddMedicineWindow.xaml
    /// </summary>
    public partial class AddMedicineWindow : Window
    {
        public AddMedicineWindow(MedicinePageViewModel medicinePageViewModel)
        {
            InitializeComponent();
            DataContext = new AddMedicineViewModel(this, medicinePageViewModel);
        }
    }
}
