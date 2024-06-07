using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ispit
    {
        public int IspitId { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }

        // Konstruktor
        public Ispit(int ispitId, string naziv, DateTime datum)
        {
            IspitId = ispitId;
            Naziv = naziv;
            Datum = datum;
        }
    }
}
