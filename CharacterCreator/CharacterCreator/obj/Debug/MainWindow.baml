   M S B A M L   `   `   `  ����K  GCharacterCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CharacterCreatorCharacterCreator  5   	   !    CharacterCreator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CharacterCreator     5   	   nameCCMainWindow     5   	     � Title$  Character Creator��5	   	   $��433.671��6#   $��683.951��64    � 
ResizeMode$ CanMinimize=�6D   .��5
      � .+�5   
   �� -   5         ��Name$ raceBox��5      $
��Left=�6$   $��
48,194,0,0q�6?   $	��Top=�6S   $	��120��6k   6w   �� 5   
   -   5        $ classBox��5      $
��Left=�6%   $��318,194,0,0q�6@   $	��Top=�6U   $	��120��6m   6y   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $	��125��6>   $��
16,222,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��251��6�   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $	��125��6?   $��286,222,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��342��6�   	� 5   
   -   5         	�Name$ radioButton��5      $
��Male��6+   $
��Left=�6:   $��173,120,0,0q�6U   $	��Top=�6j    	� 	GroupName$ Gender��6�   	� 5   
   -   5        $ radioButton1��5      $��Female��6,   $
��Left=�6=   $��173,135,0,0q�6X   $	��Top=�6m   $ Gender��6�   �� 5   
   -   5         ��Name$ button��5      $��Generate��6!   $
��Left=�64   $��553,352,0,0q�6O   $	��Top=�6d   $��75��6|   {�.  6�   �� 5   
   -   5         ��Name$ label��5      $��	Gender:
��6   $
��Left=�6;   $��
164,95,0,0q�6V   $	��Top=�6j   $��25��6�   $��60��6�   �� 5   
   -	   5        $ label1��5      $��Race:��6    $
��Left=�60   $��
10,190,0,0q�6K   $	��Top=�6_   �� 5   
   -
   5        $ label2��5      $��Class:��6    $
��Left=�61   $��279,190,0,0q�6L   $	��Top=�6a   	 J� RenderTransformOrigin$	 0.272,-0.115&�6y   �� 5   
   -   5        
 ��Name$
 image��5      $��pathfindercover.jpeg��6   $
��Left=�6=   $	��175��6X   $��	10,10,0,0q�6e   $	��Top=�6x   $	��132��6�   �� 5   
   -   5        $ label3��5      $"��Pathfinder Character Creator��6    $
��Left=�6G   $��
158,10,0,0q�6b   $	��Top=�6v   $	��379��6�   $��49��6�   $��26.667(�6�   �� 5   
   -   5        $ label4��5      $��Label��6    $
��Left=�60   $	��Top=�6K   �� 5   
   -   5        $ label5��5      $��
Alignment:��6    $
��Left=�65   $��
271,94,0,0q�6P   $	��Top=�6d   	� 5   
   -   5        $ radioButton2��5      $��Lawful��6,   $ Align1��6=   $
��Left=�6P   $��285,120,0,0q�6k   $	��Top=�6�   6�   	� 5   
   -   5        $ radioButton3��5      $��Neutral��6,   $ Align1��6>   $
��Left=�6Q   $��285,135,0,0q�6l   $	��Top=�6�   	� 5   
   -   5        $ radioButton4��5      $��Chaotic��6,   $ Align1��6>   $
��Left=�6Q   $��285,150,0,0q�6l   $	��Top=�6�   6�   	� 5   
   -   5        $ radioButton5��5      $
��Good��6,   $ Align2��6;   $
��Left=�6N   $��380,120,0,0q�6i   $	��Top=�6~   6�   	� 5   
   -   5        $ radioButton6��5      $��Neutral��6,   $ Align2��6>   $
��Left=�6Q   $��380,135,0,0q�6l   $	��Top=�6�   	� 5   
   -   5        $ radioButton7��5      $
��Evil��6,   $ Align2��6;   $
��Left=�6N   $��380,150,0,0q�6i   $	��Top=�6~   6�   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��23��6?   $��
208,67,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��225��6�   �� 5    
   -   5        $ label6��5       $��Name:��6    $
��Left=�60   $��
164,64,0,0q�6K   $	��Top=�6_   �� 5!   
   -   5        $ label7��5!      $��
Archetype:��6    $
��Left=�65   $��443,190,0,0q�6P   $	��Top=�6e   $��69��6}   �� 5"   
   -   5        $ archBox��5"      $
��Left=�6$   $��508,194,0,0q�6?   $	��Top=�6T   $	��120��6l   {�.  6x   �� 5#   
   -   5        $ textBox3��5#      $
��Left=�6$   $	��100��6?   $��
459,85,0,0q�6L   $
 Wrap=�6`   $����*Note: Some classes cannot have certain alignments, or must be one specific alignment. Pay attention to if your alignment changes when you select your class!��6t   $	��Top=�6  $	��169��61  $��0q�6=  �� 5$   
   -   5         ��Name$ checkBox��5$      $��Finalize��6%   $
��Left=�68   $��478,355,0,0q�6S   $	��Top=�6h   6�   5%      5&      