using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    public interface ISorted<T>
    {
        public void Sort(List<T> list, IComparer<T> comparer);
    }
}
