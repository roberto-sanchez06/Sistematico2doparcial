using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class ActivoFIjoService : IModel<ActivoFijo>
    {
        private IModel<ActivoFijo> model;
        public void Add(ActivoFijo t, ref ActivoFijo[] data)
        {
            model.Add(t, ref data);
        }

        public void Create(ActivoFijo t)
        {
            model.Create(t);
        }

        public ActivoFijo[] FIndAll()
        {
            return model.FIndAll();
        }
    }
}
