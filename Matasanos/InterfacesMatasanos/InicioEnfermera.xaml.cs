﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace InterfacesMatasanos
{
    /// <summary>
    /// Lógica de interacción para InicioEnfermera.xaml
    /// </summary>
    public partial class InicioEnfermera : MetroWindow
    {
        public InicioEnfermera()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            Pacientes P = new Pacientes();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            ListadeHistorias L = new ListadeHistorias();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}