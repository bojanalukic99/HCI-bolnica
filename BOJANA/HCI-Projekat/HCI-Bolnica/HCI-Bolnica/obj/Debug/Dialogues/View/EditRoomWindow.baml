   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5      /    )HCI_Bolnica.Dialogues.View.EditRoomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5        � Title$  EditRoomWindow��5
   	   $	��350��6    $	��600��6-    J� InputBindings 5      �� 5   
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
   $��Izmeni prostoriju��6   $��30(�6,   $��177,43,170.6,219.8q�6:   �� 5   
   {�.  $��252,106,41.6,180.8q�6$   .��6@   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61    �� ValidationRules 5        5      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6?     5      $	 RawProposedValue=�6?   5      .��5       
 =� ErrorTemplate
 5!      �� 5"      .R�5#      �  � RowDefinitions 5$      �� 5%      �� 5&       � ColumnDefinitions 5(      �� 5)      .+�5,      ��  ��Name$ textBox��6A   $��0��64   6A   �� 5-      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5.      5/      .��50   (   51      �� 52   
   $	��ID:��6   $��15(�6   $��189,106,360.6,180.8q�6,   �� 53   
   $��Right=�6   $��68,153,360.6,128.8q�63   .��6O   Sprat Prostorije:6b   �� 54   
   -   5        $��txtFloor��54      $	��300��6"   $��252,157,41.6,129.8q�6.   .��6J   ��55      �� 56      $ SelectedItem.Floor�6   $ PropertyChanged=�64    57        58      $	 RawProposedValue=�6?     59      $	 RawProposedValue=�6B   5;      .��5<      
 5=      �� 5>      .R�5?      �  5@      �� 5A      �� 5B       5D      �� 5E      .+�5H      �� $ textBox��6A   $��0��64   6A   �� 5I      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5J      5K      .��5L   (   5N      �� 5O   
   $��Right=�6   $��119,210,358.6,54.8q�63   .��6O   Vrsta Prostorije:6b   �� 5P   
   -   5        $��cmbRoomType��5P   �    �� DisplayMemberPath$
 Name��65    �� SelectedValuePath$ Value��6N   $	��300��6�   $��252,216,41.6,69.8q�6�   ��6   �� *	RoomTypes+ �� SelectedValue 6h   �� *SelectedItem.RoomType+6�   �� 5Q   
   -   5        $��
btnConfirm��5Q   b    � ToolTip$ izmeni sobu(CTRL+O)��6   
�������$
��Left=�6t   $��46��6�   $��113,269,0,0q�6�   $	��Top=�6�   $	��181��6�   $��20(�6�   $
��Bold"�6�   ��60   �� *	OkCommand+.��5R      ��  �� Orientation$ 
Horizontal=�6   .+�5S      �� $��Center=�6   $��27��67   $��87��6C   Izmeni6V   �� 5T      $��edit.png��6   5U      5V      �� 5W   
   -   5        $��btnCancellations��5W   N   $ odustani(CTRL+C)��6   
�������$
��Left=�6y   $��46��6�   $��318,269,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6,   �� *CancelCommand+.��5X      �� $ 
Horizontal=�6   .+�5Y      �� $��Center=�6   $��Center=�67   $	��103��6T   
Odustani6j   �� 5Z      $��
cancel.png��6   $��42��6,   $��64��68   5[      5\      5]      5^      