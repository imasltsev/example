using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
        public class ShakerSort<T> : ISorted<T>
        {
            public void Sort(List<T> list, IComparer<T> comparer)
            {
            for (var i = 0; i < list.Count / 2; i++)
            {
                var swapFlag = false;
                //from left to right
                for (var j = i; j < list.Count - i - 1; j++)
                {
                    if (comparer.Compare(list[j], list[j + 1])<0)
                    {
                        Swap(list,j, j + 1);
                        swapFlag = true;
                    }
                }

                //from right  to left
                for (var j = list.Count - 2 - i; j > i; j--)
                {
                    if (comparer.Compare(list[j - 1], list[j])<0)
                    {
                        Swap(list, j - 1,j);
                        swapFlag = true;
                    }
                }

                //if there were no exchanges, we leave
                if (!swapFlag)
                {
                    break;
                }
            }
        }

        private void Swap(List<T> list, int i, int j)
            {
                
                T tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
        }
    }
