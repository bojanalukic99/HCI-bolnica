   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   ?$clr-namespace:HCI_Bolnica.ValidationHCI_Bolnica.Validation  5   	   2    ,HCI_Bolnica.Dialogues.View.AddMedicineWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	   ;
validators$clr-namespace:HCI_Bolnica.Validation     5   	     � Title$  AddMedicineWindow��5	   	   $	��550��6#   $	��800��60    J� InputBindings 5
      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ O��6&    �� Command 6.   �� *	OkCommand+�� 5   
   $
 Ctrlf�6   $ C��6&    6.   �� *CancelCommand+ � 	Resources 5      6   0HCI_Bolnica.Validation.EmptyStringValidationRule   EmptyStringValidationRule6   0HCI_Bolnica.Validation.JustNumbersValidationRule  JustNumbersValidationRule9   3HCI_Bolnica.Validation.IntOnlyNumbersValidationRule   IntOnlyNumbersValidationRule5   /HCI_Bolnica.Validation.OnlyLetterValidationRule  OnlyLetterValidationRule��%t   &	        &	      &	 &     &	 9       5   
   6/     5   
   6/     5   
   62     5   
   6.   5      .��5      � $��0,0,-0.4,-55q�6   .+�5   
   �� $��main.png��6   $
��Fill=�6"   $��
0,0,0,41.2q�61   �� 5   
   $��Dodavanje leka��6   $��Center=�6)   $��Center=�6M   $
��Left=�6o   $��56��6�   $��
223,10,0,0q�6�   $	��Top=�6�   $	��364��6�   $��30(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   -   5        $��txtID��5      $
��Left=�6   $��43��6:   $��
327,81,0,0q�6F   $	��Top=�6Z   $	��296��6r   .��6~   ��5      �� 5       �� Path$ SelectedItem.ID�6    �� UpdateSourceTrigger$ PropertyChanged=�61    �� ValidationRules 5        5      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6?     5      $	 RawProposedValue=�6?   5      .��5      
 =� ErrorTemplate
 5       �� 5!      .R�5"      �  � RowDefinitions 5#      �� 5$      �� 5%       � ColumnDefinitions 5'      �� 5(      .+�5+      ��  ��Name$ textBox��6A   $��0��64   6A   �� 5,      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5-      5.      .��5/   (   50      �� 52   
   $��ID leka:��6   $
��Left=�6#   $��43��6>   $��
215,81,0,0q�6J   $��Center=�6^   $��Center=�6�   $	��Top=�6�   $��88��6�   $��20(�6�   �� 53   
   $��Naziv:��6   $
��Left=�6!   $��43��6<   $��222,151,0,0q�6H   $��Center=�6]   $��Center=�6�   $	��Top=�6�   $��88��6�   $��20(�6�   �� 54   
   -   5        $��txtName��54      $
��Left=�6!   $��43��6<   $��327,151,0,0q�6H   $	��Top=�6]   $	��296��6u   .��6�   ��55      �� 56      $ SelectedItem.Name�6   $ PropertyChanged=�63    57        58      $	 RawProposedValue=�6?     59      $	 RawProposedValue=�6>   5;      .��5<      
 5=      �� 5>      .R�5?      �  5@      �� 5A      �� 5B       5D      �� 5E      .+�5H      �� $ textBox��6A   $��0��64   6A   �� 5I      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5J      5K      .��5L   (   5M      �� 5N   
   $��Sastav:��6   $��Center=�6"   $��Center=�6F   $
��Left=�6h   $��38��6�   $��222,220,0,0q�6�   $	��Top=�6�   $��88��6�   $��20(�6�    J� RenderTransformOrigin$ 0.485,0.488&�6�   �� 5O   
   $��	Kolicina:��6   $��Center=�6%   $��Center=�6I   $
��Left=�6k   $��37��6�   $��216,299,0,0q�6�   $	��Top=�6�   $��95��6�   $��20(�6�   $ 0.519,0.129&�6�   �� 5R   
   $��Zamena:��6   $��Center=�6#   $��Center=�6G   $��50��6i   $��0,360,255,0q�6u   $	��Top=�6�   $��20(�6�   �� 5S   
   -   5        $��txtComposition��5S      $
��Left=�6*   $��50��6E   $��327,220,0,0q�6Q   $	��Top=�6f   $	��296��6~   .��6�   ��5T      �� 5U      $ SelectedItem.Composition�6   $ PropertyChanged=�6:    5V        5W      $	 RawProposedValue=�6?     5X      $	 RawProposedValue=�6>   5Z      .��5[      
 5\      �� 5]      .R�5^      �  5_      �� 5`      �� 5a       5c      �� 5d      .+�5g      �� $ textBox��6A   $��0��64   6A   �� 5h      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5i      5j      .��5k   (   5l      �� 5m   
   -   5        $��txtGrams��5m      $
��Left=�6#   $��43��6>   $��327,299,0,0q�6J   $	��Top=�6_   $	��296��6w   .��6�   ��5n      �� 5o      $ SelectedItem.Grams�6   $ PropertyChanged=�64    5p        5q      $	 RawProposedValue=�6?     5r      $	 RawProposedValue=�6?   5t      .��5u      
 5v      �� 5w      .R�5x      �  5y      �� 5z      �� 5{       5}      �� 5~      .+�5�      �� $ textBox��6A   $��0��64   6A   �� 5�      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5�      5�      .��5�   (   5�      �� 5�   
   -   5        $��txtReplacement��5�      $
��Left=�6)   $��43��6D   $��327,367,0,0q�6P   $	��Top=�6e   $	��296��6}   .��6�   ��5�      �� 5�      $ SelectedItem.Replacment�6   $ PropertyChanged=�69    5�        5�      $	 RawProposedValue=�6?     5�      $	 RawProposedValue=�6>   5�      .��5�      
 5�      �� 5�      .R�5�      �  5�      �� 5�      �� 5�       5�      �� 5�      .+�5�      �� $ textBox��6A   $��0��64   6A   �� 5�      $��1��6$   $��1��64   
���  ����6A   �� *[0].ErrorContent+6c   5�      5�      .��5�   (   5�      �� 5�   
   -   5        $��
btnConfirm��5�   ]    � ToolTip$ potvrdi(CTRL+O)��6   
�������$
��Left=�6o   $��59��6�   $��203,448,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6+   �� *	OkCommand+.��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��28��67   $��63��6C   Dodaj6U   �� 5�      $��add.png��6   $��46��6)   $��60��65   5�      5�      �� 5�   
   -   5        $��btnCancellations��5�   O   $ odustani(CTRL+C)��6   
�������$
��Left=�6z   $��59��6�   $��444,448,0,0q�6�   $	��Top=�6�   $	��179��6�   $��20(�6�   $
��Bold"�6�   ��6-   �� *CancelCommand+.��5�      �� $ 
Horizontal=�6   .+�5�      �� $��Center=�6   $��28��67   $��88��6C   
Odustani6X   �� 5�      $��
cancel.png��6   $��46��6,   $��60��68   5�      5�      5�      5�      