using HCI_Bolnica.Dialogues.ViewModel;
using HCI_Bolnica.Model;
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
    /// Interaction logic for EditEquipmentWindow.xaml
    /// </summary>
    public partial class EditEquipmentWindow : Window
    {
        public EditEquipmentWindow(HCI_Bolnica.Model.Equipment selectedItem)
        {
            InitializeComponent();
            DataContext =new EditEquipmentViewModel(this, selectedItem);
        }
    }
}
