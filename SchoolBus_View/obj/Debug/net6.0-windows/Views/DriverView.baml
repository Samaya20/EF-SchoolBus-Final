   M S B A M L   `   `   `  ����I  ESchoolBus_View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SchoolBus_View.ViewsSchoolBus_View.Views  5      %    SchoolBus_View.Views.DriverView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SchoolBus_View.Views     5      .��5	      �� .+�5
   
   ��   �� Orientation$  
Horizontal=�6   $
��Left=�6.   $	��337��6I    �� Left$	 285��6U   
 �� Top$ 10��6g   $��Center=�6w   .+�5      �� $	��100��64   $��50��6@   $	��Add��6L   $��0q�6Z   $��20(�6n   $
��Bold"�6|   
��� �����6   �� *
Add_Button+6�   �� 5      $	��100��67   $��50��6C   $��Delete��6O   $��0q�6`   $��20(�6t   $
��Bold"�6�   
��� ���$��10,0,0,0q�6�   ��6   �� *Delete_Button+6�   5      �� 5   
   $��1��6   $ 63��6"   $ 73��63   $  
Horizontal=�6C   
��� ���$��Center=�6n   $	��Top=�6�   $	��674��6�   .+�5      �� $��10,0,0,0q�6   $��DemiBold"�6&   $��20(�6<   $	��129��6J   $��50��6V   $
��Name��6b   $��Center=�6q   $��Center=�6�   �� 5      $��DemiBold"�6   $��20(�6*   $	��122��68   $��50��6D   $��LastName��6P   $��Center=�6c   $��Center=�6�   �� 5      $��DemiBold"�6   $��20(�6*   $	��126��68   $��50��6D   $��CarId��6P   $��Center=�6`   $��Center=�6�   �� 5      $��DemiBold"�6   $��20(�6*   $	��111��68   $��50��6D   $��Phone��6P   $��Center=�6`   $��Center=�6�   �� 5      $��DemiBold"�6   $��20(�6*   $	��170��68   $��50��6D   $��
HomeAdress��6P   $��Center=�6e   $��Center=�6�   5      �� 5   
   $��2��6   $	��300��6   $	 124��6,   
���iii�$
��True��6R   $	��Top=�6w   $ 63��6�   $��Center=�6  $	��674��6)  ��6�   �� *	Drivers+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedDriver+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��133 �6/   �� 5      $	��133 �6/   �� 5      $	��133 �6/   �� 5      $	��133 �6/   �� 5       $	��133 �6/   .+�5#      �� $��0��6$   $��10(�6O   $��Center=�6]   $��Center=�6x    �� TextAlignment$ Center=�6�   ��64   �� *	FirstName+6�   �� 5$      $��1��6$   $��10(�6N   $��Center=�6\   $��Center=�6w   ��64   �� *
LastName+6w   �� 5%      $��2��6$   $��10(�6K   $��Center=�6Y   $��Center=�6t   ��64   �� *CarId+6t   �� 5&      $��3��6$   $��10(�6K   $��Center=�6Y   $��Center=�6t   ��64   �� *Phone+6t   �� 5'      $��4��6$   $��10(�6M   $��Center=�6[   $��Center=�6v   ��64   �� *	Address+6v   5(      5)      5+      5,      5-      