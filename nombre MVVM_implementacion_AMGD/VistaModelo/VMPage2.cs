using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using nombre_MVVM_implementacion_AMGD.Modelo;
using nombre_MVVM_implementacion_AMGD.VistaModelo;
using System.Windows.Input;
using System.Threading.Tasks;


namespace nombre_MVVM_implementacion_AMGD.VistaModelo
{
    public class VMPage2 : BaseViewModel
    {
        private string _Texto;
        public List<MiUsuario> ListaUsuario { get; set; }

        #region CONSTRUCTOR
        public VMPage2()
        {

            MostrarUsuarios();
        }
        #endregion

        public VMPage2(INavigation navigation) 
        {
            Navigation = navigation;
            MostrarUsuarios();
        }

        #region COMANDOS 


        public void MostrarUsuarios()
        {
            ListaUsuario = new List<MiUsuario> {

                new MiUsuario
                {
                    Nombre = "Alexa",
                    Imagen = "https://i.ibb.co/rFhSx56/lluvia-de-meteoros.gif"
                },

                new MiUsuario
                {
                    Nombre = "Emiliano",
                    Imagen = "https://i.ibb.co/564SptP/noche.gif"
                },

                new MiUsuario
                {
                    Nombre = "Nicol",
                    Imagen = "https://i.ibb.co/6HpZ5Pk/arcoiris.gif"
                }
            };
        }

        public async Task Cualquiera()
        { 
        }

        public async Task Alerta(MiUsuario parametros) 
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }
        public ICommand Volvercommand => new Command(async () => await Cualquiera());
        //Public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command<MiUsuario>(async (p) => await Alerta(p));
        #endregion

    }

    public class MiUsuario
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
    
}
