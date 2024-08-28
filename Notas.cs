using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevNotas
{
    public class Notas
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Notas(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        public double MediaNotas()
        {
            return (Nota1  * 0.30)+ (Nota2 * 0.35) + (Nota3 * 0.35) / 3;
        }
    }
}
