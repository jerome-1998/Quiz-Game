   M S B A M L   `   `   `  ����C  ?QuizGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizGameQuizGame  5          QuizGame.AddQuestion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:QuizGame     5        N� Title$  AddQuestion��5	       N� 
Background
 ����� � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 25(�6)   66   �� 5       � ��$ Center=�69   6J   5      5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��2��6   $��Center=�6$   $��30(�6A   $
��Bold"�6O   .��6a   Frage Hinzufügen6s   �� 5   
   -   5        $��tbxQueestion��5   b   $��Frage��6   $��0��6   $��1��6/   $��2��6<   
����� �6�   �� 5    
   -   5        $��tbxResultOne��5    Y   $��0��6   $��2��6"   $��	Antwort 1��6/   
���2͚�6�   �� 5!   
   -   5        $��tbxResultTwo��5!   T   $��1��6   $��2��6"   $��	Antwort 2��6/   
��� ���6�   �� 5"   
   -   5        $��tbxResultThree��5"   T   $��0��6   $��3��6"   $��	Antwort 3��6/   
��� ���6�   �� 5#   
   -   5        $��tbxResultFour��5#   T   $��1��6   $��3��6"   $��	Antwort 4��6/   
��� ���6�   �� 5%   
   -   5        $��	btnCancel��5%   v   $��0��6   $��4��6!   $��Abrechen��6.   $��25(�6A   $��Center=�6O   $	��250��6j   
��� E��6�   �� 5&   
   -   5        $��btnAddQuestion��5&   ~   $��1��6   $��4��6!   $��Frage hinzufügen��6.   $��25(�6I   $��Center=�6W   $	��250��6r   
��� � �6�   5'      5(      