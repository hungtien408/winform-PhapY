   M S B A M L   `   `   `  ����@  <PhapY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PhapY.ucPhapY.uc  5      g cComponentArt.Win.UI.Input, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbhJclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.InputComponentArt.Win.UI.Input 61   f bComponentArt.Win.UI.Data, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbeHclr-namespace:ComponentArt.Win.UI.Data;assembly=ComponentArt.Win.UI.DataComponentArt.Win.UI.Data 6�   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D1clr-namespace:System.Windows;assembly=WindowsBaseSystem.Windows 5      h dComponentArt.Win.UI.Common, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbiKclr-namespace:ComponentArt.Win.UI.Utils;assembly=ComponentArt.Win.UI.CommonComponentArt.Win.UI.Utils 5          PhapY.uc.DanhSachChupHinh   5      my2clr-namespace:PhapY.uc  Rmy1Jclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.Input  61   OmyHclr-namespace:ComponentArt.Win.UI.Data;assembly=ComponentArt.Win.UI.Data  6�   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      ?vsm1clr-namespace:System.Windows;assembly=WindowsBase    5      oComponentArt_Win_UI_UtilsKclr-namespace:ComponentArt.Win.UI.Utils;assembly=ComponentArt.Win.UI.Common    5        � 	Resources  5
      3  -ComponentArt.Win.UI.Data.DataGridColumnHeader �� 
TargetType �� Property �� Value   
AllFilters9  3ComponentArt.Win.UI.Data.DataGridColumnFilterHeader �� 
TargetType ��Name �� Padding �� EndPoint �� 
StartPoint	 � Color
 � Offset �Name � ColumnDefinitions � RowDefinitions ��Name � Cursor'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup  Name   States   System.Windows.VisualState  Name   
Storyboard �� 
TargetName �� TargetProperty	 �� To g� Duration ��Name � ToolTip+  %ComponentArt.Win.UI.Utils.CommonPopup  Name   VerticalOffset ��Name
 � Tag ��Name  
TextFilter  DropdownlistTextFilter(  "ComponentArt.Win.UI.Input.ComboBox    AutoComplete!   
AutoFilter"   FilteringType,  &ComponentArt.Win.UI.Input.ComboBoxItem#   Text��%sC  '        &	  �     &	 "    &	 1    �� 5   
   "  6   .�5      ��  � ��$ 5q�6(   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      �� 5   
   "  6#   .�5      ��  � �� .  6*   �� 5       � ��$ 1,0,1,0q�60   �� 5       � �� 5      �� 5      "  6&   .R�5      �� $ RootElement��6!   $��Stretch=�66   $ 2q�6T   $��1,0,1,0q�6`   ��5      �� 5   "   $	 0,1&�66   $	 0,0&�6E   .��5   &   � $	 	#FFF3F3F3��63   � 5   &   $	 	#FFD6D6D6��63   $
 1Q�6E   5   #   ��5      �� 5    "   $	 1,0&�66   $	 0,0&�6E   .��5!   &   � $	 	#FFFFFFFF��63   � 5"   &   $	 	#FFCCCCCC��63   $
 1Q�6E   5#   #   ._�5%      � $ FilterContent��6#   $y�	Collapsed=�6:    5&   "   �� 5'   &   $
