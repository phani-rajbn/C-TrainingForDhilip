   M S B A M L   `   `   `  ����G  CSampleWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SampleWpfAppSampleWpfApp  5   	       SampleWpfApp.GridPanel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SampleWpfApp     5   	     � Title$  
Tabular UI��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $��* �6   .+�5   
   �� $��2q�6   $��34(�6   $��Center=�6)   $��2��6M   .��6a   Employee Details6s   �� 5   
   $��2q�6   $��Right=�6   $��1��67   .��6D   Enter the Employee ID6[   �� 5   
   $��2q�6   $��Right=�6   $��2��67   .��6D   Enter the Employee Name6]   �� 5   
   $��2q�6   $��Right=�6   $��3��67   .��6D   Enter the Employee Address6`   �� 5   
   $��2q�6   $��Right=�6   $��4��67   .��6D   Enter the Employee Phone6^   �� 5   
   -   5        $��txtId��5   a   $��2q�6   $	��250��6   $
��Left=�6)   $��1��6D   $��1��6T   6a   �� 5   
   -   5        $��txtName��5   b   $��2q�6   $	��250��6   $
��Left=�6)   $��1��6E   $��2��6U   6b   �� 5   
   -   5        $��
txtAddress��5   b   $��2q�6   $	��250��6   $
��Left=�6)   $��1��6E   $��3��6U   6b   �� 5   
   -   5        $��txtPhone��5   b   $��2q�6   $	��250��6   $
��Left=�6)   $��1��6E   $��4��6U   6b   � 5    
   $��2q�6   $��5��6   $��2��6,   $��Center=�6@   .+�5!      �� -   5        $��5q�5!      .��6/   Save Changes6=   �� 5"      -   5        $��5q�5"      .��61   Cancel69   5#      � 5$   
   $��2q�6   $��6��6   $��2��6,   $��Center=�6@   .+�5%      �� -   5        $��
lblDisplay��5%      $��5q�6&   $��24(�61   5&      5'      5(      