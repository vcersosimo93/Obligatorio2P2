using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio2MVC
{
    abstract class Donacion
    {
        private DateTime fechaDonacion;
        private double vale;
        private int codigoDonacion;
        //habia creado un codigo para poder poder hacer el 
        //alta de las Donaciones (TipoProducto y TipoEconomica)


        public DateTime FechaDonacion
        {
            get { return fechaDonacion; }
        }

        public int CodigoDonacion
        {
            get { return codigoDonacion; }
        }

        public double Vale
        {
          get { return vale; }
        }
        
        // no deberia estar no? es abstracta
        /*public Donacion(DateTime fechaDonacion, int codigoDonacion)
        {
            this.fechaDonacion= fechaDonacion;
            this.codigoDonacion = codigoDonacion;

        }*/






    }
}
