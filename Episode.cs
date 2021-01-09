using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Episode
    {

        public int Story { get;  set; }

        public int Season { get;  set; }

        public int Year { get;  set; }

        public String Title { get;  set; }

        public Episode(int story, int season , int year , String title)
        {
            Story = story;
            Season = season;
            Year = year;
            Title = title;
        }

        public Episode()
        {

        }
    }
}
