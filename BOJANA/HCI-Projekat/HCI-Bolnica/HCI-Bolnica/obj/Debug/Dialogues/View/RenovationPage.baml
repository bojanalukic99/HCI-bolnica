   M S B A M L   `   `   `  ����F  BHCI-Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HCI_Bolnica.Dialogues.ViewHCI_Bolnica.Dialogues.View  5      /    )HCI_Bolnica.Dialogues.View.RenovationPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:HCI_Bolnica.Dialogues.View     5        N� Title$  RenovationPage��5	       J� InputBindings 5
      �� 5   
    �� 	Modifiers$
 Ctrlf�6   
 �� Key$ Z��6&    �� Command 6.   �� *RenovationCommand+�� 5   
   $
 Ctrlf�6   $ S��6&    6.   �� *ConnectingRoomsCommand+�� 5   
   $
 Ctrlf�6   $ D��6&    6.   �� *DivideTheRoomCommand+.��5      � .+�5   
   �� $��RASPORED RENOVIRANJA��6   $��30(�6/   $��Center=�6=   $	��Top=�6Z   $��35,10,190,0q�6r   $	��375��6�   �� 5   
   
�������$��491,0,10,290.4q�6F   ��6   �� *ReportCommand+.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Center=�6   $��Center=�69   $��20(�6T   	Izveštaj6l   �� 5      $��izvestaj.png��6   $��38��6.   5      5      �� 5   
   $	��OD:��6   $��47,62,526,246.4q�6    J� RenderTransformOrigin$ 0.462,0.733&�67   (  "System.Windows.Controls.DatePicker  5   
   $��77,62,451,248.4q�6@      SelectedDate 6   �� *StartOfRenovation+6@   �� 5   
   $	��DO:��6   $��204,60,372,248.4q�6   $ 0.462,0.733&�68     5   
   $��233,61,285,249.4q�6>    6   �� *EndOfRenovation+6>   �� 5   
   $��20(�63   
�������$
��Left=�6U   $��64��6p   $��397,55,0,249.4q�6|   ��6   �� *SearchCommand+.��5      �� .+�5      �� $��search1.png��6   $��21��6-   $��25��69   5      5      &   System.Windows.Controls.DataGrid  5    
   -   5        $��dataGridRoom��5    7      AutoGenerateColumns .  $	��155��5!      $��21,103,10,0q�6    $	��Top=�65   ��5       �� *Renovations+	   Columns	 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Broj Prostorije��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *Room+  5%      $
 Datum pocetka��6%   $ * 6<    6F   �� *DateOfRenovationStart+  5'      $
 Datum zavrsetka��6%   $ * 6>    6H   �� *DateOfRenovationEnd+5*      �� 5+   
    � ToolTip$' !zakazi obicno renoviranje(CTRL+A)��6   
�������$��25,278,440,10.4q�6w   $��20(�6�   ��6=   �� *RenovationCommand+.��5,      �� $ 
Horizontal=�6   $��39��62   .+�5-      �� $��Center=�6   $��Center=�69   �� 6U   $�	Renoviraj��6Y   6m   �� 5.      $��renovation.png��6   5/      50      �� 51   
   $" zakazi spajanje soba(CTRL+C)��6   
�������$��233,278,232,10.4q�6w   $��20(�6�   ��68   �� *ConnectingRoomsCommand+.��52      �� $ 
Horizontal=�6   .+�53      �� $��Center=�6   $��Center=�69   �� 6U   $�Spajanje soba��6Y   6q   54      55      �� 56   
   $" zakazi deljenje sobe(CTRL+D)��6   
�������$��452,278,13,10.4q�6u   $��20(�6�   ��68   �� *DivideTheRoomCommand+.��57      �� $ 
Horizontal=�6   .+�58      �� $��Center=�6   $��Center=�69   �� 6U   $�Deljenje sobe��6Y   6q   59      5:      5<      5=      