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
    /// Lógica de interacción para PacientesLista.xaml
    /// </summary>
    public partial class PacientesLista : Window
    {




        public PacientesLista()
        {
            InitializeComponent();
           
            DGHistoriales.ItemsSource = Servicio.MostrarPaciente();
            DGHistoriales.Items.Refresh();
        }

        Service1Client Servicio = new Service1Client();
        PacienteEN paciente = new PacienteEN();

        private void DGHistorial_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Historia1 H = new Historia1();
            PacienteEN me = (PacienteEN)DGHistoriales.SelectedItems[0];

            //medico  = DGMedico.SelectedItem as MedicoEN;
            //Foto.ImageFailed = medico.Imagenes();
            txtId.Text = me.IdNumeroSeguro.ToString();
            txtNombre.Text = me.Nombre.ToString();
           txtApellido.Text = me.Apellido.ToString();
           
        


           
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!(txtBuscar.Text == ""))
            {
                paciente.Dni = txtBuscar.Text;
                DGHistoriales.ItemsSource = Servicio.BuscarPacientePordni(paciente);
                DGHistoriales.Items.Refresh();
                MessageBox.Show("Paciente Encontrado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Historia1 H = new Historia1();
            H.txtseguro.Text = txtId.Text;
            H.lNombre.Text = txtNombre.Text;
            H.lApellido.Text = txtApellido.Text;

            H.Show();
            this.Close();

        }

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
