﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApps2m1.Depreciacion
{
    class DigitoADecremental : IDepreciacion
    {
        public decimal[] Calcular(decimal valor, decimal valorR, int vidaUtil)
        {
            int factor = sumatoria(vidaUtil);

            decimal[] depreciacion = new decimal[vidaUtil];

            decimal depreciacionBase = valor - valorR;

            decimal w = 0;

            for (int i = 0; i < vidaUtil; i++)
            {
                w = (decimal)(vidaUtil - i) / factor;
                depreciacion[i] = Math.Round(depreciacionBase * w, 2);
            }

            return depreciacion;
        }

        public int sumatoria(int n)
        {
            return ((n * (n + 1)) / 2);
        }
    }
}
