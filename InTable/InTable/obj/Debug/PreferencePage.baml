   M S B A M L   `   `   `  ����  InTable    InTable.PreferencePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  PreferencePage��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ 	DataPanel��5      $��2��6(   $��2��68   .+�5      �  5      �� 5      $��* �6'   �� 5      $
��Auto �6'   �� 5      $��* �6'   .+�5!      �� $��1��6   $
��Wrap=�6M   ��6,   �� *LongDescription+6M   5"      �� 5#       �� Orientation$ 
Horizontal=�6   .+�5$      �� -   5        $ SliderPanel��5$      $ 
Horizontal=�62   .+�5%      �� ��6    �� *
LeftOption+�� 5&      -   5        $��ActualSlider��5&      $��10, 0, 0, 0q�62   $	��180��5'       �� Orientation$ 
Horizontal=�6%   $
��Left=�6>    � Value$ 5Q�5(       � Minimum$ 1Q�6#    � Maximum$ 10Q�6/   	 � SmallChange$	 1Q�5)      
 � LargeChange$
 2Q�6)    �� TickPlacement$ BottomRight=�5*       �� TickFrequency$ 1Q�65   5+      �� 5,      ��6    �� *RightOption+5-      �� 5/      -   5        $ RadioButtonsPanel��5/      $ 
Horizontal=�68   .+�50      	� -   5         	�Name$ FalseRadioButton��50   "    	� 	GroupName$ homies��6<   $��
0,10,10,10q�6n   ��6O   �� *
LeftOption+6n   	� 51      -   5        $ TrueRadioButton��51   "   $ homies��6;   $��10q�6n   ��6N   �� *RightOption+6n   52      54      � 55       56      �� 57      $
��Auto �6'   �� 58      $��* �6'   �� 59      $
��Auto �6'   .+�5;      �� -   5        $��Previous��5;      $��0��6,      BaseButtonStyle#��[  6<   $
��0,10q�6�   �� 5<      -   5        $
��Next��5<      $��2��6(   #��[  68   $
��0,10q�6y   5=      5>      5?      5@      