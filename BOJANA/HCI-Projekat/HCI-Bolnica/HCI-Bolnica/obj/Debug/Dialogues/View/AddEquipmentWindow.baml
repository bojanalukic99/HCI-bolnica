   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5   	   3    -HCI_Bolnica.Dialogues.View.AddEquipmentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5   	     � Title$  AddEquipmentWindow��5	   	   $	��400��6$   $	��600��61    J� InputBindings 5
      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ O��6&    �� Command 6.   �� *	OkCommand+�� 5   
   $
 Ctrlf�6   $ C��6&    6.   �� *CancelCommand+ � 	Resources 5      6   0HCI_Bolnica.Validation.EmptyStringValidationRule   EmptyStringValidationRule6   0HCI_Bolnica.Validation.JustNumbersValidationRule  JustNumbersValidationRule9   3HCI_Bolnica.Validation.IntOnlyNumbersValidationRule   IntOnlyNumbersValidationRule5   /HCI_Bolnica.Validation.OnlyLetterValidationRule  OnlyLetterValidationRule��%t   &	        &	      &	 &     &	 9       5   
   6/     5   
   6/     5   
   62     5   
   6.   5      .��5      � .+�5   
   �� $��main.png��6   $
��Fill=�6"   $��4,-4,-4.4,4.4q�61   �� 5   
   $��Dodavanje opreme��6   $��30(�6+   $��177,10,147.6,252.8q�69   �� 5   
   $��
ID opreme:��6   $��20(�6%   $��76,72,394.6,205.4q�63   �� 5   
   -   5        $��txtID��5      $	��300��6    $��199,75,94.6,260.4q�6,   .��6G   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61    �� ValidationRules 5        5      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6?     5      $	 RawProposedValue=�6?   5      .��5       
 =� ErrorTemplate
 5!      �� 5"      .R�5#      �  � RowDefinitions 5$      �� 5%      �� 5&       � ColumnDefinitions 5(      �� 5)      .+�5,      ��  ��Name$ textBox��6A   $��0��64   6A   �� 5-      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5.      5/      .��50   (   51      �� 52   
   $��20(�6   $��Naziv:��6   $��119,127,399.6,148.4q�60   �� 53   
   -   5        $��txtName��53      $	��300��6"   $��199,129,94.6,203.4q�6.   .��6J   ��54      �� 55      $  SelectedItem.EquipmentName�6   $ PropertyChanged=�6<    56        57      $	 RawProposedValue=�6?     58      $	 RawProposedValue=�6>   5:      .��5;      
 5<      �� 5=      .R�5>      �  5?      �� 5@      �� 5A       5C      �� 5D      .+�5G      �� $ textBox��6A   $��0��64   6A   �� 5H      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5I      5J      .��5K   (   5M      �� 5N   
   $��	Kolicina:��6   $��20(�6$   $��102,190,382.6,77.4q�62   �� 5O   
   -   5        $��txtGrams��5O      $	��300��6"   $��199,192,94.6,138.4q�6.   .��6K   ��5Q      �� 5R      $ SelectedItem.Quantity�6   $ PropertyChanged=�67    5S        5T      $	 RawProposedValue=�6?     5U      $	 RawProposedValue=�6B   5W      .��5X      
 5Y      �� 5Z      .R�5[      �  5\      �� 5]      �� 5^       5`      �� 5a      .+�5d      �� $ textBox��6A   $��0��64   6A   �� 5e      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5f      5g      .��5h   (   5j      �� 5k   
   $��Proizvodjac:��6   $��20(�6'   $��76,256,394.6,12.4q�65   �� 5l   
   -   5        $��txtManufacturer��5l      $��199,256,94.6,76.4q�6*   $	��300��6E   .��6R   ��5m      �� 5n      $ SelectedItem.Manufacturer�6   $ PropertyChanged=�6;    5o        5p      $	 RawProposedValue=�6?   5r      .��5s      
 5t      �� 5u      .R�5v      �  5w      �� 5x      �� 5y       5{      �� 5|      .+�5      �� $ textBox��6A   $��0��64   6A   �� 5�      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5�      5�      .��5�   (   5�      �� 5�   
   -   5        $��
btnConfirm��5�   ]    � ToolTip$ potvrdi(CTRL+O)��6   
�������$
��Left=�6o   $��44��6�   $��108,317,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6+   �� *	OkCommand+.��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��28��67   $��63��6C   Dodaj6U   �� 5�      $��add.png��6   $��40��6)   $��60��65   5�      5�      �� 5�   
   -   5        $��btnCancellations��5�   N   $ odustani(CTRL+C)��6   
�������$
��Left=�6y   $��44��6�   $��320,317,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6,   �� *CancelCommand+.��5�      �� $ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��28��67   $��88��6C   
Odustani6X   �� 5�      $��
cancel.png��6   $��40��6,   $��60��68   5�      5�      5�      5�      