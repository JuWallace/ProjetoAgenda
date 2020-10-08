using Agenda_WPF.DAL;
using Agenda_WPF.Model;
using System.Linq;
using System.Windows;


namespace Agenda_WPF.Views
{
    /// <summary>
    /// Interaction logic for frmListarUsuario.xaml
    /// </summary>
    public partial class frmListarUsuario : Window
    {
        Context ctx = SingletonContext.GetInstance();
        public frmListarUsuario()
        {
            InitializeComponent();
        }

        // ================ INÍCIO MÉTODOS ================

        private void CarregaLista()
        {
            var usuario = ctx.Usuarios;
            dtgListaUsuarios.ItemsSource = usuario.ToList();
        }
        private void ControleBotoes(int op)
        {
            if (op == 1) //default
            {
                btnAlterar.IsEnabled = true;
                btnExcluir.IsEnabled = false;
                btnCancelar.IsEnabled = false;

                mskCpf.IsEnabled = false;
                txtFiltro.IsEnabled = false;
            }
            if (op == 2) // Alterar
            {
                btnAlterar.IsEnabled = true;
                btnAlterar.Focus();
                btnExcluir.IsEnabled = true;
                btnCancelar.IsEnabled = true;

                mskCpf.IsEnabled = false;
                txtFiltro.IsEnabled = false;
            }
            if (op == 3) // Excluir
            {
                btnAlterar.IsEnabled = false;
                btnExcluir.IsEnabled = true;
                btnExcluir.Focus();
                btnCancelar.IsEnabled = true;

                mskCpf.IsEnabled = false;
                txtFiltro.IsEnabled = false;
            }
        }
        private void ControleFiltro(int op)
        {
            if (op == 1) //default disable
            {
                mskCpf.Visibility = Visibility.Hidden;
                mskCpf.IsEnabled = false;
                txtFiltro.Visibility = Visibility.Hidden;
                txtFiltro.IsEnabled = false;
            }
            if (op == 2) //Cpf true, Filtro false
            {
                mskCpf.Visibility = Visibility.Visible;
                mskCpf.IsEnabled = true;
                mskCpf.Focus();
                txtFiltro.Visibility = Visibility.Hidden;
                txtFiltro.IsEnabled = false;
            }
            if (op == 3) //Filtro true, Cpf false
            {
                mskCpf.Visibility = Visibility.Hidden;
                mskCpf.IsEnabled = false;
                txtFiltro.Visibility = Visibility.Visible;
                txtFiltro.IsEnabled = true;
                txtFiltro.Focus();
            }
        }
        private void Filtrar()
        {
            if (rdoCpf.IsChecked == true)
            {
                var FiltroCpf = ctx.Usuarios.Where(x => x.Cpf.Contains(mskCpf.Text));
                dtgListaUsuarios.ItemsSource = FiltroCpf.ToList();
            }
            else if (rdoEmail.IsChecked == true)
            {
                var FiltroEmail = ctx.Usuarios.Where(x => x.Email.Contains(txtFiltro.Text));
                dtgListaUsuarios.ItemsSource = FiltroEmail.ToList();
            }
            else if (rdoNome.IsChecked == true)
            {
                var FiltroNome = ctx.Usuarios.Where(x => x.Nome.Contains(txtFiltro.Text));
                dtgListaUsuarios.ItemsSource = FiltroNome.ToList();
            }
            else
            {
                MessageBox.Show("Por favor selecione um tipo de filtro!!");
            }
        }

        // ================ FIM MÉTODOS ================


        private void Windos_Loaded(object sender, RoutedEventArgs e)
        {
            CarregaLista();
            ControleBotoes(1);
            ControleFiltro(1);

        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            Filtrar();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            ControleBotoes(1);
            ControleFiltro(1);
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }
        private void rdoCpf_Checked(object sender, RoutedEventArgs e)
        {
            if (rdoCpf.IsChecked == true)
            {
                ControleFiltro(2);
            }
        }

        private void rdoEmail_Checked(object sender, RoutedEventArgs e)
        {
            if (rdoEmail.IsChecked == true)
            {
                ControleFiltro(3);
            }
        }

        private void rdoNome_Checked(object sender, RoutedEventArgs e)
        {
            if (rdoNome.IsChecked == true)
            {
                ControleFiltro(3);
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            rdoCpf.IsChecked = false;
            rdoEmail.IsChecked = false;
            rdoNome.IsChecked = false;
            ControleFiltro(1);
            CarregaLista();

        }
    }
}
