   M S B A M L   `   `   `  ����J  FChatApp.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ChatApp.Desktop.ViewsChatApp.Desktop.Views  5      &     ChatApp.Desktop.Views.ChatLayout   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ChatApp.Desktop.Views     5      .��5      � 
����� �  � RowDefinitions  5	   
   �� 5
      $��31 �6   �� 5      $��* �6   �� 5      $��60 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5        $��Title��5      $��Connected Mike��6!   ���#686868
�������$��Right=�6b   $��1q�6�   5      � 5   
   $��1��6   
�������.+�5      �� -   5        $��ContentScroller��5      $��Disabled=�62   $
��Auto=�6[   
�������.��5      �� -   5        $��MessageTemplate��5      ��5      �� 5      .R�5      � .+�5   "   � $��5q�6'   ��62   �� *ItemBackground+  5   &   �� 5   *   $��32 �68   6F   �� 5   *   $��* �68   6E   .+�5   &   � $��0��6+   .+�5    *   ��  �� Orientation$ 
Horizontal=�65   ��6N   �� *HeaderBackground+.+�5!   .   �� $
��Left=�6M   ��64   �� *Name+6j   �� 5"   .   $��Right=�6Q   ��64   �� *
SentTime+6o   5#   +   5$   '   � 5%   &   $��1��6+   .+�5&   *   �� $ 
Horizontal=�65   .+�5'   .   �� $��Right=�64   $��Right=�6W   ��6s   �� *MessageSent+6�   5(   +   5)   '   5*   #   5+      5,      5.      5/      50      � 51   
   $��2��6   ���#2B2C2E.+�52      �� $ 
Horizontal=�6   .+�53      �� -   5        $��MessageContent��53      ���#686868$	��200��6E    �� TextWrapping$
 Wrap=�6Q    �� AcceptsReturn . $��10q�6z   6�   �� 54      -   5        $��
SendButton��54      $
��Send��6+   $��20q�6:   $��Right=�6F   
���   �
�������6�   55      56      57      58      