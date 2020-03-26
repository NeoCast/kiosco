using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidades
{
   public class productos
    {
        public int codProducto { get; set; }

        public int codPromo { get; set; }

        public string tipoProducto { get; set; }

        public string descripcion { get; set; }

        public double precio { get; set; }

        public double costos { get; set; }

        public int stock { get; set; }

        public int stockMin { get; set; }

        public DateTime inFecha { get; set; }

        public DateTime outFecha { get; set; }


    }
}
