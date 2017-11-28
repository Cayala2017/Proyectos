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
using System.IO;
using Microsoft.Win32;

namespace InterfacesMatasanos
{
    /// <summary>
    /// Lógica de interacción para Pacientes.xaml
    /// </summary>
    public partial class Pacientes : MetroWindow
    {

        Service1Client Servicio = new Service1Client();
        PacienteEN paciente = new PacienteEN();

        public Pacientes()
        {
            InitializeComponent();
            DGHistorial.ItemsSource = Servicio.MostrarPaciente();
            DGHistorial.Items.Refresh();
            cbEstado.Items.Add("Ingresado");
            cbEstado.Items.Add("De Alta");

        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            paciente.Dni = txtdni.Text;
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.FechaNacimiento = Fecha.Text;
            paciente.Estado = cbEstado.Text;

            String resultado = Servicio.AgregarPaciente(paciente);
            if (resultado == "Paciente Registrado.")
            {
                await this.ShowMessageAsync("Excelente", "Agregado");
                DGHistorial.ItemsSource = Servicio.MostrarPaciente();
                DGHistorial.Items.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void DGHistorial_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PacienteEN me = (PacienteEN)DGHistorial.SelectedItems[0];

            //medico  = DGMedico.SelectedItem as MedicoEN;
            //Foto.ImageFailed = medico.Imagenes();
            txtid.Text = me.IdNumeroSeguro.ToString();
            txtNombre.Text = me.Nombre.ToString();
            txtApellido.Text = me.Apellido.ToString();
        }

        private async void btnmodificar_Click(object sender, RoutedEventArgs e)
        {
            paciente.IdNumeroSeguro = Convert.ToInt64(txtid.Text);
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.FechaNacimiento = Fecha.Text;
            paciente.Estado = cbEstado.Text;


            int resultado = Servicio.ActualizarPaciente(paciente);
            if (resultado >= 1)
            {
                await this.ShowMessageAsync("Excelente", "Modificado");
                DGHistorial.ItemsSource = Servicio.MostrarPaciente();
                DGHistorial.Items.Refresh();
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
                paciente.Dni = txtbuscar.Text;
                DGHistorial.ItemsSource = Servicio.BuscarPacientePordni(paciente);
                DGHistorial.Items.Refresh();
                await this.ShowMessageAsync("Excelente", "Paciente Encontrado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void DGHistorial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }
    }
}