��Auto �67   �� 5(   &   $��* �67   �� 5)   &   $
��Auto �67    5+   "   .+�5-   "   �� $ FilterButton��6)   $
 Hand��6?   $��19��6M   $��18��6X   ��5.   &   �� 5/   *   " ��6:   .R�50   .   �� $ FilterButtonOuterBorder��6g   ���	#FFAAAAAA$��1,1,0,1q�6M    51   2     52   6   $ CommonStates��6G   . 53   :     $ Normal��6F     54   :   $ 	MouseOver��6F   . 55   >   �� .��56   B   �� $ FilterButtonInnerBorder��6Q   $+ %(BorderBrush).(SolidColorBrush.Color)�6�   $ 	LightBlueX�6�   $ 0:0:0.1D�6�   57   ?   58   ;   59   7   ._�5;   2   �� $ FilterButtonInnerBorder��6e   ���	#FFFFFFFF$��1q�6Q   ��5<   6   �� 5=   :   $	 0,1&�6N   $	 0,0&�6]   .��5>   >   � $	 	#FFFFFFFF��6K   � 5?   >   $	 	#FFFFFFFF��6K   $	
 .35Q�6]   � 5@   >   $	 	#FFEFEFEF��6K   $	
 .36Q�6]   � 5A   >   $	 	#FFD6D6D6��6K   $
 1Q�6]   5B   ;   ._�5D   6   �� #��z��6G   5E   3   5F   /   5G   +   ��5I   &   � 5J   *   .+�5K   .   �� $ NoFilterIcon��64   $ Tùy chỉnh bộ lọc��6J   $��Center=�6e   $��Center=�6�   $O��I/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter.png��6�   $
��None=�6�   �� 5L   .   $ 
FilterIcon��64   $y�	Collapsed=�6H   $��Center=�6_   $��Center=�6z   $T��N/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filterclose.png��6�   $
��None=�6�   5M   +   5O   #   �� 5P   "   $ FilterCloseButton��6)   $
 Hand��6D   $��19��6R   $��18��6]   $��2,0,0,0q�6i   $��2��6z   $y�	Collapsed=�6�   ��5Q   &   �� 5R   *   " ��6:   .R�5S   .   �� $" FilterCloseButtonOuterBorder��6g   ���	#FFCCCCCC$��1,1,0,1q�6M    5T   2     5U   6   $ CommonStates��6G   . 5V   :     $ Normal��6F     5W   :   $ 	MouseOver��6F   . 5X   >   �� .��5Y   B   �� $" FilterCloseButtonInnerBorder��6Q   $+ %(BorderBrush).(SolidColorBrush.Color)�6�   $ 	LightBlueX�6�   $ 0:0:0.1D�6�   5Z   ?   5[   ;   5\   7   ._�5^   2   �� $" FilterCloseButtonInnerBorder��6e   ���	#FFFFFFFF$��1q�6Q   ��5_   6   �� 5`   :   $	 0,1&�6N   $	 0,0&�6]   .��5a   >   � $	 	#FFFFFFFF��6K   � 5b   >   $	 	#FFFFFFFF��6K   $	
 .35Q�6]   � 5c   >   $	 	#FFEFEFEF��6K   $	
 .36Q�6]   � 5d   >   $	 	#FFD6D6D6��6K   $
 1Q�6]   5e   ;   ._�5g   6   �� $ FilterCloseIcon��6<   $ Xoá bộ lọc��6U   $��Center=�6j   $��Center=�6�   $T��N/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filterclose.png��6�   $
