using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ5.Models
{
    public class Imc1
    {
        public double IMC { get; set; }
        public double ImcMaior { get; set; }
        public double ImcMenor { get; set; }
        public List<double> participantes { get; set; }
    }
}
