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
    /// Interaction logic for AddEquipmentInRoomWindow.xaml
    /// </summary>
    public partial class AddEquipmentInRoomWindow : Window
    {
        public AddEquipmentInRoomWindow(EquipmentDisplayViewModel equipment)
        {
            InitializeComponent();
            DataContext = new AddEquipmentInRoomViewModel(this,equipment);
        }
    }
}
