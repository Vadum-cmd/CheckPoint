   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Presentation.ViewsPresentation.Views  5   	   A%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5   	   !    Presentation.Views.MainView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Presentation.Views     5   	   ;	viewModel%clr-namespace:Presentation.ViewModels     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  MainWindowView��5
   	   $	��700��6    $
��1300��6-    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      +   %Presentation.ViewModels.MainViewModel  5   
    � 	Resources 5       �� DataType/   )Presentation.ViewModels.ProductsViewModel$   Presentation.Views.ProductView/   )Presentation.ViewModels.InvoicesViewModel%   Presentation.Views.InvoicesView/   )Presentation.ViewModels.ReceiptsViewModel%   Presentation.Views.UserReceipts4   .Presentation.ViewModels.SaleStatisticViewModel*	   $Presentation.Views.SaleStatisticView/
   )Presentation.ViewModels.ActivityViewModel%   Presentation.Views.ActivityView��%w  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5"      *,
 +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5       	  5!      �� 5"   
   " 
 6   .R�5#        5$      5&      .��5(      ��  �� CornerRadius$ 10��6   $��1q�5)      ._�5,   
   �  � RowDefinitions 5-      �� 5.      $
��181* �6    �� 5/      $
��168* �6    	 � ColumnDefinitions	 51      �� 53      $	��250 �6#   �� 55      $��* �6#   .+�58      �� $ 	10,0,0,10��6   $��0��59      $��2��6%   $��	0,-10,0,0q�66   ��5:      �� 5;      
 �� 
StartPoint$	
 0,0&�6*    �� EndPoint$ 1,0.7&�6;   .��5<      �    secondaryBackColor1 � Color# [  6'    � Offset$ 0Q�6T   � 5=        secondaryBackColor2# [ 6'   $ 1Q�6T   5>      ._�5@      �� .+�5C      ��  �� Orientation$ 
Horizontal=�6!   $��35��5D   !   $��
15,25,0,40q�5E   !   .+�5H      �� $��Check Point��6$     titleColor2#��[ 5I   $   $��20(�5J   $   $��
Montserrat)�5K   $   $��Medium"�5L   $   $��Center=�5M   $   $��10,0,0,0q�5N   $   5O      	� 5R        
menuButton#��[ 6"    
 color1
 � Tag# [ 5S   "    d� 	IsChecked$
 TrueY�5T   "   ��5U   "   �� *ShowProductsViewCommand+.��5V      �� $ 
Horizontal=�6%   .+�5X      �� $��Products��6(     menuButtonText#��[ 68   $��20,0,0,0q�6`   5Y      5Z      	� 5[      #��[ 6"    
 color2# [ 5\   "   ��5]   "   �� *ShowInvoicesViewCommand+.��5^      �� $ 
Horizontal=�6%   .+�5`      �� $��Invoices��6(   #��[ 68   $��20,0,0,0q�6`   5a      5b      	� 5c      #��[ 6"   # [ 5d   "   ��5e   "   �� *ShowReceiptsViewCommand+.��5f      �� $ 
Horizontal=�6%   .+�5h      �� $��Receipts��6(   #��[ 68   $��20,0,0,0q�6`   5i      5j      	� 5k      #��[ 6"   # [ 5l   "   ��5m   "   �� *ShowSaleStatisticViewCommand+.��5n      �� $ 
Horizontal=�6%   .+�5p      �� $��Sale statistic��6(   #��[ 6>   $��20,0,0,0q�6f   5q      5r      	� 5s      #��[ 6"   # [ 5t   "   ��5u   "   �� *ShowActivityViewCommand+.��5v      �� $ 
Horizontal=�6%   .+�5x      �� $��Your activity��6(   #��[ 6=   $��20,0,0,0q�6e   5y      5z      5{      5|      �� 5      $ 	0,10,10,0��6   $��1��5�      $��2��6%   $��
0,-10,-5,0q�66   ��5�      �� 5�      $	
 1,1&�6*   $	 0,0&�6;   .��5�      �   primaryBackColor2# [ 6'   $ 1Q�6R   5�      ._�5�      �  5�      �� 5�      $��25 �6(   �� 5�      $��35 �6(   �� 5�      $��* �6(   .+�5�      �� -   5         ��Name$ pnlControlBar��5�   !   $��0��5�   !   $ 
Horizontal=�5�   !   $��RightToLeft=�5�   !   
������ $��0,0,5,0q�5�   !   .+�5�      �� -   5         ��Name$ btnClose��5�   !     controlButton#��[ 5�   !    
	 color4# [	 5�   !   5�      �� 5�      -   5        $ btnMaximize��5�   !   #��[ 5�   !    

 color6# [
 5�   !   5�      �� 5�      -   5        $ btnMinimize��5�   !   #��[ 5�   !    
 color8# [ 5�   !   5�      5�      � 5�      $��1��6   	 5�      �� 5�      �� 5�      .+�5�      �� $��0��6%   $ 
Horizontal=�5�   %   $��Center=�5�   %   .+�5�      �� #��[ 5�   (   $��16(�5�   (   $��
Montserrat)�5�   (   $��Medium"�5�   (   $��Center=�5�   (   ��5�   (   �� *	Caption+5�   (   5�      �� 5�      $��1��6%   $ 
Horizontal=�5�   %   $��RightToLeft=�5�   %   $��Center=�5�   %   $��0,0,10,0q�5�   %   .+�5�      �� -   5        $ btnCloseMain��5�   %     
iconButton#��[ 6;   # [ 5�   %   .��5�   "   �� $��x��6,   #��[ 65   5�      �� 5�      -   5        $ btnMinimizeMain��5�   %   #��[ 6>   # [ 5�   %   .��5�   "   �� -   5         ��Name$ btnMinimize1��5�   ,   $��-��6B   #��[ 6K   5�      �� 5�        titleColor3#��[ 5�   (   $��
Montserrat)�5�   (   $��12(�5�   (   $��Center=�5�   (   ��5�   (   �� * CurrentUserAccount.DisplayName+5�   (   A� 5�      $��35��6&   $��35��62   #��[ 5�   &   $��2��5�   &   $��	10,0,10,0q�5�   &   ��5�   "   �� 5�   &    �� ImageSource$! /Images/profile-picture.jpg��61   5�      �� 5�      #��[ 6%   # [ 5�   %   $��93��6C   .��5�   "   �� $��Log out��6,   #��[ 6;   5�      �� 5�      #��[ 6%    
 color5# [ 5�   %   $	��122��6C   .��5�   "   �� $��Switch account��6,   #��[ 6B   5�      5�      5�      �� 5�      $��2��5�   %   $��25q�5�   %   ��5�   %   �� *CurrentChildView+5�   %   5�      5�      5�      5�      5�      