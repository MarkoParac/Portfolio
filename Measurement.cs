using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature
{
    class Measurement
    {
        public string Naziv { get; set; }
        public int Temperatura { get; set; }
        public DateTime Datum { get; set; }

        public Measurement(string naziv_mjerenja, int temperatura_mjerenja, DateTime datum_mjerenja)
        {
            Naziv = naziv_mjerenja;
            Temperatura = temperatura_mjerenja;
            Datum = datum_mjerenja;
        }
    }
}
