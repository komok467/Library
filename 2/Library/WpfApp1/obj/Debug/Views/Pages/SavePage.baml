   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfApp1.Views.PagesWpfApp1.Views.Pages  5      "    WpfApp1.Views.Pages.SavePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WpfApp1.Views.Pages     5      -   5          N� Title$  SavePage��5	       � 	Resources 5       �� 
TargetType �� Property �� Value��%Q   '��       �� 5   
   " ��6   .�5      ��  � ��$ 2q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $��Center=�5      .+�5      �� -   5         ��Name$ Picture��5      $	��200��5      $	��200��5      �� 5      -   5         ��Name$ 
btnLoadImg��5      $��0,10,0,0q�5      $��35��5      $��Загрузить��5         btn2#��[  5!      
����ح�5$      5%      5&      � 5(   
   $��1��6   .+�5)      �� $��Center=�6   $��Center=�5*      .+�5,      ��  �� Orientation$ 
Horizontal=�6   .+�5-      �� $#��Название книги: ��6    $	��180��68   �� 5.      -   5        $��txbName��5.        txb1#��[ 5/      50      �� 51      $ 
Horizontal=�6   .+�52      �� $��
Жанр: ��6    $	��180��6.   �� 53      -   5        $��cmbGenre��53        cmb1#��[ 54      55      �� 56      $ 
Horizontal=�6   .+�57      �� $+��%Количество страниц: ��6    $	��180��6<   �� 58      -   5        $��txbCountPage��58      #��[ 59      5:      �� 5;      $ 
Horizontal=�6   .+�5<      �� $��Автор: ��6    $	��180��6/   �� 5=      -   5        $��cmbFirstName��5=      #��[ 5>      5?      �� 5A      $ 
Horizontal=�6   .+�5B      �� $��
Цена: ��6    $	��180��6.   �� 5C      -   5        $��txbPrice��5C      #��[ 5D      5E      �� 5G      $ 
Horizontal=�6   .+�5H      �� $��Издатель: ��6    $	��180��62   �� 5I      -	   5        $��cmbPublisher��5I      #��[ 5J      5K      �� 5L      $ 
Horizontal=�6   $��Center=�5M      $��Center=�5N      $��10q�5O      .+�5P      �� -
   5        $��btnBack��5Q      $��
Назад��5P      $	��150��5R      $��0,0,10,0q�5S        btn1#��[ 5U      
����ح�5X      �� 5Y      -   5        $��btnSave��5Z      $��Сохранить��5Y      $	��150��5[      #��[ 5]      
����ح�5`      5a      5b      5c      5d      5e      