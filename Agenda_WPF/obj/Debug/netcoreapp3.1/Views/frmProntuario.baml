   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Agenda_WPF.ViewsAgenda_WPF.Views  5   	   $    Agenda_WPF.Views.frmProntuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Agenda_WPF.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AGENDA WPF - Prontuário��5	   	   $	��720��6)   $
��1020��66   .��5
      � .+�5   
   �� -   5        $��lblMedLogado��5      $�� ��6$   $
��Left=�6/   $��
204,13,0,0q�6J   $	��Top=�6^   ]� 5   
   -   5        $��mn_Principal��5      $
��Left=�6(   $��Center=�6D   $	��190��6_   $	��704��6k   ���	#FF5AABFA.+�5      �� $��/unnamed.png��6   $	��Top=�6*   �� 5      -   5        $��btnProntuario��5      $��Prontuário do Paciente��6*   $
��Left=�6K   $��30��6m   $	��Top=�6y   �� 5      -   5        $��btnImpressaoReceita��5      $��Imprimir Receita��60   $
��Left=�6K   $��30��6m   $	��Top=�6y   �� 5      -   5        $��	btnFechar��5      $��Fechar��6&   $��30��67   $	��Top=�6C   6X   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtgAgendaMedico��5      $
��Left=�6*   $	��170��6E   $	��815��6R   $��
195,10,0,0q�6^   $	��Top=�6r   �� 5   
   -   5         ��Name$ lblIdProntuario��5      $
��Id: ��6)   $
��Left=�68   $��204,192,0,0q�6S   $	��Top=�6h   �� 5   
   -	   5         ��Name$ txtIdProntuario��5      $
��Left=�6+   $��25��6F   $��204,216,0,0q�6R   $�� ��6g    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $��63��6�   ${�False��6�   �� 5   
   -
   5        $ lblPaciente��5      $��
Paciente: ��6%   $
��Left=�6:   $��280,192,0,0q�6U   $	��Top=�6j   �� 5   
   -   5        $ txtPaciente��5      ${�False��6'   $
��Left=�69   $��25��6T   $��284,216,0,0q�6`   $�� ��6u   $
 Wrap=�6}   $	��Top=�6�   $	��242��6�   �� 5   
   -   5        $ 	lblMedico��5      $��Medico: ��6#   $
��Left=�66   $��575,192,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $ lblConsulta��5      $��Data da Consulta: ��6%   $
��Left=�6B   $��861,192,0,0q�6]   $	��Top=�6r   �� 5   
   -   5        $ txtConsulta��5      $
��Left=�6'   $��861,216,0,0q�6B   $�� ��6W   $
 Wrap=�6_   $	��Top=�6s   $	��149��6�   ${�False��6�   �� 5   
   -   5        $ lblSintomas��5      $��
Sintomas: ��6%   $
��Left=�6:   $��200,264,0,0q�6U   $	��Top=�6j   �� 5   
   -   5        $ txtSintomas��5      $
��Left=�6'   $	��170��6B   $��204,293,0,0q�6O   $�� ��6d   $
 Wrap=�6l   $	��Top=�6�   $	��394��6�   �� 5    
   -   5        $ lblMedicamentos��5       $��Medicamentos:��6)   $
��Left=�6A   $��204,489,0,0q�6\   $	��Top=�6q   �� 5!   
   -   5        $ txtMedicamentos��5!      $
��Left=�6+   $��97��6F   $��208,518,0,0q�6R   $�� ��6g   $
 Wrap=�6o   $	��Top=�6�   $	��394��6�   �� 5"   
   -   5        $ lblAvaliacao��5"      $��Avaliação:��6&   $
��Left=�6;   $��626,264,0,0q�6V   $	��Top=�6k   $��39��6�   �� 5#   
   -   5        $ txtAvaliacao��5#      $
��Left=�6(   $	��322��6C   $��626,293,0,0q�6P   $�� ��6e   $
 Wrap=�6m   $	��Top=�6�   $	��384��6�   �� 5%   
   -   5        $��btnCadastrarProntuario��5%      $��Cadastrar Prontuário��6/   $
��Left=�6N   $��30��6p   $	��Top=�6|   $��838,664,10,10q�6�   �� 5&   
   -   5        $ 	txtMedico��5&      ${�False��6%   $
��Left=�67   $��25��6R   $��573,216,0,0q�6^   $�� ��6s   $
 Wrap=�6{   $	��Top=�6�   $	��242��6�   5(      5)      