   M S B A M L   `   `   `  ����  Demonstracao#    Demonstracao.Telas.Linguagens   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  
Linguagens��5      .��5      � $	��383��6   $	��439��6   .+�5   
   �� -   5        $��tabControl1��5   P   $	��309��6   $
��Left=�6"   $��	12,21,0,0q�6=   $	��Top=�6c   $	��412��6{   .@�5      �� -   5        $��tabItem1��5   %   $��Lista��6   .��5      � .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5   �      CanUserAddRows .     AutoGenerateColumns .  $	��264��6R   $
��Left=�6_   $��6,6,0,0q�6z   $	��Top=�6�   $	��390��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Código��6R      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID_LINGUAGEM+6b     5      $
 Nome��6R   $	 200 6`    61   �� *NM_LINGUAGEM+6`   5      5      5      �� 5      -   5        $��tabItem2��5   $   $
��Novo��6   .��5      � .+�5      �� -   5        $��	groupBox1��5   y   $��Informações do Registro��6   $	��264��6@   $
��Left=�6M   $��7,1,0,0q�6h   $	��Top=�6�   $	��390��6�   
�������.��5      � .+�5      �� -   5        $��label1��5   n   $��Código��6$   $��28��65   $
��Left=�6A   $��6,16,0,0q�6\   $	��Top=�6|   
���  ��6�   �� 5      -   5        $��label2��5   l   $
��Nome��6$   $��28��63   $
��Left=�6?   $��7,65,0,0q�6Z   $	��Top=�6z   
���  ��6�   �� 5      -	   5        $��textBox1��5   `   $��23��6&   $
��Left=�62   $��	11,36,0,0q�6M   $	��Top=�6p   $��67��6�    �� 
IsReadOnly . 6�   �� 5      -
   5        $��textBox2��5   `   $��23��6&   $
��Left=�62   $��	11,87,0,0q�6M   $	��Top=�6p   $	��192��6�   �� 5      -   5        $��button2��5   r   $��Limpar��6%   $��23��66   $
��Left=�6B   $��128,116,0,0q�6]   $	��Top=�6�   $��75��6�   ��5    "   �� 5!   &    �� EndPoint$ 0.5,1&�6:   	 �� 
StartPoint$	 0.5,0&�6K   .��5"   *   � 
 � Color$
 Black��67    � Offset$ 0Q�6E   � 5#   *   $
 	#FF9DD4FF��67   $ 1Q�6I   5$   '   5&      �� 5'      -   5        $��button3��5'   q   $��Salvar��6%   $��23��66   $
��Left=�6B   $��
11,116,0,0q�6]   $	��Top=�6�   $��75��6�   ��5(   "   �� 5)   &   $ 0.5,1&�6:   $	 0.5,0&�6K   .��5*   *   � $
 Black��67   $ 0Q�6E   � 5+   *   $
 Yellow��67   $ 1Q�6F   5,   '   5.      5/      50      51      52      ��53      �� 54      $ 1,0.5&�6&   $	 0,0.5&�67   .��55      � $
 Black��6#   $ 0Q�61   � 56      $
 	#FF70FFE9��6#   $ 1Q�65   57      59      �� 5:   
   -   5        $��button1��5:   ^   $��Voltar��6   $��23��6"   $
��Left=�6.   $��349,348,0,0q�6I   $	��Top=�6m   $��75��6�   6�   5;      5<      