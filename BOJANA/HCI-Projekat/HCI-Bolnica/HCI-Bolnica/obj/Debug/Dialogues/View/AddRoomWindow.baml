   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5      .    (HCI_Bolnica.Dialogues.View.AddRoomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5        � Title$  AddRoomWindow��5	   	   $	��360��6   $	��600��6,    J� InputBindings 5
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
��Fill=�6"   �� 5   
   $��Dodavanje prostorije��6   $��30(�6/   $��177,10,119.6,252.8q�6=   �� 5   
   $��ID prostorije:��6   $	��150��6)   $��15(�65   $��109,92,334.6,192.8q�6C    J� RenderTransformOrigin$ 0.378,1.662&�6_   �� 5   
   $��208,92,85.6,192.8q�6   $	��300��6.   .��6:   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61   	 �� ValidationRules	 5        5      ,  &System.Windows.Controls.ValidationRule
   ValidationStep$
 RawProposedValue=�6?     5      $
 RawProposedValue=�6?   5      .��5        =� ErrorTemplate 5!      �� 5"      .R�5#      �  � RowDefinitions 5$      �� 5%      �� 5&       � ColumnDefinitions 5(      �� 5)      .+�5,      ��  ��Name$ textBox��6A   $��0��64   6A   �� 5-      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5.      5/      .��50   (   51      �� 52   
    �� Orientation$ Vertical=�6   $��Center=�6,   $	��126��6G   $��0,128,-0.4,66.8q�6T   .+�53      �� $ 
Horizontal=�6   $��
0,10,30,10q�62   $��Center=�6F   $��Center=�6c   54      �� 55      $ 
Horizontal=�6   $��
0,10,30,10q�62   $��Center=�6F   $��Center=�6c   .+�56      �� $��15(�6   $	��150��6&   $��31��62   $��Right=�6>   .��6a   Sprat Prostorije:6t   �� 57      -   5        $��txtFloor��57      $	��300��6*   $��34��66   .��6B   ��58      �� 59      $ SelectedItem.Floor�6"   $ PropertyChanged=�6<   	 5:        5;   "   $
 RawProposedValue=�6G     5<   "   $
 RawProposedValue=�6J   5>      .��5?   $    5@      �� 5A      .R�5B      �  5C   "   �� 5D   &   �� 5E   &    5G   "   �� 5H   &   .+�5K   "   �� $ textBox��6I   $��0��6<   6I   �� 5L   "   $��1��6,   $��1��6<   
���  ����6I   �� *[0].ErrorContent+6k   5M      5N      .��5O   0   5Q      5R      �� 5S      $ 
Horizontal=�6   $��
0,10,30,10q�62   $��Center=�6F   $��Center=�6c   .+�5T      �� $��15(�6   $	��150��6&   $��37��62   $��Right=�6>   .��6a   Vrsta Prostorije:6t   �� 5U      -   5         ��Name$ cmbRoomType��5U   �    �� DisplayMemberPath$
 Name��6=    �� SelectedValuePath$ Value��6V   $	��300��6�   $��29��6�   ��6   �� *	RoomTypes+ �� SelectedValue 6p   �� *SelectedItem.RoomType+5V      5W      5X      �� 5Y      -   5        $��
btnConfirm��5Y   a    � ToolTip$ potvrdi(CTRL+O)��6   
�������$
��Left=�6s   $��59��6�   $��109,252,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6/   �� *	OkCommand+.��5Z      �� $ 
Horizontal=�6   .+�5[      �� $��Center=�6    $��28��6;   $��63��6G   Dodaj6Y   �� 5\      $��add.png��6   $��46��6-   $��60��69   5]      5^      �� 5_      -   5        $��btnCancellations��5_   R   $ odustani(CTRL+C)��6   
�������$
��Left=�6}   $��59��6�   $��329,252,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��60   �� *CancelCommand+.��5`      �� $ 
Horizontal=�6   .+�5a      �� $��Center=�6    $��28��6;   $��88��6G   
Odustani6\   �� 5b      $��
cancel.png��6   $��46��60   $��60��6<   5c      5d      5f      5g      