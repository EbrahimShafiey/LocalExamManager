   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.Student_Page   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Student Page��5   	   $	��802��6   $
��1536��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��527* �6   �� 5      $��1002* �6   .+�5   
   �� $
��Left=�6   $	��752��60   $��	10,10,0,0q�6=   $	��Top=�6P   $
��1510��6h   $��2��6u   .@�5      �� $��صفحه اصلی��6   .��5      � ���	#FFE5E5E5.+�5      �� 
���   �$��1q�61   $
��Left=�6E   $	��233��6`   $��1157,15,0,0q�6m   $	��Top=�6�   $	��336��6�   ���	#FFFFF898._�5      �� -   5         ��Name$ studentdata��5       ${��uبه سطح دسترسی دانشجو خوش آمدید

Student ID:
Student First Name:
Student Last Name:


��65   $
��Left=�6�   $	��174��6�   $��9.2,9.2,0,0q�6�   $	��Top=�6  $	��316��6)  $��18(�65  5      �� 5      -   5        $��خروج از حساب ��5      $
��Left=�65   $��28��6P   $��1233,208,0,0q�6\   $	��Top=�6r   $	��184��6�   6�   5      5      �� 5      $��پاسخگویی��6   .��5      � #��� ��6   .+�5      �� 
���   �$��1q�61   $
��Left=�6E   $	��176��6`   $��	10,23,0,0q�6m   $	��Top=�6�   $	��996��6�   #��� ��6�   ._�5      �� 
���   �$��1q�65   $
��Left=�6I   $	��153��6d   $��13.2,12.2,0,0q�6q   $	��Top=�6�   $	��154��6�   ._�5      �� -   5        $ lblExamShow��5   $   $�� ��69   $
��Left=�6D   $	��133��6_   $��10.2,9.2,0,0q�6l   $	��Top=�6�   $	��133��6�   5      5      �� 5      -   5         ��Name$ 	Answertxt��5      $
��Left=�61   $	��220��6L   $��
10,249,0,0q�6Y    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $	��996��6�   $��18(�6�   ���	#FFFFFFBF6�   �� 5      -   5        $ 
lblQAnswer��5      $��جواب سوال 1��60   $
��Left=�6F   $��43��6a   $��443,206,0,0q�6m   $	��Top=�6�   $	��164��6�   ���	#FFFFFFBF$��20(�6�   $��	20,5,27,5q�6�   �� 5       -   5         ��Name$ btnPrivousQ��5       $��سوال قبل��62   $
��Left=�6E   $��47��6`   $��
12,475,0,0q�6l   $	��Top=�6�   $	��214��6�   $��
1,-2,-21,1q�6�   ��5!      �� 5"       �� ImageSource$ Untitled-23.png��6)    j� Stretch$ UniformToFill=�6G   5$      �� 5%      -   5        $ btnNextQ��5%      $��سوال بعد��6/   $
��Left=�6B   $��47��6]   $��799,475,0,0q�6i   $	��Top=�6~   $	��207��6�   $��
-20,-2,1,1q�6�   ��5&      �� 5'      $ Untitled-2.png��6)   $ UniformToFill=�6F   5)      �� 5*      $-��'مدت زمان باقیمانده : 60��6   $
��Left=�6>   $��49��6Y   $��386,475,0,0q�6e   $	��Top=�6z   $	��238��6�   #��� ��6�   $��20(�6�   $��14,5,5,5q�6�    � UseLayoutRounding .  6  �� 5+      
���   �$��1q�61   $
��Left=�6E   $	��179��6`   $��
12,527,0,0q�6m   $	��Top=�6�   $	��994��6�   #��� ��6�   �� 5,      -   5        	 ��Name$	 QuestionPic��5,      $
��Left=�61   $	��683��6L   $��1031,23,0,0q�6Y   $	��Top=�6n   $	��457��6�   $��yaddasht.png��6�   �� 5-      
���  ��$��5q�6/   $
��Left=�6C   $��43��6^   $��440,206,0,0q�6j   $	��Top=�6   $	��170��6�   �� 5.      
���  ��$��5q�6/   $
��Left=�6C   $��54��6^   $��385,470,0,0q�6j   $	��Top=�6   $	��242��6�   �� 5/      $����لطفا شماره آزمون مورد نظر خود را وارد کرده و گزینه "بررسی و تایید" را انتخاب کنید��6   $
��Left=�6�   $��41��6�   $��
204,36,0,0q�6�   $	��Top=�6�   $	��420��6�   �� 50      -	   5        $ txtEIDEnter��50      $
��Left=�63   $��32��6N   $��
204,82,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��242��6�   �� 51      -
   5        $��بررسی و تایید��51      $
��Left=�65   $��98��6P   $��
480,82,0,0q�6\   $	��Top=�6p   $	��127��6�   6�   52      53      �� 54      $��Label��6   $��34��6$   $��39��60   �� 55      
���   �$��1q�6)   $��55��6=   $��56��6I   �� 56      $��26��6   $
 Wrap=�6"   $��TextBox��66   $	��180��6E   57      59      5:      