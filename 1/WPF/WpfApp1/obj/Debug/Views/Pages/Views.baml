   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfApp1.Views.PagesWpfApp1.Views.Pages  5          WpfApp1.Views.Pages.Views   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WpfApp1.Views.Pages     5      -   5          N� Title$  Views��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   5      �� 5   
   $��0��6   $
��Left=�5      $��Center=�5      .+�5      �� -   5           btn1#��[  5      $��
Назад��5      
�������5      5       �� 5"   
   $��1��6    �� Orientation$ 
Horizontal=�5#      $��Right=�5$      $��Center=�5%      .+�5&      �� $��Поиск: ��6   $��18(�5'      $��0,0,10,0q�5(      
�������5)      �� 5*      -   5         ��Name$ 	txbSearch��5*        txb1#��[ 5+      5,      5-      � 5/   
   $��1��6   .+�50      &   System.Windows.Controls.DataGrid  -   5          Name$ dbView��50         AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 53      $��10q�54      	   Columns	 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)      Width$
 0.5* 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+6L     57      $
 Название��6)    6;   �� *Name+  58      $
 Жанр��6)    67   �� *
Genre.Name+  59      $
 Странцы��6)    6:   �� *	CountPage+  5:      $+
 %Имя и фамилия автора��6)    6G   �� *Author.FirstName+  5;      $
 Цена��6)   $ * 6R    67   �� *Price+6R     5<      $
 Издатель��6)   $ * 6^    6;   �� *Publisher.Name+6^   4  .System.Windows.Controls.DataGridTemplateColumn  5=      $
 Обложка��6-      CellTemplate 5>      �� 5?      .R�5@   "   �� ��6(   �� *	Picture+5A      5C      5E      5F      � 5G   
   $��2��6   .+�5H      �� $ 
Horizontal=�6   $��Center=�5I      $��Center=�5J      .+�5K      �� -   5         ��Name$ btn_Add��5K        btn2#��[ 5L      
�������$��Добавить��5N      5O      �� 5P      -   5        $ btn_Edit��5P      #��[ 5Q      
�������$ ��Редактировать��5S      5T      �� 5U      -   5        $ 
btn_Remove��5U      #��[ 5V      
�������$��Удалить��5X      5Y      5Z      5[      5b      5c      