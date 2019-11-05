using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapt4_Tema2
{
    public class MyQueue
    {
        public int[] a = new int[10];
        public int l = 0;
        public int m = 0;
        public void Enqueue(int e)
        {
            int f = a.Length;
            if (f == a.Length)
            {
                Console.WriteLine("The queue is full");
            }
            else
                a[l] = e;
            l++;
        }
        public int top()
        {
            int e;
            e = a[m];
            a[m] = 0;
            return e;
        }



    }
}
