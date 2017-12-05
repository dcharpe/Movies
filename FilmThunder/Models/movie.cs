using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmThunder.Models
{
    public class movie
    {
        public int filmID { get; set; }
        public int certID { get; set; }
        public int genreID { get; set; }
        public string filmName { get; set; }
        public string certName { get; set; }
        public string genreName { get; set; }

        
    }
}