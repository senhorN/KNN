using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knn.Class
{
    public class Filmes
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double wViolencia { get; set; }
        public double wAcao { get; set; }
        public double wRomance { get; set; }
        public double wComedia { get; set; }
        public double wPesoFinal { get; set; }
    }
}