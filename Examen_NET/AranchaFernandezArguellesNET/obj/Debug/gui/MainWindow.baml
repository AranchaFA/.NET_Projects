   M S B A M L   `   `   `  ����   AranchaFernandezArguellesNET-    'AranchaFernandezArguellesNET.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��10,41,9.667,0q�6P   $	��Top=�6g   $	��184��6      AutoGenerateColumns .  ��.  ��6%   ��  �� Path$ listaPersonas�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6%      Header$ Nombre��61      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� $ Nombre�6a     5	      $	 200 6%   $ 	Apellidos��61   	   CanUserReorder	 .   6D   �� $ 	Apellidos�6g     5
      $ 50 6%   $ Estado��60   	 .   6@   �� $ Estado�6`   5      �� 5   
   $!��REGISTRO ENTRADAS Y SALIDAS��6   $��10,0,-0.333,0q�66   $	��Top=�6M   $��36��6e   $��Center=�6q   $��20(�6�   �� 5   
   -   5        
 ��Name$
 comboBox��5      $
��Left=�6}   $��
27,266,0,0q�6�   $	��Top=�6�   $	��274��6�   ��6%   �� $ listaPersonas�6�   �� 5   
   -   5         ��Name$ bt_Entra��5      $��Entra��6#   $
��Left=�6F   $��320,266,0,0q�6a   $	��Top=�6v   $��75��6�   �� 5   
   -   5        $ bt_Sale��5      $
��Sale��6"   $
��Left=�6C   $��420,266,0,0q�6^   $	��Top=�6s   $��75��6�   �� 5   
   -   5        $ 
bt_anhadir��5      $��Añadir��6%   $
��Left=�6K   $��	10,12,0,0q�6f   $	��Top=�6y   $��66��6�   5      5      