   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Agenda_WPF.ViewsAgenda_WPF.Views  5   	   -    'Agenda_WPF.Views.frmTelaPrincipalMedico   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Agenda_WPF.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AGENDA WPF - Médico��5	   
   $	��720��6&   $
��1020��63    � WindowState$ 	Maximized=�6@   .��5
      � .+�5   
   �� -   5        $��lblMedLogado��5      $�� ��6$   $
��Left=�6/   $��
204,13,0,0q�6J   $	��Top=�6^   ]� 5   
   -   5        $��mn_Principal��5      $
��Left=�6(   $��Center=�6D   $	��190��6_   $	��704��6k   ���	#FF5AABFA.+�5      �� $��/unnamed.png��6   $	��Top=�6*   �� 5      -   5        $��btnProntuario��5      $��Prontuário do Paciente��6*   $
��Left=�6K   $��30��6m   $	��Top=�6y   �� 5      -   5        $��btnImpressaoReceita��5      $��Imprimir Receita��60   $
��Left=�6K   $��30��6m   $	��Top=�6y   �� 5      -   5        $��	btnFechar��5      $��Fechar��6&   $��30��67   $	��Top=�6C   6X   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtgAgendaMedico��5         CanUserAddRows$ False��5         CanUserDeleteRows$ False��6*      
IsReadOnly$
 true��6D      AutoGenerateColumns$ False��5      $
��Left=�6/   $	��390��6J   $	��760��6W   $��206,130,0,0q�6c   $	��Top=�6x   ��5   V   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Paciente��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 67   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   %   �� *
Paciente+  5      $ Data Agendada��6%   $	 1* 6<   
 5   %   �� *DataAgendada+  5      $
 Hora��6%   $	 1* 63   
 5   %   �� *HoraAgendada+  5      $ Plano��6%   $	 1* 64   
 5   %   �� *Plano+5       5!      5"      