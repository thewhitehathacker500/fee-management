   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?Exam_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Exam_ProExam_Pro 5   	      Exam_Pro.signup_window   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Exam_Pro     5   	     � Title$   ��5	   	   ���#eee$	��400��6$   $	��540��61   (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � 
ResizeMode$ NoResize=�5
       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��277* �6   �� 5      $
��257* �6   ��5   
   �� 5       �� ImageSource$ /Images/background.jpg��6   .+�5!   
   �� $��2��6   .+�5#      � .+�5$      �� -   5         ��Name$ textBlockHeading��5$   k   $��50��6   
���   �$��Center=�6;   $��	24,48,0,0q�6X   $	��Top=�6�   $��15(�6�   $��Segoe UI Light)�6�   	 �� Padding$	 5q�6�   $
��Bold"�6�   $"��PLEASE ENTER THE CREDENTIALS��6�   5%      � 5&      .+�5'      �� 
 �� Orientation$
 
Horizontal=�6   .+�5(      �� $��User ID��6    $��	85,30,0,0q�6/   $	��100��6B    �� TextAlignment$ Right=�6O   $��Black"�6e   $��18(�6x   $��Segoe UI Black)�6�   �� 5)      -   5        $��user_id_signup��5)      $	��200��64   $��20��6@   $��	15,26,0,2q�6L   $��Stretch=�6_   �� 5*      -   5        $��user_id_null��5*       $��Enter User id!!��64   $y�Hidden=�6K   $ Center=�6_   $��
 20 30 0 0q�6v   
���  ��6�   5+      5,      � 5-       5.      .+�51      �� $
 
Horizontal=�6   $��2��66   .+�52      �� $��Password��6    $��Center=�60   $ Right=�6K   $��	85 10 0 0q�6a   $	��100��6t   $
��Left=�6�   $��18(�6�   $��Black"�6�   G� 53      -   5        $��password_box_signup��53   "   $	��200��6=   $��20��6I   $��	15,7,0,-7q�6U   �� 54      -   5        $��password_wrong��54       $��Passwords don't Match!!��66   $y�Hidden=�6U   $ Center=�6i   $��	 5 15 0 0q�6�   
���  ��6�   55      56      � 57      .+�58      �� $
 
Horizontal=�6   $��2��66   .+�59      �� $��Confirm Password��6    $��Center=�68   $ Right=�6S   $��0 10 0 0q�6i   $	��185��6{   $
��Left=�6�   $��18(�6�   $��Black"�6�   G� 5:      -   5        $��password_box_confirm��5:   "   $	��200��6>   $��20��6J   $��
15,11,0,-3q�6V   5;      5<      � 5=       5>      �� 5?      $
��305* �6'   �� 5@      $
��229* �6'   .+�5B      �� $
 
Horizontal=�6   $��2��66   .+�5C      �� $��Date of Birth��6    $��	35,10,0,0q�65   $	��150��6H   $ Right=�6U   $��Black"�6k   $��18(�6~   $��Segoe UI Black)�6�   (  "System.Windows.Controls.DatePicker  5D      -   5        $��date_picker_signup��5D   !   $	��200��6;   $��20��6G   $��	15,10,0,2q�6S   $��Stretch=�6f      SelectedDate 6�   ��  �� Path$ DateOfBirth� �� StringFormat$ 	dd/MM/yyy���� 5E      -   5        $��date_picker_null��5E       $��Enter DOB!!��68   $y�Hidden=�6K   $ Center=�6_   $��
 20 15 0 0q�6v   
���  ��6�   5G      5H      � 5I      .+�5J      �� $
 
Horizontal=�6   $��2��66   .+�5K      �� $��Product Key��6    $��Center=�63   $ Right=�6N   $��0 10 0 0q�6d   $	��185��6v   $
��Left=�6�   $��18(�6�   $��Black"�6�   �� 5L      -	   5        $��product_key��5L      $	��200��61   $��20��6=   $��
15,5,0,-3 q�6I    �� 	MaxLength$ 10��6]   �� 5M      -
   5        $��product_key_null��5M       $��Enter Product Key!!��68   $y�Hidden=�6S   $ Center=�6g   $��
 20 30 0 0q�6~   
���  ��6�   5O      5P      � 5Q      $��0 30 0 0q�6    5R      �� 5S      $	��69* �6'    � RowDefinitions 5U      �� 5V      $��* �6$   .+�5X      �� -   5        $��signup_button��5X      
������ 
���   �$��Sign Up��6[   $��0��6m   $	��100��6}   $��Center=�6�   $��214,0,220,0q�6�   $��27��6�   $	��Top=�6�   5Y      5Z      5[      5\      