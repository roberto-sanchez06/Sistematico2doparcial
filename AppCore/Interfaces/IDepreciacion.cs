﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IDepreciacion
    {
        decimal CalcularDep(ActivoFijo af);
    }
}
