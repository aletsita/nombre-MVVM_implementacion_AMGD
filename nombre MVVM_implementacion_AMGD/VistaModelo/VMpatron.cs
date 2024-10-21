using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nombre_MVVM_implementacion_AMGD.VistaModelo
{
     class VMpatron : BaseViewModel
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

        public async Task ProccesoAsyncrong() 
        {
        }
        public void ProcesoSimple() 
        {
        }
        #endregion

    }
}
