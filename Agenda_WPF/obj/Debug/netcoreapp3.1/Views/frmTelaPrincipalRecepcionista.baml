   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   E AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Agenda_WPF.ViewsAgenda_WPF.Views 5   	   4   .Agenda_WPF.Views.frmTelaPrincipalRecepcionista   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Agenda_WPF.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$  TelaPrincipalRecepcionista��5
   
   $	��720��6-   $
��1020��6:    � WindowState$ 	Maximized=�6G   .��5      � .+�5   
   �� -   5        $��lblAteLogado��5      $�� ��6$   $
��Left=�6/   $��
165,10,0,0q�6J   $	��Top=�6^   ]� 5   
   -   5        $��mn_Principal��5      $
��Left=�6(   $��Center=�6D   $	��190��6_   $	��704��6k   ���	#FF5AABFA.+�5      �� $��/unnamed.png��6   $	��Top=�6*   �� 5      -   5        $��btnCadastrarPaciente��5      $��Cadastrar Paciente��61   $
��Left=�6N   $��30��6p   $	��Top=�6|   6�   �� 5      -   5        $��btnListarPaciente��5      $��Listar Paciente��6.   $
��Left=�6H   $��30��6j   $	��Top=�6v   6�   �� 5      -   5        $��btnListarConsulta��5      $��Listar Consulta��6.   $
��Left=�6H   $��30��6j   $	��Top=�6v   �� 5      -   5        $��btnInformarAgend��5      $��Informar Agenda ��6-   $
��Left=�6H   $��30��6j   $	��Top=�6v   �� 5      -   5        $��btnImpressaoDeclaracao��5      $��Imprimir Declaração��63   $
��Left=�6Q   $��30��6s   $	��Top=�6   �� 5      -	   5        $��	btnFechar��5      $��Fechar��6&   $��30��67   $	��Top=�6C   6X   5      �� 5   
   -
   5        $��AgCal��5       �� Orientation$ 
Horizontal=�6"   $��416,163,325,163q�6;   .+�5      &   System.Windows.Controls.Calendar  -   5        $��CalSet��5         DisplayMode$ Month=�6%      SelectionMode$ 
SingleDate=�69      DisplayDate$ 
01/01/2020��6T   $	��357��5   i   $	��280��6v      DisplayDateStart 6   ��  �� Mode$ OneWay=�	 �� Today
 �� Source#
 Z	 6v   5      �� 5   
   -   5         ��Name$ txtDta��5      $
��Left=�5      $��734,649,0,0q�6/   $	��Top=�6D   $y�Hidden=�6\   $��25��5      $	��150��6    ��5   "   ��  �� ElementName$ CalSet�� �� Path$ SelectedDate� �� StringFormat$ 
dd/MM/yyyy��5   ,   5"      5#      