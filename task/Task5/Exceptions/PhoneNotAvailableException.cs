﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class PhoneNotAvailableException : Exception
    {
        public PhoneNotAvailableException()
        {
        }

        public PhoneNotAvailableException(string message) : base(message)
        {
        }
    }
}
