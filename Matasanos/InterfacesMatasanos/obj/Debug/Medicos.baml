   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
      !    InterfacesMatasanos.Medicos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
      -   5          � Title$  Medicos��5   	   $	��770��6   $
��1370��6&   
������� � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\   .��5      � .+�5   
   �� -   5         ��Name$
 Foto��5      $
��Left=�6   $	��202��69   $��
42,288,0,0q�6F   $	��Top=�6Z   $	��202��6r    J� OpacityMask 5      �� 5       �� ImageSource$7 1IMG/usuario-masculino-silueta-negro_318-50205.jpg��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGMedico��5   /      AutoGenerateColumns .  $��496,31,40,0q�6A   ���	#FFFF0023$	��668��6n   $	��Top=�6{   ��5      �� 5       �� Color$ Black��6"   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Opacity$	
 0.5Q�6#   ��5      �� 5      $ IMG/Wola1.png��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��6B      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
IdMedico+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5!      $ Imagen��6)    . $	 110 6K      CellTemplate 5"      �� 5#      .R�5$      �� $��70��6>   $��70��6I   ��6$   �� *Imagen+6I   5%      5'        5(      $ Nombres��6@    . $	 250 6c    6%   �� *Nombre+6c     5)      $ 	Apellidos��6B    . $	 250 6g    6%   �� *
Apellido+6g     5*      $ Especialidad��6F    . $	 250 6n    6%   �� *Especialidad+6n   5,      �� 5-   
   $��10,26,914,234q�6   ���	#FFFE0000$��DATOS DEL MEDICO��6A   .��5.      �� -   5         ��Name$ cbespecialidad____Copy1��5.      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Especialidad��68   $
��Left=�6h   $��231,160,0,0q�6�   $	��Top=�6�   $	��166��6�   $��30��6�   ���	#FFFB04046�   5/      �� 50   
   $��10,529,914,10q�6   ���	#FFFE0000$��BUSCAR Y ELIMINAR MEDICOS��6A   6f   �� 51   
   -   5         ��Name$ txtid��51      $
��Left=�6"   $��23��6=    �� TextWrapping$
 Wrap=�6I   $�� ��6]   $	��Top=�6e   $	��138��6}   ��6�   Z� ��6�   Z�  �� 
CaretBrush 6�   Z� ��6�   Z�  �� SelectionBrush 6�   Z� �� 52   
   -   5        $ txtapellido��52      $ Apellido��6'   $
��Left=�6S   $��23��6n   $
 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��167��6�   $��
42,167,0,0q�6�   ���	#FFFE00006�   �� 53   
   -   5        $ 	txtnombre��53      $ Nombre��6%   $
��Left=�6O   $��23��6j   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��167��6�   $��
42,105,0,0q�6�   
����������	#FFFE0000 J� SnapsToDevicePixels .  J� 	AllowDrop .  J� IsHitTestVisible .  �� 	IsEnabled . 6�  �� 54   
   -   5        $ txtnombreusuario��54      $ Nombre Usuario��6,   $
��Left=�6^   $��23��6y   $��244,105,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��167��6�   ���	#FFFE00006�   �� 55   
   -	   5        $ 	txtbuscar��55      $ Buscar Por Especialidad��6%   $
��Left=�6a   $��23��6|   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��167��6�   $��
53,595,0,0q�6�   ���	#FFFE00006�   �� 56   
   -
   5        $ txteliminar��56      $ Eliminar Por Id ��6'   $
��Left=�6\   $��23��6w   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��174��6�   $��
53,637,0,0q�6�   ���	#FFFE00006�   G� 57   
   -   5         G�Name$ txtcontr��57      $ Contraseña��6(   $
��Left=�6V   $��244,167,0,0q�6q   $	��Top=�6�   $	��167��6�   ���	#FFFE00006�   �� 58   
   -   5         ��Name$ 	btnbuscar��58      $��Buscar��6$   $
��Left=�65   $	��Top=�6P   $	��112��6h   $��267,595,0,0q�6t   
����������	#FFFE00006�   �� 59   
   -   5        $ btneliminar��59      $��Eliminar��6&   $
��Left=�69   $��267,637,0,0q�6T   $	��Top=�6i   $	��112��6�   ���	#FFFE0000
�������6�   �� 5:   
   -   5        $ 
btnagregar��5:      $��Agregar��6%   $
��Left=�67   $��267,374,0,0q�6R   $	��Top=�6g   $	��112��6   ���	#FFFE0000
�������6�   �� 5;   
   -   5        $ btnmodificar��5;      $��	Modificar��6'   $
��Left=�6;   $��266,439,0,0q�6V   $	��Top=�6k   $	��112��6�   ���	#FFFE0000
�������6�   �� 5<   
   -   5        $ 	btncargar��5<      $��
Cargar Img��6$   $
��Left=�69   $��267,306,0,0q�6T   $	��Top=�6i   $	��113��6�   ���	#FFFE0000
�������6�   �� 5=   
   -   5        $	 btn��5=      $��Atras��6   $
��Left=�6.   $��
81,679,0,0q�6I   $	��Top=�6]   $	��113��6u   ���	#FFFE0000
�������6�   �� 5>   
   -   5        $ txtruta��5>      $
��Left=�6#   $��23��6>   $��0,26,0,0q�6J   $
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��138��6�   ��6�   Z� ��6�   Z�  6�   Z� ��6�   Z�  6�   Z� �� 5?   
   -   5         ��Name$ pruebalb��5?      $��Nombre��6"   $
��Left=�63   $��	91,74,0,0q�6N   $	��Top=�6a   $
��Bold"�6y   �� 5@   
   -   5        $ Apellido��5@      $��Apellido��6"   $
��Left=�65   $��
91,141,0,0q�6P   $	��Top=�6d   $
��Bold"�6|   �� 5A   
   -   5        $ NombreUsuario��5A      $��Nombre de Usuario��6'   $
��Left=�6C   $��
267,74,0,0q�6^   $	��Top=�6r   $
��Bold"�6�   �� 5B   
   -   5        $ Contraseña��5B      $��Contraseña��6$   $
��Left=�69   $��287,141,0,0q�6T   $	��Top=�6i   $
��Bold"�6�   �� 5C   
   -   5        $ cbPlanta��5C      $
��Left=�6%   $��
42,216,0,0q�6@   $	��Top=�6T   $	��167��6l   $��30��6x   5D      5E      