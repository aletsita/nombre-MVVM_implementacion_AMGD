using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace nombre_MVVM_implementacion_AMGD.VistaModelo
{
    internal class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;
        string _Mensaje;
        #endregion

        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS

        public string TipoUsuario 
        {
            get {return _TipoUsuario;}
            set { SetValue(ref _TipoUsuario, value); }
        }
        public string N1 
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }

        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }

        public string R
        {
            get { return _R; }  
            set { SetValue(ref _R, value); }
        }

        public string Mensaje 
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Procesoasync() 
        { }

        public void Sumar() 
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = n1 + n2;
            R = r.ToString();
        }

        public async Task Alerta()
        {
            await DisplayAlert("Titulo", Mensaje, "OK");
        }

        public void ProcesoSimple()
        {
        }
        #endregion

        #region COMANDOS
        public ICommand suymarcommand => new Command(Sumar);
        public ICommand Procesoasynccomand => new Command(async () => await Procesoasync());
        #endregion
    }
}
