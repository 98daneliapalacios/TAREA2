using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_3.Clases;
using Tarea2_3.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace Tarea2_3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListFirmas : ContentPage
    {
        db basedatos = new db();
        public ListFirmas()
        {
            InitializeComponent();
            OnAppearing();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                var lista = await basedatos.getReadFirmas();
                if (lista != null)
                {
                    lstfirmas.ItemsSource = lista;
                }
            }
            catch (SQLiteException e)
            {
                await DisplayAlert("Mensaje", "No hay ubicaciones guardadas", "Cerrar");

            }
        }
    }
}