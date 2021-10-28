using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IService
    {
        void Create(ActivoFijo t);
        void Add(ActivoFijo t, ref ActivoFijo[] data);
        ActivoFijo[] FIndAll();
        int GetLastId();
    }
}
