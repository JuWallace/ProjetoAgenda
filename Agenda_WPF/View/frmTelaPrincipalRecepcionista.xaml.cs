﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Agenda_WPF.View
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

        private void btn_Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_ImpressaoDeclaracao_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
