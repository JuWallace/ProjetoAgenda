   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Agenda_WPF.ViewsAgenda_WPF.Views  5   	   '    !Agenda_WPF.Views.frmListarUsuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Agenda_WPF.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$' !AGENDA MÉDICA - Listar Usuários��5
   	   $	��720��61   $
��1020��6>   .��5      � .+�5   
   �� -   5         ��Name$ lblUsrLogado��5      $�� ��6&   $
��Left=�61   $��
196,12,0,0q�6L   $	��Top=�6`   $��23��6x   ]� 5   
   -   5         ]�Name$ mn_Principal��5      $
��Left=�6*   $��Center=�6F   $	��190��6a   $	��690��6m   ���	#FF5AABFA.+�5      �� -   5         ��Name$ imgAngio��5      $��/Imgs/unnamed.png��6&   $	��Top=�6B   �� 5!      -   5         ��Name$ 	btnFechar��5!      $��Fechar��6(   $��30��69   $	��Top=�6E   6Z   5#      �� 5%   
   $1��+Selecione um tipo de busca e insira abaixo:��6   $
��Left=�6F   $��
286,70,0,0q�6a   $	��Top=�6u   	� 5&   
   -   5         	�Name$ rdoCpf��5&      $	��CPF��6&   $
��Left=�64   $��
208,61,0,0q�6O   $	��Top=�6c   6{   	� 5'   
   -   5        $ rdoEmail��5'      $��E-MAIL��6(   $
��Left=�69   $��
208,81,0,0q�6T   $	��Top=�6h   6�   	� 5(   
   -   5        $ rdoNome��5(      $
��NOME��6'   $
��Left=�66   $��208,103,0,0q�6Q   $	��Top=�6f   6~   &   System.Windows.Controls.DataGrid  5)   
   -	   5          Name$ dtgListaUsuarios��5)         AutoGenerateColumns$ False��6-   	 �� AlternationCount$	 2��6I   
   RowBackground

 �����   AlternatingRowBackground
 ��ح�$
��Left=�5*      $	��390��6.   $��206,130,0,0q�6;   $	��Top=�6P   $	��760��6h      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5-   %   �� *Nome+  5.      $	 CPF��6%   $ 1* 62    5/   %   �� *Cpf+  50      $ RG��6%   $ 1* 61    51   %   �� *Rg+  52      $ Telefone��6%   $ 1* 67    53   %   �� *
Telefone+  54      $ Email��6%   $ 1* 64    55   %   �� *Email+  56      $ Data Nascimento��6%   $ 1* 6>    57   %   �� *
Nascimento+59      %  Xceed.Wpf.Toolkit.MaskedTextBox  5:   
   -
   5        $��mskCpf��5:      $��0��6+      Mask$ 999,999,999-99��68    �� 
CaretIndex$ 0��6N   4  .Xceed.Wpf.Toolkit.Primitives.ValueRangeTextBox   ValueDataType" ��6]   $
��Left=�5;      $y�Hidden=�68   $	��Top=�6L   $��
287,97,0,0q�6d   $��14(�6x   $��24��6�   $	��306��6�   $��Center=�5<      .��6A   5=      �� 5>   
   -   5         ��Name$ 	txtFiltro��5>      $
��Left=�6%   $��24��6@   $��
286,97,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��307��6�   �� 5?   
   -   5        $ 
btnFiltrar��5?      $��Filtrar��6%   $��Center=�67   $
��Left=�6Y   $��
600,97,0,0q�6t   $	��Top=�6�   $��75��6�   $��23��6�   6�   �� 5@   
   -   5        $��
btnAlterar��5@      $��Alterar��6#   $��Center=�65   $
��Left=�6W   $��375,629,0,0q�6r   $	��Top=�6�   $��95��6�   6�   �� 5A   
   -   5        $��
btnExcluir��5A      $��Excluir��6#   $��Center=�65   $
��Left=�6W   $��479,629,0,0q�6r   $	��Top=�6�   $��95��6�   6�   �� 5B   
   -   5        $��btnCancelar��5B      $��Cancelar��6$   $��Center=�67   $
��Left=�6Y   $��585,629,0,0q�6t   $	��Top=�6�   $��95��6�   6�   �� 5C   
   -   5        $ btnLimparFiltro��5C      $��Limpar��6*   $��Center=�6;   $
��Left=�6]   $��
682,97,0,0q�6x   $	��Top=�6�   $��75��6�   $��23��6�   6�   5E      5F      