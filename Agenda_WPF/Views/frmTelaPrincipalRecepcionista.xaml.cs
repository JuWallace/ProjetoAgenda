﻿using System.Windows;
using System.Windows.Input;

namespace Agenda_WPF.Views
{
    /// <summary>
    /// Interaction logic for frmTelaPrincipalRecepcionista.xaml
    /// </summary>
    public partial class frmTelaPrincipalRecepcionista : Window
    {
         public frmTelaPrincipalRecepcionista()
        {
            InitializeComponent();
        }
        public frmTelaPrincipalRecepcionista(string AteLogin)
        {
            InitializeComponent();
            lblAteLogado.Content = $"Seja bem vindo(a) {AteLogin}!";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtDta.Clear();
        }
        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn_ImpressaoDeclaracao_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnListarPaciente_Click(object sender, RoutedEventArgs e)
        {
            frmListarPaciente listarPaciente = new frmListarPaciente();
            listarPaciente.ShowDialog();
        }
        private void txtDta_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtDta.Text != null)
            {
                string teste = txtDta.Text;
                frmCadastrarPaciente cadastrarPaciente = new frmCadastrarPaciente();
                cadastrarPaciente.dtaConsulta = txtDta.Text;
                this.Close();
                cadastrarPaciente.ShowDialog();
                //txtDta.Clear();
                
            }
        }
        private void btnCadastrarPaciente_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarPaciente cadastrarPaciente = new frmCadastrarPaciente();
            cadastrarPaciente.ShowDialog();
        }
    }
}
