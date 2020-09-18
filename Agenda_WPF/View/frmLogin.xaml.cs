﻿using Agenda_WPF.DAL;
using Agenda_WPF.Model;
using System.Windows;


namespace Agenda_WPF.View
{
    /// <summary>
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
            txtEmailLogin.Focus();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Usuario u = new Usuario();
            u.Email = txtEmailLogin.Text;

            var usr = UsuarioDAO.ValidaLogin(u.Email);
            if (usr == null)
            {
                MessageBox.Show($"Informe um LOGIN válido!");
            }
            else if (usr.Email == txtEmailLogin.Text && usr.Senha == pwdSenhaLogin.Password)
            {
                if (usr.Administrador == true)
                {
                    MainWindow principal = new MainWindow(usr.Nome);
                    principal.Show();
                    this.Close();
                }
                else if (usr.Medico == true)
                {
                    frmTelaPrincipalMedico viewMedico = new frmTelaPrincipalMedico(usr.Nome);
                    viewMedico.Show();
                    this.Close();
                }
                else
                {
                    frmTelaPrincipalRecepcionista viewAtendente = new frmTelaPrincipalRecepcionista(usr.Nome);
                    viewAtendente.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Usuário e ou Senha Inválido(a)!!");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
