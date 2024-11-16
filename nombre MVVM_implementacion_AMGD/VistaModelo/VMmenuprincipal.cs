using nombre_MVVM_implementacion_AMGD.Modelo;
using nombre_MVVM_implementacion_AMGD.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace nombre_MVVM_implementacion_AMGD.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MenuPrincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion

        #region MÉTODOS
        private void MostrarPaginas()
        {
            listapaginas = new List<MenuPrincipal>
            {
                new MenuPrincipal
                {
                    Pagina = "Entry, DatePicker, Picker, Label, Navegación",
                    Icono = "https://i.ibb.co/9ycNzG3/sombrero-de-bruja.png"
                },
                new MenuPrincipal
                {
                    Pagina = "CollectionView sin enlace a base de datos",
                    Icono = "https://i.ibb.co/n7KzpCS/noche.png"
                },
                new MenuPrincipal
                {
                    Pagina = "CRUD Pokémon",
                    Icono = "https://i.ibb.co/RYV5P45/parca.png"
                }
            };
        }

        public async Task Navegar(MenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;

            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }

            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }

            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion

        #region COMANDOS
        //public ICommand VolverCommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple());
        public ICommand NavegarCommand => new Command<MenuPrincipal>(async (p) => await Navegar(p));
        #endregion
    }
}

