   M S B A M L   `   `   `  ����  CGClient.WPF    CGClient.WPF.ShellView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ^ ZCaliburn.Micro.Platform, Version=3.0.1.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5   	     � SizeToContent$  WidthAndHeight=�5   @   .��5      � 
�������.+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$
 Code��5       �� TextWrapping$
 Wrap=�5       �� AcceptsReturn . 
���   �$��3q�5      $	��800��5      $	��600��5      " �� VerticalScrollBarVisibility$ Visible=�5      �� 5      -   5        $��PlayerResults��5      $	��800��6+   $	��300��68   $	��800��5        Caliburn.Micro.Message   Attach$/ )[Event MouseDoubleClick] = [Action Run()]��6N    �� SelectedItem 6   �� *SelectedPlayerResult+��5      �� 5      .R�5      �� $ 
Horizontal=�6%   .+�5      �� ��6(   ��  �� Path$ Player.Name��� 5      ��6(   �� $	 Win��� 5      ��6(   �� $
 Lose��� 5      ��6(   �� $
 Draw�5      5      5      5      5      5       