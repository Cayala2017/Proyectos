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
    /// Lógica de interacción para Visita_Medica.xaml
    /// </summary>
    public partial class Visita_Medica : MetroWindow
    {
        public Visita_Medica()
        {
            InitializeComponent();
            dgvista.ItemsSource = servicio.MostrarVisita();
            dgvista.Items.Refresh();
        }
        Service1Client servicio = new Service1Client();

        VisitaMedicaEN Vm = new VisitaMedicaEN();
       
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            cbmedico.ItemsSource = servicio.MostrarMedico().ToList();
            cbmedico.DisplayMemberPath = "IdMedico";
            cbmedico.SelectedValuePath = "IdMedico";

            cbpaciente.ItemsSource = servicio.MostrarPacienteCama().ToList();
            cbpaciente.DisplayMemberPath = "IdPacienteCama";
            cbpaciente.SelectedValuePath = "IdPacienteCama";
        }

        private async void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            
            Vm.Daignostico = txtdiagnostico.Text;
            Vm.FkMedico = Convert.ToInt64(cbmedico.Text);
            Vm.FkPacienteCama = Convert.ToInt64(cbpaciente.Text);
           Vm.FechaVisita = dpFechavisita.Text;
            Vm.HoraVisita = txthora.Text;

            int resultado = servicio.AgregarVisita(Vm);
            if (resultado >= 1)
            {
                await this.ShowMessageAsync("Excelente", "Agregado");
                dgvista.ItemsSource = servicio.MostrarVisita();
                dgvista.Items.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            

        }

        //private async void btnmodificar_Click(object sender, RoutedEventArgs e)
        //{
        //    //Vm.Daignostico = txtdiagnostico.Text;
            //Vm.FkMedico = Convert.ToInt64(cbmedico.Text);
            //Vm.FkPacienteCama = Convert.ToInt64(cbpaciente.Text);
            //Vm.FechaVisita = dpFechavisita.Text;
            //Vm.HoraVisita = txthora.Text;

            //int resultado = servicio.mod(Vm);
            //if (resultado >= 1)
            //{
            //    await this.ShowMessageAsync("Excelente", "Modifiado");
            //    dgvista.ItemsSource = servicio.MostrarVisitaMedica();
            //    dgvista.Items.Refresh();
            //}
            //else
            //{
            //    MessageBox.Show("ERROR");
            //}
        //}

        private  void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!(txtbuscar.Text == ""))
            {
                Vm.FkPacienteCama = Convert.ToInt64(txtbuscar.Text);
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
