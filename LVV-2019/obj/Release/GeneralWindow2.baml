   M S B A M L   `   `   `  ���� C  ?LVV-2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LVV_2019LVV_2019      LVV_2019.GeneralWindow2   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:LVV_2019       � Title$  GeneralWindow2��$	��670��$
��1200�����#c3efdd � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $��1 ��� $��1 ��� $��* ��� $��10 � � RowDefinitions �� $��60 ��� .+��� $��4��$��0�����#31b57f.+��� $��Welcome!�����#31b57f$��LUCIDA SANS UNICODE)�$��35(�$��2��$��Center=�$��Center=�]� $��1��.+��� .+��� $��Center=�$��Center=�._��� .+��� ���#31b57f$��2��$��2q�$	��565��$
��1070��$��95,20,10,10q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  ._��� ���#c3efdd._��� .+��� -    ��Name$ 
forProfile��$	��100q�$y�Hidden=�� -    �Name$ 	forEvents��$y�Visible=� �� $
��Auto ��� .+�� $��45�����#343d46 �� $
��auto ��� �� �� �� �� $
��auto �.+��� 	 �� Orientation$	 
Horizontal=�$��0��.+��� $��Cinema��$��0�����#343d46
�������$��LUCIDA SANS UNICODE)�$��17(�   ButtonStyle3#���   �� $��Theater��$��1�����#343d46
�������$��LUCIDA SANS UNICODE)�$��17(�#���   �� $��Sport��$��2�����#343d46
�������$��LUCIDA SANS UNICODE)�$��17(�#���   �� $��Conserts��$��3�����#343d46
�������$��LUCIDA SANS UNICODE)�$��17(�#���   �� $��Party��$��4�����#343d46
�������$��LUCIDA SANS UNICODE)�$��17(�#���   �� $��Coffee��$��5�����#343d46
�������$��LUCIDA SANS UNICODE)�$��17(�#���   �� -   $ forRec��$	��100q�$	��300��$y�Hidden=��� -   $ 	forRating��$��30q�$	��200��$y�Hidden=��� -   $ forEventList��$	��150q�$��50��$y�Hidden=��� ���#31b57f$��2q�._��� ���#343d46$	��610��$	��200��$��
-130,0,0,0q����� 
 �� 
TargetType"
 �� �� Triggers :�  :� RoutedEvent$ 
MouseEnter��[��� .���� .��t�  �� TargetProperty$ Margin� t� From$ 
-130,0,0,0X�	 t� To$ 0X� g� DecelerationRatio$ .9Q� g� Duration$ 0:0:1D�:� $ 
MouseLeave��[��� .���� .��t� $ Margin�$ 0,0,0,0X�$ 
-130,0,0,0X�$ .9Q�$ 0:0:1D�.+�]� $��Center=�$��Center=�.+��� -   $��Profile�����#343d46$��
-65,0,40,0q�$	��100��$��Center=�  ButtonStyle2#���  �� $+��%\\Mac\Home\Desktop\icons\profile2.png��$��	5,5,-20,5q�$��35��$��35��]� $��Center=�$��Center=�.+��� -   $��Events�����#343d46$��
-65,0,40,0q�$	��100��$��Center=�#���  �� $*��$\\Mac\Home\Desktop\icons\events3.png��$��	5,5,-20,5q�$��35��$��35��]� $��Center=�$��Center=�.+��� -   $��Recommended�����#343d46$��	-40,0,0,0q�$	��100��$��Center=�#���  �� $/��)\\Mac\Home\Desktop\icons\recommended3.png��$��	5,5,-20,5q�$��35��$��35��]� $��Center=�$��Center=�.+��� -	   $��Rating�����#343d46$��
-65,0,40,0q�$	��100��$��Center=�#���  �� $*��$\\Mac\Home\Desktop\icons\rating2.png��$��	5,5,-20,5q�$��35��$��35��]� $��Center=�$��Center=�.+��� -
   $��Events list�����#343d46$��
-45,0,40,0q�$	��100��$��Center=�#���  �� $+��%\\Mac\Home\Desktop\icons\calendar.png��$��	5,5,-20,5q�$��35��$��35��