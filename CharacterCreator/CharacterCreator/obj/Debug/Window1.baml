   M S B A M L   `   `   `  ����K  GCharacterCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CharacterCreatorCharacterCreator  5   	       CharacterCreator.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CharacterCreator     5   	     � Title$  Character Sheet��5   	   $	��542��6!   $	��537��6.    � 
ResizeMode$ CanMinimize=�6:   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Character Sheet��6   $��Center=�69   $��0,25,0,0q�6V   $	��Top=�6h   $��37��6�   $	��143��6�   $��18.667(�6�   �� 5   
   -   5        $ label1��5      $��Name:��6    $
��Left=�60   $��	35,75,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ label2��5      $��Class:��6    $
��Left=�61   $��
35,179,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ label3��5      $��Race:��6    $
��Left=�60   $��
35,153,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label4��5      $�� ��6    $
��Left=�6+   $��	84,75,0,0q�6F   $	��Top=�6Y   $	��143��6q   �� 5   
   -   5        $ label5��5      $�� ��6    $
��Left=�6+   $��
91,101,0,0q�6F   $	��Top=�6Z   $	��136��6r   �� 5   
   -   5        $ label6��5      $�� ��6    $
��Left=�6+   $��107,127,0,0q�6F   $	��Top=�6[   $	��120��6s   �� 5   
   -   5        $ label7��5      $��
Archetype:��6    $
��Left=�65   $��
35,205,0,0q�6P   $	��Top=�6d   �� 5   
   -	   5        $ label8��5      $�� ��6    $
��Left=�6+   $��
78,153,0,0q�6F   $	��Top=�6Z   $	��149��6r   �� 5   
   -
   5        $ label9��5      $��Gender:��6    $
��Left=�62   $��
35,101,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ label10��5      $��
Alignment:��6!   $
��Left=�66   $��
35,127,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ label11��5      $�� ��6!   $
��Left=�6,   $��
79,179,0,0q�6G   $	��Top=�6[   $	��148��6s   �� 5   
   -   5        $ label12��5      $�� ��6!   $
��Left=�6,   $��106,205,0,0q�6G   $	��Top=�6\   $	��121��6t   �� 5   
   -   5        $ label13��5      $��Height:��6!   $
��Left=�63   $��
232,75,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ label14��5      $��Weight:��6!   $
��Left=�63   $��232,101,0,0q�6N   $	��Top=�6c   �� 5   
   -   5        $ label15��5      $�� ��6!   $
��Left=�6,   $��
287,75,0,0q�6G   $	��Top=�6[   $	��101��6s   �� 5   
   -   5        $ label16��5      $�� ��6!   $
��Left=�6,   $��287,101,0,0q�6G   $	��Top=�6\   $	��101��6t   �� 5   
   -   5        $ label17��5      $
��STR:��6!   $
��Left=�60   $��
35,307,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label19��5      $
��DEX:��6!   $
��Left=�60   $��
35,333,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label20��5      $
��CON:��6!   $
��Left=�60   $��
35,359,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label21��5      $
��INT:��6!   $
��Left=�60   $��
35,385,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label22��5      $
��WIS:��6!   $
��Left=�60   $��
35,411,0,0q�6K   $	��Top=�6_   �� 5    
   -   5        $ label23��5       $
��CHA:��6!   $
��Left=�60   $��
35,437,0,0q�6K   $	��Top=�6_   �� 5!   
   -   5        $ label24��5!      $��Hit Points:��6!   $
��Left=�67   $��232,179,0,0q�6R   $	��Top=�6g   �� 5"   
   -   5        $ label25��5"      $��Wealth:��6!   $
��Left=�63   $��232,205,0,0q�6N   $	��Top=�6c   �� 5#   
   -   5        $ label32��5#      $�� ��6!   $
��Left=�6,   $��301,179,0,0q�6G   $	��Top=�6\   $��50��6t   �� 5$   
   -   5        $ label33��5$      $�� ��6!   $
��Left=�6,   $��286,205,0,0q�6G   $	��Top=�6\   $��65��6t   �� 5%   
   -   5        $ label18��5%      $��Racial��6!   $
��Left=�62   $��197,260,0,0q�6M   $	��Top=�6b   �� 5&   
   -   5        $ label35��5&      $��Modifiers
��6!   $
��Left=�6?   $��187,277,0,0q�6Z   $	��Top=�6o   �� 5'   
   -   5        $ label38��5'      $�� ��6!   $
��Left=�6,   $��213,307,0,0q�6G   $	��Top=�6\   �� 5(   
   -   5        $ label39��5(      $�� ��6!   $
��Left=�6,   $��213,333,0,0q�6G   $	��Top=�6\   �� 5)   
   -    5        $ label40��5)      $�� ��6!   $
��Left=�6,   $��213,359,0,0q�6G   $	��Top=�6\   �� 5*   
   -!   5        $ label41��5*      $�� ��6!   $
��Left=�6,   $��213,385,0,0q�6G   $	��Top=�6\   �� 5+   
   -"   5        $ label42��5+      $�� ��6!   $
��Left=�6,   $��213,411,0,0q�6G   $	��Top=�6\   �� 5,   
   -#   5        $ label43��5,      $�� ��6!   $
��Left=�6,   $��213,437,0,0q�6G   $	��Top=�6\   �� 5-   
   -$   5        $ label44��5-      $��Final��6!   $
��Left=�61   $��261,260,0,0q�6L   $	��Top=�6a   �� 5.   
   -%   5        $ label45��5.      $��Values��6!   $
��Left=�62   $��256,278,0,0q�6M   $	��Top=�6b   �� 5/   
   -&   5         ��Name$ textBox��5/      $
��Left=�6#    �� TextAlignment$ Center=�6>   $��19��6U   $��259,311,0,0q�6a    �� TextWrapping$
 Wrap=�6v   $	��Top=�6�   $��37��6�    �� 
IsReadOnly . 6�   �� 50   
   -'   5        $ textBox1��50      $
��Left=�6$   $ Center=�6?   $��19��6V   $��259,337,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $��37��6�    . 6�   �� 51   
   -(   5        $ textBox2��51      $
��Left=�6$   $ Center=�6?   $��19��6V   $��259,363,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $��37��6�    . 6�   �� 52   
   -)   5        $ textBox3��52      $
��Left=�6$   $ Center=�6?   $��19��6V   $��259,389,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $��37��6�    . 6�   �� 53   
   -*   5        $ textBox4��53      $
��Left=�6$   $ Center=�6?   $��19��6V   $��259,415,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $��37��6�    . 6�   �� 54   
   -+   5        $ textBox5��54      $
��Left=�6$   $ Center=�6?   $��19��6V   $��259,441,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $��37��6�    . 6�   �� 55   
   -,   5         ��Name$ finalize��55      $��Finalize��6#   $
��Left=�66   $��117,472,0,0q�6Q   $	��Top=�6f   $��74��6~   {�.  6�   �� 56   
   --   5        $ reset��56      $��Reset��6    $
��Left=�60   $��
35,472,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 57   
   -.   5        $ export��57      $��Export��6!   $
��Left=�62   $��415,472,0,0q�6M   $	��Top=�6b   $��75��6z   {�.  6�   �� 58   
   -/   5        $ label26��58      $
��Your��6!   $
��Left=�60   $��
91,263,0,0q�6K   $	��Top=�6_   �� 59   
   -0   5        $ label27��59      $��Stats��6!   $
��Left=�61   $��
91,280,0,0q�6L   $	��Top=�6`   �� 5:   
   -1   5        $ strUp��5:      $	��▲��6    $
