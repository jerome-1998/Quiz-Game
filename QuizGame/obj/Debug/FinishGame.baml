   M S B A M L   `   `   `  ����C  ?QuizGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizGameQuizGame  5          QuizGame.FinishGame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:QuizGame     5      -   5          N� Title$  
FinishGame��5	       N� 
Background 5
      �� 5   
    �� Color$
 Gray��6   6)    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� �    �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   6:   �� 5       � ��$ Center=�64   6E   �� 5       � ��$ 30(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   6:   �� 5       � ��$ Center=�69   6J   �� 5       � ��$ 20(�6)   66   �� 5       � ��$	 Top=�62   6@   �� 5       � ��$	 300��6&   64   �� 5       � ��
 � ���6<   5      �� 5   
   " ��6   .�5      ��  � ��$	 Top=�62   6@   �� 5       � ��$	 300��6&   64   �� 5       � ��$ 20(�6)   66   �� 5       � ��$
 bold"�6+   6:   �� 5        � ��
 �/���6A   5!      5"      .��5$      �  � RowDefinitions 5%   
   �� 5&      6   �� 5'      6   �� 5(      6   �� 5)      6    � ColumnDefinitions 5+   
   �� 5,      6!   �� 5-      6!   .+�50   
   �� -   5        $��lblPlayerPoints��50      $��2��6'   6=   �� 51   
   -   5        $��lblPlayerName��51      $��1��6%   $��2��62   $��
Dein Name?��6F   $��Center=�6[   6x   �� 52   
   -   5        $��tbxName��52   3   $��2��6   $��2��6   6D   �� 53   
   -   5        $��btnSendToDB��53   O   $��3��6   $��1��6   $��In Highscore eintragen��6.   6~   �� 54   
   -   5        $��	btnCancel��54   B   $��3��6   $��0��6   $��	Abbrechen��6.   
��� ���6�   55      56      