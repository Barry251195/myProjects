   M S B A M L   `   `   `  ���� >  :Med, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MedMed      Med.ShowPers   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:Med     X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -     �Name$  
mwShowPers�� � Title$" Редактирование��$	��450��$��545.6�� � WindowStartupLocation$ CenterScreen=�.��� ���	#FFD2D2FF � ColumnDefinitions �� $
��247* ��� $
��291* � � RowDefinitions �� .+��� -   $��Сохранить��$
��Left=�$��132,349,0,0q�$	��Top=�$	��133��$��42��$��1��$��13(��� -    ��Name$ tbFirstName��$
��Left=�$��25��$��
85,105,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��255��$��2��$��13(��� -   $ 	tbDiagnos��$
��Left=�$��85��$��
85,260,0,0q�$
 Wrap=�$	��Top=�$	��255��$��2��$��13(��� $��Имя��$
��Left=�$��25��$��	85,80,0,0q�$	��Top=�$��95��$��13(��� $��Фамилия��$
��Left=�$��25��$��
85,130,0,0q�$	��Top=�$��65��$��13(��� -   $ tbSecondName��$
��Left=�$��25��$��
85,155,0,0q�$
 Wrap=�$	��Top=�$	��255��$��2��$��13(��� $��Диагноз��$
��Left=�$��31��$��
85,235,0,0q�$	��Top=�$��65��$��13(��� $0��*Дата первичного приёма��$
��Left=�$��30��$��	85,20,0,0q�$	��Top=�$	��168��$��13(�$��2��(  "System.Windows.Controls.DatePicker  -     Name$ 	dateFirst��$
��Left=�$��25��$��	85,50,0,0q�$	��Top=�$	��115��   StyleCalendar   CalendarStyle# �   $��13(�%  Xceed.Wpf.Toolkit.MaskedTextBox  -   	  Name$	 	timeFirst��
   Mask$
 00:00��$��13(�$
��Left=�$��25��$��
212,50,0,0q�$
 Wrap=�$	��Top=�$��41��$��2�� �� TextAlignment$ Center=��� $��Дата рождения��$
��Left=�$��30��$��
85,180,0,0q�$	��Top=�$	��150��$��13(�  -   $ dateOfBirth��$
��Left=�$��25��$��
85,210,0,0q�$	��Top=�$	��195��$��2��# �   $��13(��� $0��*Дата повторного приёма��$
��Left=�$��30��$��
85,350,0,0q�$	��Top=�$	��162��$��13(�  -	   $ 
dateSecond��$
��Left=�$��25��$��
85,380,0,0q�$	��Top=�$	��115��# �   $��13(�  -
   $	 
timeSecond��$
 00:00��$��13(�$
��Left=�$��25��$��212,380,0,0q�$
 Wrap=�$	��Top=�$��41��$��2��$ Center=��� -    ��Name$ btnDel��$��Удалить��$��1��$
��Left=�$��132,296,0,0q�$	��Top=�$	��133��$��42��