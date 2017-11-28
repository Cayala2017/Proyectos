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
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : MetroWindow
    {

        Service1Client Servicio = new Service1Client();
        MedicoEN medico = new MedicoEN();
        EnfermeraEN enfermera = new EnfermeraEN();
        UsuarioEN us = new UsuarioEN();
        byte[] imagenDigital;
        byte[] imagen;
        BitmapDecoder bitCoder;

        public Inicio()
        {
            InitializeComponent();
            DGMedico.ItemsSource = Servicio.MostrarMedico();
            dgvista.ItemsSource = Servicio.MostrarEnfermeras();
            dgvista.Items.Refresh();

            //Enfermera
            StackUsuarioEnfermera.Visibility = Visibility.Hidden;
            DibujoEnfermera.Visibility = Visibility.Hidden;
            ChipEnfermera.Visibility = Visibility.Hidden;
            ChipEnfermera2.Visibility = Visibility.Hidden; 
          


            DGMedico.Items.Refresh();
            //Combo de Medicos
            cbespecialidad____Copy1.Items.Add("Ginecologo");
            cbespecialidad____Copy1.Items.Add("Odontologo");
            cbespecialidad____Copy1.Items.Add("Dermatologo");
            cbespecialidad____Copy1.Items.Add("Neurologo");
            cbespecialidad____Copy1.Items.Add("Cardiologo");
            cbespecialidad____Copy1.Items.Add("Oftalmologo");
            cbespecialidad____Copy1.Items.Add("Otorrinolaringologo");


            cbPlanta.ItemsSource = Servicio.MostraPlantas().ToList();
            cbPlanta.DisplayMemberPath = "IdPlanta";
            cbPlanta.SelectedValuePath = "IdPlanta";



        }

#region Tiles
        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            
           
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
           
        }

       
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Tile_Click_4(object sender, RoutedEventArgs e)
        {
          

        }

        private void Tile_Click_5(object sender, RoutedEventArgs e)
        {
           
           
        }

        private void TileDoctores_Click(object sender, RoutedEventArgs e)
        {
            Fly.IsOpen = true;
        }
#endregion

        private void Tile_Click_6(object sender, RoutedEventArgs e)
        {
            FlyEnfermeras.IsOpen = true;
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
            _str.Position = 0;
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

        private void metroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtid.Visibility = Visibility.Hidden;
           
        }

        private async void btnagregarEnfermera_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                enfermera.DUI = txtDui_Enfermera.Text;
                enfermera.Nombre = txtNombre_Enfermera.Text;
                enfermera.Apellido = txtApellido_Enfermera.Text;

                String resultado = Servicio.ReguistraEnfermero(enfermera);
                if (resultado == "Registrado/a Correctamente.")
                {
                    await this.ShowMessageAsync("Exelente", "Registrado Correctamente");
                    dgvista.ItemsSource = Servicio.MostrarEnfermeras();
                    dgvista.Items.Refresh();



                    OcultarEnfermera();

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
        public void OcultarEnfermera()
        {
            StackUsuarioEnfermera.Visibility = Visibility.Visible;
            StackEnfermera.Visibility = Visibility.Hidden;
            txtDui_Enfermera.Visibility = Visibility.Hidden;
            txtNombre_Enfermera.Visibility = Visibility.Hidden;
            txtApellido_Enfermera.Visibility = Visibility.Hidden;
            dgvista.Visibility = Visibility.Hidden;
            btnagregarEnfermera.Visibility = Visibility.Hidden;
            DibujoEnfermera.Visibility = Visibility.Visible;
            ChipEnfermera.Visibility = Visibility.Visible;
            ChipEnfermera2.Visibility = Visibility.Visible;
            

        }

        private async void btnAgregarUsuario_Click(object sender, RoutedEventArgs e)
        {
            us.Usuario = txtNombreUserE.Text;
            us.Contrasena = txtPassU.Text;
            us.FDUI = txtIDuiU.Text;

            String resultado = Servicio.RegistrarUsuario(us);
            if (resultado == "Usuario Registrado Correctamente.")
            {
                await this.ShowMessageAsync("Excelente", "Agregado");

                //await this.ShowMessageAsync("Excelente", "Agregado");
                //dgvista.ItemsSource = servicio.MostrarVisita();
                //dgvista.Items.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        public void mostrarEnfermera()
        {

        }

        private void RBEnfermera_Checked(object sender, RoutedEventArgs e)
        {
     


        }

        private void RBUser_Checked(object sender, RoutedEventArgs e)
        {
           

        }

        private void DGUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }
    
