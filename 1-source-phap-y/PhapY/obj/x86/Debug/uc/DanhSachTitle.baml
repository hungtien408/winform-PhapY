   M S B A M L   `   `   `  ����@  <PhapY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PhapY.ucPhapY.uc  5      g cComponentArt.Win.UI.Input, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbhJclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.InputComponentArt.Win.UI.Input 61   f bComponentArt.Win.UI.Data, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbeHclr-namespace:ComponentArt.Win.UI.Data;assembly=ComponentArt.Win.UI.DataComponentArt.Win.UI.Data 6�   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D1clr-namespace:System.Windows;assembly=WindowsBaseSystem.Windows 5      h dComponentArt.Win.UI.Common, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbiKclr-namespace:ComponentArt.Win.UI.Utils;assembly=ComponentArt.Win.UI.CommonComponentArt.Win.UI.Utils 5          PhapY.uc.DanhSachTitle   5      my2clr-namespace:PhapY.uc  Rmy1Jclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.Input  61   OmyHclr-namespace:ComponentArt.Win.UI.Data;assembly=ComponentArt.Win.UI.Data  6�   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      ?vsm1clr-namespace:System.Windows;assembly=WindowsBase    5      oComponentArt_Win_UI_UtilsKclr-namespace:ComponentArt.Win.UI.Utils;assembly=ComponentArt.Win.UI.Common    5      -   5          � 	Resources  5
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
��None=�6�   $Y��S/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_filter_notequals.png��6�   �� 5�  6   $��10,0,0,0q�6@   $��1��6R   $��Không bằng��6b   5�  3   5�  /   5�  +   5�  '   5�  #     5�  "   -   5          . ! . $��1��5�  U   $��19��6e   $��1q�6q   $��12(�6}   $" Contains=�6�   .@�5�  &     $#  ��67   6A     5�  &   $# Fissler��67   6H     5�  &   $# 	Brabantia��67   6J   5�  #   5�     5�     5�     5�     5�     5�     .��5�     � .+�5�  
   c� -   5        $ c�Name$$ toolBar1��5�  <   $��35��6   $��Stretch=�6   $	��Top=�6N   .@�5�     �� $,��&/PhapY;component/Images/graduation.png��6   $��24��6D   $��Uniform=�6O   $��Center=�6a   �� 5�     $��5,0,5,0q�6   $��0q�6%   $��Danh sách bằng cấp��61   $��Center=�6N   $
��Bold"�6p   $��18(�6�   �� 5�     �� 5�     -   5        $ 	btnInsert��5�       InsertButton#��[ 6(   $��5q�6N   $��30��6q   $��30��6|   �� 5�     -   5        $ btnEdit��5�       
EditButton#��[ 6&   $��5q�6J   6U   �� 5�     -   5        $ 	btnDelete��5�       DeleteButton#��[ 6(   $��5q�6N   6Y   �� 5�     -   5        $ 
btnRefresh��5�       RefreshButton#��[ 6)   $��5q�6P   6[   5      '	  !ComponentArt.Win.UI.Data.DataGrid	  5  
   -   5        % 	 Name$% 	dataGrid1��5     & 	  AllowColumnResizing& . ' 	  AllowColumnReordering' . ( 	  AllowEditing( . ) 	  ShowColumnFilters) . * 	  RunningMode$* Client=�5     + 	  PageSize$+ 25��5     $��0,35,0,0q�5	     , 	  	CellStyle, 5     �� 5     +
  %ComponentArt.Win.UI.Data.DataGridCell" 
 6   .�5     ��  � ��$ 5q�60   5     - 	  Columns- 5     1  +ComponentArt.Win.UI.Data.DataGridTextColumn  5     -  'ComponentArt.Win.UI.Data.DataGridColumn.   AllowEditing. .  /   Header$/ 	Mã title��6Y   0   Width$0 1* �6k   1   FilterHeaderStyle#1 [ 6v   2  ,ComponentArt.Win.UI.Data.DataGridBoundColumn2   Binding2 6(   �� *	MaTitle+6v     5     $/ Bằng cấp��6B   $0 1* �6T   #1 [ 6_   2 6(   �� *Title+6_     5     $/ Diễn giải��6E   $0 1* �6X   #1 [ 6c   2 6(   �� *
DienGiai+6c   5  /ComponentArt.Win.UI.Data.DataGridTemplateColumn  5     $
/ Edit��6,   $0 50 �6:   . .   3   HeaderHorizontalAlignment$3 Center=�6Z   4   
ShowFilter4 .  5   	CellStyle5 5     �� 5     " 
 6    .�5     ��  � ��$ 0q�68   5     6   CellTemplate6 5     �� 5     .R�5     � .+�5  "   �� 7 �� Orientation$7 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5   &   �� -	   5        ��.  ��5!  *   �� 5"  .   .R�5#  2   �  5$  6     5%  :   $ CommonStates��6K   . 5&  >     $ Normal��6J     5'  >   $ 	MouseOver��6J   . 5(  B   �� .��5)  F   W� $ EditImageHover��6V   $ Opacity�6}   	8 W� To$8 1X�6�   $ 0:0:0.2D�6�   5*  C   5+  ?   5,  ;   .+�5.  6   �� $ 	EditImage��6<   $U��O/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_edit.png��6O   $
��None=�6�   �� 5/  6   $ EditImageHover��6<   $[��U/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_edit_hover.png��6T   $
��None=�6�   9 J� Opacity$9 0Q�6�   $ Sửa��6�   $
 Hand��6�   50  3   51  /   53  '   �� 54  &   -
   5        ��.  ��55  *   �� 56  .   .R�57  2   �  58  6     59  :   $ CommonStates��6K   . 5:  >     $ Normal��6J     5;  >   $ 	MouseOver��6J   . 5<  B   �� .��5=  F   W� $ DeleteImageHover��6V   $ Opacity�6   $8 1X�6�   $ 0:0:0.2D�6�   5>  C   5?  ?   5@  ;   .+�5B  6   �� $ DeleteImage��6<   $W��Q/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_delete.png��6Q   $
��None=�6�   �� 5C  6   $ DeleteImageHover��6<   $]��W/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_delete_hover.png��6V   $
��None=�6�   $9 0Q�6�   $
 Xóa��6�   $
 Hand��6�   5D  3   5E  /   5G  '   5H  #   5I     5J     :   CellEditTemplate: 5L     �� 5M     .R�5N     � .+�5O  "   �� $7 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5P  &   �� -   5        ��.  ; �� 	IsDefault; . ��5Q  *   �� 5R  .   .R�5S  2   �  5T  6     5U  :   $ CommonStates��6K   . 5V  >     $ Normal��6J     5W  >   $ 	MouseOver��6J   . 5X  B   �� .��5Y  F   W� $ AcceptImageHover��6V   $ Opacity�6   $8 1X�6�   $ 0:0:0.2D�6�   5Z  C   5[  ?   5\  ;   .+�5^  6   �� $ AcceptImage��6<   $W��Q/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_accept.png��6Q   $
��None=�6�   �� 5_  6   $ AcceptImageHover��6<   $]��W/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_accept_hover.png��6V   $
��None=�6�   $9 0Q�6�   $ Hoàn tất��6�   5`  3   5a  /   5c  '   �� 5d  &   -   5        ��.  ��5e  *   �� 5f  .   .R�5g  2   �  5h  6     5i  :   $ CommonStates��6K   . 5j  >     $ Normal��6J     5k  >   $ 	MouseOver��6J   . 5l  B   �� .��5m  F   W� $ CancelImageHover��6V   $ Opacity�6   $8 1X�6�   $ 0:0:0.2D�6�   5n  C   5o  ?   5p  ;   .+�5r  6   �� $ CancelImage��6<   $W��Q/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_cancel.png��6Q   $
��None=�6�   �� 5s  6   $ CancelImageHover��6<   $]��W/PhapY;component/assets/images/Component_Art/Datagrid/datagrid_editing_cancel_hover.png��6V   $
��None=�6�   $9 0Q�6�   $ 
Hủy bỏ��6�   5t  3   5u  /   5w  '   5x  #   5y     5z     5|       5}     $0 18 �6(   <   AllowResizing< .  . .  =   AllowSorting= .  4 .  6s   5     5�     5�     