   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   (    "InterfacesMatasanos.ListadeMedicos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	     � Title$  ListadeMedicos��5   	   $��724.742��6    $��901.938��61    � 
ResizeMode$ NoResize=�6A   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��272* �6   �� 5      $	��23* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGMedico��5   /      AutoGenerateColumns .  $��
10,10,10,0q�6A   ���	#FFFF0023$	��684��6m   $	��Top=�6z   
���   �$��2��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.5Q�6#   ��5      �� 5       �� ImageSource$ IMG/Wola1.png��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Codigo��6B   
   
IsReadOnly
 .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
IdMedico+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Imagen��6)   
 . $	 110 6K      CellTemplate 5      �� 5      .R�5      �� $��70��6>   $��70��6I   ��6$   �� *Imagen+6I   5      5        5      $	 Nombres��6@   
 . $	 250 6c    6%   �� *Nombre+6c     5      $	 	Apellidos��6B   
 . $	 250 6g    6%   �� *
Apellido+6g     5       $	 Especialidad��6F   
 . $	 250 6n    6%   �� *Especialidad+6n   5"      5$      5%      