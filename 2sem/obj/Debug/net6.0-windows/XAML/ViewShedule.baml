   M S B A M L   `   `   `  ����E  ACourseWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CourseWork
CourseWork  5          CourseWork.ViewShedule   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:CourseWork     5        N� Title$  ViewShedule��5   	    � 	Resources 5       �� 
TargetType �� Triggers ]� 
Conditions �� Property �� Value �� Property �� Value	 :� RoutedEvent
 �� TargetProperty g� Duration	 W� To g� AutoReverse��%  '��       �� 5   
   " ��6    5      ]� 5       5      �� 5       �@J�IsMouseOver$
 True��6;   �� 5       � ��$
 True��69   /�5      �� 5       � ��$ 14(�65   �� 5       � ��
 �  ��67   5      :� 5      $	 Click��6   [�5      �� 5      .��5       �� .��5!   "   W� $
 Width�62   $ 0:0:1D�6T    2206e   $
 True��6n   W� 5"   "   $
 Height�62   $ 0:0:1D�6U    806f   $
 True��6n   5#      5$      5&      5(      5)      .��5*      � .+�5+   
   �� -   5         ��Name$ Search_button��5+   �      Search_Shedule_Button#���   6   $
��Left=�6C   $��
684,35,0,0q�6^   $	��Top=�6r   $��60��6�   $��33��6�   �� 5,   
   -   5         ��Name$ Search_TextBox��5,   �   $
��Left=�6   $��	34,36,0,0q�6-    �� TextWrapping$
 Wrap=�6@   $�� ��6T   $	��Top=�6\   $	��627��6t   $��19��6�    � Cursor$ IBeam��6�   6�   �� 5-   
   
���   �$��1q�6%   $
��Left=�69   $	��233��6T   $��	34,76,0,0q�6a   $	��Top=�6t   $	��710��6�   ._�5.      &   System.Windows.Controls.DataGrid  -   5          Name$ ListShedule��5.   d      AutoGenerateColumns$ False��6H   $��0,0,0,-1q�6y      SelectionMode$ Single=�6�   ��6   �� *listShedule+ �� Mode$ TwoWay=�   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *id+  51      $ IdTrain��6)    6:   �� *
Id_Train+  52      $
 Date��6)    67   �� *Date+  53      $ Route��6)    68   �� *	RouteId+  56      $ 	TimeInWay��6)    6<   �� *Time_In_Way+  57      $ 	Frequency��6)    6<   �� *	Frequency+59      5;      5=      5>      