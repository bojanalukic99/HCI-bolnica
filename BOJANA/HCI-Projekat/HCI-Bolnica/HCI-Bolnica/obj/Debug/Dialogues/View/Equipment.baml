   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5      *    $HCI_Bolnica.Dialogues.View.Equipment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:HCI_Bolnica.Dialogues.View     5        N� Title$  	Equipment��5	       J� InputBindings 5
      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ A��6&    �� Command 6.   �� *AddEquipmentCommand+�� 5   
   $
 Ctrlf�6   $ E��6&    6.   �� *EditEquipmentCommand+�� 5   
   $
 Ctrlf�6   $ D��6&    6.   �� *DeleteEquipmentCommand+.��5      � .+�5   
   �� $��Center=�6   $	��Top=�6-   $��30(�6E   $��OPREMA��6S   $��
12,0,452,0q�6d   $	��136��6x   �� 5   
   -   5         ��Name$ 	txtSearch��5   k    �� TextAlignment$ Center=�6   $��399,33,88,266q�6~   ��6*   �� *
SearchTerm+ �� UpdateSourceTrigger$ PropertyChanged=�6~   �� 5   
   $��20(�6   
�������$
��Left=�63   $��45��6N   $��526,33,0,266q�6Z   .��5      �� .+�5      �� $��search1.png��6   $��25��6-   $��28��69   5      5      �� 5   
   -   5        $��tabEquipment��5   5   $��24,73,29,72q�6I    �� SelectedIndex 6   �� *Tabs+.@�5      �� -   5        $��tabStaticEquipment��5      $��Staticka��60   .��5      &   System.Windows.Controls.DataGrid  -   5        $��dataGridStaticEquipment��5   D   	   AutoGenerateColumns	 .  $	��140��5      $��
10,4,3.2,0q�6    $	��Top=�64   ��5      �� *StaticEquipments+
 �� SelectedItem
 6c   �� *SelectedItem+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *EquipmentName+6^     5       $ Kolicina��6-   $ * 6\    6?   �� *
Quantity+6\     5!      $ Proizvodjac��6-   $ * 6d    6B   �� *Manufacturer+6d   5#      5$      �� 5%      -   5        $��tabConsumableEquipment��5%      $��Potrosna��64   .��5&        -   5        $!��dataGridConsumableEquipment��5&   H   	 .  $��Center=�5(      $	��132��5)      $��2,-2,2.2,-3.2q�6    $	��Top=�67   $	��491��6O   ��5&      �� *ConsumableEquipments+
 6k   �� *SelectedItem+ 5*        5+      $ Naziv��6-   $ * 6^    6<   �� *EquipmentName+6^     5,      $ Kolicina��6-   $ * 6\    6?   �� *
Quantity+6\     5-      $ Proizvodjac��6-   $ * 6d    6B   �� *Manufacturer+6d   5/      50      51      �� 53   
    � ToolTip$ dodaj opremu(CTRL+A)��6   $��20(�6Y   
�������$��24,273,481,21q�6z   ��61   �� *AddEquipmentCommand+.��54      ��  �� Orientation$ 
Horizontal=�6   $��85��62   .+�55      �� $��Center=�6   $��Center=�68   $��34��6U   $��56��6a   �� 6m   $�Dodaj��6q   6�   �� 56      $��add.png��6   $��29��6)   57      58      �� 59   
   $ izmeni opremu(CTRL+E)��6   $��20(�6Z   
�������$��242,273,264,21q�6{   ��61   �� *EditEquipmentCommand+.��5:      �� $ 
Horizontal=�6   $��27��62   $��96��6>   .+�5;      �� $��Center=�6   $��Center=�67   Izmeni6\   �� 5<      $��edit.png��6   5=      5>      �� 5?   
   $ obrisi opmrenu(CTRL+D)��6   $��20(�6]   
�������$��479,273,29,21q�6~   ��62   �� *DeleteEquipmentCommand+.��5@      �� $ 
Horizontal=�6   .+�5A      �� $��Center=�6   $��Center=�67   Obrisi6\   �� 5B      $��
delete.png��6   5C      5D      5E      5F      