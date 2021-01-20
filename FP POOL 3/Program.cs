using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_POOL_3
{
    class Program
    {
        static void Pb1()
        {
            int n,suma=0;
            n = 6;
            int[] v = new int[] { 1,2,3,4,5,0};
            for (int i = 0; i < n; i++)
                suma = suma + v[i];
            Console.WriteLine(suma);
        }
        static void Pb2()
        {
            int n, k;
            bool ok = true;
            n = 10;
            k = int.Parse(Console.ReadLine());
            int[] v = new int[10] { 1, 4, 3, 4, 5, 6, 7, 8,2, 10 };
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                {

                    Console.WriteLine(i);
                    ok = false;
                    break;


                }
            if (ok == true)
                Console.WriteLine(-1);


        }
        static void Pb3()
        {
            int max, min, n, pozmax = -1, pozmin = -1;
            n = 6;
            int[] v = new int[] {2, 2, 2, 2, 2, 2 };
            max = v[0];
            min = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    pozmax = i;
                }
                if (v[i] < min)
                {
                    min = v[i];
                    pozmin = i;
                }
            }
            if (pozmax != -1 || pozmin != -1)
                Console.WriteLine(pozmax + " " + pozmin);
            else
                Console.WriteLine("Nu avem max,min");
        }
        static void Pb4()
        {
            int n,nr=0,max,min,nrmax,nrmin;
            int[] v = new int[] {2, 3, 41, 1, 9, 1, 634, 634,1,1,634 };
            n = 11;
            max = v[0];
            min = v[0];
            nrmax = 0;
            nrmin = 0;
            for(int i=0;i<n;i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                   
                }
                else
                    if(v[i]==max)
                    nrmax++;

                if (v[i] < min)
                {
                    min = v[i];

                }
                else
                    if (v[i] == min)
                    nrmin++;
            }
            Console.WriteLine(max+" "+nrmax);
            Console.WriteLine(min+" "+nrmin);
        }
        static void Pb5()
        {
            int n, e, k;
            n = 10;
            e = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] v = new int[] { 432,1,2,74,55,76,9,3,2,1 };
            for (int i = 0; i < n; i++)
                if (i== k)
                    v[i] = e;
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void pb6()
        {
            int n = 7, k, aux = 0;
            k = int.Parse(Console.ReadLine());
            int[] v = new int[] { 4, 6, 2, 8, 6, 2, 3 };

            for (int i = 0; i < n; i++)
                if (i == k)
                {
                    Console.WriteLine(i + " " + v[i]);
                    for (int j = i + 1; j < n; j++)
                        v[j - 1] = v[j];

                }
            n--;
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void pb7()
        {
            int n = 8, i, aux;

            int[] v = new int[] { 4, 6, 3, 1, 8, 42, 2, 3 };
            for(i=0;i<n/2;i++)
            {
                aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }
            for(i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
        static void pb8()
        {
            int n = 8, i, aux;

            int[] v = new int[] { 4, 6, 3, 1, 8, 42, 2, 3 };
            aux = v[0];
            for (i = 1; i < n; i++)
                v[i - 1] = v[i];
            v[n - 1] = aux;
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void pb9()
        {
            int n = 8, k;
            k = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[] { 7, 4, 2, 4, 8, 9, 0, 0 };
            int aux = v[0];
            for (int i = 1; i < n; i++)
            {
                v[i - 1] = v[i];
                k--;
                if (k == 0)
                    break;
            }

            v[n - 1] = aux;
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void pb10()
        {
            int n,k,pozk=-1;
            int[] v = new int[] { 321,2,52,1,77,5 };
            n = 6;
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                    pozk = i;
            Console.WriteLine(pozk);

        }
        static bool NrPrim(int n)
        {

            if (n == 0)
                return false;
            if (n == 1)
                return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        static void pb11()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
                if (NrPrim(i))
                    Console.Write(i + " ");

        }
        static void pb12()
        {
            int n;
            n = 7;
            int[] v = new int[] { 4, 6, 8, 2, 11, 42, 333 };
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void pb13()
        {
            int[] v = new int[] { 47, 23, 12, 17, 30 };
            int aux = 0, n = 5, p;
            for (int i = 1; i < n; i++)
            {
                p = i;
                while (p > 0 && v[p] < v[p - 1])
                {
                    aux = v[p];
                    v[p] = v[p - 1];
                    v[p - 1] = aux;
                    p--;
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void pb14()
        {
            int[] v = new int[] { 1, 8, 3, 3, 2, 2, 0, 2, 0 };
            int n = 9, j = n - 1, aux, k = 0, poz = 0, poz1 = 0, i = 0;
            bool ok;
            for (i = 0; i < n; i++)
                if (v[i] == 0)
                    poz++;
            while (poz != 0)
            {

            }


            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void pb15()
        {
            int n = 9, i, j, poz;

            int[] v = new int[] { 4, 2, 8, 1, 2, 3, 1, 0, 3 };
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                    if (v[i] == v[j])
                    {
                        for (int d = j; d < n - 1; d++)
                            v[d] = v[d + 1];
                        n--;
                    }
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");


        }


        static void pb16()
        {
            int[] v = new int[] {8,2, 8,64, 8,8 , 8 };
            int aux, n = 7, aux1=0;
            aux = v[0];
            for (int i = 1; i < n; i++)
            {
                aux1 = v[i];
                while (aux1 != aux)
                {
                    if (aux1 > aux)
                        aux1 = aux1 - aux;
                    else
                        aux = aux - aux1;

                }
                
                
            }
          Console.WriteLine(aux1);
        }
        static void Main(string[] args)
        {
            //Pb1();
            //Pb2();
            //Pb3();
            //Pb4();
            //Pb5();
            //pb6();
            //pb7();
            //pb8();
            //pb9();
            //pb10();
            //pb11();
            //pb12();
            //pb13();
            //pb15();
            //pb16();



                

        }
    }
}