��Left=�6,   $��160,311,0,0q�6G   $	��Top=�6\   $��18��6t   $��19��6    J� RenderTransformOrigin$ 1.778,0.526&�6�   6�   �� 5;   
   -2   5        $ strDown��5;      $	��▼��6"   $
��Left=�6.   $��142,311,0,0q�6I   $	��Top=�6^   $��18��6v   $��19��6�   $ 0.889,0.474&�6�   6�   �� 5<   
   -3   5        $ dexUp��5<      $	��▲��6    $
��Left=�6,   $��160,337,0,0q�6G   $	��Top=�6\   $��18��6t   $��19��6   $ 1.778,0.526&�6�   6�   �� 5=   
   -4   5        $ dexDown��5=      $	��▼��6"   $
��Left=�6.   $��142,337,0,0q�6I   $	��Top=�6^   $��18��6v   $��19��6�   $ 0.889,0.474&�6�   6�   �� 5>   
   -5   5        $ conUp��5>      $	��▲��6    $
��Left=�6,   $��160,363,0,0q�6G   $	��Top=�6\   $��18��6t   $��19��6   $ 1.778,0.526&�6�   6�   �� 5?   
   -6   5        $ conDown��5?      $	��▼��6"   $
��Left=�6.   $��142,363,0,0q�6I   $	��Top=�6^   $��18��6v   $��19��6�   $ 0.889,0.474&�6�   6�   �� 5@   
   -7   5        $ intUp��5@      $	��▲��6    $
��Left=�6,   $��160,389,0,0q�6G   $	��Top=�6\   $��18��6t   $��19��6   $ 1.778,0.526&�6�   6�   �� 5A   
   -8   5        $ intDown��5A      $	��▼��6"   $
