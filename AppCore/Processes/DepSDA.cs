using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCore.Processes
{
    public class DepSDA : ObtenerVidautil, IDepreciacion
    {
        public decimal CalcularDep(ActivoFijo af)
        {
            int vidaUtil = VidaUtil(af.TipoActivo);
            return (af.ValorActivo - af.ValorResidual) / vidaUtil;
        }
    }
}
