   M S B A M L   `   `   `  ���� B  >AirInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AeroInfoAeroInfo  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections     AeroInfo.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:AeroInfo     Bcol2clr-namespace:System.Collections;assembly=mscorlib       � 
ResizeMode$  NoResize=� � Title$ AirInfo��$	��450��$	��800��.��� $	��450��$	��780�� � RowDefinitions �� $��40 ��� $��* � � ColumnDefinitions �� $	��280 ��� $	��280 ��� $��* �.+��� -    ��Name$ 
CitiesText��$	��120��$��20��$"��Выберите город:��$��1��$
��Left=�$��Center=�$��10,0,0,0q��� -    ��Name$ CitiesComboBox��$��0��$��20��$	��150��$��Right=�$��Center=�$��	10,0,12,0q����� .R�$� �� -   $ AirportText��$��0��$��1��$	��120��$��20��$(��"Выберите аэропорт:�� J� RenderTransformOrigin$ 1.195,0.439&�$
��Left=�$��Center=��� -   $ AirportComboBox��$��0��$��1��$��20��$	��150��$��Center=�$��Right=�$��0,0,10,0q�$|�False�� J� IsHitTestVisible$ False������ .R�$� �� -    ��Name$ ConfirmSelectButton��$��0��$��2��$	��140��$��20��$��Center=�$��12(�$+��%Обновить расписание��$��Right=�$��0,0,10,0q�$|�False��$ False��&   System.Windows.Controls.DataGrid  -   	  Name$	 SchedulesDataGrid��$��1��
   AutoGenerateColumns$
 False��$��
10,0,10,40q�$��3��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��   
IsReadOnly$
 True��1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ Id�  $ Компания��$
 True�� �� $ AirlineIata�  $ 
Номер��$
 True�� �� $ FlightNumber�  $ 
Вылет��$
 True�� �� $ DepIata�  $ Дата вылета��$
 True�� �� $ DepTime�  $ Прилет��$
 True�� �� $ ArrIata�  $ Дата прилета��$
 True�� �� $ ArrTime�  $ Статус��$
 True�� �� $ Status