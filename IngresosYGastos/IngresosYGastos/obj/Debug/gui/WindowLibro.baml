   M S B A M L   `   `   `  ����  IngresosYGastos%    IngresosYGastos.gui.WindowLibro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  WindowLibro��5   	   $��188.667��6   $	��300��6.   .��5      � $��0,0,0.333,0q�6   $	��151��6    $	��Top=�6-   .+�5   
   �� -   5         ��Name$ label_concepto��5      $��Concepto��6(   $
��Left=�6;   $��	19,51,0,0q�6V   $	��Top=�6i   $��76��6�   $��24��6�   �� 5   
   -   5        $ label_importe��5      $��Importe��6'   $
��Left=�69   $��	19,81,0,0q�6T   $	��Top=�6g   $��76��6   $��24��6�    J� RenderTransformOrigin$ 0.439,1.961&�6�   �� 5   
   $��Fecha��6   $
��Left=�6    $��	24,25,0,0q�6;   $	��Top=�6N   $��76��6f   $��21��6q   $��Center=�6}   $��0q�6�   �� 5
   
   -   5         ��Name$ textBox_concepto��5
      $��
100,53,9,0q�6�    �� TextWrapping$
 Wrap=�6�   $��23��6�   $	��Top=�6�   ��6P   ��  �� Path$ Concepto� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6�   �� 5   
   -   5        $ textBox_importe��5      $��
100,81,9,0q�6�   $
 Wrap=�6�   $��23��6�   $	��Top=�6�   ��6O   �� $ Importe� .  . 6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $��100,25,10,0q�6�   $��24��6�   $	��Top=�6�   	   SelectedDate	 6M   �� $ Fecha� .  . 6�   �� 5   
   -   5        
 ��Name$
 button_aceptar��5      $��Añadir��6)   $
��Left=�6:   $��
57,121,0,0q�6U   $��75��6i   $��20��6t   $	��Top=�6�   6�   �� 5   
   -   5        $
 button_cancelar��5      $��Cancelar��6*   $
��Left=�6=   $��165,121,0,0q�6X   $��75��6m   $��20��6x   $	��Top=�6�   6�   5      5      