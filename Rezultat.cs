using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Rezultat
    {
        public int RezultatId { get; set; }
        public int StudentId { get; set; }
        public int IspitId { get; set; }
        public int Ocjena { get; set; }

        // Konstruktor
        public Rezultat(int rezultatId, int studentId, int ispitId, int ocjena)
        {
            RezultatId = rezultatId;
            StudentId = studentId;
            IspitId = ispitId;
            Ocjena = ocjena;
        }
    }
}
