   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5   	   .    (HCI_Bolnica.Dialogues.View.ManagerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HCI_Bolnica.Dialogues.View     5   	     � Title$  ManagerWindow��5   	   $	��450��6   $	��800��6,    J� InputBindings 5	      �� 5
   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ H��6&    �� Command 6.   �� *HomeCommand+�� 5   
   $
 Ctrlf�6   $ L��6&    6.   �� *LogoutCommand+�� 5   
   $
 Ctrlf�6   $ P��6&    6.   �� *RoomCommand+�� 5   
   $
 Ctrlf�6   $ R��6&    6.   �� *RenovationCommand+�� 5   
   $
 Ctrlf�6   $ L��6&    6.   �� *MedicineCommand+�� 5   
   $
 Ctrlf�6   $ O��6&    6.   �� *EquipmentCommand+.��5      � .+�5   
   �� $��main.png��6   $
��Fill=�6"    � Cursor$ SizeWE��61    J� RenderTransformOrigin$ 0.5,0.5&�6A   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $��Upravnik:Elena Mitrovic��6   $��25(�66   $��	0,0,0,0.2q�6D   $	��269��6W   �� 5       � ToolTip$ pocetna strana(CTRL+H)��6   $��	0,5,0,368q�6V   $��54��6i   
������ ��66   �� *HomeCommand+.��5      �� $��42��6   .+�5      �� $��home.png��6   $��39��6.   $��43��6:   5      5      �� 5      $ odjavi se(CTRL+L)��6   $��290,5,0,368q�6S   $	��165��6h   $��25(�6u   
������ ��61   �� *LogoutCommand+.��5      �� $ 
Horizontal=�6   .+�5      �� $��37��6    �� 6-   $�	Odjavi se��61   6E   �� 5      $��
logout.png��6   $��42��60   5      5      5       �� 5!   
   $ Vertical=�6   $��Right=�6,   $	��Top=�6H   $��0,55,653.6,0q�6`   $	��365��6v   .+�5"      �� $ rad sa prostorija(CTRL+P)��6   $��20(�6Z   $	��140��6h   $��86��6t   $��Right=�6�   
������ ��69   �� *RoomCommand+.��5#      �� .+�5$      �� 
Prostorije6,   �� 5%      $��room.png��6   $��45��6.   $��80��6:   $ -0.037,0.259&�6E   5'      5(      �� 5)      $% zakazivanje renoviranja(CTRL+R)��6   $��20(�6e   $	��140��6s   $��93��6   $��Right=�6�   
������ ��6?   �� *RenovationCommand+.��5*      �� .+�5+      �� Renoviranje6-   �� 5,      $��renovation.png��6   $��42��64   $	��104��6@   5-      5.      �� 5/      $ rad sa lekovima(CTRL+L)��6   $��20(�6[   $	��140��6i   $��93��6u   $��Right=�6�   
������ ��67   �� *MedicineCommand+.��50      �� .+�51      �� $��Center=�6    Lekovi6E   �� 52      $��medicine.png��6   $��46��62   $	��104��6>   53      54      �� 55      $ rad sa opremom(CTRL+O)��6   $��20(�6[   $	��140��6i   $��93��6u   $��Right=�6�   
������ ��66   �� *EquipmentCommand+.��56      �� .+�57      �� $��Center=�6    Oprema6E   �� 58      $��equipment2.png��6   $��49��64   $	��117��6@   59      5:      5;       � 5=   
   -   5        	  �Name$	 ManagerFrame��5=      $��140,55,-0.4,0q�6&   5>      5?      