   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   6    0HCI_Bolnica.Dialogues.View.EquipmentInRoomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	     � Title$  EquipmentInRoomWindow��5   	   $	��450��6'   $	��800��64    J� InputBindings 5	      �� 5
   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ A��6&    �� Command 6.   �� *
AddCommand+�� 5   
   $
 Ctrlf�6   $ D��6&    6.   �� *DeleteCommand+�� 5   
   $
 Ctrlf�6   $ C��6&    6.   �� *CloseCommand+.��5      � $��	0,0,3.6,0q�6   .+�5   
   �� $��main.png��6   $
��Fill=�6"   �� 5   
   $��Oprema prostorije��6   $��20(�6,   $��Center=�6:   $	��Top=�6W   $��24,31,550.6,0q�6o   $��51��6�   $	��219��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridRoom��5   6      AutoGenerateColumns .  $	��246��5      $��24,99,21.6,0q�6    $	��Top=�66   ��5      �� *
Equipments+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *EquipmentName+6V     5      $ Kolicina��6%   $ * 6T   	 67   �� *
Quantity+6T   5      �� 5   
   
 � ToolTip$'
 !dodaj opremu u prostoriju(CTRL+A)��6   $��20(�6]   
�������$��200,367,442,10q�6~   ��6>   �� *
AddCommand+.��5      ��  �� Orientation$ 
Horizontal=�6   $	��102��62   .+�5      �� $��Center=�6   $��54��67   Dodaj6I   �� 5      $��add.png��6   5      5       �� 5!   
   $)
 #obrisi opremu iz prostorije(CTRL+D)��6   $��20(�6a   
�������$��395,367,246,10q�6�   ��6?   �� *DeleteCommand+.��5"      �� $ 
Horizontal=�6   .+�5#      �� $��Center=�6   $��64��67   Obrisi6J   �� 5$      $��
delete.png��6   5%      5&      5'      5(      