��None=�6�   5h   3   5i   /   5j   +   5l   #     5m   "   $ FilterOptionsPopup��6H   $ 20Q�6d   .��5n   &   � 
������  5o   *   �� 5p   .   $��26 �6?   $��26��6J   �� 5q   .   $��* �6?   .+�5s   *   �� ���	#FFE3E3E361   �� 5t   *   ���	#FFF9F9F9$��1��6H   �� 5u   *   $ FilterOptions��6K   
������ $��2��6b   .@�5v   .   �� $ Contains��6:   .��5w   2   �  5x   6   �� 5y   :   $
��Auto �6K   �� 5z   :   $��* �6K   .+�5|   6   �� $ ContainsIcon��6<   $��Center=�6R   $��Center=�6m   $
��None=�6�   $X��R/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_contains.png��6�   �� 5}   6   $��10,0,0,0q�6@   $��1��6R   $��Chứa từ khoá��6b   5~   3   5   /   �� 5�   .   $ 
StartsWith��6:   .��5�   2   �  5�   6   �� 5�   :   $
��Auto �6K   �� 5�   :   $��* �6K   .+�5�   6   �� $ StartsWithIcon��6<   $��Center=�6T   $��Center=�6o   $
��None=�6�   $Z��T/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_startswith.png��6�   �� 5�   6   $��10,0,0,0q�6@   $��1��6R   $��Bắt đầu với��6b   5�   3   5�   /   �� 5�   .   $ Equals��6:   .��5�   2   �  5�   6   �� 5�   :   $
��Auto �6K   �� 5�   :   $��* �6K   .+�5�   6   �� $ 
EqualsIcon��6<   $��Center=�6P   $��Center=�6k   $
��None=�6�   $V��P/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_equals.png��6�   �� 5�   6   $��10,0,0,0q�6@   $��1��6R   $��Bằng��6b   5�   3   5�   /   �� 5�   .   $ 
NotEqualTo��6:   .��5�   2   �  5�   6   �� 5�   :   $
��Auto �6K   �� 5�   :   $��* �6K   .+�5�   6   �� $ NotEqualToIcon��6<   $��Center=�6T   $��Center=�6o   $
��None=�6�   $Y��S/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_notequals.png��6�   �� 5�   6   $��10,0,0,0q�6@   $��1��6R   $��Không bằng��6b   5�   3   5�   /   �� 5�   .   $ GreaterThan��6:   .��5�   2   �  5�   6   �� 5�   :   $
��Auto �6K   �� 5�   :   $��* �6K   .+�5�   6   �� $ GreaterThanIcon��6<   $��Center=�6U   $��Center=�6p   $
��None=�6�   $[��U/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_greaterthan.png��6�   �� 5�   6   $��10,0,0,0q�6@   $��1��6R   $��
Lớn hơn��6b   5�   3   5�   /   �� 5�   .   $ GreaterThanOrEqual��6:   .��5�   2   �  5�   6   �� 5�   :   $
��Auto �6K   �� 5�   :   $��* �6K   .+�5�   6   �� $ GreaterThanOrEqualIcon��6<   $��Center=�6\   $��Center=�6w   $
��None=�6�   $c��]/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_greaterthanorequals.png��6�   �� 5�   6   $��10,0,0,0q�6@   $��1��6R   $��Lớn hơn hoặc bằng��6b   5�   3   5�   /   �� 5�   .   $ LessThan��6:   .��5�   2   �  5�   6   �� 5�   :   $
��Auto �6K   �� 5�   :   $��* �6K   .+�5�   6   �� $ LessThanIcon��6<   $��Center=�6R   $��Center=�6m   $
��None=�6�   $X��R/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_lessthan.png��6�   �� 5�   6   $��10,0,0,0q�6@   $��1��6R   $��
Nhỏ hơn��6b   5�   3   5�   /   �� 5�   .   $ LessThanOrEqual��6:   .��5�   2   �  5�   6   �� 5�   :   $
��Auto �6K   �� 5�   :   $��* �6K   .+�5�   6   �� $ LessThanOrEqualIcon��6<   $��Center=�6Y   $��Center=�6t   $
��None=�6�   $`��Z/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_lessthanorequals.png��6�   �� 5�   6   $��10,0,0,0q�6@   $��1��6R   $��Nhỏ hơn hoặc bằng��6b   5�   3   5�   /   5�   +   5�   '   5�   #   �� 5�   "   $ FilterValue��6*   $��1��6?   $��19��6O   $��1q�6[   $��12(�6g   5�      5�      5�      5�      5�      �� 5�   
   "  6#   .�5�      ��  � �� .  6*   �� 5�       � ��$ 1,0,1,0q�60   �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      �� $ RootElement��6!   $��Stretch=�66   $ 2q�6T   $��1,0,1,0q�6`   ��5�      �� 5�   "   $	 0,1&�66   $	 0,0&�6E   .��5�   &   � $	 	#FFF3F3F3��63   � 5�   &   $	 	#FFD6D6D6��63   $
 1Q�6E   5�   #   ��5�      �� 5�   "   $	 1,0&�66   $	 0,0&�6E   .��5�   &   � $	 	#FFFFFFFF��63   � 5�   &   $	 	#FFCCCCCC��63   $
 1Q�6E   5�   #   ._�5�      � $ FilterContent��6#   $y�	Collapsed=�6:    5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67   �� 5�   &   $
