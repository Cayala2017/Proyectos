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
    /// Lógica de interacción para Medicos.xaml
    /// </summary>
    public partial class Medicos : MetroWindow
    {
        
        Service1Client Servicio = new Service1Client();
        MedicoEN medico = new MedicoEN();
        byte[] imagenDigital;
        byte[] imagen;
        BitmapDecoder bitCoder;
      

        public Medicos()
        {
            InitializeComponent();
            DGMedico.ItemsSource = Servicio.MostrarMedico();
            DGMedico.Items.Refresh();
            cbespecialidad____Copy1.Items.Add("Ginecologo");
            cbespecialidad____Copy1.Items.Add("Odontologo");
            cbespecialidad____Copy1.Items.Add("Dermatologo");
            cbespecialidad____Copy1.Items.Add("Neurologo");
            cbespecialidad____Copy1.Items.Add("Cardiologo");
            cbespecialidad____Copy1.Items.Add("Oftalmologo");
            cbespecialidad____Copy1.Items.Add("Otorrinolaringologo");

        }

        private async void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            medico.Imagen = imagen;
            medico.Nombre = txtnombre.Text;
            medico.Apellido = txtapellido.Text;
            medico.Especialidad = cbespecialidad____Copy1.Text;
            medico.NombreUsuario = txtnombreusuario.Text;
            medico.Contrasena = txtcontr.Password;
            medico.FkPlanta = Convert.ToInt64(cbPlanta.Text);

            String resultado = Servicio.AgregarMedico(medico);
            if (resultado == "Medico Registrado.")
            {
                await this.ShowMessageAsync("Excelente", "Agregado");
                DGMedico.ItemsSource = Servicio.MostrarMedico();
                DGMedico.Items.Refresh();
                txtnombre.Focus();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            txtnombreusuario.Text = "";
            txtcontr.Password = "";

        }

        private void btncargar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog _OFD = new OpenFileDialog();
            _OFD.Filter = "Imagenes jpg(*.jpg)|*.jpg|Imagenes png(*.png)|*.png|All Files(*.*)|*.*";
            if (_OFD.ShowDialog() == true)
            {
                using (Stream _strem = _OFD.OpenFile())
                {
                    bitCoder = BitmapDecoder.Create(_strem, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                    Foto.Source = bitCoder.Frames[0];
                    txtruta.Text = _OFD.FileName;
                }
                FileStream _FStream = new FileStream(txtruta.Text, FileMode.Open);
                imagen = new byte[Convert.ToInt64(_FStream.Length)];
                _FStream.Read(imagen, 0, imagen.Length);
                _FStream.Close();
            }
            else
            {
                Foto.Source = null;
            }
        }

        public void convertirbitscver(MedicoEN _medico)
        {
            MemoryStream _str = new MemoryStream();
            _str.Write(_medico.Imagen, 0, _medico.Imagen.Length);
            _str .Position = 0;
            System.Drawing.Image _img = System.Drawing.Image.FromStream(_str);
            BitmapImage bitimage = new BitmapImage();
            MemoryStream str = new MemoryStream();
            bitimage.BeginInit();
            _img.Save(str, System.Drawing.Imaging.ImageFormat.Jpeg);
            str.Seek(0, SeekOrigin.Begin);
            bitimage.StreamSource = str;
            bitimage.EndInit();
            Foto.Source = bitimage;
        }

        private void DGMedico_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MedicoEN me = (MedicoEN)DGMedico.SelectedItems[0];

            //medico  = DGMedico.SelectedItem as MedicoEN;
            //Foto.ImageFailed = medico.Imagenes();
            txtid.Text = me.IdMedico.ToString();
            txtnombre.Text = me.Nombre.ToString();
            txtapellido.Text = me.Apellido.ToString();
            cbespecialidad____Copy1.Text = me.Especialidad.ToString();

            convertirbitscver(me);
        }

        private async void btnmodificar_Click(object sender, RoutedEventArgs e)
        {
            medico.IdMedico = Convert.ToInt64(txtid.Text);
            medico.Imagen = imagen;
            medico.Nombre = txtnombre.Text;
            medico.Apellido = txtapellido.Text;
            medico.Especialidad = cbespecialidad____Copy1.Text;
            medico.NombreUsuario = txtnombreusuario.Text;
            medico.Contrasena = txtcontr.Password;
            medico.FkPlanta = Convert.ToInt64(cbPlanta.Text);

            int resultado = Servicio.ActualizarMedico(medico);
            if (resultado >= 1)
            {
                await this.ShowMessageAsync("Excelente", "Modificar");
                DGMedico.ItemsSource = Servicio.MostrarMedico();
                DGMedico.Items.Refresh();
                DGMedico.Items.Refresh();
                txtnombre.Focus();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private async void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            medico.IdMedico = Convert.ToInt64(txteliminar.Text);

            int resultado = Servicio.EliminarMedico(medico);
            if (resultado == 1)
            {
                await this.ShowMessageAsync("Excelente", "Eliminado");
                DGMedico.ItemsSource = Servicio.MostrarMedico();
                DGMedico.Items.Refresh();
                txtnombre.Focus();
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
                medico.Especialidad = txtbuscar.Text;
                DGMedico.ItemsSource = Servicio.BuscarMedicoEspecialidad(medico);
                DGMedico.Items.Refresh();
                await this.ShowMessageAsync("Excelente", "Medico Encontrado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private void cbespecialidad____SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void txtnombre_SelectionChanged(object sender, RoutedEventArgs e)
        {
            pruebalb.Opacity = 100;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            pruebalb.Visibility = Visibility.Hidden;
            Apellido.Visibility = Visibility.Hidden;
            NombreUsuario.Visibility = Visibility.Hidden;
            Contraseña.Visibility = Visibility.Hidden;

            cbPlanta.ItemsSource = Servicio.MostraPlantas().ToList();
            cbPlanta.DisplayMemberPath = "IdPlanta";
            cbPlanta.SelectedValuePath = "IdPlanta";
        }

        private void txtnombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            pruebalb.Visibility = Visibility.Visible;
            Apellido.Visibility = Visibility.Visible;
            NombreUsuario.Visibility = Visibility.Visible;
            Contraseña.Visibility = Visibility.Visible;
        }
    }
}
