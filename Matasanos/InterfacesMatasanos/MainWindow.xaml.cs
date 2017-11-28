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
using System.Windows.Navigation;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        
        MedicoEN medico = new MedicoEN();
        UsuarioEN us = new UsuarioEN();
        Service1Client Servicio = new Service1Client();

        public MainWindow()
        {
            
            
            InitializeComponent();
        }


        private async void button_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                medico.NombreUsuario = txtNombreUser.Text;
            medico.Contrasena = txtContrasena.Password;
           
                int resultado = Servicio.Validar(medico);
            if (resultado >= 1)
            {
                    await this.ShowMessageAsync("Bienvenido", "Sr." + txtNombreUser.Text);
                    Inicio I = new Inicio();


                    if (!(txtNombreUser.Text == ""))
                    {
                        medico.NombreUsuario = txtNombreUser.Text;
                        I.DGUser.ItemsSource = Servicio.ObtenerImagen(medico);
                        I.DGUser.Items.Refresh();
                       
                    I.Show();

                    this.Close();

                   
                }
            else
            {
                us.Usuario = txtNombreUser.Text;
                us.Contrasena = txtContrasena.Password;

                int _resultado = Servicio.IniciarSesion(us);
                if (_resultado >= 1)
                {
                   //var controller = await this.ShowMessageAsync("Bienvenido", "Sr." + txtNombreUser.Text);
                   // Home IF = new Home();
                   // //-IF.lbSesion.Content = txtNombreUser.Text;
                   // IF.Show();
                   // this.Close();
                   //     PR11.Visibility = Visibility.Visible;

                    }
                else
                    {
                    MessageBox.Show("Comprube Sus Datos");
                }
                    }
                }
            }


            catch
            {
                MessageBox.Show("Estamos Trabajando en el Problema");
            }
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PruebadeReporte c = new PruebadeReporte();
            c.Show();
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PruebadeReporte c = new PruebadeReporte();
            c.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
