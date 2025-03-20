﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Excepciones
{
    public class LogicaNegocioException : Exception
    {
        public LogicaNegocioException()
        {
        }

        public LogicaNegocioException(string? message) : base(message)
        {
        }
    }
}
