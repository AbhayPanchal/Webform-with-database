using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Doctor
    {
        public int Original { get;  set; }

        public String Actor { get;  set; }

        public int Series { get;  set; }

        public int Age { get;  set; }

        public byte[] Picture { get;  set; }

        public String Debut { get;  set; }


        public Doctor(int original , string actor , int series , int age, byte[] image , string debut)
        {
            Original = original;
            Actor = actor;
            Series = series;
            Age = age;
            Picture = image;
            Debut = debut;
        }

        public Doctor()
        {

        }
    }
}
