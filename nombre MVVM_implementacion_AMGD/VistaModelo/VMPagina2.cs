using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using nombre_MVVM_implementacion_AMGD.Modelo;

namespace nombre_MVVM_implementacion_AMGD.VistaModelo
{
    public class VMPagina2 : BaseViewModel
    {
        #region PROPIEDADES
        private string _texto;
        public string Texto
        {
            get => _texto;
            set => SetValue(ref _texto, value);
        }

        public List<MiUsuario> ListaPaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMPagina2(INavigation navigation)
        {
            Navigation = navigation;
            CargarUsuarios();
        }
        #endregion

        #region MÉTODOS
        private void CargarUsuarios()
        {
            ListaPaginas = new List<MiUsuario>
            {
                new MiUsuario
                {
                    Nombre = "Alexa",
                    Imagen = "https://i.ibb.co/bXcn5tH/calabaza.png"
                },
                new MiUsuario
                {
                    Nombre = "Emiliano",
                    Imagen = "https://i.ibb.co/RY2RGkm/calcetin.png"
                },
                new MiUsuario
                {
                    Nombre = "Nicol",
                    Imagen = "https://i.ibb.co/jv8FCdr/ciclope.png"
                }
            };
        }

        private async Task MostrarAlerta(MiUsuario usuario)
        {
            await DisplayAlert("Detalle de Usuario", usuario.Nombre, "Ok");
        }

        private async Task VolverAtras()
        {
            await Navigation.PopAsync();
        }

        private void ProcesoSimple()
        {
            // Lógica para el proceso simple.
        }
        #endregion

        #region COMANDOS
        public ICommand AlertaCommand => new Command<MiUsuario>(async usuario => await MostrarAlerta(usuario));
        public ICommand VolverCommand => new Command(async () => await VolverAtras());
        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);
        #endregion
    }

    public class MiUsuario
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
}
