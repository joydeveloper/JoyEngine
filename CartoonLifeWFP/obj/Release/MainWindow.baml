   M S B A M L   `   `   `  ���� I  ECartoonLifeWFP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CartoonLifeWFPCartoonLifeWFP  T PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem ` \DevComponents.WpfEditors, Version=7.9.0.56, Culture=neutral, PublicKeyToken=cbba4a1563683cdbeHclr-namespace:DevComponents.WpfEditors;assembly=DevComponents.WpfEditorsDevComponents.WpfEditors     CartoonLifeWFP.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:CartoonLifeWFP     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     9System&clr-namespace:System;assembly=mscorlib     _
WpfEditorsHclr-namespace:DevComponents.WpfEditors;assembly=DevComponents.WpfEditors     -     � Title$  
MainWindow��$
��1022��$
��1280�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=�$��Center=�$��Center=� � WindowStyle$
 None=� � 	Resources    BorderStyle_1 �� 
TargetType �� Property �� Value��%�   &	        �� " ��.�-   ��  � |� . ��  � ��
 � �����  � ��$ 5q���  � ��$ Center=���  � ��$ Center=���  �@��CornerRadius$ 8����  � ��$	 320����  � ��$	 550����  � ��$ 	50,10,0,9q�.��� ����  �� EndPoint$ 0.5,1&�	 �� 
StartPoint$	 0.5,0&�.��� 
 � Color$
 Black�� � Offset$ 0.826Q�� $
 	#FF642797��$ 0.352Q�.+�(� $��0,10,0,9q� (� Stretch$
 Fill=�.��� -    �Name$ MainGrid��$	��972��$
