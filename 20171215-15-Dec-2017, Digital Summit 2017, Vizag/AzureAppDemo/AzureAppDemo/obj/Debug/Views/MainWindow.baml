   M S B A M L   `   `   `  ����G  CAzureAppDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AzureAppDemo.ConvertersAzureAppDemo.Converters  5   	   #    AzureAppDemo.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <
converters%clr-namespace:AzureAppDemo.Converters     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ 
MainWindow��5   	   $	��350��6   $	��600��6)    � 	Resources 5      6   0AzureAppDemo.Converters.ObjectToBooleanConverter   ObjectToBooleanConverter��%   &	          5   
   6.   5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
myCartGrid��5         AutoGenerateColumns .    CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .  	   CanUserResizeRows	 .  
   
IsReadOnly
 . $��0��5       � DataContext 5      ��  �� ElementName$ 
mainWindow����5      �� *MyCart+5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��5      $��8q�5      $��Center=�5      .+�5      �� -   5        $��Refresh Cart��5      $��4q�5       $	��120��5!      $��30��5"      5#      �� 5$      -   5        $��Add to Cart��5$      $��4q�5%      $	��120��5&      $��30��5'      5(      �� 5)      -   5        $��Update Cart Item��5)      $��4q�5+      $	��120��5,      $��30��5-      {�5*      �� *SelectedItem+$ 
myCartGrid�� �� 	Converter# [  5.      �� 5/      -   5        $��Delete from Cart��5/      $��4q�51      $	��120��52      $��30��53      {�50      �� *SelectedItem+$ 
myCartGrid��# [  54      55      56      57      