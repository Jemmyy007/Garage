   M S B A M L   `   `   `  ����B  >masinki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:masinkimasinki  5   	       masinki.garage11   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:masinki     5   	     � Title$  garage11��5   	   $	��450��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63   .��5	      � ���	#FF68619A � RowDefinitions 5
   
   �� 5      $	��82* �6   �� 5      $
��355* �6    � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      .+�5   
   �� $
��Left=�6   $	��241��6+   $��3,10,0,0q�68   $	��Top=�6J   $	��384��6b   $��/гараж 11.png��6n    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��1��6�   $��1��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.24Q�6$   �� 5      T� 5       T� Y$ -0.602Q�6)   5      5      �� 5   
   $��Площадь: ��6   $
��Left=�6$   $��45,7,0,0q�6?   $	��Top=�6Q   $
��Bold"�6i   $��22(�6{   
�������$��1��6�   $��36��6�   $	��130��6�   �� 5   
   $ ��Гаражных мест:��6   $
��Left=�6)   $��	45,38,0,0q�6D   $	��Top=�6W   $
��Bold"�6o   $��22(�6�   
�������$��1��6�   $��36��6�   $	��195��6�   �� 5   
   $��Стоимость:��6   $
��Left=�6%   $��
45,229,0,0q�6@   $	��Top=�6T   $��22(�6l   $
��Bold"�6z   
�������$ 0.577,0.666&�6�   $��1��6�   $��36��6�   $	��138��6�   �� 5    
   $��Опции:��6   $
��Left=�6!   $��	46,76,0,0q�6<   $	��Top=�6O   $
��Bold"�6g   $��22(�6y   
�������$��1��6�   $��36��6�   $��92��6�   �� 5!   
   $��20 кв. м. (4х5)��6   $
��Left=�6*   $��
173,13,0,0q�6E   $	��Top=�6Y   $	��134��6q   $��16(�6}   $
��Bold"�6�   
�������$��1��6�   $��29��6�   �� 5"   
   $��1��6   $
��Left=�6   $��
240,42,0,0q�67   $	��Top=�6K   $
��Bold"�6c   $��18(�6u   
�������$��1��6�   $��32��6�   $��21��6�   �� 5#   
   $��-Освещение��6   $
��Left=�6%   $��
142,80,0,0q�6@   $	��Top=�6T   $��16(�6l   $	��124��6z   $
��Bold"�6�   
�������$��33��6�   $��1��6�   �� 5$   
   $��-Отопление��6   $
��Left=�6%   $��142,107,0,0q�6@   $	��Top=�6U   $��16(�6m   $
��Bold"�6{   
�������$��1��6�   $��29��6�   $	��108��6�   �� 5%   
   $��-Сигнализация��6   $
��Left=�6(   $��142,136,0,0q�6C   $	��Top=�6X   $
��Bold"�6p   $��16(�6�   
�������$��1��6�   $��29��6�   $	��136��6�   �� 5&   
   -   5         ��Name$ 
lblPrice11��5&      $��Label��6$   $
��Left=�64   $��186,229,0,0q�6O   $	��Top=�6d   $��49��6|   $	��204��6�   $��22(�6�   $
��Bold"�6�   ���	#FF00FF31$��1��6�   �� 5'   
   ���	#FFD07777$
��Left=�6%   $��35��6@   $��	24,18,0,0q�6L   ���	#FFD07777$	��Top=�6r   $��38��6�   �� 5(   
   -   5        $�� ��5(      $
��Left=�6   $��	24,18,0,0q�67   $	��Top=�6J   $��35��6b   $��38��6n   $
��Bold"�6�   
�������$��14(�6�   $��0��6�   $��0��6�    �� IsCancel . ��5)      �� 5*      	 �� ImageSource$	 icons8-назад-48.png��6   5,      �� 5-   
   $
��Left=�6   $��59��6+   $��	266,0,0,0q�67   $	��Top=�6J   $	��126��6b   $��1��6n   �� 5.   
   $��
281,0,0,29q�6   $��
Image2.png��6$   $
��Fill=�68   $��1��6G   �� 5/   
   $��ver 0.1��6   $
��Left=�6"   $��331,296,0,0q�6=   $	��Top=�6R   $
��Bold"�6j   
�������$��23��6�   $��1��6�   $��1��6�   $��48��6�   �� 50   
   -   5        $��
Карта��50      $
��Left=�6!   $��228,256,0,0q�6<   $	��Top=�6Q   $��35��6i   $��76��6u   ���	#FFD07777$��18(�6�   
�������$
��Bold"�6�   $��1��6�   $��1��6�   �� 51   
   -   5        $��1��51      $��Чертеж��6!   $
��Left=�62   $��
73,256,0,0q�6M   $	��Top=�6a   $��34��6y   $��76��6�   $��1��6�   $
��Bold"�6�   $��18(�6�   
����������	#FFD077776�   �� 52   
   -   5        $��Оформить��52      $
��Left=�6$   $��127,278,0,0q�6?   $	��Top=�6T   $��32��6l   $	��105��6x   ���	#FFD07777
�������$
��Bold"�6�   $��18(�6�   $��1��6�   6�   �� 53   
   -   5        $ lblStatus11��53      $��Label��6%   $��Center=�65   $��	0,177,0,0q�6R   $��1��6e   $	��Top=�6r   $��36��6�   $	��147��6�   $
��Bold"�6�   $��20(�6�   ���	#FF00FF316�   55      56      