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
                    Imagen = "https://ibb.co/Z2PPzLD"
                },

                new MiUsuario
                {
                    Nombre = "Emiliano",
                    Imagen = "https://ibb.co/Qf9yngP"
                },

                new MiUsuario
                {
                    Nombre = "Nicol",
                    Imagen = "https://ibb.co/xjTWjZy"
                }
            };
        }

        public async Task Cualquiera()
        { 
        }
        public ICommand Volvercommand => new Command(async () => await Cualquiera());
        #endregion

    }

    public class MiUsuario
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
    
}
