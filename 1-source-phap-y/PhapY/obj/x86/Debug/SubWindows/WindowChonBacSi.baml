   M S B A M L   `   `   `  ����g  cComponentArt.Win.UI.Input, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbhJclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.InputComponentArt.Win.UI.Input  5   	   	 PhapY&    PhapY.SubWindows.WindowChonBacSi   5   	   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   WmyJclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.Input    5   	     � Title$  Chọn bác sĩ��5   	   $��50��5   	   $	��300��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � 	Resources 5
         HeadingTemplate � ColumnDefinitions � RowDefinitions �� Padding  ItemTemplate ��Name��%	  &	        &	 �    �� 5   
   .R�5      � $��Stretch=�6   $��Stretch=�5      ���#ababab 5      �� 5      $��90 �6'   �� 5      $��0 �6'   �� 5      $	��200 �6'   �� 5      $��0 �6'   �� 5      $	��150 �6'   �� 5      $��0 �6'   �� 5      $	��150 �6'    5      �� 5      $��24 �6$   .+�5      �� ���#666666$��1q�5      $��0��5      $ 4,0,0,0q�5      ._�5      �� 
�������$��12(�5        $��Center=�5!       $��Mã Nhân Viên��5"       $��Arial)�5#       5$      �� 5%      ���#666666$��1q�5&      $��2��5'      $ 4,0,0,0q�5(      ._�5)      �� 
�������$��12(�5*       $��Center=�5+       $��Tên Nhân Viên��5,       $��Arial)�5-       5.      �� 5/      ���#666666$��1q�50      $��4��51      $ 4,0,0,0q�52      ._�53      �� 
�������$��12(�54       $��Center=�55       $��Chức vụ��56       $��Arial)�57       58      �� 59      ���#666666$��1q�5:      $��6��5;      $ 4,0,0,0q�5<      ._�5=      �� 
�������$��12(�5>       $��Center=�5?       $��
Số thẻ��5@       $��Arial)�5A       5B      5C      5D      �� 5E   
   .R�5F      � $��Stretch=�6   $��Stretch=�5G      
������  5I      �� 5J      $��90 �6'   �� 5K      $��1 �6'   �� 5L      $	��200 �6'   �� 5M      $��1 �6'   �� 5N      $	��150 �6'   �� 5O      $��1 �6'   �� 5P      $	��150 �6'    5R      �� 5S      $	��12* �6$   .+�5U      �� $ tblEditMaNhanVien��6   
���   �$��0��5W      $��12(�5X      $��Center=�5Y      $��Arial)�5[      $
��Wrap=�5\      ��5Z      �� *
MaNhanVien+5\      �� 5^      $ ItemText��6   
��� ���$��2��5`      $��12(�5a      $��Center=�5b      $��Arial)�5d      $
��Wrap=�5e      ��5c      �� *HoTen+5e      �� 5f      $ tblEditChucVu��6   
���   �$��4��5h      $��12(�5i      $��Center=�5j      $��Arial)�5l      $
��Wrap=�5m      ��5k      �� *	TenChucVu+5m      �� 5n      $ tblEditSoThe��6   
���   �$��6��5p      $��12(�5q      $��Center=�5r      $��Arial)�5t      $
��Wrap=�5u      ��5s      �� *SoThe+5u      5v      5w      5x      .��5y      � .+�5z   
   (   "ComponentArt.Win.UI.Input.ComboBox  -   5          Name$ 
MyComboBox��5z      $��Stretch=�5{      $��Stretch=�5|      	   DataFieldName$	 TenNhanVien��5}      
   DropDownHeader#
 [  5~         FilteringType$ Contains=�5      #��[ 5�         MaxPopupHeight$	 300��5�      5�      5�      5�      