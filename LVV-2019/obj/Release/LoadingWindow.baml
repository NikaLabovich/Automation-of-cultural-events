   M S B A M L   `   `   `  ���� C  ?LVV-2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LVV_2019LVV_2019      LVV_2019.LoadingWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:LVV_2019       � Title$  LoadingWindow��$	��500��$	��400�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency . ��Z�  � 	Resources    Storyboard2 g� RepeatBehavior �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame	 �� KeyTime
 �� Value��%�  &	        �� $ Forever��.���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse��.g�  $	 0��$
 	#FF009696��  $	 0:0:0.1��$
 	#BF009696��  $	 0:0:0.2��$
 	#7F009696��  $	 0:0:0.3��$
 	#3F009696��  $	 0:0:0.4��$
 	#00009696���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse1��.g�  $	 0��$
 	#BF009696��  $	 0:0:0.1��$
 	#7F009696��  $	 0:0:0.2��$
 	#3F009696��  $	 0:0:0.3��$
 	#00009696��  $	 0:0:0.7��$
 	#FF009696���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse2��.g�  $	 0��$
 	#3F009696��  $	 0:0:0.1��$
 	#00009696��  $	 0:0:0.5��$
 	#FF009696��  $	 0:0:0.6��$
 	#BF009696��  $	 0:0:0.7��$
 	#7F009696���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse3��.g�  $	 0��$
 	#00009696��  $	 0:0:0.3��$
 	#FF009696��  $	 0:0:0.4��$
 	#BF009696��  $	 0:0:0.5��$
 	#7F009696��  $	 0:0:0.6��$
 	#3F009696��  $	 0:0:0.7��$
 	#00009696���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse4��.g�  $	 0��$
 	#00009696��  $	 0:0:0.4��$
 	#FF009696��  $	 0:0:0.5��$
 	#BF009696��  $	 0:0:0.6��$
 	#7F009696��  $	 0:0:0.7��$
 	#3F009696���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse5��.g�  $	 0��$
 	#00009696��  $	 0:0:0.2��$
 	#FF009696��  $	 0:0:0.3��$
 	#BF009696��  $	 0:0:0.4��$
 	#7F009696��  $	 0:0:0.5��$
 	#3F009696��  $	 0:0:0.6��$
 	#00009696���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse6��.g�  $	 0��$
 	#00009696��  $	 0:0:0.1��$
 	#FF009696��  $	 0:0:0.2��$
 	#BF009696��  $	 0:0:0.3��$
 	#7F009696��  $	 0:0:0.4��$
 	#3F009696��  $	 0:0:0.5��$
 	#00009696���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse7��.g�  $	 0:0:0.1��$
 	#3F009696��  $	 0:0:0.2��$
 	#00009696��  $	 0:0:0.6��$
 	#FF009696��  $	 0:0:0.7��$
 	#BF009696�� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� #��[  .��� $	��170��$	��170��.+�A� -    A�Name$ ellipse1��$
��Left=�$��30��$��56.666,20,0,0q�$	��Top=�$��30�����	#7f009696$��2��A� -   $ ellipse��$
��Left=�$��30��$��97.666,20,0,0q�$	��Top=�$��30�����	#7f009696$��2��A� -   $ ellipse5��$
��Left=�$��30��$��126.999,90,0,0q�$	��Top=�$��30�����	#7f009696A� -   $ ellipse2��$
��Left=�$��30��$��26.666,90,0,0q�$	��Top=�$��30�����	#7f009696A� -   $ ellipse6��$
��Left=�$��30��$��126.667,55,0,0q�$	��Top=�$��30�����	#7f009696A� -   $ ellipse7��$
��Left=�$��30��$��26.666,55,0,0q�$	��Top=�$��30�����	#7f009696A� -   $ ellipse4��$
��Left=�$��30��$��55.999,125,0,0q�$	��Top=�$��30�����	#7f009696A� -   $ ellipse3��$
��Left=�$��30��$��96.999,125,0,0q�$	��Top=�$��30�����	#7f009696