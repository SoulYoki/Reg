   M S B A M L   `   `   `  ����>  :Reg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:RegReg  5   	       Reg.auto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Reg     5   	     � Title$
  auto��5   	   $	��420��6   $	��380��6#   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��80 �6   6*   .+�5   
   �� -   5         ��Name$ AutorizationDataSP��5   -   $��0��6   $��5q�6"   .+�5      �� $��Comic Sans MS)�6   $��50��6/   $��	5,50,5,5 q�6:   .��6O   
Логин6V   �� 5      -   5         ��Name$ LoginTB��5      $��20��6'   65   �� 5      $��Comic Sans MS)�6   $��50��6/   $��5,50,5,5q�6:   .��6M   Пароль6U   �� 5      -   5        $ 
PasswordTB��5      $��20��6*   68   ]� 5      -   5         ]�Name$ 	CaptchaDP��5   8   $��15q�6   $y�Hidden=�6$   .+�5      �� -   5        $ CaptchaTextBox��5       �� 
IsReadOnly . {�.  $��20(�6W   $
��Bold"�6e   �� 5      -   5         ��Name$ CaptchaLabel��5      .��6/   	CAPTCHA68   �� 5      -   5        $ CaptchaCheckTextBox��5      5      5      �� 5    
   -   5        $ 	ButtonsSP��5    "   $��1��6   .+�5!      �� -	   5         ��Name$ LoginButton��5!   0   $��Comic Sans MS)�6   $��	10 20 0 0q�6E   $��40��6X   $��Center=�6c   ���	#FF76E383.��6�   
Войти6�   �� 5"      -
   5        $ GuestButton��5"   0   $��Comic Sans MS)�6   $��40��6F   $��Right=�6Q   $��0 0 10 0q�6m   ���	#FF498C51.��6�   
гость6�   5#      5$      5%      