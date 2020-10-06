﻿using Agenda_WPF.Views;
using NewAgenda_WPF.Views;
using System;
using System.Windows;

namespace Agenda_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string UsrLogin)
        {
            InitializeComponent();
            lblUsrLogado.Content = $"Seja bem vindo(a) {UsrLogin}!";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a janela:", "Agenda_WPF",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarUsuario CadUsuario = new frmCadastrarUsuario();
            CadUsuario.ShowDialog();
        }

        private void btnCadastrarMedico_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarMedico CadMedico = new frmCadastrarMedico();
            CadMedico.ShowDialog();
        }

        private void btnCadastrarPaciente_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarPaciente frm = new frmCadastrarPaciente();
            frm.ShowDialog();
        }

        private void btnListarPaciente_Click(object sender, RoutedEventArgs e)
        {
            frmListarPaciente frm = new frmListarPaciente();
            frm.ShowDialog();
        }

        private void btnEncerrarSistema_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnListarUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmListarUsuario listarUsuario = new frmListarUsuario();
            listarUsuario.ShowDialog();
        }

        private void btnListarMedico_Click(object sender, RoutedEventArgs e)
        {
            frmListarMedico listarMedico = new frmListarMedico();
            listarMedico.ShowDialog();
        }

        private void btnAgendarConsulta_Click(object sender, RoutedEventArgs e)
        {
            //frmAgenda agenda = new frmAgenda();
            //agenda.ShowDialog();
            frmTelaPrincipalRecepcionista agendarConsulta = new frmTelaPrincipalRecepcionista();
            agendarConsulta.ShowDialog();
        }

        private void btnProntuario_Click(object sender, RoutedEventArgs e)
        {
            frmProntuario prontuario = new frmProntuario();
            prontuario.ShowDialog();
        }

        private void btnListarProntuario_Click(object sender, RoutedEventArgs e)
        {
            frmListarProntuario listarProntuario = new frmListarProntuario();
            listarProntuario.ShowDialog();
        }

        private void btnCadastrarPlanoSaude_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarPlanoSaude cadastrarPlanoSaude = new frmCadastrarPlanoSaude();
            cadastrarPlanoSaude.ShowDialog();
        }

        private void btnCadastrarProcedimento_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarProcedimento cadastrarProcedimento = new frmCadastrarProcedimento();
            cadastrarProcedimento.ShowDialog();
        }
    }
}
