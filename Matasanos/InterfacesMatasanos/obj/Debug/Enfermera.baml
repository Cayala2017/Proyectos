   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5      #    InterfacesMatasanos.Enfermera   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$  	Enfermera��5
   	   $��418.602��6   $��830.447��6,    � 
ResizeMode$ NoResize=�6<   .��5      � $��0,0,2,-1q�6   .+�5   
   �� -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��23��6@   $��
50,163,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ txtApellido��5      $
��Left=�6'   $��23��6B   $��
50,230,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5         ��Name$ button��5      $��Agregar��6!   $
��Left=�63   $��
246,95,0,0q�6N   $	��Top=�6b   $��90��6z   
���  ��
�������6�   �� 5   
   -   5        $ button1��5      $��	Modificar��6"   $
��Left=�66   $��246,162,0,0q�6Q   $	��Top=�6f   $��90��6~   
���  ��
�������6�   �� 5   
   -   5        $ button2��5      $��usuario��6"   $
��Left=�64   $��246,227,0,0q�6O   $	��Top=�6d   $��90��6|   
���  ��
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvista��5   /      AutoGenerateColumns .  $��
383,95,0,0q�6@   ���	#FFFF002E$	��187��6l   $	��Top=�6y   $
��Left=�6�   $	��401��6�   ��5      �� 5       �� ImageSource$ IMG/Wola1.png��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 DUI��6=   
   
IsReadOnly
 .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *DUI+6\     5      $	 Nombre��6@   
 . $	 150 6b    6%   �� *Nombre+6b     5      $	 Apellido��6B   
 . $	 150 6f    6%   �� *
Apellido+6f   5      �� 5   
   -   5        $ txtId��5      $
��Left=�6!   $��23��6<   $��	50,98,0,0q�6H   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   -   5         ��Name$ label��5      $��ID��6   $
��Left=�6,   $��
100,72,0,0q�6G   $	��Top=�6[   $
��Bold"�6s   �� 5   
   -	   5        $ label1��5      $��Nombres��6    $
��Left=�62   $��
82,137,0,0q�6M   $	��Top=�6a   $
��Bold"�6y   �� 5   
   -
   5        $ label2��5      $��	Apellidos��6    $
��Left=�64   $��
82,199,0,0q�6O   $	��Top=�6c   $
��Bold"�6{   �� 5    
   -   5        $ button3��5       $��Buscar��6"   $
��Left=�63   $��
680,52,0,0q�6N   $	��Top=�6b   $��88��6z   
���  ��
�������6�   �� 5!   
   -   5        $ 
txtId_Copy��5!      $
��Left=�6&   $��23��6A   $��
520,52,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5"   
   -   5        $ button3_Copy��5"      $��Atras��6'   $
��Left=�67   $��359,316,0,0q�6R   $	��Top=�6g   $��88��6   
���  ��
�������6�   5&      5'      