��Auto �67    5�   "   .+�5�   "   �� $ FilterButton��6)   $
 Hand��6?   $��19��6M   $��18��6X   ��5�   &   �� 5�   *   " ��6:   .R�5�   .   �� $ FilterButtonOuterBorder��6g   ���	#FFAAAAAA$��1,1,0,1q�6M    5�   2     5�   6   $ CommonStates��6G   . 5�   :     $ Normal��6F     5�   :   $ 	MouseOver��6F   . 5�   >   �� .��5�   B   �� $ FilterButtonInnerBorder��6Q   $+ %(BorderBrush).(SolidColorBrush.Color)�6�   $ 	LightBlueX�6�   $ 0:0:0.1D�6�   5�   ?   5�   ;   5�   7   ._�5�   2   �� $ FilterButtonInnerBorder��6e   ���	#FFFFFFFF$��1q�6Q   ��5�   6   �� 5�   :   $	 0,1&�6N   $	 0,0&�6]   .��5�   >   � $	 	#FFFFFFFF��6K   � 5�   >   $	 	#FFFFFFFF��6K   $	
 .35Q�6]   � 5   >   $	 	#FFEFEFEF��6K   $	
 .36Q�6]   � 5  >   $	 	#FFD6D6D6��6K   $
 1Q�6]   5  ;   ._�5  6   �� #��z��6G   5  3   5  /   5  +   ��5	  &   � 5
  *   .+�5  .   �� $ NoFilterIcon��64   $ Tùy chỉnh bộ lọc��6J   $��Center=�6e   $��Center=�6�   $O��I/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter.png��6�   $
��None=�6�   �� 5  .   $ 
FilterIcon��64   $y�	Collapsed=�6H   $��Center=�6_   $��Center=�6z   $T��N/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filterclose.png��6�   $
��None=�6�   5  +   5  #   �� 5  "   $ FilterCloseButton��6)   $
 Hand��6D   $��19��6R   $��18��6]   $��2,0,0,0q�6i   $��2��6z   $y�	Collapsed=�6�   ��5  &   �� 5  *   " ��6:   .R�5  .   �� $" FilterCloseButtonOuterBorder��6g   ���	#FFCCCCCC$��1,1,0,1q�6M    5  2     5  6   $ CommonStates��6G   . 5  :     $ Normal��6F     5  :   $ 	MouseOver��6F   . 5  >   �� .��5  B   �� $" FilterCloseButtonInnerBorder��6Q   $+ %(BorderBrush).(SolidColorBrush.Color)�6�   $ 	LightBlueX�6�   $ 0:0:0.1D�6�   5  ?   5  ;   5  7   ._�5  2   �� $" FilterCloseButtonInnerBorder��6e   ���	#FFFFFFFF$��1q�6Q   ��5  6   �� 5   :   $	 0,1&�6N   $	 0,0&�6]   .��5!  >   � $	 	#FFFFFFFF��6K   � 5"  >   $	 	#FFFFFFFF��6K   $	
 .35Q�6]   � 5#  >   $	 	#FFEFEFEF��6K   $	
 .36Q�6]   � 5$  >   $	 	#FFD6D6D6��6K   $
 1Q�6]   5%  ;   ._�5'  6   �� $ FilterCloseIcon��6<   $ Xoá bộ lọc��6U   $��Center=�6j   $��Center=�6�   $T��N/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filterclose.png��6�   $