��Left=�6.   $��142,389,0,0q�6I   $	��Top=�6^   $��18��6v   $��19��6�   $ 0.889,0.474&�6�   6�   �� 5B   
   -9   5        $ wisUp��5B      $	��▲��6    $
��Left=�6,   $��160,415,0,0q�6G   $	��Top=�6\   $��18��6t   $��19��6   $ 1.778,0.526&�6�   6�   �� 5C   
   -:   5        $ wisDown��5C      $	��▼��6"   $
��Left=�6.   $��142,415,0,0q�6I   $	��Top=�6^   $��18��6v   $��19��6�   $ 0.889,0.474&�6�   6�   �� 5D   
   -;   5        $ chaUp��5D      $	��▲��6    $
��Left=�6,   $��160,441,0,0q�6G   $	��Top=�6\   $��18��6t   $��19��6   $ 1.778,0.526&�6�   6�   �� 5E   
   -<   5        $ chaDown��5E      $	��▼��6"   $
��Left=�6.   $��142,441,0,0q�6I   $	��Top=�6^   $��18��6v   $��19��6�   $ 0.889,0.474&�6�   6�   �� 5F   
   -=   5        $ 
strStatBox��5F      $
��Left=�6&   $ Center=�6A   $��19��6X   $��
91,311,0,0q�6d   $
 Wrap=�6x   $	��Top=�6�   $��37��6�    . $��10��6�   6�   �� 5G   
   ->   5        $ 
dexStatBox��5G      $
��Left=�6&   $ Center=�6A   $��19��6X   $��
91,337,0,0q�6d   $
 Wrap=�6x   $	��Top=�6�   $��37��6�    . $��10��6�   6�   �� 5H   
   -?   5        $ 
conStatBox��5H      $
��Left=�6&   $ Center=�6A   $��19��6X   $��
91,363,0,0q�6d   $
 Wrap=�6x   $	��Top=�6�   $��37��6�    . $��10��6�   6�   �� 5I   
   -@   5        $ 
intStatBox��5I      $
��Left=�6&   $ Center=�6A   $��19��6X   $��
91,389,0,0q�6d   $
 Wrap=�6x   $	��Top=�6�   $��37��6�    . $��10��6�   6�   �� 5J   
   -A   5        $ 
wisStatBox��5J      $
��Left=�6&   $ Center=�6A   $��19��6X   $��
91,415,0,0q�6d   $
 Wrap=�6x   $	��Top=�6�   $��37��6�    . $��10��6�   6�   �� 5K   
   -B   5        $ 
chaStatBox��5K      $
��Left=�6&   $ Center=�6A   $��19��6X   $��
91,441,0,0q�6d   $
 Wrap=�6x   $	��Top=�6�   $��37��6�    . $��10��6�   6�   �� 5L   
   -C   5        $ label28��5L      $��Point Pool:��6!   $
��Left=�67   $��344,307,0,0q�6R   $	��Top=�6g   �� 5M   
   -D   5        $ 	pointPool��5M      $
��Left=�6%   $ Center=�6@   $��19��6W   $��415,311,0,0q�6c   $
 Wrap=�6x   $	��Top=�6�   $��37��6�    . $��20��6�   6�   	� 5N   
   -E   5        	 	�Name$	 strRadio��5N      
 	� 	GroupName$
 	statGroup��6(   $
��Left=�6>   $��212,314,0,0q�6Y   $	��Top=�6n   $y�Hidden=�6�   6�   	� 5O   
   -F   5        $	 dexRadio��5O      $
 	statGroup��6(   $
��Left=�6>   $��212,340,0,0q�6Y   $	��Top=�6n   $y�Hidden=�6�   6�   	� 5P   
   -G   5        $	 conRadio��5P      $
 	statGroup��6(   $
��Left=�6>   $��212,366,0,0q�6Y   $	��Top=�6n   $y�Hidden=�6�   6�   	� 5Q   
   -H   5        $	 intRadio��5Q      $
 	statGroup��6(   $
��Left=�6>   $��212,392,0,0q�6Y   $	��Top=�6n   $y�Hidden=�6�   6�   	� 5R   
   -I   5        $	 wisRadio��5R      $
 	statGroup��6(   $
��Left=�6>   $��212,418,0,0q�6Y   $	��Top=�6n   $y�Hidden=�6�   6�   	� 5S   
   -J   5        $	 chaRadio��5S      $
 	statGroup��6(   $
��Left=�6>   $��212,444,0,0q�6Y   $	��Top=�6n   $y�Hidden=�6�   6�   5T      5U      