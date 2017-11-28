using System;
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
using InterfacesMatasanos.ServiceReference1;
using System.IO;
using Microsoft.Win32;

namespace InterfacesMatasanos
{
    /// <summary>
    /// Lógica de interacción para ListadeMedicos.xaml
    /// </summary>
    public partial class ListadeMedicos : Window
    {
        Service1Client Servicio = new Service1Client();
        MedicoEN medico = new MedicoEN();

        public ListadeMedicos()
        {
            InitializeComponent();
           
            DGMedico.ItemsSource = Servicio.MostrarMedico();
            DGMedico.Items.Refresh();
        }
    }
}
