using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Processes
{
    public abstract class ObtenerVidautil
    {
        protected int VidaUtil(TipoActivo tipoActivoFijo)
        {
            switch (tipoActivoFijo)
            {
                case TipoActivo.Edificio:
                    return 20;
                case TipoActivo.Vehiculo:
                    return 5;
                case TipoActivo.Maquinaria:
                    return 3;
                case TipoActivo.Mobiliario:
                    return 2;
                case TipoActivo.EquipoComputo:
                    return 1;
                default:
                    throw new ArgumentException("Tipo de activo fijo no existe.");
            }
        }
    }
}
