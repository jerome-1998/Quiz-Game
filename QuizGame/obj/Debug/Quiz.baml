   M S B A M L   `   `   `  ����C  ?QuizGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizGameQuizGame  5          QuizGame.Quiz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:QuizGame     5      -   5          N� Title$
  Quiz��5	       N� 
Background
 ����� � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   6:   �� 5       � ��$ Center=�64   6E   �� 5       � ��$ 25(�6)   66   5      5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      $	��200 �6   6+   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   .+�5   
   �� -   5        $��lblGamePoints��5   h   $��Center=�6   $��Center=�6-   $��30(�6H   $
��Bold"�6V   6   �� 5    
   -   5        $��spJoker��5    X   $��1��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?    5!      ��%�   '��       �� 5"      " ��6   .�5#      ��  � ��$ 	30,5,30,5q�6/   6C   �� 5$       � ��$	 150��6.   6<   �� 5%       � ��
 � �|�6G   �� 5&       � ��$
 Bold"�63   6B   5'      5(      .+�5)      �� -   5        $��btnJokerFiftyFifty��5)      $��50/50��6/   6X   �� 5*      -   5        $��btnJokerTelephone��5*      $��Telefonjoker��6.   6^   �� 5+      -   5        $��btnJokerCrowd��5+      $��Publikumsjoker��6*   6\   5,      �� 5.   
   -   5        $��lblQuestion��5.      $��2��6#   62   �� 50   
   -   5        $��	spResults��50   ?   $��3��6   $��Center=�6"    51      ��%�   '��       �� 52      " ��6   .�53      ��  � ��$ 0,5,0,5q�6/   6A   �� 54       � ��$	 150��6.   6<   �� 55       � ��
 � ���6D   �� 56       � ��$
 Bold"�63   6B   57      58      59      �� 5;   
   -	   5        $��btnExitGame��5;   {   $��4��6   $��Center=�6   $	��150��6;   $
��Bold"�6G   
���  ��$��0,5,0,5q�6j   $��Spiel beenden��6�   6�   5<      5=      