   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5      -    'HCI_Bolnica.Dialogues.View.MedicinePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:HCI_Bolnica.Dialogues.View     5        N� Title$  MedicinePage��5	       J� InputBindings 5
      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ A��6&    �� Command 6.   �� *AddMedicineCommand+�� 5   
   $
 Ctrlf�6   $ E��6&    6.   �� *EditMedicineCommand+�� 5   
   $
 Ctrlf�6   $ D��6&    6.   �� *DeleteMedicineCommand+.��5      �  � ColumnDefinitions 5   
   �� 5      $	��99* �6   �� 5      $	��17* �6   .+�5   
   �� $��Center=�6   $��30(�6-   $��27,-4,354.2,285.4q�6;   $	��114��6V   .��6b   Lekovi6j   �� 5   
   -   5         ��Name$ 	txtSearch��5   k    �� TextAlignment$ Center=�6   $��383,33,10.2,271.4q�6~   ��6)   �� *
SearchTerm+ �� UpdateSourceTrigger$ PropertyChanged=�6~   �� 5   
   $��20(�6   
�������$
��Left=�63   $��45��6N   $��0.8,32,0,271.4q�6Z   $��1��6r   .��5      �� .+�5      �� $��search1.png��6   $��25��6-   $��28��69   5      5      �� 5   
   $��27,65,39,87.4q�6   $��2��6,   .@�5      �� -   5        $��tabUncertified��5      $��Neovereni lekovi��6-   .��5      &   System.Windows.Controls.DataGrid  -   5        $��dataGridUncertified��5   =   	   AutoGenerateColumns	 .  $��Center=�5   7   $��0,19,-7.2,18.4q�6T   $	��516��6l   ��5      �� *	Medicines+
 �� SelectedItem
 6X   �� *SelectedItem+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      Header$ ID��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *ID+  5!      $ * 6-   $ Naziv��67    6F   �� *Name+  5"      $ * 6-   $ Sastav��67    6G   �� *Composition+  5#      $ * 6-   $ Kolicina[mg]��67    6M   �� *Grams+  5$      $ * 6-   $ Zamena��67    6G   �� *
Replacment+  5%      $ * 6-   $ Komentar��67    6I   �� *	Comment+5'      5(      �� 5)      -   5        $��tabCertified��5)      $��Overeni lekovi��6+   .��5*        -   5        $��dataGridCertified��5*   E   	 .     SelectionMode$ Single=�5+         
IsReadOnly . $��Center=�6<   $��0,9,-17.2,18.4q�6Y   $	��526��6q   ��5*      �� *MedicinesApproved+
 6z   �� *SelectedItem+ 5,        5-      $ * 6-   $ ID��67    6C   �� *ID+  5.      $ * 6-   $ Naziv��67    6F   �� *Name+  5/      $ * 6-   $ Sastav��67    6G   �� *Composition+  50      $ * 6-   $ Kolicina[mg]��67    6M   �� *Grams+  51      $ * 6-   $ Zamena��67    6G   �� *
Replacment+  52      $ * 6-   $ Komentar��67    6I   �� *	Comment+54      55      56      �� 57   
    � ToolTip$ dodaj lek(CTRL+A)��6   $��20(�6U   
�������$��27,276,374.2,10.4q�6v    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6.   �� *AddMedicineCommand+.��58      ��  �� Orientation$ 
Horizontal=�6   $��86��62   $��33��6=   .+�59      �� $��Center=�6   $��Center=�67   Dodaj6[   �� 5:      $��add.png��6   5;      5<      �� 5=   
   $ izmeni (CTRL+E)��6   $��20(�6S   
�������$��246,276,156.2,10.4q�6t   ��6+   �� *EditMedicineCommand+.��5>      �� $ 
Horizontal=�6   $��27��62   $��96��6>   .+�5?      �� $��Center=�6   $��Center=�67   Izmeni6\   �� 5@      $��edit.png��6   5A      5B      �� 5C   
   $ obrisi(CTRL+D)��6   $��20(�6T   
�������$��453,276,39,10.4q�6u   $��2��6�   ��6*   �� *DeleteMedicineCommand+.��5D      �� $ 
Horizontal=�6   $��35��62   $��94��6>   .+�5E      �� $��Center=�6   $��Center=�67   $��55��6T   $��31��6_   $��	0,4,0,0.2q�6k   Obrisi6�   �� 5F      $��
delete.png��6   5G      5H      5I      5J      