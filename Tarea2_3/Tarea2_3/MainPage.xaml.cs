using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Tarea2_3.Models;
using Tarea2_3.Clases;
using Tarea2_3.Views;

namespace Tarea2_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public String imgfirma;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void firma_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListFirmas());
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                await DisplayAlert("Mensaje", "Nombre vacio", "Salir");
                return;
            }
            else if (string.IsNullOrEmpty(txtdcc.Text))
            {
                await DisplayAlert("Mensaje", "Descripcion vacio", "Salir");
                return;
            }

            

            Stream inputfirma = await padFirma.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Png);
            if (inputfirma != null)
            {
                BinaryReader br = new BinaryReader(inputfirma);
                Byte[] bytes = br.ReadBytes((Int32)inputfirma.Length);
                imgfirma = Convert.ToBase64String(bytes, 0, bytes.Length);
            }
            else
            {
                await DisplayAlert("Mensaje", "Firma vacia", "Salir");
                return;
            }

            if (imgfirma != null)
            {
                db operacionesDB = new db();
                Conexion conn = new Conexion();

                var firma = new Modelo()
                {
                    nombre = txtname.Text,
                    descripcion = txtdcc.Text,
                    foto = imgfirma

                };
                conn.conn().CreateTable<Modelo>();
                conn.conn().Insert(firma);
                await DisplayAlert("Mensaje", "Firma Guardada", "Salir");
            }
            else
            {
                await DisplayAlert("Mensaje", "No se pudo guardar la firma", "Salir");
                return;
            }
        }
    }
}