using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionExamen
{
    class clsTemperatura
    {
        int noIdentificacion;
        decimal temperatura;

        public int NoIdentificacion { get => noIdentificacion; set => noIdentificacion = value; }
        public decimal Temperatura { get => temperatura; set => temperatura = value; }
    }
}
