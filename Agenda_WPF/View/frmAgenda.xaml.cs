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

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.operacao = "cancelar";
           
        }
    }
}
