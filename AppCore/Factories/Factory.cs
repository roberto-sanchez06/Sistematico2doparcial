using AppCore.Interfaces;
using AppCore.Processes;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Factories
{
    public static class Factory
    {
        public static IDepreciacion Crear(ActivoFijo af)
        {
            switch (af.MetodoDepreciacion)
            {
                case Domain.Enums.MetodoDepreciacion.LineaRecta:
                    return new DepreciacionLineal();
                    
                case Domain.Enums.MetodoDepreciacion.SDAiIncremental:
                    return null;
                //break;
                default:
                    return null;
            }
        }
    }
}
