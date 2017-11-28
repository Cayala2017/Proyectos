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
    /// Lógica de interacción para Usuario.xaml
    /// </summary>
    public partial class Usuario : MetroWindow
    {
        public Usuario()
        {
            InitializeComponent();
        }
        Service1Client servicio = new Service1Client();
        UsuarioEN us = new UsuarioEN();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            us.Usuario = txtusuario.Text;
            us.Contrasena = txtcontra.Password;
            us.FDUI = txtdui.Text;

            String resultado = servicio.RegistrarUsuario(us);
            if (resultado == "Usuario Registrado Correctamente.")
            {
                MessageBox.Show("Exelente");
                //await this.ShowMessageAsync("Excelente", "Agregado");
                //dgvista.ItemsSource = servicio.MostrarVisita();
                //dgvista.Items.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
