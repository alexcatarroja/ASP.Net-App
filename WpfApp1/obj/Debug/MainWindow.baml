   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   ?$clr-namespace:WpfApp1.MVVM.ViewModelWpfApp1.MVVM.ViewModel  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   :	viewModel$clr-namespace:WpfApp1.MVVM.ViewModel     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      *  $WpfApp1.MVVM.ViewModel.MainViewModel  5   
   .��5      �� 
�����F� �� CornerRadius$ 4��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5"      �� 5#      $��75 �6    �� 5$      .+�5'      �� $��Agenda��6   $��Center=�5(      $
��Left=�5)      
�������$��35(�5+      $��Corbel Light)�5,      $��	ExtraBold"�5-      $��20,0,0,0q�5.      �� 51      $��1��6   .+�53      	� $
��Home��6   $��50��54      
�������$��14(�56      $��Corbel Light)�57      $��	ExtraBold"�58         MenuButtonTheme#��[  59       d� 	IsChecked$
 TrueY�5:      ��5;      �� *HomeViewCommand+	� 5=      $�� ��6   $��50��5>      
�������$��14(�5@      $��Corbel Light)�5A      $��	ExtraBold"�5B      #��[  5C      ��5D      �� *DiscoveryViewCommand+	� 5F      $��To-Do��6   $��50��5G      
�������$��14(�5I      $��Corbel Light)�5J      $��	ExtraBold"�5K      #��[  5L      5O      �� 5Q      $	��250��6   $��40��5R      $��Center=�5S      $��Right=�5T      $��5q�5U      $��1��5V        ModernTextBox#��[ 5W      �� 5Y      $��1��6   $��1��5Z      $��10q�5[      ��5\      �� *CurrentView+5_      5c      5d      