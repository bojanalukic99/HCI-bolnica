   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5   	   9    3HCI_Bolnica.Dialogues.View.AddEquipmentInRoomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5   	     � Title$  AddMedicineInRoomWindow��5	   	   $	��360��6)   $	��600��66    J� InputBindings 5      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ O��6&    �� Command 6.   �� *	OkCommand+�� 5   
   $
 Ctrlf�6   $ C��6&    6.   �� *CancelCommand+ � 	Resources 5      6   0HCI_Bolnica.Validation.EmptyStringValidationRule   EmptyStringValidationRule6   0HCI_Bolnica.Validation.JustNumbersValidationRule  JustNumbersValidationRule9   3HCI_Bolnica.Validation.IntOnlyNumbersValidationRule   IntOnlyNumbersValidationRule5   /HCI_Bolnica.Validation.OnlyLetterValidationRule  OnlyLetterValidationRule��%t   &	        &	      &	 &     &	 9       5   
   6/     5   
   6/     5   
   62     5   
   6.   5      .��5      � $��0,0,-0.4,-0.2q�6   .+�5   
   �� $��main.png��6   $
��Fill=�6"   �� 5   
   $��Dodaj opremu u prostoriju��6   $��30(�64   $��113,10,103.6,255.8q�6B   �� 5   
   $��Oprema:��6   $��20(�6"   $��166,101,332,174q�60   �� 5   
   -   5        $��cmbEquipment��5   �    �� DisplayMemberPath$
 Name��66    �� SelectedValuePath$ Value��6O   $��267,101,95,182q�6�   ��6   �� *
Equpiments+ �� SelectedValue 6i   �� *SelectedItem.EquipmentName+5      �� 5   
   $��	Kolicina:��6   $��20(�6$   $��166,164,332,111q�62   �� 5   
   -   5        $��	txtAmount��5   +   $��267,164,95,124q�6   .��6<   ��5      �� 5      	 �� Path$	 SelectedItem.Quantity�6   
 �� UpdateSourceTrigger$
 PropertyChanged=�67    �� ValidationRules 5         5!      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6?     5"      $ RawProposedValue=�6B   5$      .��5%       =� ErrorTemplate 5&      �� 5'      .R�5(      �  � RowDefinitions 5)      �� 5*      �� 5+       � ColumnDefinitions 5-      �� 5.      .+�51      ��  ��Name$ textBox��6A   $��0��64   6A   �� 52      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   53      54      .��55   (   56      �� 57   
   -   5        $��
btnConfirm��57   V    � ToolTip$ Potvrda��6   
�������$
��Left=�6h   $��49��6�   $��135,236,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6$   �� *	OkCommand+.��58      ��  �� Orientation$ 
Horizontal=�6   .+�59      �� $��Center=�6   $��28��67   $��63��6C   Dodaj6U   �� 5:      $��add.png��6   $��40��6)   $��60��65   5;      5<      �� 5=   
   -   5        $��btnCancellations��5=   F   $ Odustani��6   
�������$
��Left=�6q   $��49��6�   $��319,236,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6$   �� *CancelCommand+.��5>      �� $ 
Horizontal=�6   .+�5?      �� $��Center=�6   $��28��67   $��88��6C   
Odustani6X   �� 5@      $��
cancel.png��6   $��40��6,   $��60��68   5A      5B      5D      5E      