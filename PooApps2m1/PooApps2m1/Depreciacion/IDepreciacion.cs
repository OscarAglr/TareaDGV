using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApps2m1.Depreciacion
{
    public interface IDepreciacion
    {
        decimal[] Calcular(decimal valor, decimal valorR, int vidaUtil);
    }
}
