using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_unit3
{
    internal class area_circulo
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public area_circulo() 
        { 
           radio = 0;
        }
        public void circulo(double radio_)
        {
            radio = radio_;
        }
        public double Formula (double _area) 
        { 
            return _area= 3.1416*(radio *radio);
        }

    }
}
