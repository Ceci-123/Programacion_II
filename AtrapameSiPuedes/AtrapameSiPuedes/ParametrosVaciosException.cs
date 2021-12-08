﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtrapameSiPuedes
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string message) : this(message, null)
        {
        }

        public ParametrosVaciosException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
