using PooApps2m1.poco;
using System;
using System.Linq;

namespace PooApps2m1.model
{
    public class ActivoFijoModel
    {
        private ActivoFijo[] activoFijos;

        public ActivoFijoModel()
        {

        }

        public void AddElement(ActivoFijo af)
        {
            if(activoFijos == null)
            {
                activoFijos = new ActivoFijo[1];
                activoFijos[0] = af;
                return;
            }
            ActivoFijo[] tmp = new ActivoFijo[activoFijos.Length + 1];
            Array.Copy(activoFijos, tmp,activoFijos.Length);

            tmp[tmp.Length - 1] = af;
            activoFijos = tmp;
        }

        public void Remove(int index)
        {
            if (activoFijos == null)
            {
                return;
            }

            if (index < 0 || index >= activoFijos.Length)
            {
                throw new IndexOutOfRangeException($"El indice {index} esta fuera de rango.");
            }     

            if(activoFijos.Length == 1 && index == 0)
            {
                activoFijos = null;
                return;
            }

            ActivoFijo[] tmp = new ActivoFijo[activoFijos.Length - 1];
            if(index == activoFijos.Length - 1)
            {
                Array.Copy(activoFijos, 0, tmp, 0, tmp.Length);
                activoFijos = tmp;
                return;
            }

            if(index == 0)
            {
                Array.Copy(activoFijos, index + 1, tmp, 0, tmp.Length);
                activoFijos = tmp;
                return;
            }

            Array.Copy(activoFijos,0,tmp,0,index);
            Array.Copy(activoFijos, index + 1, tmp, index, tmp.Length - index);
            activoFijos = tmp;
        }

        public ActivoFijo[] GetAll()
        {
            return activoFijos;
        }

        public int GetGreaterVidaUtil()
        {
            return (int) activoFijos.OrderBy(a => a.TipoActivo)
                              .Reverse()
                              .FirstOrDefault()
                              .TipoActivo;
        }
    }
}
