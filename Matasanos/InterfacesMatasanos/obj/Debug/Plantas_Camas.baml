   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   '    !InterfacesMatasanos.Plantas_Camas   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	     � Title$  Plantas_Camas��5   	   $��436.827��6   $��761.218��60   .��5	      � $��0,0,2,4q�6   .+�5
   
   �� -   5         ��Name$ 	txtnombre��5
      $
��Left=�6%   $��24��6@   $��	50,56,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��116��6�   �� 5   
   -   5        $ 	txtnumero��5      $
��Left=�6%   $��24��6@   $��
50,106,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��116��6�    J� RenderTransformOrigin$ 0.683,0.822&�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgplanta��5   /      AutoGenerateColumns .  $��
10,151,0,0q�6A   ���	#FFFF002E$	��169��6m   $	��Top=�6z   $
��Left=�6�   $	��329��6�    J� OpacityMask
 �   ���5      �� 5       �� ImageSource$ IMG/Wola1.png��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Codigo��6B   
   
IsReadOnly
 .    Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
IdPlanta+6d     5      $	 Nombre��6@   
 . $	 150 6b    6%   �� *Nombre+6b     5      $	 	Nº Camas��6E   
 . $	 100 6i    6%   �� *NumeroCamas+6i   5        5   
   -   5        $ dgcama��5   /    .  $��408,151,0,0q�6?   ���	#FFFF002E$	��169��6l   $	��Top=�6y   $
��Left=�6�   $	��329��6�   
 �   ���5      �� 5      $ IMG/Wola1.png��6    5        5      $	 Codigo��6@   
 . $ 70 6b    6%   �� *IdCama+6b     5      $	 Codigo de planta��6B   
 . $	 150 6n    6%   �� *
FkPlanta+6n   5      �� 5    
   -   5        $ 	txtIdCama��5       $
��Left=�6%   $��24��6@   $��
408,56,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��116��6�   �� 5!   
   -   5        $ txtfkplanta��5!      $
��Left=�6'   $��24��6B   $��486,106,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��116��6�   $ 0.683,0.822&�6�   �� 5"   
   -   5         ��Name$ label��5"      $��Nombre��6   $
��Left=�60   $��	81,28,0,0q�6K   $	��Top=�6^   $
��Bold"�6v   $��24��6�   $��64��6�   $ 0.516,0.833&�6�   �� 5#   
   -   5        $ label1��5#      $��Numero De Camas��6    $
��Left=�6:   $��	50,84,0,0q�6U   $	��Top=�6h   $
��Bold"�6�   $��24��6�   $	��116��6�   �� 5$   
   -	   5        $ label2��5$      $��IdCama��6    $
��Left=�61   $��
440,35,0,0q�6L   $	��Top=�6`   $
��Bold"�6x   $��24��6�   $��61��6�   �� 5%   
   -
   5        $ label3��5%      $��planta��6    $
��Left=�61   $��
529,73,0,0q�6L   $	��Top=�6`   $
��Bold"�6x   $��33��6�   $��50��6�   �� 5&   
   -   5         ��Name$ btnAgregarPlanta��5&      $��Agregar��6+   $
��Left=�6=   $��
240,53,0,0q�6X   $	��Top=�6l   $��89��6�   ���	#FFFE0000
�������6�   �� 5'   
   -   5        $ btnModificarPlanta��5'      $��	Modificar��6-   $
��Left=�6A   $��240,103,0,0q�6\   $	��Top=�6q   $��89��6�   ���	#FFFE0000
�������6�   �� 5(   
   -   5        $ btnEliminarPlanta��5(      $��Eliminar��6,   $
��Left=�6?   $��138,339,0,0q�6Z   $	��Top=�6o   $��75��6�   ���	#FFFE0000
�������6�   �� 5)   
   -   5        $ btnAgregarCama��5)      $��Agregar��6)   $
��Left=�6;   $��
638,62,0,0q�6V   $	��Top=�6j   $��75��6�   ���	#FFFE0000
�������$ 
0.12,0.552&�6�   6�   �� 5*   
   -   5        $ btnModificarCama��5*      $��	Modificar��6+   $
��Left=�6?   $��638,106,0,0q�6Z   $	��Top=�6o   $��89��6�   ���	#FFFE0000
�������6�   �� 5+   
   -   5        $ btnEliminarCama��5+      $��Eliminar��6*   $
��Left=�6=   $��527,339,0,0q�6X   $	��Top=�6m   $��75��6�   ���	#FFFE0000
�������6�   �� 5,   
   -   5        $ btnatras��5,      $��Atras��6#   $
��Left=�63   $��348,363,0,0q�6N   $	��Top=�6c   $��75��6{   ���	#FFFE0000
�������6�   5.      5/      