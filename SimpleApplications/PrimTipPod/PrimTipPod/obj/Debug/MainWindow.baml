   M S B A M L   `   `   `  ����E  APrimTipPod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PrimTipPod
PrimTipPod  5   	       PrimTipPod.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PrimTipPod     5   	     � Title$   Primitivni tipovi podataka��5   	   $	��400��6,   $	��575��69    � WindowStartupLocation$ CenterScreen=�6E    � Cursor$
 Hand��6j   ���	#FFECC5C5��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ White��6   $ 1Q�6)   � 5      $ 	#FF595959��6   $
 0.35Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $
��Wrap=�6B   $ ��Primitivni tipovi podataka��6V   $	��Top=�6x   $��
125,10,0,0q�6�   $��45��6�   $��24(�6�   $
��Bold"�6�   $��Segoe WP Black)�6�   ��6�   Z� �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��	30,55,0,0q�6C   $
��Wrap=�6V   $��Odaberi tip pod.��6j   $	��Top=�6�   $	��140��6�   $
��Bold"�6�   $��16(�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   � 5      $ 	#FF0A0909��6#   $
 0.35Q�65   5      5      �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��
326,60,0,0q�6C   $
��Wrap=�6W   $��Primjer vrijednosti��6k   $	��Top=�6�    J� RenderTransformOrigin$ 
1.02,4.062&�6�   $
��Bold"�6�   $��16(�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   � 5       $ 	#FF0A0909��6#   $
 0.35Q�65   5!      5#      �� 5$   
   -   5        	 ��Name$	 rezultat��5$      $
��Left=�6$   $��23��6?   $��
326,90,0,0q�6K   
 �� TextWrapping$

 Wrap=�6_   $	��Top=�6s   $	��224��6�   ���	#FF0B0B0C$��18(�6�   $
��Bold"�6�   .��6�    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&      .��5'      5(      �� 5)   
   -   5         ��Name$ izlaz��5)      $
��KRAJ��6    $
��Left=�6/   $��420,304,0,0q�6J   $	��Top=�6_   $	��130��6w   $��55��6�   ���	#FF111111$��24(�6�   $
��Bold"�6�   $��Segoe WP Black)�6�   $��Expanded&�6�   $��Oblique$�6�   ���	#FF5E5E636%  �� 5*   
   -   5         ��Name$ tipovi��5*      $
��Left=�6"   $	��150��6=   $��	30,90,0,0q�6J   $	��Top=�6]   $	��195��6u   ���	#FFF7DEA7.@�5+      �� $	��int��6   �� 5,      $
��long��6   �� 5-      $��float��6   �� 5.      $��double��6   �� 5/      $��decimal��6   �� 50      $��string��6   �� 51      $
��char��6   �� 52      $
��bool��6   53      55      56      