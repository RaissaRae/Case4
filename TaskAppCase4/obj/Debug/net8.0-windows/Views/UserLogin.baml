   M S B A M L   `   `   `  ����G  CTaskAppCase4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TaskAppCase4.ViewsTaskAppCase4.Views  5   	   "    TaskAppCase4.Views.UserLogin   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TaskAppCase4.Views     5   	     � Title$  	UserLogin��5   	   $	��430��6   $	��330��6(   .��5	      �� $	��300��6   $	��400��5
      
������� �� CornerRadius$ 6��5       J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6      	Direction$	 -90Q�5         RenderingBias$ Quality=�5         ShadowDepth$ 2Q�5         Color$
 Gray��5      ._�5   
   ��  �� Orientation$ Vertical=�6   $��20q�5      .+�5      �� $��Login��6   $��25(�5      $��Center=�5      $	��Top=�5      $
��Bold"�5      	 �� Padding$	 10q�5      � 5      $��Center=�6   
 � RowDefinitions
 5      �� 5      $��* �6$   �� 5       $��* �6$   �� 5!      $��* �6$   �� 5"      $��* �6$   .+�5$      �� $��UserName��6   $��0��5%      $
��0,15q�5&      $��Center=�5'      �� 5(      -   5         ��Name$ UsernameText��5)      $��1��5*      $��1��5+      $	��0,5q�5,      $	��255��5-      $��0,0,0,1q�5.      $��Center=�5/      �� 51      $��Password��6   $��2��52      $
��0,15q�53      $��Center=�54      G� 55      -   5         G�Name$ PasswordText��56      $��3��57      $	��0,5q�58      $	��255��59      $��0,0,0,1q�5:      $��Center=�5;      5<      �� 5=      -   5         ��Name$ LoginBtn��5=      $��Login��5>      
�������
���   �$
��0,75q�5A      $��35��5B      $	��250��5C      ��5E      �� 5F       �� 
TargetType" ��6   .�5G      ��  �� Property � �� �� Value 5H      �� 5I   "    �� 
TargetType" ��62   .R�5J   &   ��  ��Name$ LoginBorder��6-   #��z��6B   $ 16��5K   -   ._�5L   *   �� $��Center=�6;   $��Center=�5M   ;   5N   '    �� Triggers 5O   &   P� 5P   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �5Q   .   ��  �� 
TargetName$ LoginBorder��6[    � �� �#B76D68�� 5R   .   $ LoginBorder��6d    � ��
 �   �5S   +   5U   #   5W      5X      5Z      5\      5]      5^      