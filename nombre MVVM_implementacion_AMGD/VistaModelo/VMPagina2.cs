using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace nombre_MVVM_implementacion_AMGD.VistaModelo
{
    class VMPagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsynccommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

        #region CONSTRUCTOR
        public VMPagina2(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
    }
}
