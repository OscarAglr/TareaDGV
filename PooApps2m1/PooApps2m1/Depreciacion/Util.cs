using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApps2m1.Depreciacion
{
    public class Util
    {
        public decimal sumatoria (decimal [] numeros)
        {
            decimal suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            return suma;
        }
    }
}
