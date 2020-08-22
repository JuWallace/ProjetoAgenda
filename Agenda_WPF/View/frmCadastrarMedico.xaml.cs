using Agenda_WPF.Model;
using Correios.Net;
using System;
using System.Windows;

namespace Agenda_WPF.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarMedico.xaml
    /// </summary>
    public partial class frmCadastrarMedico : Window
    {
        private string operacao;
        public frmCadastrarMedico()
        {
            InitializeComponent();
        }

        
        private void LimpaCampos()
        {

            txtNome.IsEnabled = true;
            txtCpf.IsEnabled = true;
            txtCrm.IsEnabled = true;
            txtTelefone.IsEnabled = true;
            txtEmail.IsEnabled = true;
            txtEspecialidade.IsEnabled = true;


            txtNome.Clear();
            txtCpf.Clear();
            txtCrm.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEspecialidade.Clear();

        
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            using (Context ctx = new Context())
            {
                Medico m = new Medico();
                m.NomeMedico = txtNome.Text;
                m.Cpf = txtCpf.Text;
                m.Crm = txtCrm.Text;
                m.Telefone = txtTelefone.Text;
                m.Email = txtEmail.Text;
                m.Especialidade = txtEspecialidade.Text;

                if (operacao == "inserir")
                {
                    Context context = new Context();
                    {
                        context.Medicos.Add(m);
                        context.SaveChanges();
                    }

                }
                if (operacao == "alterar")
                {
                    {
                        ctx.Medicos.Add(m);
                        ctx.SaveChanges();
                    }
                }

                //this.ListarDados();
                this.AlteraBotoes(1);
                this.LimpaCampos();

            }


        }
        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);

        }

        //private void ListarDados(int op)
        //{
        //    this.ListarDados();
        //}
        //private void ListarDados()
        //{
        //    Context ctx = new Context();
        //    {
        //        var consulta = ctx.Pacientes;
        //        dgDados.ItemsSource = consulta.ToList();
        //    }
        //}

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

           

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

    
    }

}
