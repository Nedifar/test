   M S B A M L   `   `   `  ����P  LCreativeSystemDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CreativeSystemDesktop.FormsCreativeSystemDesktop.Forms  5   	   ,    &CreativeSystemDesktop.Forms.ClientForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:CreativeSystemDesktop.Forms     5   	     � Title$  
ClientForm��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��33* �6   �� 5      $
��386* �6   .+�5   
   �� -   5         ��Name$ tbName��5      $��Right=�6$   $��Center=�6@   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6I   .+�5      �� $��Сортировка��6   $	��5 0q�6*   �� 5      -   5         ��Name$ sortBox��5      $	��140��6T   $	��5 0q�6`   �� 5      $ ��Производитель��6   �� 5      -   5        $ 	filterBox��5       �� DisplayMemberPath$
 Name��6X   $	��140��6q   $	��5 0q�6}   5      �� 5   
   -   5         ��Name$ 
checkAdmin��5      $y�	Collapsed=�6'   �� 5   
   -   5         ��Name$ lv��5      $��1��6   $��0 0 0 30q�6,   ��5      �� 5      .R�5      �� .+�5      �� $ 
Horizontal=�6%   .+�5      �� $	��100��6$   $��0 0 20 0q�61   ��6C   �� *	imagePath+�� 5      $��0 0 20 0q�6)   .+�5   "   �� ��6,   �� *ProductName+ �� StringFormat$0 *Наименование товара: {0}���� 5   "   ��6,   �� *ProductArticleNumber+$ Артикул: {0}���� 5   "   ��6,   �� *ProductDescription+$ Описание: {0}���� 5    "   ��6,   �� *ProductCategory+$ Категория: {0}���� 5!   "   ��6,   �� *ProductManufacturer+$% Производитель: {0}���� 5"   "   ��6,   �� *ProductCost+$ Стоимость: {0}���� 5#   "   ��6,   �� *ProductDiscountAmount+$0 *Действующуая скидка: {0}���� 5$   "   ��6,   �� *ProductQuantityInStock+$+ %Товаров на складе: {0}���� 5%   "   ��6,   �� *Unit+$, &Единица измерения: {0}���� 5&   "   ��6,   �� *MaxDiscount+$0 *Максимальная скидка: {0}���� 5'   "   ��6,   �� *
Provider+$ Поставщик: {0}��5(      �� 5)      ��6(   �� *	haveStock+5*      5+      �� 5,      -   5        $ ��Редактировать��5,   !   $
��0 10q�6H   ��5-      �� 5.   "   	 �� 
TargetType"	 ��6(   
 �� Triggers
 5/   &   �� 50   *    �� Binding 66   ��  �� ElementName$ 
checkAdmin�� �� Path$ 	IsChecked� �� Value	 false6q   .a�51   .   ��  �� Property � y� �� Value$ 	Collapsed=�6K   52   +   54   #   56      �� 57      -   5        $��Удалить��57   !   ��58      �� 59   "   "	 ��6(   
 5:   &   �� 5;   *    66   �� $ 
checkAdmin��$ 	IsChecked�	 false6q   .a�5<   .   ��  � y�$ 	Collapsed=�6K   5=   +   5?   #   5A      5B      5C      5E      �� 5F   
   -   5        $��Добавить��5F      $��1��62   $��Center=�6?   $��Bottom=�6\   $	��0 5q�6w   ��5G      �� 5H      "	 ��6   
 5I      �� 5J       6&   �� $ 
checkAdmin��$ 	IsChecked�	 false6a   .a�5K      ��  � y�$ 	Collapsed=�6;   5L      5N      5P      5Q      5R      