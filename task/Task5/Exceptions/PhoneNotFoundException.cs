using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class PhoneNotFoundException : Exception
    {
        public PhoneNotFoundException()
        {
        }

        public PhoneNotFoundException(string message) : base(message)
        {
        }
    }
}
