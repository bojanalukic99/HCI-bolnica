   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5   
   6    0HCI_Bolnica.Dialogues.View.ConnectingRoomsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5   
     � Title$  ConnectingRoomsWindow��5
   	   $	��500��6'   $	��600��64    J� InputBindings 5      �� 5   
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
   $��Spajanje prostorija��6   $��30(�6.   $��182,10,102.6,261.4q�6<   �� 5   
   $��ID renoviranja:��6   $��20(�6*   $��81,71,363.6,278.4q�68   �� 5   
   $��234,81,30.6,351.4q�6   .��6/   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61    �� ValidationRules 5        5      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6?     5      $	 RawProposedValue=�6?   5!      .��5"      
 =� ErrorTemplate
 5#      �� 5$      .R�5%      �  � RowDefinitions 5&      �� 5'      �� 5(       � ColumnDefinitions 5*      �� 5+      .+�5.      ��  ��Name$ textBox��6A   $��0��64   6A   �� 5/      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   50      51      .��52   (   53      �� 54   
   $��Prostorije za spajanje:��6   $��20(�62   $��18,139,362.6,176.4q�6@   �� 55   
    �� DisplayMemberPath$
 Name��61    �� SelectedValuePath$ Value��6J   $��235,147,209.6,290.4q�6�   ��6   �� *Rooms+ �� SelectedValue 6d   �� *SelectedItemOne+6�   �� 56   
   $
 Name��61   $ Value��6J   $��414,147,30.6,290.4q�6�   ��6   �� *Rooms+ 6d   �� *SelectedItemTwo+6�   �� 57   
   $��Naziv nove sobe:��6   $��20(�6+   $��58,196,374.6,77.4q�69   �� 58   
   $��230,198,30.6,229.4q�6   .��6/   ��59      �� 5:      $ SelectedItem.Room.ID�6   $ PropertyChanged=�66    5;        5<      $	 RawProposedValue=�6?     5=      $	 RawProposedValue=�6?   5?      .��5@      
 5A      �� 5B      .R�5C      �  5D      �� 5E      �� 5F       5H      �� 5I      .+�5L      �� $ textBox��6A   $��0��64   6A   �� 5M      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5N      5O      .��5P   (   5Q      �� 5R   
   $��Datum pocetka spajanja:��6   $��20(�63   $��-10,260,369.6,26.4q�6A   �� 5S   
   $��230,267,30.6,163.4q�6   .��62   ��5T      �� 5U      $( "SelectedItem.DateOfRenovationStart�6   $ PropertyChanged=�6D    5V        5W      $	 RawProposedValue=�6?     5X      $	 RawProposedValue=�6>   5Z      .��5[      
 5\      �� 5]      .R�5^      �  5_      �� 5`      �� 5a       5c      �� 5d      .+�5g      �� $ textBox��6A   $��0��64   6A   �� 5h      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5i      5j      .��5k   (   5l      �� 5m   
   $��Datum kraja spajanja:��6   $��20(�61   $��19,324,366.6,-37.6q�6?   �� 5n   
   $��231,331,29.6,106.4q�6   .��60   ��5o      �� 5p      $&  SelectedItem.DateOfRenovationEnd�6   $ PropertyChanged=�6B    5q        5r      $	 RawProposedValue=�6?     5s      $	 RawProposedValue=�6>   5u      .��5v      
 5w      �� 5x      .R�5y      �  5z      �� 5{      �� 5|       5~      �� 5      .+�5�      �� $ textBox��6A   $��0��64   6A   �� 5�      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5�      5�      .��5�   (   5�      �� 5�   
    � ToolTip$" zakazi spajanje soba(CTRL+O)��6   
�������$��120,402,312.6,6.4q�6i   ��68   �� *	OkCommand+.��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��Center=�69   $��20(�6T   $��25��6b   $��74��6n   �� 6z   $�Zakazi��6~   6�   �� 5�      $��renovation.png��6   $��49��60   $��53��6<   5�      5�      �� 5�   
   $ odustani(CTRL+C)��6   
�������$��340,402,76.6,6.4q�6a   ��6,   �� *CancelCommand+.��5�      �� $ 
Horizontal=�6   $��60��62   .+�5�      �� $��20(�6   $��Center=�6*   $��Center=�6G   $��93��6b   
Odustani6w   �� 5�      $��
cancel.png��6   $��0,10,0,0q�6-   $��55��6?   5�      5�      5�      5�      