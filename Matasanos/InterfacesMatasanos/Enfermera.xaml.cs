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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
namespace InterfacesMatasanos
{
    /// <summary>
    /// Lógica de interacción para Enfermera.xaml
    /// </summary>
    public partial class Enfermera : MetroWindow
    {
        public Enfermera()
        {
            InitializeComponent();
            dgvista.ItemsSource = Servicio.MostrarEnfermeras();
            dgvista.Items.Refresh();
        }
        Service1Client Servicio = new Service1Client();
        EnfermeraEN enf = new EnfermeraEN();

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            enf.DUI = txtId.Text;
            enf.Nombre = txtNombre.Text;
            enf.Apellido = txtApellido.Text;

            String resultado = Servicio.ReguistraEnfermero(enf);
            if (resultado == "Registrado/a Correctamente.")
            {
                await this.ShowMessageAsync("Exelente","Registrado Correctamente");
                    dgvista.ItemsSource = Servicio.MostrarEnfermeras();
                    dgvista.Items.Refresh();
                    Inicio I = new Inicio();
                I.Show();
                Close();
            }
            else
            {
                await this.ShowMessageAsync("ERROR", "El Usuario Ya Esta Registrado");
            }
        }
            catch
            {
                await this.ShowMessageAsync("ERROR", "Estamos Trabajando en Ello");
            }
            }

        private void button3_Copy_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Usuario u = new Usuario();
            u.ShowDialog();
            Close();
        }
    }
}
