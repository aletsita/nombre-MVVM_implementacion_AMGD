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
    class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MmenuPrincipal> listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR 
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion

        #region OBJETOS
        public void Mostrarusuarios()
        {
            listausuarios = new List<MmenuPrincipal>
            {
                new MmenuPrincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://i.ibb.co/9ycNzG3/sombrero-de-bruja.png"
                },
                new MmenuPrincipal
                {
                    Pagina = "CollectionView sin enlace a base de datos",
                    Icono = "https://i.ibb.co/n7KzpCS/noche.png"
                },
                new MmenuPrincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://i.ibb.co/RYV5P45/parca.png"
                }
            };
        }
        #endregion

        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }

        public async Task Navegar(MmenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datapicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion

        #region COMANDOS
        //public ICommand Volvercommand => new Command(async () => await ProcesoAsyncrono());
        //public Icommand ProcesoSimpcommand => new command (procesoSimple);
        public ICommand Navegarcommand => new Command<MmenuPrincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
