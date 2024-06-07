using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        // Konstruktor
        public Student(int studentId, string ime, string prezime, string email)
        {
            StudentId = studentId;
            Ime = ime;
            Prezime = prezime;
            Email = email;
        }
    }
}
