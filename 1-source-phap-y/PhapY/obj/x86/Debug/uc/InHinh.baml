   M S B A M L   `   `   `  ����	  PhapY    PhapY.uc.InHinh   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      >d2http://schemas.microsoft.com/expression/blend/2008    5        � 	Resources  5       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value O� 	GlowColor O� GlowSize��%�   '��       �� 5	   
   " ��6    5
      P� 5       �@��
IsSelected . . �5      ��  �@J�BitmapEffect 5      O� 5      $	 Red��64   $ 5Q�6D   5      5      5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      �� 5      $��5 �6   �� 5      .+�5   
   �� 
 �� Orientation$
 
Horizontal=�6   $��0��6.   $	��Top=�6>   .+�5      �� $��Tổng số hình:��6   �� 5      -   5        $��lblTongSoHinh��5      $
��Bold"�6)   5       � 5!   
    � RowDefinitions 5"      �� 5#      $��1* �6    6.   �� 5$      $��1* �6    6.   .+�5&      �� -   5        $��BorderImgBig��5&      $��0��6)   $��Stretch=�66   $��0,30,0,0q�6T   $��Stretch=�6f   
���   �
�������$��2q�6�   ._�5'      �� -   5        $��imgBig��5'   6   $��Stretch=�6   $��Uniform=�6D   $��Stretch=�6V   ��6r   �� *Hinh+5(      �� 5)      -   5        $��lstNavigation��5)   A   $��Stretch=�6   $��1��64   $��Stretch=�6V   $
��Auto=�6r   $��Disabled=�6�   ��5*      �� 5+      .R�5,      � 5-      ��5/      �� 50      .R�51      �� 
�������$��1q�66   $��2q�6J   
�������$	��100��6h   ._�52      �� .+�53   "   �� $	��img��6(   $��70��6b   $��Uniform=�6q   $��0,0,0,2q�6�   ��63   �� *Hinh+
 � Tag 6K   �� *HinhID+6�   �� 54   "   $��chkChooseImg��6+   -   5        $��Stretch=�54   V   $��Center=�6t    6?   �� *HinhID+6�   55      56      57      59      5:      �� 5<   
   $
 
Horizontal=�6   $��2��6.   $	��Top=�6>   .+�5=      �� $!��Số hình được chọn:��6   �� 5>      -   5        $��lblSoHinhDuocChon��5>      $
��Bold"�6-   �� 5?      5@      �� 5A   
   -   5        $��btnSave��5A   .   $ ��Lưu hình được chọn��6   $��Right=�6=   $	��Top=�6Y   $��	10,0,10,0q�6q   $��50,0,0,0q�6�   $��2��6�   {�.  6�   �� 5B   
   -   5        $��lstChooseImg��5B      $��Stretch=�6&   $
��Auto=�6D   $��Stretch=�6t    J� 	AllowDrop . $��2��6�   $��Disabled=�6  $��0,24,0,0q�6|  ��5L      �� 5M      .R�5N      �  K� IsItemsHost . 6    5O      5Q      5T      5U      