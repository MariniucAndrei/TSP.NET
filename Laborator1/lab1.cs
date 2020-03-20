using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laborator1
{
    class lab1
    {
        int n;
        public static void Main(string[] args)
        {
            lab1 a = new lab1();
            a.n = Convert.ToInt32(Console.ReadLine());
            Thread thread = new Thread(() => a.nr_prim1(a.n));
            thread.Start();
            thread.Join();
            Console.WriteLine("Start fir: " + Thread.CurrentThread.Name + DateTime.Now.ToString("hh:mm:s:ms") + "Numar natural dat = " + a.n.ToString());
            Thread thread1 = new Thread(() => a.nr_prim2(a.n));
            thread1.Start();
            thread1.Join();
            //Console.WriteLine(a.nr_prim1(a.n));
            //Console.WriteLine(a.nr_prim2(a.n));
            Console.ReadLine();
        }

        public int nr_prim1(int n)
        {
            int i,d,ok=0;
            for(i = n - 1; i >= 3; i--)
            {
                ok = 0;
                for (d = 2; d <= i / 2; d++)
                {
                    if (i % d == 0)
                    {
                        ok = 1;
                        break;
                    }
                }
                if (ok == 0)
                    return i;
            }
            return i;
        }

        public int nr_prim2(int n)
        {
            int i, d, ok, nr = 0;
            List<int> list = new List<int>();
            for (i = 0; i <= n; i++)
            {
                ok = 0;
                for (d = 2; d <= i / 2; d++)
                {
                    if (i % d == 0)
                    {
                        ok = 1;
                        break;
                    }
                }
                if (ok == 0)
                {
                    list.Add(i);
                    nr++;
                }
            }
            return list[nr-1];
        }
    }
}
