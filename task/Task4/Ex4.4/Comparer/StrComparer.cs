using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    public class StrComparer : IComparer<string>
    {
        public int Compare(string str1, string str2)
        {
            return (str1.Length - str2.Length) * (-1);
        }
    }
}
