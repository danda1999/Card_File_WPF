   M S B A M L   `   `   `  ����D  @Card File, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Card_File	Card_File  5   	       Card_File.NewPatient   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Card_File     5   	     � Title$  Patient��5   	   $	��300��6   $	��400��6&    � Icon$ /box.ico��62   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $	��Top=�6   $��25,10,275,0q�6(   $��40��6=   $��20(�6I   $��Center=�6W   .��6{   Name:6�   �� 5   
   -   5         ��Name$ NameTxt��5      $	��Top=�6#   $
��Left=�6;   $��
200,20,0,0q�6V   $��15(�6j   $	��130��6x    �� TextAlignment$ Center=�6�   6�   �� 5   
   $	��Top=�6   $��25,74,270,0q�6(   $��40��6=   $��20(�6I   $��Center=�6W   .��6{   
Surname:6�   �� 5   
   -   5        $ 
SurnameTxt��5      $	��Top=�6&   $
��Left=�6>   $��
200,85,0,0q�6Y   $��15(�6m   $	��130��6{   $ Center=�6�    J� RenderTransformOrigin$ 0.495,-0.186&�6�   6�   �� 5   
   $��Center=�6   $��
25,0,270,0q�6+   $��40��6?   $��20(�6K   $��Center=�6Y   .��6}   Date:6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $
��Left=�6)   $��200,135,0,0q�6D   $	��Top=�6Y   $��25��6q   $	��130��6}   $ 0.507,-1.076&�6�   �� 5   
   -   5         ��Name$ 
confirmBtt��5      $	��150��6%   $	��Top=�6E   $��Center=�6]   $��	0,220,0,0q�6z   $��confirm��6�   $��20(�6�   6�   5      5      