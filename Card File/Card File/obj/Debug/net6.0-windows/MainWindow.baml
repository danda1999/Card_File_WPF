   M S B A M L   `   `   `  ����D  @Card File, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Card_File	Card_File  5   	       Card_File.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Card_File     5   	   -   5          � Title$  
PatienList��5   	    � 
ResizeMode$ CanMinimize=�6   $	��450��65   $	��800��6B    � Icon$ /box.ico��6e    � 	Resources 5	         patientViewSource��%   &	        �� 5
   
   6   5      .��5      �  � ShowGridLines$
 True��6    � ColumnDefinitions 5   
   �� 5      $	��500 �6   �� 5      $	��300 �6   6-   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ patientDataGrid��5         AutoGenerateColumns$ False��6,      CanUserAddRows$ false��6H   	   EnableRowVirtualization$
	 True��5      $��Center=�6*   $��Center=�6N   $��0��5      $��0��6   $	��300��6(   $	��Top=�65   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6M   ��5      ��  �� Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6)      
IsReadOnly$
 True��5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *	patientID+5        5      $
 Name��6E   $ * 5      $
 True��6'    5   %   �� *patientName+5   '     5      $ Surname��6H   $ * 5      $
 True��6'    5   %   �� *patientSurname+5   '     5      $ 	Birthdate��6]   $ * 5      $
 True��6'    5   %   �� *date+ �� StringFormat$ {0:dd/MM/yyyy}��5   '   4  .System.Windows.Controls.DataGridTemplateColumn  5       $ Delete��6)   $ 75 69      CellTemplate 5!      �� 5"      .R�5#      �� -   5        $��X��5#   %   61   5$      5&      5(      �� 5*   
   -   5         ��Name$ 
SearchText��5*      $��Arial)�6&   $��20(�69   $��Bottom=�6G   $��50,65,300,65q�6b    �� TextAlignment$ Center=�6x   $��0��6�   �� 5+   
   -   5         ��Name$ 
SearchButt��5+      $��Arial)�6%   $��20(�68   $��Search��6F   $��Bottom=�6W   $��250,0,70,45q�6r   $��33��6�   6�   �� 5,   
   -   5         ��Name$ label��5,      $��2��6   $��Name:��6/   $
��Left=�6?   $��	39,20,0,0q�6Z   $	��Top=�6m   �� 5-   
   -   5        $ NameTxb��5-      $��2��6{   $	��Top=�6�   $��112,25,60,0q�6�   ��6#   ��  �� ElementName$ patientDataGrid�� �� Path$ SelectedItem.patientName� �� Mode$ OneWay=�6�   �� 5.   
   -   5        $ label1��5.      $��2��6    $��Surname:��60   $
��Left=�6C   $��
39,100,0,0q�6^   $	��Top=�6r   �� 5/   
   -	   5        $ 
SurnameTxb��5/      $��2��6�   $	��Top=�6�   $��112,105,60,0q�6�   ��6&   �� $ patientDataGrid��$! SelectedItem.patientSurname�$ OneWay=�6�   �� 50   
   -
   5        $ label2��50      $��2��6    $��
Birthdate:��60   $
��Left=�6E   $��
33,157,0,0q�6`   $	��Top=�6t   �� 52   
   -   5        $ EditButt��52      $��2��6;   $��Arial)�6K   $��25(�6^   $
��Edit��6l   $��Bottom=�6{   $
��Left=�6�   $��	10,0,0,10q�6�   $	��121��6�   6�   �� 53   
   -   5        $ AddButt��53      $��2��66   $��Arial)�6F   $��25(�6Y   $	��Add��6g   $��Bottom=�6u   $
��Left=�6�   $��
150,0,0,10q�6�   $	��121��6�   6�   (  "System.Windows.Controls.DatePicker  54   
   -   5          Name$ 	Calendare��54      $��Center=�6(   $��120, -90, 75,0q�6C   $��1��6[      SelectedDate 6k   �� $ patientDataGrid��$ SelectedItem.date�$ OneWay=�   DisplayDate 6�   �� $ SelectedDate� �� RelativeSource �� *Self+$ OneWay=��� 55   
   -   5         ��Name$ 	ChooseCMB��55      $
��Left=�6&   $��Bottom=�6A   $	��120��6\   $��	60,0,0,25q�6h    �� SelectedIndex$ 0��6{   .@�56      �� -   5        $
��name��56   *   $
��Name��6   68   �� 57      -   5        $��surname��57   -   $��Surname��6   6>   58      59      5:      