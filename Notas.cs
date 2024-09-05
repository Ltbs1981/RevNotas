using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevNotas
{
    public class Notas
    {
        private double _nota1;
        public double Nota1
        {
            get { return _nota1; }
            set { _nota1 = value; }
        }

        private double _nota2;
        public double Nota2
        {
            get { return _nota2; }
            set { _nota2 = value; }
        }

        private double _nota3;
        public double Nota3
        {
            get { return _nota3; }
            set { _nota3 = value; }
        }
        public Notas(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        public double MediaNotas()
        {
            return (Nota1  * 0.30)+ (Nota2 * 0.35) + (Nota3 * 0.35);
        }
    }
}
