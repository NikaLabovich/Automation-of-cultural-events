   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   C ?LVV-2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LVV_2019LVV_2019 5   	      LVV_2019.GeneralWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   +lvv_2019clr-namespace:LVV_2019     5   	     � Title$  GeneralWindow��5
   	   $
��1400��6   ���#31b57f$��20q�6B   $	��580��6W   ���#c3efdd � WindowStyle$
 None=�6y    � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5      �  � ColumnDefinitions 5      �� 5      $
��0.5* �6$   �� 5      $
��0.5* �6$    � RowDefinitions 5      �� 5      $��70 �6    �� 5      $
��auto �6   �� 5      $��* �6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��3��62   $��20q�6F   $��Center=�6S   .+�5      �� -   5        $��Login��5      $	��200��6%   $��17(�61   
�������$��LUCIDA SANS UNICODE)�6R   ���#404040���#404040$��Center=�6�   6�   �� 5      -   5        $��10,0,0,0q�5      $��
UpdateInfo��6'   $	��200��6=   $��17(�6I   
�������$��LUCIDA SANS UNICODE)�6�   ���#404040���#404040$��Center=�6�   5        LVV_2019.UserControl1  5!      -   5          Name$ UserControl1��5!   $   $
��auto��6:   $��1��6G   $��10q�6U      Title$ Add info��6a   $��LUCIDA SANS UNICODE)�6r   	   	Minimized	 . 
�������6�     LVV_2019.UserControl2Edit  5"      -   5        
  Name$
 UserControl2��5"   (   $
��auto��6>   $��1��6K   $��1��6X   $��10q�6h      Title$ 	Edit info��6t   $��LUCIDA SANS UNICODE)�6�      	Minimized . 
�������6�   &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ DataGridEvents��5&   �   $��3��6   $��LUCIDA SANS UNICODE)�6    $��3��6A   ���#545d6a
���   �   DataGridColumnHeaderStyle1   ColumnHeaderStyle# �   6}   $��
10,0,10,10q�6�      AutoGenerateColumns .  $
��auto��6    DataGridStyle1#���  6   � 	Resources 5'       �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels ��Name   SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource  �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter!  Name"   Column# ��Name$ �� CanContentScroll% ��Name& �� ScrollableHeight' � Maximum( �� Orientation*) �� #ComputedVerticalScrollBarVisibility* �� ViewportHeight+ �� ViewportSize, � Value- �� Mode. �� ScrollableWidth,/ �� %ComputedHorizontalScrollBarVisibility0 �� ViewportWidth1 �� Triggers2 ]� 
Conditions3 �� Property4 �� Value��%c  &	       �� 5(      "  63   .�5)      ��  � ��# � ��67   �� 5*       � ��# � ��67   �� 5+       � �� �#31b57f68   �� 5,       � ��$ 2q�6<   �� 5-        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�6E   �� 5.       � �� . 6J   �� 5/       �@��PanningMode$
 Both=�6E   �� 50       �@��IsFlicksEnabled .  6C   �� 51       � �� 52      �� 53   "   "  62   .R�54   &   �� #��z��6-   #��z��6Y   #��z��6�   # z��6�    . ._�55   *   �� $ DG_ScrollViewer��68   |�.  ��56   .   �� 57   2   " ��6B   .R�58   6   �  59   :   �� 5:   >   $
��Auto �6O   �� 5;   >   $��* �6O   �� 5<   >   $
��Auto �6O    5>   :   �� 5?   >   $
��Auto �6L   �� 5@   >   $��* �6L   �� 5A   >   $
��Auto �6L   .+�5C   :   �� #��Z 6B   |�.  ��6�   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6  �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5D   :   $!! PART_ColumnHeadersPresenter��6Y   $��1��6~   y�6�   �� *HeadersVisibility+# Z" # Z  �� "   �� 5E   :   $!# PART_ScrollContentPresenter��6Q   #$ z��6v   $��2��6�   $��1��6�   �� 5F   :   $% PART_VerticalScrollBar��6D   $��2��6d   #' z& 6t   $( Vertical=�6�   $��1��6�   #y�z) 6�   #+ z* 6g  , 6  �� *VerticalOffset+$- OneWay=� �� *TemplatedParent+6g  � 5G   :   $��1��6?   $��2��6O    5H   >   �� 5I   B   ��6S   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 5J   B   $��* �6S   .+�5L   >   �� $% PART_HorizontalScrollBar��6H   $��1��6j   #' z. 6z   $( 
Horizontal=�6�   #y�z/ 6�   #+ z0 6e  , 6  �� *HorizontalOffset+$- OneWay=� �� *TemplatedParent+6e  5M   ;   5N   7   5O   3   .��5Q   .   �� # z 6=   5R   +   5S   '   5T   #   5V      1 5W      ]� 5X      2 5Y   "   �� 5Z   &   3 �@��
IsGrouping4 . 6F   �� 5[   &   "3 �@%�IsVirtualizingWhenGrouping4 .  6h   ./�5]   "   ��  � �� .  6R   5^      5`      5a      5   Columns5 5b      0  *System.Windows.Controls.DataGridTextColumn  5d      ,  &System.Windows.Controls.DataGridColumn6   Header$
6 Name��6B   7   Width5  /System.Windows.Controls.DataGridLengthConverter$7 0.25* 6P   1	  +System.Windows.Controls.DataGridBoundColumn8 	  Binding8 6)   �� *Name+6P     5e      $6 Place��6I   $7 0.25* 6X   8 6)   �� *Places.Name+6X     5f      $6 Address��6N   $7 0.25* 6_   8 6)   �� *Places.Addresses+6_     5g      $6 Interest��6L   $7 0.25* 6^   8 6)   �� *Interests.Name+6^   5i      5l      5n      