   M S B A M L   `   `   `  ����>  :Reg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:RegReg  5   	       Reg.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Reg     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��950��6)    � 	Resources 5
         listTemplate �� Orientation �� Path��%�  &	        �� 5   
   .R�5      �� $ Vertical=�6   .+�5      �� 
���   �$��1q�6-   $��0 0 0 10q�6A   ._�5      ]� $��5q�6    $
��1000��6+   .+�5      �� 
���   �$��1q�65   $��0 0 10 0q�6I   $	��100��6[   ._�5      �� $��40��6&   $��40��61   $
��Left=�6c   ��6=   �� $ ProductPhoto�6c   5      �� 5      
���   �$��1q�66   $��0 0 10 0q�6J   ._�5      �� $	��600��6*   .+�5   "   ]� .+�5   &   �� $��Heavy"�60   $��Comic Sant MS)�6C   $��16(�6_   $
��auto��6m   $��Center=�6�   $��Center=�6�   ��6z   �� $ ProductName�6�   5   #   ]� 5   "   .+�5   &   �� $��Regular"�6,   $��Comic Sant MS)�6A   $��Center=�6\   $
��Left=�6w   .��6�   Описание:6�   �� 5   &   $��Regular"�60   $��Comic Sant MS)�6E   $��Center=�6`   $
��Left=�6{   $��16(�6�   $
��auto��6�   ��6�   �� $ ProductDescription�5   #   ]� 5   "   .+�5   &   �� $��Regular"�6,   $��Comic Sant MS)�6A   $��Center=�6\   $
��Left=�6w   .��6�   Производитель:6�   �� 5    &   $��Regular"�60   $��Comic Sant MS)�6E   $��0 0.8 100 0q�6a   $��16(�6w   $
��Left=�6�   ��6�   �� $ ProductManufacturer�6�   5!   #   ]� 5"   "   .+�5#   &   �� $��Regular"�6,   $��Comic Sant MS)�6A   $��Center=�6\   $
��Left=�6w   .��6�   	Цена:6�   �� 5$   &   $��Regular"�60   $��Comic Sant MS)�6E   $��0 0.8 100 0q�6a   $��16(�6v   $
��Left=�6�   ��6�   �� $ ProductCost�6�   5%   #   5&      5'      �� 5*      
���   �$��1q�65   $��0 0 0 0q�6I   ._�5,      ]� .+�5-   "   ]� .+�5.   &   �� $��16(�6,   $��Right=�6:   $��Center=�6V   $��Regular"�6q   $��Comic Sant MS)�6�   .��6�   Статус:6�   �� 5/   &   $��16(�61   $��Center=�6?   $
��Left=�6   $��Regular"�6�   $��Comic Sant MS)�6�   ��6[   �� $ ProductStatus�6�   50   #   51      52      54      56      57      5:      5;      .��5<      �  � ColumnDefinitions 5G   
   �� 5H      $
��auto �6   �� 5I      $
��auto �6   �� 5J      $
��auto �6   .+�5M   
   ]� -   5         ]�Name$ DocFunct��5M      .+�5O      �� -   5         ��Name$ AddTov��5O   ,   ���	#FF76E383$��Добавить��6<   $	��Top=�6O   $��Center=�6g   $��	200 0 0 0q�6�   $��30��6�   $	��100��6�   6�   �� 5P      -   5        $ RedTov��5P   ,   ���	#FF76E383$ ��Редактировать��6<   $	��Top=�6T   $��Center=�6l   $��40 0 0 0q�6�   $��30��6�   $	��100��6�   6�   �� 5Q      -   5        $ 	DeleteTov��5Q   ,   ���	#FF76E383$��Удалить��6?   $	��top=�6Q   $��Center=�6i   $��70,0,0,0q�6�   $��30��6�   $	��100��6�   6�   �� 5R      -   5         ��Name$ 	FIOSlabel��5R      $��0 0 90 0q�6)   $
��auto��6;   $��30��6H   $	��Top=�6T   $��Right=�6l   .��6�   
Гость6�   5U      �� 5V   
   -   5        $ Closes��5V   (   ���	#FF76E383$��
Выход��68   $	��Top=�6H   $��Right=�6`   $��10 0 0 0q�6}   $��30��6�   $��50��6�   6�   �� 5Y   
   -   5         ��Name$ 
phonesList��5Y      #��[  6&   $��Disabled=�5[      $��Visible=�5\      $
��auto��6E   $	��900��6S   $��	20 40 0 0q�6_   ��5]      �� 5^      .R�5_      � 5`      5c      5e      5f      