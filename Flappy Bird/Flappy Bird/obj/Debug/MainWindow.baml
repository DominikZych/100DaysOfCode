   M S B A M L   `   `   `  ����F  BFlappy Bird, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Flappy_BirdFlappy_Bird  5   	       Flappy_Bird.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Flappy_Bird     5   	     � Title$  Flappy Bird��5   	   $	��490��6   $	��525��6*   .��5	      �� -   5        $��MyCanvas��5	      |�. 
����ح�.+�5   
   �� $	��144��6   $	��200��6   $��images/clouds.png��6)    �� Left$ 52��6D   
 �� Top$	 128��6U   
 � Tag$ cloud��6f   �� 5   
   $	��144��6   $	��200��6   $��images/clouds.png��6)   $	 252��6D   $	 128��6V   $ cloud��6g    J� RenderTransformOrigin$ 0.5,0.5&�6s   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 180.161Q�6&   T� 5      5      5      �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $ 70��6G   $	 196��6X   $
 obs1��6i   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $ 70��6D   $
 -324��6U   $
 obs1��6g   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $	 252��6G   $	 367��6Y   $
 obs2��6j   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $	 252��6D   $
 -182��6V   $
 obs2��6h   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $	 441��6G   $	 346��6Y   $
 obs3��6j   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $	 441��6D   $
 -182��6V   $
 obs3��6h   �� 5"   
   -   5        $��
flappyBird��5"      $��36��6"   $��50��6.   $��images/flappyBird.png��69   $
��Fill=�6X   $ 70��6g   $	 114��6x   �� 5%   
   -   5        $��txtScore��5%      $��22(�6    $��	ExtraBold"�6.   $��Score: 0��6E   5&      5'      