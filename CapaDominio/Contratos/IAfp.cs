﻿using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public interface IAfp
    {
        Afp buscarPorCodigo(string nombre);
    }
}
