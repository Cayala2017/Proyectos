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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using InterfacesMatasanos.ServiceReference1;

namespace InterfacesMatasanos
{
    /// <summary>
    /// Lógica de interacción para Historia1.xaml
    /// </summary>
    public partial class Historia1 : MetroWindow
    {
        
        public Historia1()
        {
            InitializeComponent();
            DGHistorial.ItemsSource = servicio.MostrarHistorial();
            DGHistorial.Items.Refresh();
            btnIngresar.IsEnabled = false;
        }

        Service1Client servicio = new Service1Client();
        HistorialEN history = new HistorialEN();
        PacienteEN paciente = new PacienteEN();
       
        public void limpiar()
        {
            txtid.Text = "";
            txtseguro.Text = "";
            
         
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            history.FechaEntrada = DTfechaEntrada.Text;
            history.FkNumeroSeguro = Convert.ToInt64(txtseguro.Text);
            history.FechaAlta = DTfechasalida.Text;

            int resultado = servicio.AgregarHistorial(history);

            if (resultado >=1)
            {
                await this.ShowMessageAsync("Se agrego la Historia", "Por favor asignele una cama al paciente");
                DGHistorial.ItemsSource = servicio.MostrarHistorial();
                DGHistorial.Items.Refresh();
                btnIngresar.IsEnabled = true;
                limpiar();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            txtseguro.Text = "";
        }

        private void DGHistorial_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //PacienteEN me = (PacienteEN)DGHistorial.SelectedItems[0];

            //medico  = DGMedico.SelectedItem as MedicoEN;
            //Foto.ImageFailed = medico.Imagenes();
            //txtid.Text = me.IdHistoria.ToString();
            //txtseguro.Text = me.IdNumeroSeguro.ToString();
            //lApellido.Text = me.Apellido.ToString();
            //lNombre.Text = me.Nombre.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PacientesLista P = new PacientesLista();
            P.Show();
        }
   
        private void MetroWindow_Activated(object sender, EventArgs e)
        {

        }

        public void LlenarTextBox()
        {
            PacientesLista lista = new PacientesLista();
            PacienteEN me = (PacienteEN)lista.DGHistoriales.SelectedItems[0];

            //medico  = DGMedico.SelectedItem as MedicoEN;
            //Foto.ImageFailed = medico.Imagenes();
            txtid.Text = me.IdNumeroSeguro.ToString();
            lNombre.Text = me.Nombre.ToString();
            lApellido.Text = me.Apellido.ToString();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            AsignacionCama A = new AsignacionCama();
            A.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            this.Close();
        }
    }
}
