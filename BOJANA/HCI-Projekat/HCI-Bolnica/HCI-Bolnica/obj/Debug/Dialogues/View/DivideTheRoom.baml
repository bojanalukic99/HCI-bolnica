   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5   
   .    (HCI_Bolnica.Dialogues.View.DivideTheRoom   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5   
     � Title$  DivideTheRoom��5
   	   $	��500��6   $	��600��6,    J� InputBindings 5      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ O��6&    �� Command 6.   �� *	OkCommand+�� 5   
   $
 Ctrlf�6   $ C��6&    6.   �� *CancelCommand+ � 	Resources 5      6   0HCI_Bolnica.Validation.EmptyStringValidationRule   EmptyStringValidationRule6   0HCI_Bolnica.Validation.JustNumbersValidationRule  JustNumbersValidationRule9   3HCI_Bolnica.Validation.IntOnlyNumbersValidationRule   IntOnlyNumbersValidationRule5   /HCI_Bolnica.Validation.OnlyLetterValidationRule  OnlyLetterValidationRule5   /HCI_Bolnica.Validation.DateFormatValidationRule  DateFormatValidationRule��%�   &	        &	      &	 &     &	 9     &	 L       5   
   6/     5   
   6/     5   
   62     5   
   6.     5   
   6.   5      .��5      � .+�5   
   �� $��main.png��6   $
��Fill=�6"   �� 5   
   $��Podela sobe��6   $��30(�6&   $��204,10,203.6,283.4q�64   �� 5   
   $��Prostorija:��6   $��20(�6&   $��115,101,363.6,214.4q�64   �� 5   
    �� DisplayMemberPath$
 Name��61    �� SelectedValuePath$ Value��6J   $��231,101,30.6,331.4q�6�   ��6   �� *Rooms+ �� SelectedValue 6d   �� *SelectedItem.Room+6�   �� 5   
   $��Naziv nove sobe:��6   $��20(�6+   $��58,180,362.6,92.4q�69   �� 5   
   $��230,180,30.6,253.4q�6   .��60   ��5      �� 5      	 �� Path$	 SelectedRoom.ID�6   
 �� UpdateSourceTrigger$
 PropertyChanged=�61    �� ValidationRules 5        5       ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6?     5!      $ RawProposedValue=�6?   5#      .��5$       =� ErrorTemplate 5%      �� 5&      .R�5'      �  � RowDefinitions 5(      �� 5)      �� 5*       � ColumnDefinitions 5,      �� 5-      .+�50      ��  ��Name$ textBox��6A   $��0��64   6A   �� 51      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   52      53      .��54   (   55      �� 56   
   $��Datum pocetka deljenja:��6   $��20(�63   $��0,263,359.6,22.4q�6A   �� 57   
   $��231,263,29.6,170.4q�6   .��60   ��58      �� 59      $(	 "SelectedItem.DateOfRenovationStart�6   $
 PropertyChanged=�6D    5:        5;      $ RawProposedValue=�6?     5<      $ RawProposedValue=�6>   5>      .��5?       5@      �� 5A      .R�5B      �  5C      �� 5D      �� 5E       5G      �� 5H      .+�5K      �� $ textBox��6A   $��0��64   6A   �� 5L      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5M      5N      .��5O   (   5P      �� 5Q   
   $��Datum kraja deljenja:��6   $��20(�61   $��23,331,362.6,-45.6q�6?   �� 5R   
   $��231,338,29.6,98.4q�6   .��60   ��5S      �� 5T      $&	  SelectedItem.DateOfRenovationEnd�6   $
 PropertyChanged=�6B    5U        5V      $ RawProposedValue=�6?     5W      $ RawProposedValue=�6>   5Y      .��5Z       5[      �� 5\      .R�5]      �  5^      �� 5_      �� 5`       5b      �� 5c      .+�5f      �� $ textBox��6A   $��0��64   6A   �� 5g      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5h      5i      .��5j   (   5l      �� 5m   
    � ToolTip$# zakazi deljenje soba (CTRL+O)��6   
�������$��107,411,309.6,6.4q�6j   ��69   �� *	OkCommand+.��5n      ��  �� Orientation$ 
Horizontal=�6   .+�5o      �� $��Center=�6   $��Center=�69   $��20(�6T   $��25��6b   $��74��6n   �� 6z   $�Zakazi��6~   6�   �� 5p      $��renovation.png��6   5q      5r      �� 5s   
   $ odustani (CTRL+C)��6   
�������$��340,411,76.6,6.4q�6b   ��6-   �� *CancelCommand+.��5t      �� $ 
Horizontal=�6   .+�5u      �� $��20(�6   $��Center=�6*   $��Center=�6G   $��93��6b   
Odustani6w   �� 5v      $��
cancel.png��6   5w      5x      5y      5z      