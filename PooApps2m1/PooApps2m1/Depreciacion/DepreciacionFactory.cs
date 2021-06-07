using PooApps2m1.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApps2m1.Depreciacion
{
    public class DepreciacionFactory
    {
        public IDepreciacion CreateInstance(MetodoDepreciacion metodoDepreciacion)
        {
            switch (metodoDepreciacion)
            {
                case MetodoDepreciacion.LINEARECTA:
                    return new LineaRecta();
                case MetodoDepreciacion.SDAINCREMENTAL:
                    return new DigitoAIncremental();
                case MetodoDepreciacion.SDADECREMENTAL:
                    return new DigitoADecremental();
                default:
                    return null;
            }
        }
    }
}
