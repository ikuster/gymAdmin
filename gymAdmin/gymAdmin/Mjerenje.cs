using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    class Mjerenje
    {
        public float Visina { get; set; }
        public float Tezina { get; set; }
        public float BMI { get; set; }
        public Mjerenje(float visina, float tezina)
        {
            this.Visina = visina;
            this.Tezina = tezina;
            this.BMI = tezina / (float)Math.Pow(visina, 2);
        }
    }
}
