   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   	   #    InterfacesMatasanos.Pacientes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
   	     � Title$  	Pacientes��5   	   $	��770��6   $
��1370��6(    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K   .��5      � .+�5   
   �� -   5         ��Name$ 	txtbuscar��5      $
��Left=�6%   $��30��6@   $��108,534,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $�� ��6u   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Buscar por DNI��6}   $	��Top=�6�   $	��207��6�   ���	#FFFBFBFB���	#FFFE0000���	#FF0600006  �� 5   
   -   5        $ txtid��5      $
��Left=�6!   $��30��6<   $
 Wrap=�6H   $�� ��6\   $	��Top=�6d   $	��152��6|   ��6�   Z� ��6�   Z�  �� 
CaretBrush 6�   Z� ��6�   Z�  �� SelectionBrush 6�   Z� �� 5   
   -   5        $ txtdni��5      $
��Left=�6"   $��30��6=   $��292,211,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	 DNI��6z   $	��Top=�6�   $	��152��6�   ���	#FFFBFBFB���	#FFFE0000���	#FF0600006�   �� 5   
   -   5        $ 	txtNombre��5      $
��Left=�6%   $��30��6@   $��
76,108,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $ Nombre��6|   $	��Top=�6�   $	��152��6�   ���	#FFFBFBFB���	#FFFE0000���	#FF0600006�   �� 5   
   -   5        $ txtApellido��5      $
��Left=�6'   $��29��6B   $��292,108,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $ Apellido��6   $	��Top=�6�   $	��152��6�   ���	#FFFBFBFB���	#FFFE0000���	#FF0600006�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Fecha��5      $
��Left=�6$   $��
76,211,0,0q�6?   $	��Top=�6S   $	��152��6k   $��30��6w   ���	#FFF9F9F9���	#FFFE00006�   �� 5   
   -   5        	 ��Name$	 
btnAgregar��5      $��Agregar��6%   $
��Left=�67   $��129,366,0,0q�6R   $	��Top=�6g   $��99��6   ���	#FFFE0000
�������6�   �� 5   
   -   5        $	 btnmodificar��5      $��	Modificar��6'   $
��Left=�6;   $��292,366,0,0q�6V   $	��Top=�6k   $��99��6�   ���	#FFFE0000
�������6�   �� 5   
   -	   5        $	 	btnbuscar��5      $��Buscar��6$   $
��Left=�65   $��354,534,0,0q�6P   $	��Top=�6e   $	��113��6}   ���	#FFFE0000
�������6�   &   System.Windows.Controls.DataGrid  5   
   -
   5        
  Name$
 DGHistorial��5   /      AutoGenerateColumns .  $��	557,0,0,0q�6D   ���	#FFFF002E$	��741��6o   $	��Top=�6|   $
��Left=�6�   $	��753��6�   ��5      �� 5       �� ImageSource$ IMG/Wola1.png��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Numer Seguro��6H      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *IdNumeroSeguro+6p     5      $ 	Apellidos��6B    . $	 150 6g    6%   �� *
Apellido+6g     5      $ Nombres��6@    . $	 150 6c    6%   �� *Nombre+6c     5       $	 Dni��6=    . $	 150 6\    6%   �� *Dni+6\     5!      $ 
Nacimiento��6I    . $	 150 6o    6%   �� *FechaNacimiento+6o   5#      �� 5$   
   -   5        $	 button��5$      $��Atras��6!   $
��Left=�61   $��
46,685,0,0q�6L   $	��Top=�6`   $	��165��6x   ���	#FFFE0000
�������6�   �� 5%   
   -   5         ��Name$ label��5%      $
��Left=�6   $��
116,77,0,0q�6:   $	��Top=�6N   $��66��6f   .��5&      �� -   5        $ label_Copy1��5&      $��Nombre��6)   $
��Left=�6:   $	��Top=�6U   $��66��6m   $
��Bold"�6x   5'      �� 5(   
   -   5        $ 
label_Copy��5(      $��Apellido��6$   $
��Left=�67   $��
338,77,0,0q�6R   $	��Top=�6f   $��66��6~   $
��Bold"�6�   �� 5)   
   -   5        $ label_Copy2��5)      $��Fecha��6%   $
��Left=�65   $��129,180,0,0q�6P   $	��Top=�6e   $��82��6}   $
��Bold"�6�   �� 5*   
   -   5        $ label_Copy3��5*      $	��DNI��6%   $
��Left=�63   $��354,180,0,0q�6N   $	��Top=�6c   $��66��6{   $
��Bold"�6�   �� 5+   
   -   5         ��Name$ cbEstado��5+      $
��Left=�6%   $��218,290,0,0q�6@   $	��Top=�6U   $	��150��6m   $��28��6y   
���  ��6�   �� 5,   
   -   5        $ label1��5,      $��Estado��6    $
��Left=�61   $��144,290,0,0q�6L   $	��Top=�6a   $
��Bold"�6y   5-      5.      