using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel
    {
        void Create(ActivoFijo t);
        void Add(ActivoFijo t, ref ActivoFijo[] data);
        ActivoFijo[] FIndAll();
        int GetLastId();
    }
}
