   M S B A M L   `   `   `  ����F  BTTModulzaro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TTModulzaroTTModulzaro  5   	       TTModulzaro.PatientForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TTModulzaro     5   	   -   5          � Title$  Beteg adatai��5   	   $	��300��6   $��457.143��6+   .��5	      � .+�5
   
   �� $��Beteg neve:��6   $
��Left=�6&   $��	22,21,0,0q�6A   $	��Top=�6T   �� 5   
   $��Születési hely:��6   $
��Left=�6*   $��	22,52,0,0q�6E   $	��Top=�6X   �� 5   
   $��Születési dátum:��6   $
��Left=�6+   $��	22,83,0,0q�6F   $	��Top=�6Y   �� 5   
   $��
TAJ szám:��6   $
��Left=�6$   $��
22,114,0,0q�6?   $	��Top=�6S   �� 5   
   $
��Left=�6   $��23��6-   $��
131,24,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� *Patient.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��23��6-   $��
131,55,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� *Patient.BornPlace+$ PropertyChanged=�6�   �� 5   
   -   5        $
��Left=�5      $��23��6-   $��131,118,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $	��120��6�   ��6b   �� *Patient.TAJ+$ PropertyChanged=�6�   �� 5   
   $��	Életkor:��6   $
��Left=�6#   $��287,115,0,0q�6>   $	��Top=�6S   �� 5   
   -   5         ��Name$ SubmitButton��5      $��OK��6   $
��Left=�64   $��158,182,0,0q�6O   $	��Top=�6d   $��75��6|   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
DatePicker��5      $
��Left=�6G   $��
131,85,0,0q�6b   $	��Top=�6v      Text 6)   �� *Patient.Born+6v   5      5      