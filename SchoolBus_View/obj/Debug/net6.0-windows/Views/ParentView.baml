   M S B A M L   `   `   `  ����I  ESchoolBus_View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SchoolBus_View.ViewsSchoolBus_View.Views  5      %    SchoolBus_View.Views.ParentView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SchoolBus_View.Views     5      .��5	      �� .+�5
   
   ��   �� Orientation$  
Horizontal=�6   $
��Left=�6.   $	��328��6I    �� Left$	 245��6U   
 �� Top$ 10��6g   $��Center=�6w   .+�5      �� $	��100��67   $��50��6C   $	��Add��6O   $��0q�6]   $��20(�6q   $
��Bold"�6   
��� �����6   �� *
Add_Button+6�   �� 5      $	��100��67   $��50��6C   $��Delete��6O   $��0q�6`   $��20(�6t   $
��Bold"�6�   
��� ���$��10,0,0,0q�6�   ��6   �� *Delete_Button+6�   �� 5      $	��106��67   $��50��6C   $��Update��6O   $��0q�6`   $��20(�6t   $
��Bold"�6�   
��� ���$��10,0,0,0q�6�   ��6   �� *Update_Button+6�   5      �� 5   
   $��1��6   $ 63��6"   $ 73��63   $  
Horizontal=�6C   
��� ���$��Center=�6n   $	��Top=�6�   $	��674��6�   .+�5      �� $��DemiBold"�6   $��20(�6*   $	��135��68   $��50��6D   $��     Id��6P   $��Center=�6b   $��Center=�6�   �� 5      $��10,0,0,0q�6   $��DemiBold"�6&   $��20(�6<   $	��188��6J   $��50��6V   $��	FirstName��6b   $��Center=�6v   $��Center=�6�   �� 5      $��DemiBold"�6   $��20(�6*   $	��183��68   $��50��6D   $��LastName��6P   $��Center=�6c   $��Center=�6�   �� 5      $��DemiBold"�6   $��20(�6*   $	��164��68   $��50��6D   $��Phone��6P   $��Center=�6`   $��Center=�6�   5      �� 5   
   $��2��6   $	��300��6   $	��674��6,   $	 124��68   
���iii�$
��True��6^   $	��Top=�6�   $ 63��6  $��Center=�6  ��6�   �� *	Parents+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedParent+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��165 �6/   �� 5      $	��165 �6/   �� 5      $	��165 �6/   �� 5      $	��165 �6/   .+�5"      �� $��0��6$   $��10(�6H   $��Center=�6V   $��Center=�6q   ��64   �� *Id+6q   �� 5#      $��1��6$   $��10(�6O   $��Center=�6]   $��Center=�6x    �� TextAlignment$ Center=�6�   ��64   �� *	FirstName+6�   �� 5$      $��2��6$   $��10(�6N   $��Center=�6\   $��Center=�6w   ��64   �� *
LastName+6w   �� 5%      $��3��6$   $��10(�6Q   $��Center=�6_   $��Center=�6z   ��64   �� *PhoneNumber+6z   5&      5'      5)      5+      5,      