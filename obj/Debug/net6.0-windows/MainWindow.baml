   M S B A M L   `   `   `  ����B  >AirInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AeroInfoAeroInfo  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	       AeroInfo.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AeroInfo     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ AirInfo��5
   	   $	��450��6   $	��800��6&   .��5      � $	��450��6   $	��780��6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��280 �6   �� 5      $	��280 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
CitiesText��5      $	��120��6(   $��20��64   $"��Выберите город:��6@   $��1��6W   $
��Left=�6h   $��Center=�6�   $��10,0,0,0q�6�   �� 5   
   -   5         ��Name$ CitiesComboBox��5       $��0��6   $��20��6c   $	��150��6o   $��Right=�6{   $��Center=�6�   $��	10,0,12,0q�6�   �� 5   
   -   5        $ AirportText��5   1   $��0��6   $��1��6!   $	��120��6F   $��20��6R   $(��"Выберите аэропорт:��6^    J� RenderTransformOrigin$ 1.195,0.439&�6x   $
��Left=�6�   $��Center=�6�   �� 5   
   -   5        $ AirportComboBox��5   0   $��0��6   $��1��6    $��20��6v   $	��150��6�   $��Center=�6�   $��Right=�6�   $��0,0,10,0q�6�   $|�False��6�    J� IsHitTestVisible$ False��6�   �� 5   
   -   5         ��Name$ ConfirmSelectButton��5   .   $��0��6   $��2��6   $	��140��6f   $��20��6r   $��Center=�6~   $��12(�6�   $+��%Обновить расписание��6�   $��Right=�6�   $��0,0,10,0q�6�   $|�False��6�   $ False��6  &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 SchedulesDataGrid��5       $��1��6   
   AutoGenerateColumns$
 False��6;   $��
10,0,10,40q�6W   $��3��6k      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      
IsReadOnly$
 True��6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ Id�6a     5       $ Компания��6%   $
 True��6[    67   �� $ 
FlightIata�6o     5!      $ 
Вылет��6%   $
 True��6U    64   �� $ DepIata�6i     5"      $ Дата вылета��6%   $
 True��6[    6:   �� $ DepTime�6o     5#      $ Прилет��6%   $
 True��6V    65   �� $ ArrIata�6j     5$      $ Дата прилета��6%   $
 True��6\    6;   �� $ ArrTime�6p     5%      $ Статус��6%   $
 True��6U    65   �� $ Status�6i   5'      5(      5)      