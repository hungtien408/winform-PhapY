   M S B A M L   `   `   `  ����g  cComponentArt.Win.UI.Input, Version=2010.1.2637.35, Culture=neutral, PublicKeyToken=9bc9f846553156bbhJclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.InputComponentArt.Win.UI.Input  5   	   	 PhapY-   'PhapY.SubWindows.SQLServerConfiguration   5   	   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   ?dx2http://schemas.devexpress.com/winfx/2008/xaml/core    5   	   Cdxe5http://schemas.devexpress.com/winfx/2008/xaml/editors    5   	   Jdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol    5   	   WmyJclr-namespace:ComponentArt.Win.UI.Input;assembly=ComponentArt.Win.UI.Input    5   	     � Title$&   Cấu Hình Cơ Sở Dữ Liệu��5   	   $	��410��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   $	��300��5   	    � 	Resources 5      ��%    5      .��5      � .+�5   
   �� $
��Left=�6   $��	20,19,0,0q�5      $	��Top=�5      $��Địa chỉ máy chủ��5      $��0q�5      $��22��5      $��Center=�5      � 5   
   $��
123,19,0,0q�6   $	��250��5      $	��Top=�5      $
��Left=�5       � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   .+�5       (   "ComponentArt.Win.UI.Input.ComboBox  -   5          Name$ cbxServerName��5       $
��Auto��5!      $	��Top=�5"         FilteringType$ Contains=�5#         MaxPopupHeight$	 300��5$         MinPopupHeight$	 100Q�5%      ��5'      �� 5(      .R�5)      �� 	 ��Name$	 ItemText��6$   $��2��5*   $   $��12(�5+   $   $��Center=�5,   $   $��Arial)�5.   $   $
��Wrap=�5/   $   ��5-   $   �� 5/   $   50      52      �� 53      -   5        
 ��Name$
 btnRefreshServerName��53      $��2,0.23,0,0.23q�54      $��22��56      $��22��57      $��1��58      $
��Left=�59      .��5:      �� $<��6/PhapY;component/assets/images/Icons/refresh-16x16.png��6   5;      5<      �� 5=   
   $
��Left=�6   $��
123,46,0,0q�5>      $	��Top=�5?      $	��250��5@      $��60��5A      .��5B      �� .+�5C      	� -   5         	�Name$ chkWindowAccount��5C      $
��Left=�5D      $	��Top=�5E      $��Tài Khoản Windows��5F      $��0,0,0,5q�5G       	� 	GroupName$ 	Authorize��5H       d� 	IsChecked$
 TrueY�5I      5J      	� 5K      -   5        $ chkSQLAccount��5K      $
��Left=�5L      $	��Top=�5M      $��Tài Khoản SQL Server��5N      $��0,0,0,5q�5O      $ 	Authorize��5P      5Q      5R      5S      �� 5T   
   $
��Left=�6   $��20,109.92,0,0q�5U      $	��Top=�5V      $��Tài khoản��5W      $��0q�5X      $��22��5Y      $��Center=�5Z      �� 5[   
   -   5         ��Name$ txtUserName��5[      $
��Left=�5\      $��123,109.92,0,0q�5]      $	��Top=�5^      $	��250��5_      {�.  $��sa��5a      �� 5b   
   $
��Left=�6   $��20,136.92,0,0q�5c      $	��Top=�5d      $��Mật khẩu��5e      $��0q�5f      $��22��5g      $��Center=�5h      G� 5i   
   -   5         G�Name$ txtPassword��5i      $
��Left=�5j      $��123,136.92,0,0q�5k      $	��Top=�5l      $	��250��5m      {�.   G� Password$ 123456��5o      �� 5p   
   $
��Left=�6   $��20,163.92,0,0q�5q      $	��Top=�5r      $��	Tên CSDL��5s      $��0q�5t      $��22��5u      $��Center=�5v      � 5w   
   $��123,163.92,0,0q�6   $	��250��5x      $	��Top=�5y      $
��Left=�5z       5{      �� 5|      �� 5}      $
��Auto �6#   .+�5        -   5        $ cbxDatabaseName��5      $	��Top=�5�      $ Contains=�5�      $	 300��5�      $	 100Q�5�      $
��Auto��5�      ��5�      �� 5�      .R�5�      �� $	 ItemText��6$   $��2��5�   $   $��12(�5�   $   $��Center=�5�   $   $��Arial)�5�   $   $
��Wrap=�5�   $   ��5�   $   �� 5�   $   5�      5�      �� 5�      -   5        $
 btnRefreshDatabaseName��5�      $��2,0.23,0,0.23q�5�      $��22��5�      $��1��5�      .��5�      �� $<��6/PhapY;component/assets/images/Icons/refresh-16x16.png��6   5�      5�      �� 5�   
   $��	0,0,10,10q�6   $��Bottom=�5�       �� Orientation$ 
Horizontal=�5�      $��Right=�5�      .+�5�      �� -	   5        $
 btnSave��5�      $��0,0,5,0q�5�      $��Bottom=�5�      $
��20,2q�5�       �� 	IsDefault . $��Right=�5�      .��5�      �� $ 
Horizontal=�6   .+�5�      �� $��16��6   $9��3/PhapY;component/assets/images/Icons/save-16x16.png��5�      $��16��5�      $��0,0,5,0q�5�      �� 5�      $
��Lưu��6   $��SemiBold"�5�      5�      5�      �� 5�      -
   5        $
 btnClose��5�      $��Right=�5�      $��0q�5�      $��Bottom=�5�      $
��20,2q�5�      .��5�      �� $ 
Horizontal=�6   .+�5�      �� $��16��6   $:��4/PhapY;component/assets/images/Icons/close-16x16.png��5�      $��16��5�      $��0,0,5,0q�5�      �� 5�      $��Đóng��6   $��SemiBold"�5�      5�      5�      5�      �� 5�   
   $
��Left=�6   $��	10,0,0,10q�5�      $��Bottom=�5�      .+�5�      �� -   5        $
 btnTest��5�      $��0,0,4.643,0q�5�      $��Bottom=�5�      $
��20,2q�5�       . $��Right=�5�      .��5�      �� $ 
Horizontal=�6   .+�5�      �� $��16��6   $D��>/PhapY;component/assets/images/Icons/database-search-16x16.png��5�      $��16��5�      $��0,0,5,0q�5�      �� 5�      $��Kiểm tra kết nối��6   $��SemiBold"�5�      5�      5�      5�      5�      5�      