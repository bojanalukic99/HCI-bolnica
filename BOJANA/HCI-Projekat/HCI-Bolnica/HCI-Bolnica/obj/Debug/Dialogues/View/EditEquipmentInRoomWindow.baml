   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5   
   G(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   :    4HCI_Bolnica.Dialogues.View.EditEquipmentInRoomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5   
   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	     � Title$  EditEquipmentInRoomWindow��5
   	   $	��350��6+   $	��600��68    J� InputBindings 5      �� 5   
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
   $ ��Izmeni opremu u prostoriji��6   $��30(�65   $��113,10,103.6,255.8q�6C   �� 5   
   $��Oprema:��6   $��20(�6"   $��166,100,332,175q�60   �� 5   
   -   5        $��cmbEquipment��5   �    �� DisplayMemberPath$
 Name��6f    �� SelectedValuePath$ Value��6   $��267,100,95,183q�6�   ��6   �� *
Equipments+ �� SelectedItem 66   �� *SelectedItem.Equipment+5      �� 5   
   $��	Kolicina:��6   $��20(�6$   $��166,164,332,111q�62   �� 5   
   -   5        $��	txtAmount��5   +   $��267,164,95,111q�6   .��6<   ��5      �� 5      	 �� Path$	 SelectedItem.Quantity�6   
 �� UpdateSourceTrigger$
 PropertyChanged=�67    �� ValidationRules 5        5       ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6?     5!      $ RawProposedValue=�6B   5#      .��5$       =� ErrorTemplate 5%      �� 5&      .R�5'      �  � RowDefinitions 5(      �� 5)      �� 5*       � ColumnDefinitions 5,      �� 5-      .+�50      ��  ��Name$ textBox��6A   $��0��64   6A   �� 51      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   52      53      .��54   (   55      �� 56   
   -   5        $��
btnConfirm��56   D   
�������$
��Left=�6V   $��46��6q   $��113,249,0,0q�6}   $	��Top=�6�   $	��181��6�   $��20(�6�   $
��Bold"�6�   ��6   �� *	OkCommand+.��57      ��  �� Orientation$ 
Horizontal=�6   .+�58      �� $��Center=�6   $��27��67   $��87��6C   Izmeni6V   �� 59      $��edit.png��6   5:      5;      �� 5<   
   -   5        $��btnCancellations��5<   3   
�������$
��Left=�6^   $��46��6y   $��320,249,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6   �� *CancelCommand+.��5=      �� $ 
Horizontal=�6   .+�5>      �� $��Center=�6   $��Center=�67   $	��103��6T   
Odustani6j   �� 5?      $��
cancel.png��6   $��42��6,   $��64��68   5@      5A      5C      5D      