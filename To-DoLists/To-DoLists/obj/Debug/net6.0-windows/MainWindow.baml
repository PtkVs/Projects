   M S B A M L   `   `   `  ����E  ATo-DoLists, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:To_DoLists
To_DoLists  5   	       To_DoLists.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:To_DoLists     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ To_Do��5	      $	��797��6    � ColumnDefinitions 5
   
   �� 5      $
��186* �6   �� 5      $
��323* �6   �� 5      $	��15* �6   �� 5      $
��276* �6   .+�5   
   �� $��1��5      $��To-Do Lists��5      $
��Left=�5      $��
158,10,0,0q�5      $	��Top=�5      $	��180��5      $
��Bold"�6   $��2��5      $��20(�5      $��MV Boli)�5      �� 5   
   -   5         ��Name$
 Btn1��5      $��1��5      $��	Add Tasks��5       $
��Left=�5!      $��174,112,0,0q�5"      $	��Top=�5#      $��MV Boli)�5$      $��15(�5%       J� RenderTransformOrigin$ -0.108,1.831&�5'      �� 5)   
   -   5         ��Name$ TaskListBox��5)      $��4��6'   $��61,150,73,78q�6;   $ 0.5,0.5&�6Q   $��MV Boli)�6q   $��15(�6�   z�5*      V� 5+      .~�5,      �� �� 5-       �� AngleY$ 0Q�6$   �� 5.      T� 5/       T� Y$ 0Q�6)   50      52      �� 54   
   -   5         ��Name$ 	TextInput��55      $��1��56      $
��Left=�57      $��7,64,0,0q�58      	 �� TextWrapping$
	 Wrap=�59      $	��Top=�5:      $	��412��5;      $ 1.155,0.901&�5<      $��3��5=      $��43��5>      �� 5A   
   -   5        
 ��Name$
 WarningAddT��5B      $�� ��5C      $
��Left=�5D      $��
77,110,0,0q�5E      $	��Top=�5F      $��2��5G      $	��269��5H      $��35��5I      $��MV Boli)�5J      $��15(�5K      $
��Bold"�5L      $ 
0.47,0.569&�5M      �� 5O   
   -   5        $ 	removeBtn��5P      $��1��5Q      $��Remove Tasks��5R      $
��Left=�5S      $��163,372,0,0q�5T      $	��Top=�5U      $ -0.091,-1.086&�5V      $��90��5W      $��28��6   $��MV Boli)�5X      5Y      �� 5[   
   -   5        $
 WarningRemoveT��5\      $�� ��5]      $
��Left=�5^      $��115,371,0,0q�5_      $	��Top=�5`      $ -1.552,0.495&�5a      $��2��5b      $	��217��5c      $��MV Boli)�5d      $
��Bold"�5e      5g      5h      