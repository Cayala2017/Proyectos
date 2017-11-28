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

namespace InterfacesMatasanos
{
    /// <summary>
    /// Lógica de interacción para ListadeHistorias.xaml
    /// </summary>
    public partial class ListadeHistorias : Window
    {
        public ListadeHistorias()
        {
            InitializeComponent();
            dgvista.ItemsSource = servicio.MostrarVisita();
            dgvista.Items.Refresh();
        }
        Service1Client servicio = new Service1Client();

        VisitaMedicaEN Vm = new VisitaMedicaEN();


    private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!(dtFecha.Text == ""))
            {
                Vm.FkPacienteCama = Convert.ToInt32(dtFecha.Text);
                dgvista.ItemsSource = servicio.BuscarVisita(Vm);
                dgvista.Items.Refresh();
                MessageBox.Show("Encontrado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
