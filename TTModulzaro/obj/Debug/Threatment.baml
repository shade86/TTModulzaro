   M S B A M L   `   `   `  ����F  BTTModulzaro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TTModulzaroTTModulzaro  5   	       TTModulzaro.Threatment   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TTModulzaro     5   	     � Title$  Kezelési lap��5   	   $��542.05��6   $��523.529��6.   .��5	      � .+�5
   
   �� $��Center=�6U   $	��180��6p   $��23��6|   $
��Left=�6�   $��146,277,0,211q�6�    �� SelectedItem 6   �� *SelectedBNO+��68   �� *BNOs+5      �� 5   
   -   5        $
��Left=�5   M   $	��122��6h   $��
78,147,0,0q�6u   $	��Top=�6�   $	��413��6�    6   �� *BNOs+��60   �� *BNOs+��5      �� 5      .R�5      �� .+�5      ��  �� ContentStringFormat$ BNO: {0}��69   ��6    �� *Name+69   �� 5      $ Jegyzet: {0} ��6<   ��6    �� *	Jegyzet+6<   5      5      5      �� 5   
   $��Beteg neve:��6   $
��Left=�6&   $��	78,23,0,0q�6A   $	��Top=�6T   �� 5   
   $
��Left=�61   $��
168,23,0,0q�6L   $	��Top=�6`   ��6   �� *Patient.Name+6`   �� 5   
   $��	Életkor:��6   $
��Left=�6#   $��	78,54,0,0q�6>   $	��Top=�6Q   �� 5   
   $��
TAJ szám:��6   $
��Left=�6$   $��	78,85,0,0q�6?   $	��Top=�6R   �� 5    
   $
��Left=�60   $��
168,85,0,0q�6K   $	��Top=�6_   ��6   �� *Patient.TAJ+6_   �� 5!   
   $��Régebbi kezelések:��6   $
��Left=�6-   $��
78,116,0,0q�6H   $	��Top=�6\   �� 5"   
   $��	BNO kód:��6   $
��Left=�6#   $��
78,274,0,0q�6>   $	��Top=�6R   �� 5#   
   $��Jegyzet:��6   $
��Left=�6#   $��
78,315,0,0q�6>   $	��Top=�6R   �� 5$   
   -   5         ��Name$ JegyzetTextBox��5$      $
��Left=�6*   $	��117��6E   $��
78,363,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6�   $	��413��6�   ��6z   �� *SelectedBNO.Jegyzet+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5&      5'      