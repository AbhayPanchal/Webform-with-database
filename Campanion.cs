using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Campanion
    {

        public string Name { get;  set; }

        public String Actor { get;  set; }

        public int DoctorID { get;  set; }

        public String Debut { get; set; }

        public Campanion(string name, string actor, int doctor, string debut)
        {
            Name = name;
            Actor = actor;
            DoctorID = doctor;
            Debut = debut;
        }

        public Campanion()
        {

        }
    }
}
