using System.Windows;

namespace Agenda_WPF.View
{
    /// <summary>
    /// Interaction logic for frmListarAgenda.xaml
    /// </summary>
    public partial class frmListarAgenda : Window
    {
        private string operacao;
        public frmListarAgenda()
        {
            InitializeComponent();
        }
        private void AlteraBotoes(int op)
        {
            btnAlterar.IsEnabled = false;
            btnInserir.IsEnabled = false;
            btnExcluir.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnLocalizar.IsEnabled = false;
            btnSalvar.IsEnabled = false;

            if (op == 1)
            {
                //ativar as opções iniciais
                btnInserir.IsEnabled = true;
                btnLocalizar.IsEnabled = true;
            }
            if (op == 2)
            {
                //inserir um valor
                btnCancelar.IsEnabled = true;
                btnSalvar.IsEnabled = true;
            }
            if (op == 3)
            {
                btnAlterar.IsEnabled = true;
                btnExcluir.IsEnabled = true;
            }
        }
        //private void LimpaCampos()
        //{

        //    txtNome.IsEnabled = true;
        //    txtCpf.IsEnabled = true;
        //    txtRg.IsEnabled = true;
        //    dtNascimento.IsEnabled = true;
        //    txtTelefone.IsEnabled = true;
        //    txtEmail.IsEnabled = true;
        //    cboPlano.IsEnabled = true;
        //    txtNumplano.IsEnabled = true;
        //    txtRua.IsEnabled = true;
        //    txtNumero.IsEnabled = true;
        //    txtBairro.IsEnabled = true;
        //    txtCidade.IsEnabled = true;
        //    txtEstado.IsEnabled = true;
        //    txtCep_Leave.IsEnabled = true;

        //    txtNome.Clear();
        //    txtCpf.Clear();
        //    txtRg.Clear();
        //    dtNascimento.Clear();
        //    txtTelefone.Clear();
        //    txtEmail.Clear();

        //    txtNumplano.Clear();
        //    txtRua.Clear();
        //    txtNumero.Clear();
        //    txtBairro.Clear();
        //    txtCidade.Clear();
        //    txtEstado.Clear();
        //    txtCep_Leave.Clear();
        //}

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.AlteraBotoes(1);
          //  this.LimpaCampos();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }
    }
}
