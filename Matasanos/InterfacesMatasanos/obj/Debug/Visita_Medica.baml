   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   
   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	      '    !InterfacesMatasanos.Visita_Medica   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5   
   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	      -   5          � Title$  Visita Medica��5
   	   $��498.496��6   $��974.436��60    � 
ResizeMode$ NoResize=�6\   .��5      � .+�5   
   �� -   5         ��Name$ cbmedico��5      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Medico��6%   $
��Left=�6O   $��	73,36,0,0q�6j   $	��Top=�6}   $	��143��6�   �� 5   
   -   5        $ 
cbpaciente��5      $ Paciente��6'   $
��Left=�6S   $��	73,88,0,0q�6n   $	��Top=�6�   $	��143��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFechavisita��5      $
��Left=�6,   $��
73,202,0,0q�6G   $	��Top=�6[   �� 5   
   -   5         ��Name$ txtdiagnostico��5      $
��Left=�6*   $	��101��6E   $��
73,264,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $ Diagnostico de Paciente��6z   $�� ��6�   $	��Top=�6�   $	��225��6�   �� 5   
   -   5         ��Name$ 
btnagregar��5      $��Agregar��6%   $
��Left=�67   $��
346,75,0,0q�6R   $	��Top=�6f   $��75��6~   ���	#FFF91212
�������6�   �� 5   
   -   5        $ 	btnbuscar��5      $��Buscar��6$   $
��Left=�65   $��
81,383,0,0q�6P   $	��Top=�6d   $��75��6|   ���	#FFFE0000
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvista��5   /   	   AutoGenerateColumns	 .  $��	426,0,0,0q�6@   ���	#FFFF002E$	��459��6k   $	��Top=�6x   $
��Left=�6�   $	��542��6�   ��5      �� 5      
 �� ImageSource$
 IMG/Wola1.png��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ fecha��6E      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *FechaVisita+6f     5      $
 hora��6D    . $	 150 6d    6%   �� *
HoraVisita+6d     5      $ Medico��6B    . $	 150 6d    6%   �� *
FkMedico+6d     5      $ Paciente��6H    . $	 150 6l    6%   �� *FkPacienteCama+6l   5        5   
   -	   5        $ 	txtbuscar��5      $
��Left=�6(   $��184,386,0,0q�6C   $	��Top=�6X   �� 5   
   -
   5        $ txthora��5      $ Hora de visita��6#   $
��Left=�6U   $��23��6p   $��
73,145,0,0q�6|   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��143��6�   �� 5    
   -   5         ��Name$ label��5       $��Medico��6   $
��Left=�60   $��	73,10,0,0q�6K   $	��Top=�6^   $��50��6v   $
��Bold"�6�   �� 5!   
   -   5        $ label1��5!      $��Paciente��6    $
��Left=�63   $��	73,62,0,0q�6N   $	��Top=�6a   $��61��6y   $
��Bold"�6�   �� 5"   
   -   5        $ label2��5"      $��Hora de Visita��6    $
��Left=�69   $��
73,119,0,0q�6T   $	��Top=�6h   $��92��6�   $
��Bold"�6�   �� 5#   
   -   5        $ label3��5#      $��fecha de Visita��6    $
��Left=�6:   $��
73,171,0,0q�6U   $	��Top=�6i   $��92��6�   $
��Bold"�6�   �� 5$   
   -   5        $ label4��5$      $��Diagnostico��6    $
��Left=�66   $��
73,233,0,0q�6Q   $	��Top=�6e   $��83��6}   $
��Bold"�6�   5%      5&      