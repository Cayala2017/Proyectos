   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
      #    InterfacesMatasanos.Historia1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
      -   5          � Title$  Historia��5   	   $	��770��6   $
��1370��6'    � 
ResizeMode$ NoResize=�6V    � WindowStartupLocation$ CenterScreen=�6l   .��5      � .+�5   
   �� $��10,59,852,273q�6   ���	#FFFE0000$��DATOS DEL PACIENTE��6A   .��5      �� .+�5      �� -   5         ��Name$ label��5      $��Numero��6'   $
��Left=�68   $	��Top=�6S    �� Left$ 41��6k   
 �� Top$ 18��6|   $
��Bold"�6�   �� 5      -   5        $ label1��5      $��	Apellidos��6(   $
��Left=�6<   $	��Top=�6W   $ 41��6o   $ 76��6�   $
��Bold"�6�   �� 5      -   5        $ label3��5      $��Nombres��6(   $
��Left=�6:   $	��Top=�6U   $ 41��6m   $	 134��6~   $
��Bold"�6�   �� 5      -   5        $ label4��5      $��Fecha Entrada��6(   $
��Left=�6@   $	��Top=�6[   $ 41��6s   $	 196��6�   $
��Bold"�6�   �� 5      -   5        $ labels��5      $��Fecha Salida��6(   $
��Left=�6?   $	��Top=�6Z   $ 41��6r   $	 259��6�   $
��Bold"�6�   5      5      �� 5   
   -   5         ��Name$ txtid��5      $
��Left=�6!   $��23��6<   $��	10,10,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��143��6�   ��6�   Z� ��6�   Z� ��6�   Z�  �� SelectionBrush 6�   Z� 	 �� 
CaretBrush	 6�   Z� �� 5   
   -   5        $ 	txtseguro��5      $
��Left=�6%   $��23��6@   $��
57,138,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��143��6�   *  $MahApps.Metro.Controls.TextBoxHelper
   	Watermark$
 Numero��6�   ���	#FFFB05056�   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ DTfechaEntrada��5      $
��Left=�6-   $��
57,318,0,0q�6H   $	��Top=�6\   $	��143��6t   ���	#FFFB05056�     5   
   -
   5        $ DTfechasalida��5      $
��Left=�6,   $��
57,383,0,0q�6G   $	��Top=�6[   ���	#FFFB05056s   �� 5   
   -   5         ��Name$ button��5      $��Agregar Historia��6!   $
��Left=�6<   $��330,190,0,0q�6W   $	��Top=�6l   $	��159��6�   ���	#FFFD0303���	#FFF90606
������� J� RenderTransformOrigin$ 0.256,0.483&�6�   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ DGHistorial��5"   /      AutoGenerateColumns .  $��
599,59,0,0q�6D   ���	#FFFF002E$	��426��6p   $	��Top=�6}   $
��Left=�6�   $	��728��6�   ��5#      �� 5$       �� ImageSource$ IMG/Wola1.png��6      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Entrada��6F      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *FechaEntrada+6i     5(      $ 
Fecha Alta��6I    . $	 130 6o    6%   �� *FechaAsignacion+6o     5)      $ Numero Seguro��6H    . $	 130 6q    6%   �� *FkNumeroSeguro+6q     5*      $ Nombre��6A    . $	 170 6c    6%   �� *	NombreP+6c     5+      $ Apellido��6C    . $	 170 6g    6%   �� *	ApellidoP+6g   5-      �� 5.   
   -   5        $ lNombre��5.      $
 Nombre��6#   $
��Left=�6M   $��
57,259,0,0q�6h   $	��Top=�6|   $ 0.316,0.577&�6�   $	��143��6�   ���	#FFF508086�   �� 5/   
   -   5        $ 	lApellido��5/      $
 Apellido��6%   $
��Left=�6Q   $��
57,197,0,0q�6l   $	��Top=�6�   $ 0.316,0.577&�6�   $	��143��6�   ���	#FFF508086�   �� 50   
   -   5        $ button1��50      $��Seleccionar Paciente��6"   $
��Left=�6A   $��330,134,0,0q�6\   $	��Top=�6q   $	��159��6�   ���	#FFF50808���	#FFF72929
�������6�   �� 51   
   -   5        $ btnIngresar��51      $��AsignarCama��6&   $
��Left=�6<   $��856,519,0,0q�6W   $	��Top=�6l   $	��229��6�   ���	#FFF50808���	#FFF72929
�������$��67��6�   �� 52   
   -   5        $ button2��52      $��Atras��6"   $
��Left=�62   $��
57,656,0,0q�6M   $	��Top=�6a   $	��200��6y   ���	#FFF50808
�������$��47��6�   6�   54      55      