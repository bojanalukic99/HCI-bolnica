   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5      1    +HCI_Bolnica.Dialogues.View.RenovationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5        � Title$  RenovationWindow��5	   	   $	��450��6"   $	��800��6/    J� InputBindings 5
      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ O��6&    �� Command 6.   �� *	OkCommand+�� 5   
   $
 Ctrlf�6   $ C��6&    6.   �� *CancelCommand+ � 	Resources 5      6   0HCI_Bolnica.Validation.EmptyStringValidationRule   EmptyStringValidationRule6   0HCI_Bolnica.Validation.JustNumbersValidationRule  JustNumbersValidationRule9   3HCI_Bolnica.Validation.IntOnlyNumbersValidationRule   IntOnlyNumbersValidationRule5   /HCI_Bolnica.Validation.OnlyLetterValidationRule  OnlyLetterValidationRule5   /HCI_Bolnica.Validation.DateFormatValidationRule  DateFormatValidationRule��%�   &	        &	      &	 &     &	 9     &	 L       5   
   6/     5   
   6/     5   
   62     5   
   6.     5   
   6.   5      .��5      � .+�5   
   �� $��main.png��6   $
��Fill=�6"   �� 5   
   $(��"Zakazivanje renoviranja prostorije��6   $��Center=�6=   $��Center=�6a   $
��Left=�6�   $��71��6�   $��
155,10,0,0q�6�   $	��Top=�6�   $	��505��6�   $��30(�6�   $
��Bold"�6�   $��2��6  �� 5   
   $��Id renoviranja:��6   $��20(�6*   $��180,81,451.6,289q�68   �� 5   
   $��Prostorije:��6   $��15(�6&   $��230,144,468.6,234q�64   �� 5   
   $��399,86,53.6,289q�6   .��6.   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61    �� ValidationRules 5        5      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6?     5       $	 RawProposedValue=�6?   5"      .��5#      
 =� ErrorTemplate
 5$      �� 5%      .R�5&      �  � RowDefinitions 5'      �� 5(      �� 5)       � ColumnDefinitions 5+      �� 5,      .+�5/      ��  ��Name$ textBox��6A   $��0��64   6A   �� 50      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   51      52      .��53   (   54      �� 55   
    �� DisplayMemberPath$
 Name��61    �� SelectedValuePath$ Value��6J   $��399,144,53.6,234q�6�   ��6   �� *Rooms+ �� SelectedValue 6d   �� *SelectedItem.Room+6�   �� 56   
   $��Datum pocetka:��6   $
��Left=�6)   $��43��6D   $��188,214,0,0q�6P   $��Center=�6e   $��Center=�6�   $	��Top=�6�   $	��129��6�   $��16(�6�   �� 57   
   -   5        $��txtStartDate��57      $
��Left=�6(   $��43��6C   $��399,214,0,0q�6O   $	��Top=�6d   $	��341��6|   .��6�   ��58      �� 59      $( "SelectedItem.DateOfRenovationStart�6   $ PropertyChanged=�6D    5:        5;      $	 RawProposedValue=�6?     5<      $	 RawProposedValue=�6>   5>      .��5?      
 5@      �� 5A      .R�5B      �  5C      �� 5D      �� 5E       5G      �� 5H      .+�5K      �� $ textBox��6A   $��0��64   6A   �� 5L      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5M      5N      .��5O   (   5Q      �� 5R   
   $��Datum zavrsetka:��6   $
��Left=�6+   $��43��6F   $��188,275,0,0q�6R   $��Center=�6g   $��Center=�6�   $	��Top=�6�   $	��131��6�   $��16(�6�   �� 5S   
   -   5        $��
txtEndDate��5S      $
��Left=�6&   $��43��6A   $��399,275,0,0q�6M   $	��Top=�6b   $	��341��6z   .��6�   ��5T      �� 5U      $&  SelectedItem.DateOfRenovationEnd�6   $ PropertyChanged=�6B    5V        5W      $	 RawProposedValue=�6?     5X      $	 RawProposedValue=�6>   5Z      .��5[      
 5\      �� 5]      .R�5^      �  5_      �� 5`      �� 5a       5c      �� 5d      .+�5g      �� $ textBox��6A   $��0��64   6A   �� 5h      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5i      5j      .��5k   (   5m      �� 5n   
   -   5        $��
btnConfirm��5n   h    � ToolTip$  zakazi renoviranje(CTRL+O)��6   
�������$
��Left=�6z   $��46��6�   $��134,341,0,0q�6�   $	��Top=�6�   $	��216��6�   $��18(�6�   $
��Bold"�6�   ��66   �� *	OkCommand+.��5o      ��  �� Orientation$ 
Horizontal=�6   .+�5p      �� $��Center=�6   $��Center=�67   $��29��6T   $��77��6`   Zakazi6s   �� 5q      $��renovation.png��6   $��47��60   5r      5s      �� 5t   
   -   5        $��btnCancellations��5t   O   $ odustani(CTRL+C)��6   
�������$
��Left=�6z   $��46��6�   $��475,341,0,0q�6�   $	��Top=�6�   $	��216��6�   $��18(�6�   $
��Bold"�6�   ��6-   �� *CancelCommand+.��5u      �� $ 
Horizontal=�6   .+�5v      �� $��Center=�6   $��Center=�67   $��84��6T   
Odustani6i   �� 5w      $��
cancel.png��6   5x      5y      5{      5|      