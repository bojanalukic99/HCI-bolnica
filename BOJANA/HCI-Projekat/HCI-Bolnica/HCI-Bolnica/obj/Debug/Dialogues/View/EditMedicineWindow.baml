   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5      3    -HCI_Bolnica.Dialogues.View.EditMedicineWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5        � Title$  EditMedicineWindow��5
   	   $	��600��6$   $	��800��61    J� InputBindings 5      �� 5   
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
   $��Izmena leka��6   $��Center=�6&   $��Center=�6J   $
��Left=�6l   $��56��6�   $��
223,10,0,0q�6�   $	��Top=�6�   $	��364��6�   $��30(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   $	��ID:��6   $��20(�6   $��264,71,470.6,406.8q�6,   �� 5   
   $��328,71,30.6,449.4q�6   {�.  .��6@   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61    �� ValidationRules 5        5      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6?     5      $	 RawProposedValue=�6?   5       .��5!      
 =� ErrorTemplate
 5"      �� 5#      .R�5$      �  � RowDefinitions 5%      �� 5&      �� 5'       � ColumnDefinitions 5)      �� 5*      .+�5-      ��  ��Name$ textBox��6A   $��0��64   6A   �� 5.      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5/      50      .��51   (   52      �� 53   
   $��Naziv:��6   $
��Left=�6!   $��43��6<   $��232,125,0,0q�6H   $��Center=�6]   $��Center=�6�   $	��Top=�6�   $��88��6�   $��20(�6�   �� 54   
   -   5        $��txtName��54      $
��Left=�6"   $��43��6=   $��328,126,0,0q�6I   $	��Top=�6^   $	��435��6v   .��6�   ��55      �� 56      $ SelectedItem.Name�6   $ PropertyChanged=�63    57        58      $	 RawProposedValue=�6?     59      $	 RawProposedValue=�6>   5;      .��5<      
 5=      �� 5>      .R�5?      �  5@      �� 5A      �� 5B       5D      �� 5E      .+�5H      �� $ textBox��6A   $��0��64   6A   �� 5I      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5J      5K      .��5L   (   5M      �� 5N   
   $��Sastav:��6   $��Center=�6"   $��Center=�6F   $
��Left=�6h   $��38��6�   $��232,195,0,0q�6�   $	��Top=�6�   $��88��6�   $��20(�6�    J� RenderTransformOrigin$ 0.337,0.469&�6�   �� 5O   
   $��	Kolicina:��6   $��Center=�6%   $��Center=�6I   $
��Left=�6k   $��37��6�   $��223,282,0,0q�6�   $	��Top=�6�   $��95��6�   $��20(�6�   $ 0.585,1.584&�6�   �� 5R   	   $��Zamena:��6   $��Center=�6"   $��Center=�6F   $��50��6h   $��212,345,459.6,0q�6t   $	��Top=�6�   $��20(�6�   �� 5S   
   -   5        $��txtComposition��5S      $
��Left=�6*   $��53��6E   $��328,195,0,0q�6Q   $	��Top=�6f   $	��435��6~   .��6�   ��5T      �� 5U      $ SelectedItem.Composition�6   $ PropertyChanged=�6:    5V        5W      $	 RawProposedValue=�6?     5X      $	 RawProposedValue=�6>   5Z      .��5[      
 5\      �� 5]      .R�5^      �  5_      �� 5`      �� 5a       5c      �� 5d      .+�5g      �� $ textBox��6A   $��0��64   6A   �� 5h      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5i      5j      .��5k   (   5l      �� 5n   
   -   5        $��txtGrams��5n      $
��Left=�6$   $��43��6?   $��328,279,0,0q�6K   $	��Top=�6`   $	��435��6x   .��6�   ��5o      �� 5p      $ SelectedItem.Grams�6   $ PropertyChanged=�64    5q        5r      $	 RawProposedValue=�6?     5s      $	 RawProposedValue=�6?   5u      .��5v      
 5w      �� 5x      .R�5y      �  5z      �� 5{      �� 5|       5~      �� 5      .+�5�      �� $ textBox��6A   $��0��64   6A   �� 5�      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5�      5�      .��5�   (   5�      �� 5�   
   -   5        $��txtReplacement��5�      $
��Left=�6*   $��43��6E   $��328,355,0,0q�6Q   $	��Top=�6f   $	��435��6~   .��6�   ��5�      �� 5�      $ SelectedItem.Replacment�6   $ PropertyChanged=�69    5�        5�      $	 RawProposedValue=�6?     5�      $	 RawProposedValue=�6>   5�      .��5�      
 5�      �� 5�      .R�5�      �  5�      �� 5�      �� 5�       5�      �� 5�      .+�5�      �� $ textBox��6A   $��0��64   6A   �� 5�      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5�      5�      .��5�   (   5�      �� 5�   
   $��	Komentar:��6   $��20(�6$   $��223,425,21.6,53.4q�62   �� 5�   
   -   5        $��
txtComment��5�   8   $��328,428,30.6,76.4q�6J   ��6   �� *SelectedItem.Comment+6J   �� 5�   
   -   5        $��
btnConfirm��5�   a    � ToolTip$ izmeni lek(CTRL+O)��6   
�������$
��Left=�6s   $��46��6�   $��153,514,0,0q�6�   $	��Top=�6�   $	��181��6�   $��20(�6�   $
��Bold"�6�   ��6/   �� *	OkCommand+.��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��27��67   $��87��6C   Izmeni6V   �� 5�      $��edit.png��6   5�      5�      �� 5�   
   -   5        $��btnCancellations��5�   N   $ odustani(CTRL+C)��6   
�������$
��Left=�6y   $��46��6�   $��454,513,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6,   �� *CancelCommand+.��5�      �� $ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��Center=�67   $	��103��6T   
Odustani6j   �� 5�      $��
cancel.png��6   $��42��6,   $��64��68   5�      5�      5�      5�      