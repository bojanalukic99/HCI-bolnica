   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5      )    #HCI_Bolnica.Dialogues.View.RoomPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:HCI_Bolnica.Dialogues.View     5        N� Title$  RoomPage��5	       J� InputBindings 5
      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ A��6&    �� Command 6.   �� *AddRoomCommand+�� 5   
   $
 Ctrlf�6   $ E��6&    6.   �� *EditRoomCommand+�� 5   
   $
 Ctrlf�6   $ D��6&    6.   �� *DeleteRoomCommand+�� 5   
   $
 Ctrlf�6   $ O��6&    6.   �� *EquipmentCommand+.��5      �  � RowDefinitions 5   
   �� 5      $	��71* �6   �� 5      $	��19* �6   .+�5   
   �� $��
Prostorije��6   $��30(�6%   $��0,0,438,168.8q�63   �� 5   
   -   5         ��Name$ 	txtSearch��5   l    �� TextAlignment$ Center=�6   $��403,10,75,212.8q�6    J� RenderTransformOrigin$ 0.484,0.447&�6�   ��6+   �� *
SearchTerm+	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5   
   $��20(�6   
�������$
��Left=�63   $��38��6N   $��541,10,0,212.8q�6Z   .��5      �� .+�5      �� $��search1.png��6   $��18��6-   $��33��69   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridRoom��5   1   
   AutoGenerateColumns
 .     SelectionMode$ Single=�5         
IsReadOnly . $��Center=�6<   $	��174��5      $��	3,62,-1,0q�6    $	��Top=�63   $	��598��6K   $ 0.5,0.5&�6W   ��5      �� *Rooms+ �� SelectedItem 6E   �� *SelectedItem+z�5       V� 5!      .~�5"      �� �� 5#      �� 5$       �� Angle$ 0.157Q�6&   T� 5%      5&         Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Id Prostorije��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *ID+6S     5*      $ Sprat Prostorije��6%   $ * 6Y    6?   �� *Floor+6Y     5+      $ Vrsta Prostorije��6%   $ * 6\    6?   �� *
RoomType+6\   5-      �� 5.   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��92��6f   $��-11,0,0,-0.4q�6r   $	��500��6�   $��1��6�   .+�5/      ��  � ToolTip$ dodaj prostoriju(CTRL+A)��6   $��76��6\   $��Center=�6g   $��20,34,20,10q�6�   
���������69   �� *AddRoomCommand+.��50      �� $ 
Horizontal=�6   $��27��66   $��75��6B   .+�51      �� $��Center=�6    $��Center=�6;   $��	0,6,0,5.2q�6X   $��36��6k   Dodaj6}   �� 52      $��add.png��6   $��27��6-   $��33��69   53      54      �� 55      $ izmeni prostoriju(CTRL+E)��6   $��80��6]   $��Center=�6h   $��20,34,20,10q�6�   
���������69   �� *EditRoomCommand+.��56      �� $ 
Horizontal=�6   $��27��66   $��75��6B   .+�57      �� $��Center=�6    $��Center=�6;   $��	0,6,0,5.2q�6X   $��36��6k   Izmeni6~   �� 58      $��edit.png��6   $��27��6.   $��33��6:   59      5:      �� 5;      $ obrisi prostoriju(CTRL+D)��6   $��80��6_   $��Center=�6j   $��20,34,20,10q�6�   
���������69   �� *DeleteRoomCommand+.��5<      �� $ 
Horizontal=�6   $��27��66   $��75��6B   .+�5=      �� $��Center=�6    $��Center=�6;   $��	0,6,0,5.2q�6X   $��36��6k   �� 6w   $�Obrisi��6{   6�   �� 5>      $��
delete.png��6   $��27��60   $��33��6<   5?      5@      �� 5A      $1 +uvid u opremu selektovane prostrije(CTRL+O)��6   $��87��6p   $��Center=�6{   $��20,34,20,10q�6�   
���������6K   �� *EquipmentCommand+.��5B      �� $ 
Horizontal=�6   $��37��66   $��87��6B   .+�5C      �� $��Center=�6    $��Center=�6;   $��	0,8,0,6.8q�6X   $��44��6k   $��22��6v   �� 6�   $�Oprema��6�   6�   �� 5D      $��equipment2.png��6   $��40��64   $��	0,0,0,6.8q�6?   5E      5F      5G      5H      5I      