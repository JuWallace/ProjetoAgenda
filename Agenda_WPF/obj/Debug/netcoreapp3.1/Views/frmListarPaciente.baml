   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Agenda_WPF.ViewsAgenda_WPF.Views  5   	   (    "Agenda_WPF.Views.frmListarPaciente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Agenda_WPF.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Listar Paciente - AGENDA��5	   	   $	��720��6*   $
��1020��67   .��5
      � .+�5   
   ]� -   5        $��mn_Principal��5      $
��Left=�6(   $��Center=�6D   $	��190��6_   $	��704��6k   ���	#FF5AABFA.+�5      �� $��/unnamed.png��6   $	��Top=�6*   �� 5      -   5        $��btn_CadastrarPaciente��5      $��Cadastrar Paciente��62   $
��Left=�6O   $��30��6q   $	��Top=�6}   6�   �� 5      -   5        $��btn_ListarPaciente��5      $��Listar Paciente��6/   $
��Left=�6I   $��30��6k   $	��Top=�6w   6�   �� 5      -   5        $��btn_AgendarConsulta��5      $��Agendar Consulta��60   $
��Left=�6K   $��30��6m   $	��Top=�6y   �� 5      -   5        $��btn_ListarConsulta��5      $��Listar Consulta��6/   $
��Left=�6I   $��30��6k   $	��Top=�6w   �� 5      -   5        $��btn_AlterarPaciente��5      $��Atualizar Dados Paciente��60   $
��Left=�6S   $��30��6u   $	��Top=�6�   �� 5      -   5        $��btn_AlterarAgendamento��5      $��Alterar Agendamento��63   $
��Left=�6Q   $��30��6s   $	��Top=�6   �� 5      -	   5        $��btn_ImpressaoDeclaracao��5      $��Imprimir Declaração��64   $
��Left=�6R   $��30��6t   $	��Top=�6�   �� 5      -
   5        $��
btn_Fechar��5      $��Fechar��6'   $��Center=�68   $��30��6\   $	��Top=�6h   6}   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtgPacientes��5         AutoGenerateColumns$ False��6'   $��213,99,30,102q�6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nome Paciente��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *Nome+  5      $ Telefone��6%   $ 1* 67    5   %   �� *
Telefone+  5      $ Celular��6%   $ 1* 66    5   %   �� *	Celular+  5       $
 Peso��6%   $ 1* 63    5!   %   �� *Peso+  5"      $ E-mail��6%   $ 1* 65    5#   %   �� *Email+  5$      $ Plano��6%   $ 1* 64    5%   %   �� *	NomePlano+5)      �� 5+   
   -   5        $��lblNome��5+      $��Nome:��6   $
��Left=�6/   $��
409,20,0,0q�6J   $	��Top=�6^   �� 5,   
   -   5        $��txtNome��5,      $
��Left=�6!   $��
457,20,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��533��6|   $��26��6�   �� 5-   
   -   5        $��lblIdPaciente��5-      $
��Id: ��6%   $
��Left=�64   $��
221,20,0,0q�6O   $	��Top=�6c   �� 5.   
   -   5        $��txtIdPaciente��5.      $
��Left=�6'   $��
252,20,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��130��6�   $��26��6�   �� 5/   
   -   5        $��lblCpf��5/      $
��CPF:��6   $
��Left=�6-   $��
219,51,0,0q�6H   $	��Top=�6\   �� 50   
   -   5        $��txtCpf��50      $
��Left=�6!   $��
267,51,0,0q�6<   $
 Wrap=�6P   $	��Top=�6d   $	��127��6|   $��26��6�   �� 51   
   -   5        $��lblTelefone��51      $��	Telefone:��6#   $
��Left=�67   $��
417,51,0,0q�6R   $	��Top=�6f   �� 52   
   -   5        $��txtTelefone��52      $
��Left=�6&   $��
473,51,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��138��6�   $��26��6�   �� 53   
   -   5        $��lblEmail��53      $��E-mail:��6    $
��Left=�62   $��
639,51,0,0q�6M   $	��Top=�6a   $��50��6y   �� 54   
   -   5        $��txtEmail��54      $
��Left=�6#   $��
694,51,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��296��6~   $��26��6�   �� 57   
   -   5        $��btnCadastrar��57      $��	Cadastrar��6%   $��Center=�69   $
��Left=�6[   $��270,629,0,0q�6v   $	��Top=�6�   $��95��6�   6�   �� 58   
   -   5        $��
btnAlterar��58      $��Alterar��6#   $��Center=�65   $
��Left=�6W   $��375,629,0,0q�6r   $	��Top=�6�   $��95��6�   �� 59   
   -   5        $��btnLocalizar��59      $��	Localizar��6%   $��Center=�69   $
��Left=�6[   $��480,629,0,0q�6v   $	��Top=�6�   $��95��6�   �� 5:   
   -   5        $��
btnExcluir��5:      $��Excluir��6#   $��Center=�65   $
��Left=�6W   $��586,629,0,0q�6r   $	��Top=�6�   $��95��6�   �� 5;   
   -   5        $��btnCancelar��5;      $��Cancelar��6$   $��Center=�67   $
��Left=�6Y   $��692,629,0,0q�6t   $	��Top=�6�   $��95��6�   6�   5>      5?      