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
    /// Lógica de interacción para AsignacionCama.xaml
    /// </summary>
    public partial class AsignacionCama : MetroWindow
    {
        public AsignacionCama()
        {
            InitializeComponent();
            DGPacienteCama.ItemsSource = servicio.MostrarPacienteCama();
            DGPacienteCama.Items.Refresh();
            txtid.IsEnabled = false;
            DGCAMA.ItemsSource = servicio.MostrarCama();
            DGCAMA.Items.Refresh();
            
        }
        Service1Client servicio = new Service1Client();
        PacienteCamaEN pc = new PacienteCamaEN();
   
        

        private async void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            pc.FechaAsignada = txtfecha.Text;
            pc.FkHistoria = Convert.ToInt64(chistorial.SelectedValue);
            pc.FkCama = Convert.ToInt64(ccama.SelectedValue);
           

            int resultado = servicio.AgregarCamaAPaciente(pc);
            if (resultado >= 1)
            {
                await this.ShowMessageAsync("Excelente","Agregado" );
                DGPacienteCama.ItemsSource = servicio.MostrarPacienteCama();
                DGPacienteCama.Items.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private async void btnmodificar_Click(object sender, RoutedEventArgs e)
        {
            pc.IdPacienteCama = Convert.ToInt64(txtid.Text);
            pc.FechaAsignada = txtfecha.Text;
            pc.FkHistoria = Convert.ToInt64(chistorial.SelectedValue);
            pc.FkCama = Convert.ToInt64(ccama.SelectedValue);


            int resultado = servicio.ActualizarCamaAPaciente(pc);
            if (resultado >= 1)
            {
                await this.ShowMessageAsync("Excelente", "Modificado");
                DGPacienteCama.ItemsSource = servicio.MostrarPacienteCama();
                DGPacienteCama.Items.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private async void btneliminar_Click(object sender, RoutedEventArgs e)
        {
          
            pc.FechaAsignada = txteliminar.Text;


            int resultado = servicio.EliminarCamaAPaciente(pc);
            if (resultado >= 1)
            {
                await this.ShowMessageAsync("Excelente", "Eliminado");
                DGPacienteCama.ItemsSource = servicio.MostrarPacienteCama();
                DGPacienteCama.Items.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private async void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!(txtbuscar.Text == ""))
            {
                pc.FechaAsignada = txtbuscar.Text;
                DGPacienteCama.ItemsSource = servicio.BuscraCamaPacientePorFecha(pc);
                DGPacienteCama.Items.Refresh();
                await this.ShowMessageAsync("Excelente", "Eliminado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void DGPacienteCama_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PacienteCamaEN me = (PacienteCamaEN)DGPacienteCama.SelectedItems[0];
            
            txtid.Text = me.IdPacienteCama.ToString();
            //txtidCama.Text = me.FkCama.ToString();
            //txtidhistorial.Text = me.FkHistoria.ToString();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Historia1 i = new Historia1();
            Close();
            
        }

        private void MetroWindow_Initialized(object sender, EventArgs e)
        {

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            chistorial.ItemsSource = servicio.MostrarHistorial().ToList();
            chistorial.DisplayMemberPath = "IdHistorial";
            chistorial.SelectedValuePath = "IdHistorial";

            ccama.ItemsSource = servicio.MostrarCama().ToList();
            ccama.DisplayMemberPath = "IdCama";
            ccama.SelectedValuePath = "IdCama";
        }

        private void chistorial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
