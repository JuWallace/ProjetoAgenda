   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Agenda_WPF.ViewsAgenda_WPF.Views  5   	   *    $Agenda_WPF.Views.frmListarProntuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Agenda_WPF.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$$ AGENDA WPF - Listar Pronuário��5	   	   $	��720��6/   $
��1020��6<   .��5
      � .+�5   
   ]� -   5         ]�Name$ mn_Principal��5      $
��Left=�6*   $��Center=�6F   $	��190��6a   $	��704��6m   ���	#FF5AABFA.+�5      �� $��/unnamed.png��6   $	��Top=�6*   �� 5      -   5         ��Name$ btn_CadastrarPaciente��5      $��Cadastrar Paciente��64   $
��Left=�6Q   $��30��6s   $	��Top=�6   �� 5      -   5        $ btn_ListarPaciente��5      $��Listar Paciente��61   $
��Left=�6K   $��30��6m   $	��Top=�6y   �� 5      -   5        $ btn_AgendarConsulta��5      $��Agendar Consulta��62   $
��Left=�6M   $��30��6o   $	��Top=�6{   �� 5      -   5        $ btn_ListarConsulta��5      $��Listar Consulta��61   $
��Left=�6K   $��30��6m   $	��Top=�6y   �� 5      -   5        $ btn_AlterarPaciente��5      $��Atualizar Dados Paciente��62   $
��Left=�6U   $��30��6w   $	��Top=�6�   �� 5      -   5        $ btn_AlterarAgendamento��5      $��Alterar Agendamento��65   $
��Left=�6S   $��30��6u   $	��Top=�6�   �� 5      -	   5        $ btn_ImpressaoDeclaracao��5      $��Imprimir Declaração��66   $
��Left=�6T   $��30��6v   $	��Top=�6�   �� 5      -
   5        $ 
btn_Fechar��5      $��Fechar��6)   $��Center=�6:   $��30��6^   $	��Top=�6j   6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaProntuario��5         AutoGenerateColumns$ False��6*   $��213,99,30,102q�6F      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Data Consulta��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6<   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   %   �� *DataConsulta+  5      $ Nome Paciente��6%   $ 1* 6<   	 5   %   �� *Nome+  5      $ Sintomas��6%   $ 1* 67   	 5   %   �� *
Sintomas+  5       $ Avaliação��6%   $ 1* 68   	 5!   %   �� *	Avaliacao+  5"      $ Medicamento��6%   $ 1* 6:   	 5#   %   �� *Medicamento+  5$      $ Plano Daúde��6%   $ 1* 6:   	 5%   %   �� *
PlanoSaude+5)      �� 5+   
   -   5        
 ��Name$
 lblIdPaciente��5+      $
��Id: ��6'   $
��Left=�66   $��
221,20,0,0q�6Q   $	��Top=�6e   �� 5,   
   -   5         ��Name$ txtIdPaciente��5,      $
��Left=�6)   $��
252,20,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $��91��6�   $��24��6�   �� 5.   
   -   5        $
 lblNomePaciente��5.      $��Nome:��6)   $
��Left=�69   $��
374,20,0,0q�6T   $	��Top=�6h   �� 5/   
   -   5        $ txtNomePaciente��5/      $
��Left=�6+   $��
422,20,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��534��6�   $��26��6�   �� 50   
   -   5        $
 lblNomeMedico��50      $��Médico:��6'   $
��Left=�69   $��
213,49,0,0q�6T   $	��Top=�6h   �� 51   
   -   5         ��Name$ 	cboMedico��51      $��270,47,563,0q�6&   $	��Top=�6<   �� 55   
   -   5        $ btnCadastrar��55      $��	Cadastrar��6'   $��Center=�6;   $
��Left=�6]   $��270,629,0,0q�6x   $	��Top=�6�   $��95��6�   �� 56   
   -   5        $ 
btnAlterar��56      $��Alterar��6%   $��Center=�67   $
��Left=�6Y   $��375,629,0,0q�6t   $	��Top=�6�   $��95��6�   �� 57   
   -   5        $ btnLocalizar��57      $��	Localizar��6'   $��Center=�6;   $
��Left=�6]   $��480,629,0,0q�6x   $	��Top=�6�   $��95��6�   �� 58   
   -   5        $ 
btnExcluir��58      $��Excluir��6%   $��Center=�67   $
��Left=�6Y   $��586,629,0,0q�6t   $	��Top=�6�   $��95��6�   �� 59   
   -   5        $ btnCancelar��59      $��Cancelar��6&   $��Center=�69   $
��Left=�6[   $��692,629,0,0q�6v   $	��Top=�6�   $��95��6�   5<      5=      