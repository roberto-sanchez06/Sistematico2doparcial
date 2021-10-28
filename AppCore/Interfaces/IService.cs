using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Create(T t);
        void Add(T t, ref T[] data);
        T[] FIndAll();
    }
}
