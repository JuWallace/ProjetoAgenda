using Agenda_WPF.DAL;
using Agenda_WPF.Model;
using System.Linq;
using System.Windows;


namespace Agenda_WPF.View
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
            FormLoad();
        }
        private void FormLoad()
        {
            var consulta = ctx.Usuarios;
            dtgListaUsuarios.ItemsSource = consulta.ToList();

            rdoCpf.IsChecked = false;
            rdoEmail.IsChecked = false;
            rdoNome.IsChecked = false;

        }

        private void btnSairListar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            if (rdoCpf.IsChecked == true)
            {
                var FiltroCpf = ctx.Usuarios.Where(x => x.Cpf.Contains(txtFiltro.Text));
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
    }
}
