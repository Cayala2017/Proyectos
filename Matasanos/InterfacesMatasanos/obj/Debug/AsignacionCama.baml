   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5      (    "InterfacesMatasanos.AsignacionCama   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      -   5          � Title$  AsignacionCama��5
   	   $��575.48��6    $��1137.024��60   .��5      � $��0,1,0,-1q�6   .+�5   
   �� $��10,3,641,230q�6   $��DATOS DEL PACIENTE��6)   ���	#FFFE0000.��5      �� .+�5      �� -   5         ��Name$ ccama��5      $
��Left=�6*   $	��Top=�6E   $	��143��6]    J� RenderTransformOrigin$ 0.5,0.5&�6i   $��30��6�   ���	#FF686464 �� Left$ 25��6�   
 �� Top$	 154��6�   ��5      �� 5       �� EndPoint$	 0,1&�6.    �� 
StartPoint$	 0,0&�6=   .��5      �  � Color$ 	#FFF0F0F0��6+    � Offset$ 0Q�6=   � 5      $ White��6+   $ 1Q�69   5      z�5      V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$	 -0.135Q�6.   T� 5      5      5      �� 5      -   5        
 ��Name$
 label��5      $��Fecha Asignación��6'   $ 29��6B   $ 10��6S   $
��Bold"�6c   �� 5       -   5        $
 label1��5       $��	Historial��6(   $ 29��6<   $ 68��6M   $
��Bold"�6]   �� 5!      -   5        $
 label2��5!      $
��Cama��6(   $ 29��67   $	 129��6H   $
��Bold"�6Y   5"      5#      �� 5$   
   -   5         ��Name$ txtid��5$      $
��Left=�6!   $��23��6<    �� TextWrapping$
 Wrap=�6H   $�� ��6\   $	��Top=�6d   $	��143��6|   ��6�   Z� ��6�   Z�  �� 
CaretBrush 6�   Z� ��6�   Z�  �� SelectionBrush 6�   Z� �� 5%   
   -   5        $ txteliminar��5%      $
��Left=�6'   $��23��6B   $��
41,246,0,0q�6N   $
 Wrap=�6b   $�� ��6v   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$&  Eliminar por Fecha de Asignacion��6~   $	��Top=�6�   $	��185��6�   ���	#FFF302026�   �� 5&   
   -   5        $ 	txtbuscar��5&      $ Buscar por ID��6%   $
��Left=�6V   $��23��6q   $��
41,433,0,0q�6}   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��185��6�   ���	#FFF302026�   (  "System.Windows.Controls.DatePicker  5'   
   -	   5          Name$ txtfecha��5'      $
��Left=�6'   $��	41,71,0,0q�6B   $	��Top=�6U   
���  ��6m   �� 5(   
   -
   5         ��Name$ 
btnagregar��5(      $��Agregar��6%   $
��Left=�67   $��
343,71,0,0q�6R   $	��Top=�6f   $��87��6~   ���	#FFFE0000
�������6�   �� 5)   
   -   5        $ btnmodificar��5)      $��	Modificar��6'   $
��Left=�6;   $��343,154,0,0q�6V   $	��Top=�6k   $��87��6�   ���	#FFFE0000
�������6�   �� 5*   
   -   5        $ btneliminar��5*      $��Eliminar��6&   $
��Left=�69   $��343,246,0,0q�6T   $	��Top=�6i   $��87��6�   ���	#FFFE0000
�������6�   �� 5+   
   -   5        $ 	btnbuscar��5+      $��Buscar��6$   $
��Left=�65   $��264,433,0,0q�6P   $	��Top=�6e   $��75��6}   ���	#FFFE0000
�������6�   �� 5,   
   -   5        $ button4��5,      $��Atras��6"   $
��Left=�62   $��395,430,0,0q�6M   $	��Top=�6b   $��75��6z   ���	#FFFE0000
�������6�   &   System.Windows.Controls.DataGrid  5-   
   -   5          Name$ DGPacienteCama��5-   /      AutoGenerateColumns .  $��
537,10,0,0q�6G   ���	#FFFF002E$	��311��6s   $	��Top=�6�   $
��Left=�6�   $	��562��6�   ��5.      �� 5/       �� ImageSource$ IMG/Wola1.png��6      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ codigo��6H      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *IdPacienteCama+6j     53      $ Fecha de Asignacion��6I    . $	 150 6x    6%   �� *FechaAsignacion+6x     54      $
 Cama��6@    . $	 150 6`    6%   �� *FkCama+6`     55      $ 	Historial��6D    . $	 150 6i    6%   �� *
FkHistoria+6i   57        58   
   -   5        $ DGCAMA��58   /    .  $��668,334,0,0q�6?   ���	#FFFF002E$	��200��6l   $	��Top=�6y   $
��Left=�6�   $	��290��6�   ��59      �� 5:      $ IMG/Wola1.png��6    5<        5=      $ Codigo de Cama��6@    . $	 150 6j    6%   �� *IdCama+6j     5>      $ codigo de planta��6B    . $	 150 6n    6%   �� *
FkPlanta+6n   5@      �� 5A   
   -   5        $ 
chistorial��5A      $
��Left=�6'   $	��Top=�6B   $	��143��6Z   $��
41,127,0,0q�6f   $��31��6z   6�   5B      5C      