using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidades
{
    class detalleVta
    {

        public int codDetalle { get; set; }

        public int codVta { get; set; }

        public int codProd { get; set; }

        public string tipoProd { get; set; }

        public int codPromo { get; set; }

        public string descripcion { get; set; }

        public int cantidad { get; set; }

        public double totalProd { get; set; }

        public DateTime vtaFecha { get; set; }
    }
}
