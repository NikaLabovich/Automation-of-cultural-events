   M S B A M L   `   `   `  ����C  ?LVV-2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LVV_2019LVV_2019  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 6:   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBox.Static.Background  �� EndPoint �� 
StartPoint � Color � Offset  ComboBox.Static.Border �� Color ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border  ComboBox.MouseOver.Glyph ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border *	 &ComboBox.MouseOver.Editable.Background &
 "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Glyph  ComboBox.Pressed.Background  ComboBox.Pressed.Border ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border  ComboBox.Disabled.Glyph   ComboBox.Disabled.Background  ComboBox.Disabled.Border ) %ComboBox.Disabled.Editable.Background % !ComboBox.Disabled.Editable.Border 0 ,ComboBox.Disabled.Editable.Button.Background , (ComboBox.Disabled.Editable.Button.Border  ComboBox.Static.Glyph  ComboBoxToggleButton �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 J� SnapsToDevicePixels F�Name ��Name J� Opacity �� Triggers P� Property P� Value �� 
TargetName N� EnterActions �� TargetProperty �� 
TargetName	 W� To g� Duration N� ExitActions ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value  ComboBoxTemplate �Name � ColumnDefinitions �Name  � AllowsTransparency! �� Mode5   /Microsoft.Windows.Themes.SystemDropShadowChrome"   Name#    Color$ �� MaxDropDownHeight% �� ElementName& ��Name' �� ClearTypeHint( ��Name) ��Name-  'System.Windows.Input.KeyboardNavigation*   DirectionalNavigation+ d�Name, d� 	IsChecked- ��Name. �� SelectionBoxItemTemplate/ �� SelectionBoxItem#0 �� SelectionBoxItemStringFormat1 �� ContentStringFormat2 J� IsHitTestVisible3 P� 
SourceName4 ]� 
Conditions5 �� Property  TextBox.Static.Background  ComboBoxEditableTextBox   ComboBoxEditableTemplate6 ��Name7 �� 
IsReadOnly ! ComboBoxStyle1 " FocusVisual8 �� Triggers�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5       localclr-namespace:LVV_2019  5      VThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  6:   %!/  &	        &	 �     &	 �     &	 �     &	 �     &	 $    &	 I    &	 l    &	     &		 '    &	
 H    &	 k    &	     &	 &    &	 I    &	 �    &	     &	 %    &	 H    &	 �    &	     &	 &    &	 G    &	 j    &	 �    &	 �    &	 �    &	 �    &	     7   7  7  7  7  7  7  7  7  7  7 	 7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 m    7  &	 �    &	     &	  +!    7  7  7  &	! �*    7 " 7   7  7  7   �� 5      $	  0,1&�6=   $	 0,0&�6L   .��5   
   � $ #545d6a��6   $	 0.0Q�6'   � 5   
   $ #4c5561��6   $	 1.0Q�6'   5      �� 5	      $ 	#FFACACAC��65   �� 5
      $ #545d6a��6B   �� 5      $ 	#FFABADB3��6>   �� 5      $ Transparent��6I   �� 5      $ Transparent��6E   �� 5      $ 	#FF000000��67   �� 5      $	  0,1&�6@   $	 0,0&�6O   .��5   
   � $ #545d6a��6   $	 0.0Q�6'   � 5   
   $ #4c5561��6   $	 1.0Q�6'   5      �� 5      $ 	#FF7EB4EA��68   �� 5      $ #545d6a��6E   �� 5      $ 	#FF7EB4EA��6A   �� 5      $	  0,1&�6P   $	 0,0&�6_   .��5   
   � $ #545d6a��6   $	 0.0Q�6'   � 5   
   $ #4c5561��6   $	 1.0Q�6'   5      �� 5      $ 	#FF7EB4EA��6H   �� 5      $ 	#FF000000��65   �� 5      $	  0,1&�6>   $	 0,0&�6M   .��5   
   � $ #545d6a��6   $	 0.0Q�6'   � 5   
   $ #4c5561��6   $	 1.0Q�6'   5      �� 5       $ 	#FF569DE5��66   �� 5!      $ #545d6a��6C   �� 5"      $ 	#FF569DE5��6?   �� 5#      $	  0,1&�6N   $	 0,0&�6]   .��5$   
   � $ #545d6a��6   $	 0.0Q�6'   � 5%   
   $ #4c5561��6   $	 1.0Q�6'   5&      �� 5'      $ 	#FF569DE5��6F   �� 5(      $ 	#FFBFBFBF��66   �� 5)      $ #545d6a��6;   �� 5*      $ 	#FFD9D9D9��67   �� 5+      $ #545d6a��6D   �� 5,      $ 	#FFBFBFBF��6@   �� 5-      $ Transparent��6K   �� 5.      $ Transparent��6G   �� 5/      $ 	#FF606060��64   �� 50      " d�6)   .�51   
   ��  �@�OverridesDefaultStyle . 62   �� 52   
    � �� .  6&   �� 53   
    � |� .  6&   �� 54   
    �@��	ClickMode$ Press=�6&   �� 55   
    � �� 56      �� 57      " d�6"   .R�58      � .+�59      �� $	 templateRoot��6!   
 . 8��  #��z��6�   8�� ._�5:      �� $	 splitBorder��6%   #��� r�6:   
 . $��0q�6�   $��Right=�6�   $��1q�6�   
������ ._�5;   "   F� $ arrow��6'   $��Center=�66   $��0q�6Q   $��Center=�6\   8�� F����        ���( ��( јaQ     јaQ P����̰( � �    P����        6�   5<      5=      �� 5>      $
 Rect��6$   ���#38ae84$ 0Q�6D   5?       5@      P� 5A       � {� .  . �5B      �� $ templateRoot��68    �@J�Opacity$
 0.56Q�6R   5C      P� 5D       �@J�IsMouseOver .  5E      �� 5F   "   .��5G   &   �� .��5H   *   W� $ Opacity�6:   $
 Rect��6^   $ 2X�6{   $ 	0:0:0.300D�6�   5I   +   5J   '   5K   #    5M      �� 5N   "   .��5O   &   �� .��5P   *   W� $ Opacity�6:   $
 Rect��6^   $ 0X�6{   $ 	0:0:0.300D�6�   5Q   +   5R   '   5S   #   5U      ^� 5V       5W      �� 5X   "    6,   �� *
IsEditable+ �� " �� true6�   �� 5Y   "    6,   �� *IsMouseOver+ �� *Self+	 false6r   �� 5Z   "    6,   �� *	IsPressed+ �� *Self+	 false6p   �� 5[   "    6,   �� *	IsEnabled+ �� *Self+ true6p   .0�5]      �� $ templateRoot��6;   8   � ��6U   �� 5^      $ templateRoot��6<   8   � ��6V   �� 5_      $ splitBorder��6;   8   � ��6T   �� 5`      $ splitBorder��6<   8   � ��6U   5a      P� 5b       �@J�IsMouseOver . . �5c      �� $ arrow��65   8   � ��6H   5d      ^� 5e       5f      �� 5g   "    6,   �� *IsMouseOver+ �� *Self+ true6r   �� 5h   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5j      �� $ templateRoot��6;   8   � ��6U   �� 5k      $ templateRoot��6<   8 	  � ��6V   5l      ^� 5m       5n      �� 5o   "    6,   �� *IsMouseOver+ �� *Self+ true6r   �� 5p   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5r      �� $ templateRoot��6;   8 
  � ��6U   �� 5s      $ templateRoot��6<   8   � ��6V   �� 5t      $ splitBorder��6;   8   � ��6T   �� 5u      $ splitBorder��6<   8   � ��6U   5v      P� 5w       � �� . . �5x      �� $ arrow��65   8   � ��6H   5y      ^� 5z       5{      �� 5|   "    6,   �� *	IsPressed+ �� *Self+ true6p   �� 5}   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsPressed+ �� *Self+ true6p   �� 5�   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5�      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   �� 5�      $ splitBorder��6;   8   � ��6T   �� 5�      $ splitBorder��6<   8   � ��6U   5�      P� 5�       � {� .  . �5�      �� $ arrow��65   8   � ��6H   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsEnabled+ �� *Self+	 false6p   �� 5�   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5�      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsEnabled+ �� *Self+	 false6p   �� 5�   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5�      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   �� 5�      $ splitBorder��6;   8   � ��6T   �� 5�      $ splitBorder��6<   8   � ��6U   5�      5�      5�      5�      �� 5�      " ��6/   .R�5�   
   � $ templateRoot��6   
 .  5�      �� 5�      $��* �6#   �� 5�      #��� r�6#   $��0 �6v   .+�5�      � $ 
PART_Popup��6     . $��2��6B   $��1q�6�   #��� .�6�   $��Bottom=�6  ��6V   �� *IsDropDownOpen+$! TwoWay=� �� *TemplatedParent+.��5�         $" shadow��60   $# Transparent��6@   #��z$ 6T   ��6�   �� *ActualWidth+$% templateRoot��._�5�      �� $	 dropDownBorder��6   #��� ��65   $��1q�6�   #��� ��6�   ._�5�      �� $& DropDownScrollViewer��6'   .��5�      � $
 grid��6#   $' Enabled=�61   .+�5�   "   �� $( canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�5�   &   �� $ 
opaqueRect��60   ��6D   �� *
Background+$% dropDownBorder����6|   �� *ActualHeight+$% dropDownBorder����6�   �� *ActualWidth+$% dropDownBorder��5�   #   �� 5�   "   $) ItemsPresenter��61   $* 	Contained=�6I   #
 z
 6~   5�      5�      5�      5�      5�      d� 5�      $+ toggleButton��6   #��z��61   #��z��6]   #��z��6�   $��2��6�   8��  , 6�   �� *IsDropDownOpen+$! TwoWay=� �� *TemplatedParent+62  �� 5�      $- contentPresenter��6   #��z. 69   #��z��6v   #��z/ 6�   #1 z0 6�   #��z��6)  2 .  #��z��6�  #
 z
 6�  #��z��6�  5�       5�   
   P� 5�      $3 
PART_Popup��6/    �@�HasDropShadow . . �5�      �� $ shadow��6+    � ��$ 0,0,5,5q�6?   �� 5�      $ shadow��6*    �@  Color$ 	#71000000��6>   5�      P� 5�       �@��HasItems .  . �5�      �� $ dropDownBorder��6+    � ��$ 95��6G   5�      ]� 5�      4 5�      �� 5�      5 �@��
IsGrouping . 66   �� 5�      "5 �@%�IsVirtualizingWhenGrouping .  6X   ./�5�      ��  � �� .  6B   5�      P� 5�      $3 DropDownScrollViewer��6?    � �� .  . �5�      �� $ 
opaqueRect��6/    6G   �� *VerticalOffset+$% DropDownScrollViewer�� �@��Top�� 5�      $ 
opaqueRect��60    6H   �� *HorizontalOffset+$% DropDownScrollViewer�� �@��Left5�      5�      �� 5�      $ #545d6a��68   �� 5�      " ��6,   .�5�   
   ��  �@�OverridesDefaultStyle . 62   �� 5�   
    �@J�	AllowDrop . 6&   �� 5�   
    � ��$ 0��6%   �� 5�   
    � ��$ 0��6&   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    �@��PanningMode$ VerticalFirst=�65   �� 5�   
    �@��IsFlicksEnabled .  63   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $& PART_ContentHost��6#   
������ |�.  $��Hidden=�6h   $��Hidden=�6�   5�      5�      5�      �� 5�      " ��67   .R�5�   
   � $ templateRoot��6   
 .  5�      �� 5�      $��* �6#   �� 5�      #��� r�6#   $��0 �6v   .+�5�      � $ 
PART_Popup��6     . $��2��6B   #��� .�6�   $��Bottom=�6  ��6V   �� *IsDropDownOpen+ �� *TemplatedParent+.��5�         $" shadow��60   $# Transparent��6@   #��z$ 6T   ��6�   �� *ActualWidth+$% templateRoot��._�5�      �� $	 dropDownBorder��6   #��� ��65   $��1q�6�   #��� ��6�   ._�5�      �� $& DropDownScrollViewer��6'   .��5�      � $
 grid��6#   $' Enabled=�61   .+�5�   "   �� $( canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�5�   &   �� $ 
opaqueRect��60   ��6D   �� *
Background+$% dropDownBorder����6|   �� *ActualHeight+$% dropDownBorder����6�   �� *ActualWidth+$% dropDownBorder��5�   #   �� 5�   "   $) ItemsPresenter��61   $* 	Contained=�6I   #
 z
 6~   5�      5�      5�      5�      5�      d� 5�      $+ toggleButton��6   #��z��61   #��z��6]   #��z��6�   $��2��6�   8��  , 6�   �� *IsDropDownOpen+$! TwoWay=� �� *TemplatedParent+62  �� 5�      $	 border��6   8�� #��z��6]   ._�5�      �� $6 PART_EditableTextBox��6   #��z��68   #��z��6�   8�� #��z��6)  7 6�   �� *
IsReadOnly+ �� *TemplatedParent+6)  5�      5�       5�   
   P� 5�       � {� .  . �5�      �� $ border��6,    �@J�Opacity$
 0.56Q�6@   5�      P� 5       �@J�IsKeyboardFocusWithin . . �5     ��  � ��
 �   �6/   5     P� 5     $3 
PART_Popup��6/    �@�HasDropShadow . . �5     �� $ shadow��6+    � ��$ 0,0,5,5q�6?   �� 5     $ shadow��6*    �@  Color$ 	#71000000��6>   5     P� 5      �@��HasItems .  . �5     �� $ dropDownBorder��6+    � ��$ 95��6G   5	     ]� 5
     4 5     �� 5     5 �@��
IsGrouping . 66   �� 5     "5 �@%�IsVirtualizingWhenGrouping .  6X   ./�5     ��  � �� .  6B   5     P� 5     $3 DropDownScrollViewer��6?    � �� .  . �5     �� $ 
opaqueRect��6/    6G   �� *VerticalOffset+$% DropDownScrollViewer�� �@��Top�� 5     $ 
opaqueRect��60    6H   �� *HorizontalOffset+$% DropDownScrollViewer�� �@��Left5     5     �� 5     " ��6#   .�5  
   ��  �@�FocusVisualStyle8   6-   �� 5  
    � ��8  6'   �� 5  
    � ��8  6(   �� 5  
    � ��# � ��6'   �� 5  
    � ��$ 1q�6,   �� 5  
    � ��$
 Auto=�6G   �� 5  
    � ��$
 Auto=�6E   �� 5  
    � ��$ 6,3,5,3q�6$   �� 5   
    � �� . 6:   �� 5!  
    �@��PanningMode$
 Both=�65   �� 5"  
    �@��IsFlicksEnabled .  63   �� 5#  
    � ��8  6%   8 5$  
   P� 5%      �@��
IsEditable . . �5&     ��  � �� .  6.   �� 5'      � ��$ 2q�6,   �� 5(      � ��8  6-   5)     5+     5-     