using Domain.Entities;
using Domain.Interfaces;
using System;

namespace Infraestructure
{
    public class ActivoFijoModel : IModel
    {
        private ActivoFijo[] activoFijos;
        public void Add(ActivoFijo t, ref ActivoFijo[] data)
        {
            if (data == null)
            {
                data = new ActivoFijo[1];
                data[0] = t;
                return;
            }

            ActivoFijo[] tmp = new ActivoFijo[data.Length + 1];
            Array.Copy(data, tmp, data.Length);
            tmp[tmp.Length - 1] = t;
            data = tmp;
        }

        public void Create(ActivoFijo t)
        {
            Add(t, ref activoFijos);
        }

        public ActivoFijo[] FIndAll()
        {
            return activoFijos;
        }

        public int GetLastId()
        {
            try
            {
                return (activoFijos == null) ? 0 : activoFijos[activoFijos.Length - 1].Id;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
    }
}