��None=�6�   5(  3   5)  /   5*  +   5,  #     5-  "   $ FilterOptionsPopup��6H   $ 20Q�6d   .��5.  &   � 
������  5/  *   �� 50  .   $��26 �6?   $��26��6J   �� 51  .   $��* �6?   .+�53  *   �� ���	#FFE3E3E361   �� 54  *   ���	#FFF9F9F9$��1��6H   �� 55  *   $ FilterOptions��6K   
������ $��2��6b   .@�56  .   �� $ Contains��6:   .��57  2   �  58  6   �� 59  :   $
��Auto �6K   �� 5:  :   $��* �6K   .+�5<  6   �� $ ContainsIcon��6<   $��Center=�6R   $��Center=�6m   $
��None=�6�   $X��R/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_contains.png��6�   �� 5=  6   $��10,0,0,0q�6@   $��1��6R   $��Chứa từ khoá��6b   5>  3   5?  /   �� 5@  .   $ 
StartsWith��6:   .��5A  2   �  5B  6   �� 5C  :   $
��Auto �6K   �� 5D  :   $��* �6K   .+�5F  6   �� $ StartsWithIcon��6<   $��Center=�6T   $��Center=�6o   $
��None=�6�   $Z��T/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_startswith.png��6�   �� 5G  6   $��10,0,0,0q�6@   $��1��6R   $��Bắt đầu với��6b   5H  3   5I  /   �� 5J  .   $ Equals��6:   .��5K  2   �  5L  6   �� 5M  :   $
��Auto �6K   �� 5N  :   $��* �6K   .+�5P  6   �� $ 
EqualsIcon��6<   $��Center=�6P   $��Center=�6k   $
��None=�6�   $V��P/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_equals.png��6�   �� 5Q  6   $��10,0,0,0q�6@   $��1��6R   $��Bằng��6b   5R  3   5S  /   �� 5T  .   $ 
NotEqualTo��6:   .��5U  2   �  5V  6   �� 5W  :   $
��Auto �6K   �� 5X  :   $��* �6K   .+�5Z  6   �� $ NotEqualToIcon��6<   $��Center=�6T   $��Center=�6o   $
��None=�6�   $Y��S/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_notequals.png��6�   �� 5[  6   $��10,0,0,0q�6@   $��1��6R   $��Không bằng��6b   5\  3   5]  /   5^  +   5_  '   5`  #   �� 5a  "   $ FilterValue��6*   $��1��6?   $��19��6O   $��1q�6[   $��12(�6g   5c     5d     5e     5g     5h     �� 5j  
   "  6/   .�5k     ��  � �� .  6*   �� 5l      � ��$ 1,0,1,0q�60   �� 5m      � �� 5n     �� 5o     "  6&   .R�5p     �� $ RootElement��6!   $��Stretch=�66   $ 2q�6T   $��1,0,1,0q�6`   ��5q     �� 5r  "   $	 0,1&�66   $	 0,0&�6E   .��5s  &   � $	 	#FFF3F3F3��63   � 5t  &   $	 	#FFD6D6D6��63   $
 1Q�6E   5u  #   ��5w     �� 5x  "   $	 1,0&�66   $	 0,0&�6E   .��5y  &   � $	 	#FFFFFFFF��63   � 5z  &   $	 	#FFCCCCCC��63   $
 1Q�6E   5{  #   ._�5}     � $ FilterContent��6#   $y�	Collapsed=�6:    5~  "   �� 5  &   $
��Auto �67   �� 5�  &   $��* �67   �� 5�  &   $
��Auto �67    5�  "   .+�5�  "   �� $ FilterButton��6)   $
 Hand��6?   $��19��6M   $��18��6X   ��5�  &   �� 5�  *   " ��6:   .R�5�  .   �� $ FilterButtonOuterBorder��6g   ���	#FFAAAAAA$��1,1,0,1q�6M    5�  2     5�  6   $ CommonStates��6G   . 5�  :     $ Normal��6F     5�  :   $ 	MouseOver��6F   . 5�  >   �� .��5�  B   �� $ FilterButtonInnerBorder��6Q   $+ %(BorderBrush).(SolidColorBrush.Color)�6�   $ 	LightBlueX�6�   $ 0:0:0.1D�6�   5�  ?   5�  ;   5�  7   ._�5�  2   �� $ FilterButtonInnerBorder��6e   ���	#FFFFFFFF$��1q�6Q   ��5�  6   �� 5�  :   $	 0,1&�6N   $	 0,0&�6]   .��5�  >   � $	 	#FFFFFFFF��6K   � 5�  >   $	 	#FFFFFFFF��6K   $	
 .35Q�6]   � 5�  >   $	 	#FFEFEFEF��6K   $	
 .36Q�6]   � 5�  >   $	 	#FFD6D6D6��6K   $
 1Q�6]   5�  ;   ._�5�  6   �� #��z��6G   5�  3   5�  /   5�  +   ��5�  &   � 5�  *   .+�5�  .   �� $ NoFilterIcon��64   $ Tùy chỉnh bộ lọc��6J   $��Center=�6e   $��Center=�6�   $O��I/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter.png��6�   $
��None=�6�   �� 5�  .   $ 
FilterIcon��64   $y�	Collapsed=�6H   $��Center=�6_   $��Center=�6z   $T��N/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filterclose.png��6�   $
��None=�6�   5�  +   5�  #   �� 5�  "   $ FilterCloseButton��6)   $
 Hand��6D   $��19��6R   $��18��6]   $��2,0,0,0q�6i   $��2��6z   $y�	Collapsed=�6�   ��5�  &   �� 5�  *   " ��6:   .R�5�  .   �� $" FilterCloseButtonOuterBorder��6g   ���	#FFCCCCCC$��1,1,0,1q�6M    5�  2     5�  6   $ CommonStates��6G   . 5�  :     $ Normal��6F     5�  :   $ 	MouseOver��6F   . 5�  >   �� .��5�  B   �� $" FilterCloseButtonInnerBorder��6Q   $+ %(BorderBrush).(SolidColorBrush.Color)�6�   $ 	LightBlueX�6�   $ 0:0:0.1D�6�   5�  ?   5�  ;   5�  7   ._�5�  2   �� $" FilterCloseButtonInnerBorder��6e   ���	#FFFFFFFF$��1q�6Q   ��5�  6   �� 5�  :   $	 0,1&�6N   $	 0,0&�6]   .��5�  >   � $	 	#FFFFFFFF��6K   � 5�  >   $	 	#FFFFFFFF��6K   $	
 .35Q�6]   � 5�  >   $	 	#FFEFEFEF��6K   $	
 .36Q�6]   � 5�  >   $	 	#FFD6D6D6��6K   $
 1Q�6]   5�  ;   ._�5�  6   �� $ FilterCloseIcon��6<   $ Xoá bộ lọc��6U   $��Center=�6j   $��Center=�6�   $T��N/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filterclose.png��6�   $
��None=�6�   5�  3   5�  /   5�  +   5�  #     5�  "   $ FilterOptionsPopup��6H   $ 20Q�6d   .��5�  &   � 
������  5�  *   �� 5�  .   $��26 �6?   $��26��6J   �� 5�  .   $��* �6?   .+�5�  *   �� ���	#FFE3E3E361   �� 5�  *   ���	#FFF9F9F9$��1��6H   �� 5�  *   $ FilterOptions��6K   
������ $��2��6b   .@�5�  .   �� $ Equals��6:   .��5�  2   �  5�  6   �� 5�  :   $
��Auto �6K   �� 5�  :   $��* �6K   .+�5�  6   �� $ 
EqualsIcon��6<   $��Center=�6P   $��Center=�6k   $
��None=�6�   $V��P/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_equals.png��6�   �� 5�  6   $��10,0,0,0q�6@   $��1��6R   $��Bằng��6b   5�  3   5�  /   �� 5�  .   $ 
NotEqualTo��6:   .��5�  2   �  5�  6   �� 5�  :   $
��Auto �6K   �� 5�  :   $��* �6K   .+�5�  6   �� $ NotEqualToIcon��6<   $��Center=�6T   $��Center=�6o   $
��None=�6�   $Y��S/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_notequals.png��6�   �� 5�  6   $��10,0,0,0q�6@   $��1��6R   $��Không bằng��6b   5�  3   5�  /   5�  +   5�  '   5�  #     5�  "   -   5          . ! . $��1��5�  U   $��19��6e   $��1q�6q   $��12(�6}   $" Contains=�6�   .@�5�  &     $#  ��67   6A     5�  &   $# Fissler��67   6H     5�  &   $# 	Brabantia��67   6J   5�  #   5�     5�     5�     5�     5�     5�     .��5�     � .+�5�  
   �� $��32��6   $��Stretch=�6    $��Danh sách hình��6>   $	��Top=�6T   $
��Bold"�6l   $��20(�6~   $ �� Padding$$ 10,5,0,0q�6�   
�������$��Tahoma)�6�   �� 5�  
   -   5        $��stackPanel1��5�  ?   $��Stretch=�6   $��0q�63   $	��Top=�6R   % �� Orientation$% 
Horizontal=�6j   $��RightToLeft=�6�   $��40��6�   .+�5�     �� -   5        $ 	AddButton��5�     $��Thêm hình��6(   $
��Bold"�6<   $��23��6f   $	��100��6r   $��5q�6~   �� 5�     -   5        $��
btnRefresh��5�  3   $��Refresh��6   $��23��6'   $��84��6E   6P   5�     '	  !ComponentArt.Win.UI.Data.DataGrid	  5�  
   -   5        & 	 Name$& 	dataGrid1��5�     ' 	  HeaderVisibility$' 	Collapsed=�5�     ( 	  AllowColumnReordering( . ) 	  PageSize$) 25��5�     * 	  RunningMode$* Client=�5�     + 	  AllowEditing+ . , 	  ShowColumnFilters, . $��0,35,0,0q�5   *   - 	  AllowColumnResizing- . . 	  ItemsSource. 5�     �� / 	  	CellStyle/ 5     �� 5     +
  %ComponentArt.Win.UI.Data.DataGridCell" 
 6   .�5     ��  � ��$ 5q�60   5     0 	  Columns0 5     1  +ComponentArt.Win.UI.Data.DataGridTextColumn  5     -  'ComponentArt.Win.UI.Data.DataGridColumn1   AllowEditing1 .  2   Header$2 	Mã hình��6X   3   Width$3 1* �6i   4   FilterHeaderStyle#4 [ 6t   2  ,ComponentArt.Win.UI.Data.DataGridBoundColumn5   Binding5 6(   �� *HinhID+6t     5     1 .  $3 0 �6X   6   
ShowFilter6 .  5 6(   �� *MaHoSo+6b     5	     $2 Họ tên đương sự��6B   $3 1* �6[   #4 [ 6f   5 6(   �� *HoTen+7   CellEditTemplate7 5
     �� 5     .R�5        PhapY.uc.ComboboxChucVu  8  Name$8 cbbCV��61      PhapY.uc.ComboboxChucVu9   Loaded9 cbbCV_Loaded6L   :   SelectionFinalized: cbbCV_SelectionFinalized6b   $��-5q�6@   6b   5     5       5     $2 Hình��6A   $3 1* �6O   #4 [ 6Z   5 6(   �� *Hinh+6Z     5     $2 Diễn giải��6E   $3 1* �6X   #4 [ 6c   5 6(   �� *
DienGiai+6c   5  /ComponentArt.Win.UI.Data.DataGridTemplateColumn  5     $
2 Edit��6,   $3 50 �6:   1 .   ;   HeaderHorizontalAlignment$; Center=�6Z   6 .  <   	CellStyle< 5     �� 5     " 
 6    .�5     ��  � ��$ 0q�68   5     =   CellTemplate= 5     �� 5     .R�5     � .+�5  "   �� $% 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5  &   �� -   5        ��.  ��5  *   �� 5  .   .R�5  2   �  5   6     5!  :   $ CommonStates��6K   . 5"  >     $ Normal��6J     5#  >   $ 	MouseOver��6J   . 5$  B   �� .��5%  F   W� $ EditImageHover��6V   $ Opacity�6}   	> W� To$> 1X�6�   $ 0:0:0.2D�6�   5&  C   5'  ?   5(  ;   .+�5*  6   �� $ 	EditImage��6<   $U��O/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_edit.png��6O   $
��None=�6�   �� 5+  6   $ EditImageHover��6<   $[��U/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_edit_hover.png��6T   $
��None=�6�   ? J� Opacity$? 0Q�6�   $ Sửa��6�   $
 Hand��6�   5,  3   5-  /   5/  '   �� 50  &   -   5        ��.  ��51  *   �� 52  .   .R�53  2   �  54  6     55  :   $ CommonStates��6K   . 56  >     $ Normal��6J     57  >   $ 	MouseOver��6J   . 58  B   �� .��59  F   W� $ DeleteImageHover��6V   $ Opacity�6   $> 1X�6�   $ 0:0:0.2D�6�   5:  C   5;  ?   5<  ;   .+�5>  6   �� $ DeleteImage��6<   $W��Q/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_delete.png��6Q   $
��None=�6�   �� 5?  6   $ DeleteImageHover��6<   $]��W/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_delete_hover.png��6V   $
��None=�6�   $? 0Q�6�   $
 Xóa��6�   $
 Hand��6�   5@  3   5A  /   5C  '   5D  #   5E     5F     7 5H     �� 5I     .R�5J     � .+�5K  "   �� $% 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5L  &   �� -   5        ��.  @ �� 	IsDefault@ . ��5M  *   �� 5N  .   .R�5O  2   �  5P  6     5Q  :   $ CommonStates��6K   . 5R  >     $ Normal��6J     5S  >   $ 	MouseOver��6J   . 5T  B   �� .��5U  F   W� $ AcceptImageHover��6V   $ Opacity�6   $> 1X�6�   $ 0:0:0.2D�6�   5V  C   5W  ?   5X  ;   .+�5Z  6   �� $ AcceptImage��6<   $W��Q/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_accept.png��6Q   $
��None=�6�   �� 5[  6   $ AcceptImageHover��6<   $]��W/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_accept_hover.png��6V   $
��None=�6�   $? 0Q�6�   $ Hoàn tất��6�   5\  3   5]  /   5_  '   �� 5`  &   -	   5        ��.  ��5a  *   �� 5b  .   .R�5c  2   �  5d  6     5e  :   $ CommonStates��6K   . 5f  >     $ Normal��6J     5g  >   $ 	MouseOver��6J   . 5h  B   �� .��5i  F   W� $ CancelImageHover��6V   $ Opacity�6   $> 1X�6�   $ 0:0:0.2D�6�   5j  C   5k  ?   5l  ;   .+�5n  6   �� $ CancelImage��6<   $W��Q/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_cancel.png��6Q   $
��None=�6�   �� 5o  6   $ CancelImageHover��6<   $]��W/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_cancel_hover.png��6V   $
��None=�6�   $? 0Q�6�   $ 
Hủy bỏ��6�   5p  3   5q  /   5s  '   5t  #   5u     5v     5x     5z     5{     5|     