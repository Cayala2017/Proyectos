   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   *    $InterfacesMatasanos.ListadeHistorias   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	     � Title$  ListadeHistorias��5   	   $��529.897��6"   $��744.33��63    � 
ResizeMode$ NoResize=�6B   .��5	      � $��0,0,2,-4q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgvista��5
   /      AutoGenerateColumns .  $��0,80,0,0q�6@   ���	#FFFF002E$	��372��6j   $	��Top=�6w   $
��Left=�6�   $	��724��6�   ��5      �� 5       �� ImageSource$ IMG/Wola1.png��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ fecha��6E      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6f   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *FechaVisita+6f     5      $
 hora��6D    . $	 150 6d   	 6%   �� *
HoraVisita+6d     5      $ Medico��6B    . $	 150 6d   	 6%   �� *
FkMedico+6d     5      $ Paciente��6H    . $	 150 6l   	 6%   �� *FkPacienteCama+6l   5      (  "System.Windows.Controls.DatePicker  5   
   -   5        
  Name$
 dtFecha��5      $
��Left=�6&   $��
253,30,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ button��5      $��Buscar Por Fecha��6!   $
��Left=�6<   $��
442,30,0,0q�6W   $	��Top=�6k   $	��150��6�   
���  ��
�������6�   5      5      