��1272��.+��� -    ��Name$ HeaderStack��$��172.031��$	��Top=����� $ 0.5,1&�$	 0.5,0&�.��� $
 Black��$ 0Q��   MainMenuBg_color_1#
 �  $ 1Q�.+��� -    ��Name$ appName_label��$��Cartoon Life��$��Bottom=�$��80(����	#FF934848$��104.892��$��155,0,527,0q�$��Italic$�$
��Bold"�����  �� ImageSource$ Resources/cart_fill_1.jpg���� -    ��Name$ exit_but��$��Button��$��64.933��  MainExitButton#���  $	��267��$��Right=����� $	 0,1&�$		 0,0&�.��� $
 	#FFF3F3F3��$ 0Q�� $
 	#FFEBEBEB��$	 0.5Q�� $
 	#FFDDDDDD��$	 0.5Q�A� -    A�Name$ 
MainPanels�� A� Rows$ 2�� A� Columns$ 2��$��20,210,52,82.915q����� .+��� #���   $��
50,10,0,10q�._�� -   $ NewGameGrid��$��0,5,0,0q�$��49.441��$	��Top=�.+��� -	   $ NewGameStack_�� �� Orientation$ 
Horizontal=�$��54.441��$	��Top=����� $ 0.5,1&�$	 0.5,0&�.��� $
 Black��$ 0Q�� #
 �  $ 1Q�.+��� -
   $ gametype_label��  H1_Label#��[ $��50��$��0,0,0,4q�$	��440��$
��Test���� -   $ l_gametype_but��  left_but#��[  J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$	 180Q�T� �� -   $ r_gametype_but��#��[ $ 0.5,0.5&�$��0,4.72q���Z� ��Z� ���� $	 0,1&�$		 0,0&�.��� $
 	#FFF3F3F3��$ 0Q�� $
 	#FFEBEBEB��$	 0.5Q�� $
 	#FFDDDDDD��$	 0.5Q�� $
 White��$ 1Q��� $��0,0,0,-255.559q�$��255.521��$��Bottom=�
������� J� Opacity$ 0Q�� -   $ GameSetupPanel��$��0,49.479,0,-255.559q�$ 0.5,0.5&�.+�A� $ 2��.+��� .+��� $ 
Horizontal=�.+���   positive_plus_but#��[ $
��Left=��� -    ��Name$ textBox��$��40�� �� TextWrapping$
 Wrap=�$��
PlayerName��$	��225��$��Right=�$��Bottom=�$��20(�.������ $ 0.5,1&� � MappingMode$ RelativeToBoundingBox=�$	 0.5,0&�.��� $
 Black��$ 1Q�� $
 	#FFFFC2EE��� $
 	#FF98AA28��$ 0.908Q�.���� $��210.75��.���� $	��270��$��210.75��$	��Top=�.+�� .+���   wait_minus_but#��[ $
��Left=�$	��Top=���   H2_Label#��[ $��40.75��$��50,0,0,0q�$	��Top=����� $ 0.5,1&�$	 0.5,0&�.��� $
 Black��$ 0Q�� $
 	#FFFFF300��$ 1Q�� $
 	#FF9F9800��$ 0.199Q�.��Kate� .+��� #��[ $
��Left=�$	��Top=����	#FFE2DBDB�� #��[ $��40.75��$��50,0,0,0q�$	��Top=�$	��Joy������ $ 0.5,1&�$	 0.5,0&�.��� $
 Black��$ 0Q�� $
 	#FFFFF300��$ 1Q�� $
 	#FF9F9800��$ 0.199Q�]� ��.  �� #���   ._�� -   $ FastStartGrid��$
��Auto��$��0,0,5,5q�$��Stretch=����	#00000000.+��� -   $ faststart_button��$��
Fast Start��$	��Top=�$��Normal"�$��60(�$��Segoe UI)�$��5,4.492,230,0q�  MyFocusVisual � FocusVisualStyle# �  $��89.908��$
��Auto����Z� ��Z� ����  �� 
TargetType" ��.R���  ��Name$ Border��#��z��#��z��#��z��._��� #��z��#��z��#��z�� �� Triggers P�   P� Property  �@J�	IsFocused! P� Value! . . ��� " �� 
TargetName$" Border�� � ��
 � ������� $ 0.5,1&�$	 0.5,0&�.��� $
 Black��$ 0.958Q�� $
 	#FF58E67F��$ 0.175Q�# J� Effect# 3  -System.Windows.Media.Effects.DropShadowEffect  $   ShadowDepth$	$ 0.9Q�%   Color#% � ���� -   $ continue_game_button��$��Continue��$��Normal"�$��60(�$��Segoe UI)�$��Bottom=�$��Right=���Z� ��Z� ���� " ��.R��� $ Border��#��z��#��z��#��z��._��� #��z��#��z��#��z�� P�   �@J�	IsFocused! . . ��� $" Border�� � ��
 � ������� $ 0.5,1&�$	 0.5,0&�.��� $
 Black��$ 0.958Q�� $
 	#FF46CB6A��$ 0.175Q�#   $	$ 1.2Q�#% � ���� -   $ OptionsBord��#���   $��
50,10,0,10q�._��� -   & ��Name$& tabNavigation��$
��Left=�$	��300��$��	-5,5,-5,0q�$	��Top=�$	��550����Z� ��Z� ��Z� .@��� $��Video��$��22(�.��� �� $��Audio��.��� �� $
��Game��.��� �� #���   ._�� .+�� -   $ NewsSelector��$��62��$	��Top=�.+��� $��	0,0,0,250q�$ 
Horizontal=�� -   $ NewsGrid��$��0,67,0,0q�.+��� -   ' ��Name$' groupBox��$��
NewsHeader��$
��Left=�$	��243��$��5,0,0,0q�$	��Top=�$	��530��.���� $
��Left=�$	��212��$��-6,-5,-2,-3q�$	��Top=�$	��526��� $��69,894,52,0q�.+��� 
��� ���$��2q�( �� CornerRadius$( 	0,30,0,30��._�� $
��Left=�$��-619,2,0,-2q�$
��1147��) � RowDefinitions) �� $
��auto ��� �� $
��auto �.+��� $��Cartoonlife��* �� Padding$* 5q�$
��Left=�$	��259��� $��1��$��Right=�$
��1147��$��
0,0,-619,0q����� $ 0.5,1&�$	 0.5,0&�.��� $
 	#FFFFACAC��$ 0.245Q�� $
 	#B2993636��$ 0.614Q�.+��� $��Center=�$��18(�$
��Left=�$��49,-0.93,0,-0.93q�$	��100������ $ 0.5,1&�$	 0.5,0&�.��� $
 Black��$ 0.222Q�� $
 	#FFAF58B8��$ 1Q�� $
 	#FFF3FD17��$ 0.964Q�
FeZiko inc�� $
��2018��$* 5q�$��2��$��Center=����	#FF42A02C$��Pericles)�$��18(