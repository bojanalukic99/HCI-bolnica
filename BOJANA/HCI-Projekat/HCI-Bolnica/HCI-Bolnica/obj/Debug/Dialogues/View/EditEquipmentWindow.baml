   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5   
   4    .HCI_Bolnica.Dialogues.View.EditEquipmentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5   
     � Title$  EditEquipmentWindow��5
   	   $	��400��6%   $	��600��62    J� InputBindings 5      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ O��6&    �� Command 6.   �� *	OkCommand+�� 5   
   $
 Ctrlf�6   $ C��6&    6.   �� *CancelCommand+ � 	Resources 5      6   0HCI_Bolnica.Validation.EmptyStringValidationRule   EmptyStringValidationRule6   0HCI_Bolnica.Validation.JustNumbersValidationRule  JustNumbersValidationRule9   3HCI_Bolnica.Validation.IntOnlyNumbersValidationRule   IntOnlyNumbersValidationRule5   /HCI_Bolnica.Validation.OnlyLetterValidationRule  OnlyLetterValidationRule��%t   &	        &	      &	 &     &	 9       5   
   6/     5   
   6/     5   
   62     5   
   6.   5      .��5      � .+�5   
   �� $��main.png��6   $
��Fill=�6"   �� 5   
   $��Izmena opreme��6   $��30(�6(   $��177,10,147.6,252.8q�66   �� 5   
   $	��ID:��6   $��20(�6   $��165,82,387.6,195.8q�6,   �� 5   
   {�.  $��211,89,82.6,252.4q�6%   .��6A   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61    �� ValidationRules 5        5      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6?     5      $	 RawProposedValue=�6?   5       .��5!      
 =� ErrorTemplate
 5"      �� 5#      .R�5$      �  � RowDefinitions 5%      �� 5&      �� 5'       � ColumnDefinitions 5)      �� 5*      .+�5-      ��  ��Name$ textBox��6A   $��0��64   6A   �� 5.      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5/      50      .��51   (   52      �� 53   
   $	��150��6   $��39��6   $��Right=�6)   $��20(�6L   $��Naziv:��6Z   $��50,125,393.6,156.8q�6k   �� 54   
   -   5        $��txtName��54      $	��300��6"   {�. $��211,140,82.6,191.4q�6?   .��6[   ��55      �� 56      $  SelectedItem.EquipmentName�6   $ PropertyChanged=�6<    57        58      $	 RawProposedValue=�6?     59      $	 RawProposedValue=�6>   5;      .��5<      
 5=      �� 5>      .R�5?      �  5@      �� 5A      �� 5B       5D      �� 5E      .+�5H      �� $ textBox��6A   $��0��64   6A   �� 5I      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5J      5K      .��5L   (   5N      �� 5O   
   $	��150��6   $��40��6   $��Right=�6)   $��20(�6L   $��	Kolicina:��6Z   $��50,202,393.6,128.4q�6n   �� 5P   
   -   5        $��txtGrams��5P      $	��300��6"   $��211,202,82.6,132.4q�6.   .��6J   ��5Q      �� 5R      $ SelectedItem.Quantity�6   $ PropertyChanged=�67    5S        5T      $	 RawProposedValue=�6?     5U      $	 RawProposedValue=�6B   5W      .��5X      
 5Y      �� 5Z      .R�5[      �  5\      �� 5]      �� 5^       5`      �� 5a      .+�5d      �� $ textBox��6A   $��0��64   6A   �� 5e      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5f      5g      .��5h   (   5j      �� 5n   
   $��Proizvodjac:��6   $��20(�6'   $��88,255,382.6,25.4q�65   �� 5o   
   -   5        $��txtManufacturer��5o      $��211,255,82.6,80.4q�6*   $	��300��6E   .��6R   ��5p      �� 5q      $ SelectedItem.Manufacturer�6   $ PropertyChanged=�6;    5r        5s      $	 RawProposedValue=�6?     5t      $	 RawProposedValue=�6>   5v      .��5w      
 5x      �� 5y      .R�5z      �  5{      �� 5|      �� 5}       5      �� 5�      .+�5�      �� $ textBox��6A   $��0��64   6A   �� 5�      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5�      5�      .��5�   (   5�      �� 5�   
   -   5        $��
btnConfirm��5�   d    � ToolTip$ izmeni opmrenu(CTRL+O)��6   
�������$
��Left=�6v   $��46��6�   $��116,314,0,0q�6�   $	��Top=�6�   $	��181��6�   $��20(�6�   $
��Bold"�6�   ��62   �� *	OkCommand+.��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��27��67   $��87��6C   Izmeni6V   �� 5�      $��edit.png��6   5�      5�      �� 5�   
   -   5        $��btnCancellations��5�   N   $ odustani(CTRL+C)��6   
�������$
��Left=�6y   $��46��6�   $��315,313,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6,   �� *CancelCommand+.��5�      �� $ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��Center=�67   $	��103��6T   
Odustani6j   �� 5�      $��
cancel.png��6   $��42��6,   $��64��68   5�      5�      5�      5�      