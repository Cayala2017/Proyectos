   M S B A M L   `   `   `  ����N  JInterfacesMatasanos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InterfacesMatasanosInterfacesMatasanos  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   	        InterfacesMatasanos.Inicio   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InterfacesMatasanos     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  metroWindow��5      $��Regular"�5   	   $��16(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	    � Title$ Inicio��5   	   $	��770��6   $
��1370��6%    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   ���	#FF81BAD8 � 	Resources 5        Storyboard1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value��%q  &	       �� 5   
   .��5      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6,   $
 grid��6�   .\�5        $	 0:0:2.1��6'   $
 1.008Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $
 grid��6�   .\�5        $	 0:0:2.1��6'   $
 3Q�69   5      U� 5       $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $
 grid��6�   .\�5!        $	 0��6'   $
 -15.899Q�63     5"      $	 0:0:2.1��6'   $
 0Q�69   5#      5$      5%       � Triggers 5&      :� 5'   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5(      �� #��[ 6   5)      .��5+      � -   5         �Name$
 grid��5+       J� RenderTransformOrigin$ 0.5,0.5&�6   z�5,   
   V� 5-      .~�5.      �� �� 5/      �� 50      T� 51      52      ��54   
   �� 55       �� ImageSource$ IMG/Fondo 2.jpg��6   .+�58   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGUser��58   /      AutoGenerateColumns .  $	��150��6?   $	��Top=�6L    �� Left$	 470��6d      HorizontalGridLinesBrush
 �����   GridLinesVisibility$ 
Horizontal=�6�    J� OpacityMask
 �����$
��Bold"�6�   $��Lucida Bright)�6�   $��Italic$�6�   $ Display=�6     TextHintingMode$ Animated=�67  $��995,10,12,0q�6^  ��6�  Z�  � BindingGroup 59      &   System.Windows.Data.BindingGroup  5:      ��5<      �� 5=       �� Color$ White��6"    J� Effect 5?      3  -System.Windows.Media.Effects.DropShadowEffect  5@         Columns 5B      4  .System.Windows.Controls.DataGridTemplateColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6)      
IsReadOnly .    Width5	  /System.Windows.Controls.DataGridLengthConverter$	 110	 6E      CellTemplate 5G      �� 5H      .R�5I      �� $��70��6>   $��70��6I   ��6$   �� *Imagen+6I   5J      5L      0
  *System.Windows.Controls.DataGridTextColumn
  5M      $  ��6@    . $	 250	 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nombre+6\   5O      !  MahApps.Metro.Controls.Tile  5S   
   -   5        $
��Auto��5S      $��908,292,240,289q�6&   $
��Auto��6?   $��
��6L     � ToolTip$  
Enfermeras��6a   ��5T      �� 5U      $ IMG/Enfermeras.png��6   5W        5Y   
   -   5        !  Name$! TileDoctores��5Y      $
��Auto��6.   $��248,292,896,297q�6<   $
��Auto��6U   $  Doctores��6}   ��5Z      �� 5[      $ IMG/Historial.png��6   5]      #  MahApps.Metro.Controls.Flyout  5^   
   -   5        "  Name$" FlyEnfermeras��5^   S   ���	#FF2F7FCD
�������#   Position$	# Top=�6D   $	��711��6j   $��0,30,0,0q�6w   .��5_      �� $	��975��6   .+�5c      �� -   5        $ ��Name$$ DibujoEnfermera��5c      $	��260��65   $	��250��6B   $
 -136��6N   
% �� Top$	% 231��6a   ��5d      �� 5e      $ IMG/EnfermeraDedo.gif��6%   5g      #  MaterialDesignThemes.Wpf.Chip  5h      -   5        &  Name$& ChipEnfermera��5h   &   $0��*Ahora, Ingresa a la Enfermera como Usuario��6>   $	��305��6s   $ 94��6   $	% 261��6�   $��50��6�   '   IconBackground' �	#FF7349BD���	#FF2648686�   �� 5j      -	   5        ( ��Name$( StackEnfermera��5j      .  (MaterialDesignThemes.Wpf.ColorZoneAssist)   Mode$) 
PrimaryMid=�65   $	��590��6f   $	��675��6r   $
 -176��6   ���	#FF36576A$% 26��6�   �� 5k      -
   5        * ��Name$* txtDui_Enfermera��5k      $
��Left=�65   $��45��6P   + �� TextWrapping$
+ Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��225��6�   
�������$ -1��6�   $% 51��6�   )  #MaterialDesignThemes.Wpf.HintAssist,   Hint$	, Dui��6�   -   
IsFloating- . . �� SelectionBrush
. �����/ �� 
CaretBrush
/ �����69  �� 5l      -   5        $* txtNombre_Enfermera��5l      $
��Left=�68   $��45��6S   $
+ Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��225��6�   
�������$
 -131��6�   $	% 116��6�   $, Nombres��6�   - . 
. �����
/ �����6C  �� 5m      -   5        $* txtApellido_Enfermera��5m      $
��Left=�6:   $��50��6U   $
+ Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��225��6�   
�������$	 139��6�   $	% 111��6�   $, 	Apellidos��6�   - . 
. �����
/ �����6F  �� 5n      -   5        0 ��Name$0 btnagregarEnfermera��5n      $��Agregar��66   $
��Left=�6H   $	��Top=�6c   $	��392��6{   ���	#FFFE0000
�������+  %MaterialDesignThemes.Wpf.ShadowAssist1   ShadowDepth$1 Depth3=�6�   $	 -78��6�   $	% 606��6�   6    5o      -   5        $ dgvista��5o   7    .  
�������$	��360��6\   $	��Top=�6i   $
��Left=�6�   $	��530��6�   $
 -151��6�   $	% 241��6�   2   AlternatingRowBackground2 �	#FF177BDC3   AreRowDetailsFrozen3 . 4   RowBackground4 �	#FF1663AE��6�   Z�  5p      
  5q      $	 DUI��6E    . $	 100	 6d    6-   �� *DUI+6d   
  5r      $ Nombre��6H    . $	 150	 6j    6-   �� *Nombre+6j   
  5s      $ Apellido��6J    . $	 150	 6n    6-   �� *
Apellido+6n   5u      �� 5w      -   5        $( StackUsuarioEnfermera��5w      $) 
PrimaryMid=�6<   $	��610��6m   $	��675��6y   $	 499��6�   ���	#FF174159$% 26��6�   .+�5x      �� -   5        5 ��Name$5 USUARIO��5x      .+�5y      �� -   5        $0 btnAgregarUsuario��5y   !   $��Agregar��6=    $  MaterialDesignRaisedAccentButton#���  6O   $
��Left=�6�   $	��Top=�6�   $	��240��6�   
�������$1 Depth3=�6�   $	 190��6  $	% 525��6   $��37��61  ���	#FFFF1414���	#FF2F7FCD6l    5z      $��40��6.   6   Icon$6  ��69   $��50��6A   $	 140��6M   $	% 225��6_   ��6p   Z� ' 5{      �� 5|   "   $ IMG/user.png��6-   5~      �� 5      -   5        $* txtIDuiU��5   "   $��55��64   $�� ��6@   
�������$, Dui de la Enfermera��6]   - . 
. �����
/ �����$	 195��6�   $	��220��6�   $% 20��6  �� 5�      -   5        $* txtPassU��5�   "   $��55��64   $�� ��6@   
�������$, Password��6]   - . 
. �����
/ �����$	 185��6�   $	% 315��6�   $	��255��6   �� 5�      -   5        $* txtNombreUserE��5�   "   $��55��6:   $�� ��6F   
�������$, Nombre de Usuario��6c   - . 
. �����
/ �����$	 185��6�   $	% 210��6�   $	��255��6    5�      $��40��6.   $6  ��69   $��50��6A   $	 140��6M   $	% 335��6_   ��6p   Z� ' 5�      �� 5�   "   $ IMG/pass.png��6-   5�      5�      5�        5�      -   5        $& ChipEnfermera2��5�   &   $%��Asi, Podra ingresar al sistema.��6>   $	��235��6h   $	 164��6t   $	% 331��6�   $��50��6�   ' �	#FF59555F���	#FF7DA4C96�   5�      5�        5�   
   ���	#FF1F50A4.��5�      �� $
��1370��6   .+�5�      �� -   5        $* txtid_p��5�      $
��Left=�6+   $��30��6F   $
+ Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��152��6�   ��6�   Z� ��6�   Z� / 6�   Z� ��6�   Z� . 6�   Z�   5�      -   5        $ DGHistorial��5�   7    .  ���	#FFFF002E$	��400��6d   $	��Top=�6q   $
��Left=�6�   $	��765��6�   $	% 125��6�    5�      
  5�      $ Numer Seguro��6P    . $	 150	 6x    6-   �� *IdNumeroSeguro+6x   
  5�      $ 	Apellidos��6J    . $	 150	 6o    6-   �� *
Apellido+6o   
  5�      $ Nombres��6H    . $	 150	 6k    6-   �� *Nombre+6k   
  5�      $	 Dni��6E    . $	 150	 6d    6-   �� *Dni+6d   
  5�      $ 
Nacimiento��6Q    . $	 150	 6w    6-   �� *FechaNacimiento+6w   5�      5�      5�        5�   
   -   5        $	" Fly��5�   V   ���	#FF2D2C4D
�������$# Bottom=�6D   $	��708��6c   .��5�      �� $
��1278��6   .+�5�      �� -   5        $* txtid��5�      $
��Left=�6*   $��23��6E   $
+ Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��138��6�   $	 327��6  ��6�   Z� ��6�   Z� / 6�   Z� ��6�   Z� . 6�   Z� 6  �� 5�      -   5        $* txtapellido��5�      $
��Left=�60   $��45��6K   $
+ Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��180��6�   
�������$	 241��6�   $% 62��6�   $, 	Apellidos��6�   - . 
. �����
/ �����6;  �� 5�      -   5        $* txtnombreusuario��5�      $
��Left=�65   $��40��6P   $
+ Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��180��6�   
�������$	 -19��6�   $	% 137��6�   $, Nombre de Usuario��6�   - . 6  �� 5�      -   5        $* 	txtbuscar��5�      $
��Left=�6/   $��23��6J   $
+ Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��167��6�   ���	#FFFE0000$ 51��6�   $	% 527��6�   �� 5�      -   5        $* txteliminar��5�      $
��Left=�61   $��23��6L   $
+ Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��165��6�   ���	#FFFE0000$ 51��6�   $	% 576��6�   G� 5�      -   5        7 G�Name$7 txtcontr��5�      $
��Left=�60   $	��Top=�6K   $	��180��6c   
�������$	 241��6�   $	% 132��6�   $, Contraseña��6�   - . $��45��6�   �� 5�      -   5        $0 	btnbuscar��5�      $��Buscar��6,   $
��Left=�6=   $	��Top=�6X   $	��112��6p   
����������	#FFFE0000$	 265��6�   $	% 527��6�   $1 Depth3=�6�   �� 5�      -    5        $0 btneliminar��5�      $��Eliminar��6.   $
��Left=�6A   $	��Top=�6\   $	��112��6t   ���	#FFFE0000
�������$	 265��6�   $	% 569��6�   $1 Depth3=�6�   �� 5�      -!   5        $0 
btnagregar��5�      $��Agregar��6-   $
��Left=�6?   $��267,374,0,0q�6Z   $	��Top=�6o   $	��112��6�   ���	#FFFE0000
�������$1 Depth3=�6�   �� 5�      -"   5        $0 btnmodificar��5�      $��	Modificar��6/   $
��Left=�6C   $��266,439,0,0q�6^   $	��Top=�6s   $	��112��6�   ���	#FFFE0000
�������$1 Depth3=�6�   �� 5�      -#   5        8 ��Name$
8 Foto��5�      $
��Left=�6&   $	��202��6A   $	��Top=�6N   $	��199��6f   $	 -28��6r   $	% 288��6�   �� 5�      -$   5        $0 	btncargar��5�      $��
Cargar Img��6,   $
��Left=�6A   $��267,306,0,0q�6\   $	��Top=�6q   $	��113��6�   ���	#FFFE0000
�������$1 Depth3=�6�   �� 5�      -%   5        $	0 btn��5�      $��Atras��6&   $
��Left=�66   $	��Top=�6Q   $	��110��6i   ���	#FFFE0000
�������$	 266��6�   $	% 632��6�   $1 Depth3=�6�   �� 5�      -&   5        $* txtruta��5�      $
��Left=�6+   $��23��6F   $
+ Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��138��6�   $	 131��6  $	% -16��6  ��6�   Z� ��6�   Z� / 6�   Z� ��6�   Z� . 6�   Z� 6  �� 5�      -'   5        9 ��Name$9 cbespecialidad____Copy1��5�      *  $MahApps.Metro.Controls.TextBoxHelper:   	Watermark$: Especialidad��6<   $
��Left=�6l   $	��Top=�6�   $	��180��6�   $��40��6�   
�������$	 241��6�   $	% 202��6�   $, Especialidad��6�   - . 6  �� 5�      -(   5        $9 cbPlanta��5�      $
��Left=�6-   $	��Top=�6H   $	��180��6`   $��40��6l   $	 -19��6x   $	% 202��6�   
����������	#FFFDFDFD$, Numero de Planta��6�   - . 6�     5�      -)   5        $ DGMedico��5�   7    .  ���	#FFBFADAF$	��708��6a   $	��Top=�6n   $	 470��6�   $	��808��6�   
 �����;   VerticalGridLinesBrush; �	#FF2D2C4D$ 
Horizontal=�6�   2 �	#FF3532814 �	#FF2D2C4D���	#FF81BAD8
 �����$
��Bold"�6s  $��Lucida Bright)�6�  $��Italic$�6�  $ Display=�6�  $ Animated=�6�   5�        5�      ��5�      �� 5�      $ White��6*    5�        5�       5�      
  5�      $ Codigo��6J    . $	 100	 6l    6-   �� *
IdMedico+6l     5�      $ Imagen��61    . $	 110	 6S    5�      �� 5�   "   .R�5�   &   �� $��70��6F   $��70��6Q   ��6,   �� *Imagen+6Q   5�   #   5�      
  5�      $ Nombres��6H    . $	 250	 6k    6-   �� *Nombre+6k   
  5�      $ 	Apellidos��6J    . $	 250	 6o    6-   �� *
Apellido+6o   
  5�      $ Especialidad��6N    . $	 250	 6v    6-   �� *Especialidad+6v   5�      �� 5�      -*   5        $* 	txtnombre��5�      $
��Left=�6.   $��40��6I   $
+ Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��180��6�   
�������$% 67��6�   $	 -19��6�   $, Nombre��6�   - . 
/ �����
. �����62  5�      5�      5�      5�      