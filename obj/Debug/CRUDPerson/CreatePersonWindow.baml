   M S B A M L   `   `   `  ����P  LHousingAssociationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:HousingAssociationApp.CRUDPerson HousingAssociationApp.CRUDPerson  5   	   9    3HousingAssociationApp.CRUDPerson.CreatePersonWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:HousingAssociationApp.CRUDPerson     5   	     � Title$  UTWÓRZ OSOBĘ��5   	   $	��450��6   $	��800��6+    � Icon$# \Content\logo_sf_eq3_icon.ico��67    � WindowStartupLocation$ CenterScreen=�6\   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��10 �6   .+�5%   
   �� $��1��6   $��1��6!   $��Imię:��61   �� 5&   
   $��1��6   $��2��6   ��6/   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=��� 5'   
   $��2��6   $��1��6!   $��	Nazwisko:��61   �� 5(   
   $��2��6   $��2��6   ��6/   �� *	Surname+$ PropertyChanged=��� 5)   
   $��3��6   $��1��6!   $��Miasto:��61   �� 5*   
   $��3��6   $��2��6   ��6/   �� *City+$ PropertyChanged=��� 5+   
   $��4��6   $��1��6!   $��Ulica:��61   �� 5,   
   $��4��6   $��2��6   ��6/   �� *Street+$ PropertyChanged=��� 5-   
   $��5��6   $��1��6!   $��Numer mieszkania:��61   �� 5.   
   $��5��6   $��2��6   ��6/   �� *Housenumber+$ PropertyChanged=��� 5/   
   $��6��6   $��1��6!   $��Kod pocztowy:��61   �� 50   
   $��6��6   $��2��6   ��6/   �� *
PostCode+$ PropertyChanged=��� 51   
   $��7��6   $��2��6    $��2��60    �� DisplayMemberPath$
 Name��6�   ��6D   �� *HousingList+$ PropertyChanged=�6�   �� 57   
   $��1��6   $��5��6!   ��61   �� *Name+�� 58   
   $��2��6   $��5��6!   ��61   �� *	Surname+�� 59   
   $��3��6   $��5��6!   ��61   �� *City+�� 5:   
   $��4��6   $��5��6!   ��61   �� *Street+�� 5;   
   $��5��6   $��5��6!   ��61   �� *Housenumber+�� 5<   
   $��6��6   $��5��6!   ��61   �� *
PostCode+5?      5@      