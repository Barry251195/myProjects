   M S B A M L   `   `   `  ���� >  :Med, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MedMed      Med.NewPerson   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  localclr-namespace:Med  :
extensions)using:Microsoft.Toolkit.Uwp.UI.Extensions  -     �Name$  	windowAdd�� � Title$' !Добавить пациента��$	��597��$	��459�� � WindowStartupLocation$ CenterScreen=�����  �� Color$ 	#FFD2D2FF��.��� $��0,0,0,-1q� � ColumnDefinitions �� .+��� -   $��Добавить��$
��Left=�$��60��$��
85,460,0,0q�$	��Top=�$	��255��$��13(��� -    ��Name$ tbFirstName��$
��Left=�$��25��$��
85,105,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��255��$��13(��� -   $ 	tbDiagnos��$
��Left=�$��85��$��
85,260,0,0q�$
 Wrap=�$	��Top=�$	��255��$��13(��� $��Имя��$
��Left=�$��25��$��	85,80,0,0q�$	��Top=�$��95��$��13(��� $��Фамилия��$
��Left=�$��25��$��
85,130,0,0q�$	��Top=�$��65��$��13(��� -   $ tbSecondName��$
��Left=�$��25��$��
85,155,0,0q�$
 Wrap=�$	��Top=�$	��255��$��13(��� $��Диагноз��$
��Left=�$��31��$��
85,235,0,0q�$	��Top=�$��65��$��13(��� $0��*Дата первичного приёма��$
��Left=�$��30��$��	85,20,0,0q�$	��Top=�$	��168��$��13(�(  "System.Windows.Controls.DatePicker  -     Name$ 	dateFirst��$
��Left=�$��25��$��	85,50,0,0q�$	��Top=�$	��115��   StyleCalendar   CalendarStyle# �   $��13(�%  Xceed.Wpf.Toolkit.MaskedTextBox  -   	  Name$	 	timeFirst��
   Mask$
 00:00�� �� 
CaretIndex$ 0��$��13(�$
��Left=�$��25��$��
212,50,0,0q�$
 Wrap=�$	��Top=�$��41���� $��Дата рождения��$
��Left=�$��30��$��
85,180,0,0q�$	��Top=�$	��150��$��13(�  -   $ dateOfBirth��$
��Left=�$��25��$��
85,210,0,0q�$	��Top=�$	��195��# �   $��13(��� $0��*Дата повторного приёма��$
��Left=�$��30��$��
85,350,0,0q�$	��Top=�$	��168��$��13(�  -	   $ 
dateSecond��$
��Left=�$��25��$��
85,380,0,0q�$	��Top=�$	��115��# �   $��13(�  -
   $	 
timeSecond��$
 00:00��$��13(�$
��Left=�$��25��$��212,380,0,0q�$
 Wrap=�$	��Top=�$��41��