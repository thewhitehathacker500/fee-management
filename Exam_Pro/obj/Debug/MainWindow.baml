   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?Exam_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Exam_ProExam_Pro 5   	      Exam_Pro.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Exam_Pro     5   	     � Title$   ��5	   	   
������ $	��400��6+   $	��540��68   (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � 
ResizeMode$ NoResize=�5
       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� ImageSource$ /Images/background.jpg��6   .+�5   
   �� .+�5      � .+�5       �� -   5         ��Name$ textBlockHeading��5    k   $��50��6   
���   �$��Center=�6;   $��	24,48,0,0q�6X   $	��Top=�6�   $��15(�6�   $��Segoe UI Light)�6�    �� Padding$ 5q�6�   $)��#PLEASE LOGIN TO USE THE APPLICATION��6�   $
��Bold"�6�   5!      � 5"      .+�5#      �� 	 �� Orientation$	 
Horizontal=�6   .+�5$      �� $��User ID��6    $��	85,30,0,0q�6/   $	��100��6B   $
��Left=�6N   $��Black"�6i   $��18(�6|   $��Segoe UI Black)�6�   �� 5%      -   5        $��user_id��5%      $	��200��6-   $��20��69   $��0,26,0,2q�6E   $��Stretch=�6W   5&      5'      � 5(      
 � ColumnDefinitions
 5)      .+�5,      �� $	 
Horizontal=�6   $��2��66   .+�5-      �� $��Password��6    $��Center=�60   $��	85 10 0 0q�6K   $	��100��6^   $
��Left=�6j   $��18(�6�   $��Black"�6�   G� 5.      -   5        $��password_box��5.   "   $	��200��66   $��20��6B   $��0,7,0,-7q�6N   5/      50      � 51      $��0 30 0 0q�6   
 52      �� 53      $	��69* �6'   �� 54      $	��20* �6'   �� 55      $	��89* �6'    � RowDefinitions 58      �� 59      $��* �6$   .+�5;      �� -   5        $��signup_button��5;      
������ 
���   �$��Sign Up��6[   $��0��6m   $	��100��6}   $��Right=�6�   $��0 0 5 0q�6�   $��2��6�   6�   �� 5<      -   5        $��login_button��5<      
������ 
���   �$��2��6Z   $��Login��6j   $	��100��6z   $
��Left=�6�   $��5 0 0 0q�6�   6�   5=      �� 5>      -   5         ��Name$ forgot_pass��5>      ���	#00000000
���   �$��Forgot Password??��6U   $��10(�6q   $	��200��6�   $��10q�6�   
���  ��6�   � 5?      
 5@      �� 5A      $��2* �6'   �� 5B      $��* �6'   .+�5D      �� -   5        $ conn_button��5D      $��1��6.   $��OFFLINE��6>   $��15(�6P   
���  ��$��85��6p   $��Right=�6{   $��Bottom=�6�   $��	0 40 10 0q�6�   6�   �� 5E      -   5        $ login_error��5E      $�� ��61    �� TextAlignment$ Center=�69   $��Center=�6P   $��Center=�6m   
���  ��6�   5F      5H      5I      5L      