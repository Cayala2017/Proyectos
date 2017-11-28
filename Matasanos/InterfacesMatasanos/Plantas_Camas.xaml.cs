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
    /// Lógica de interacción para Plantas_Camas.xaml
    /// </summary>
    public partial class Plantas_Camas : Window
    {
        public Plantas_Camas()
        {
            InitializeComponent();
            dgcama.ItemsSource = servicio.MostraPlantas();
            dgcama.Items.Refresh();
            dgplanta.ItemsSource = servicio.MostrarCama();
            dgplanta.Items.Refresh();
        }
        Service1Client servicio = new Service1Client();
        PlantaEN p = new PlantaEN();
        CamaEN c = new CamaEN();

        private void btnAgregarPlanta_Click(object sender, RoutedEventArgs e)
        {
            p.Nombre = txtnombre.Text;
            p.NumeroCamas = Convert.ToInt32(txtnumero.Text);

            String resultado = servicio.AgregarPlanta(p);
            if (resultado == "Ingresado Correctamente.")
            {

                dgplanta.ItemsSource = servicio.MostrarCama();
                dgplanta.Items.Refresh();
                MessageBox.Show("Exelente");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }

        private void btnAgregarCama_Click(object sender, RoutedEventArgs e)
        {
            c.FkPlanta = Convert.ToInt64(txtfkplanta.Text);

            int _resultado = servicio.AgregarCama(c);
            if (_resultado >= 1)
            {
                dgcama.ItemsSource = servicio.MostraPlantas();
                dgcama.Items.Refresh();
                MessageBox.Show("Exelente");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnatras_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }
    }
}
