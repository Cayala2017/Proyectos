   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   (    "InterfacesMatasanos.PacientesLista   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   -   5          � Title$  PacientesLista��5   	   $��520.973��6    $��708.27��61    � AllowsTransparency .  � WindowStyle$
 None=�6Z   ���	#FF030040.��5	      � $��0,0,0,21q�6   ��5
   
   �� 5       �� ImageSource$ IMG/Sin título-5.png��6    � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��32* �6   .+�5   
   �� -   5         ��Name$ 	txtBuscar��5      $��1��6%   $
��Left=�65   $��23��6P   $��
320,27,0,0q�6\    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ 	btnBuscar��5      $��Buscar��6$   $��1��65   $
��Left=�6E   $��
463,24,0,0q�6`   $	��Top=�6t   $	��107��6�   ���	#FFFE0000
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGHistoriales��5   /   	   AutoGenerateColumns	 .  $��	0,117,0,0q�6F   ���	#FFFF002E$	��340��6q   $	��Top=�6~   $
��Left=�6�   $	��708��6�   $��2��6�   ��5      �� 5      $ IMG/Wola1.png��6   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Numer Seguro��6H      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *IdNumeroSeguro+6p     5      $ 	Apellidos��6B    . $	 150 6g    6%   �� *
Apellido+6g     5      $ Nombres��6@    . $	 150 6c    6%   �� *Nombre+6c     5      $	 Dni��6=    . $	 150 6\    6%   �� *Dni+6\     5      $ 
Nacimiento��6I    . $	 150 6o    6%   �� *FechaNacimiento+6o   5      �� 5   
   -   5        $ txtId��5      $��2��6!   $
��Left=�65   $��23��6P   $��	10,27,0,0q�6\   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��120��6�   6�   �� 5    
   -   5        $ 	txtNombre��5       $��1��6%   $
��Left=�65   $��23��6P   $��	53,27,0,0q�6\   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5!   
   -   5        $ button��5!      $��Enviar Datos��6!   $��1��68   $
��Left=�6H   $��
199,68,0,0q�6c   $	��Top=�6w   $	��104��6�   ���	#FFC02000
�������6�   �� 5"   
   -   5        $ txtApellido��5"      $
��Left=�6'   $��23��6B   $��	82,71,0,0q�6N   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   $��2��6�   �� 5#   
   -	   5        $ button_Copy��5#      $��Cancelar��6&   $��1��69   $
��Left=�6I   $��
463,71,0,0q�6d   $	��Top=�6x   $	��104��6�   ���	#FFC02000
�������6�   5%      5&      