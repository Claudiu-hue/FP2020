using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentele_Programarii
{
    class Program
    {
        //POOL 1
        static void Pb1()
        {
            float a, b;
            Console.Write("introduceti a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("x=" + -b / a);


        }
        static void Pb2()
        {
            float a, b, c;
            float delta;
            Console.Write("introduceti a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = float.Parse(Console.ReadLine());
            Console.Write("introduceti c=");
            c = float.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta < 0)
                Console.WriteLine("nu are solutii");
            else
                if (delta > 0)
            {
                Console.WriteLine((float)((-b + Math.Sqrt(delta)) / (2 * a)));
                Console.WriteLine((float)((-b - Math.Sqrt(delta)) / (2 * a)));
            }
            if (delta == 0)
                Console.WriteLine(-b / (2 * a));

        }
        static void Pb3()
        {
            int n, k;
            Console.Write("introduceti n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("introduceti k=");
            k = Convert.ToInt32(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("n se div cu k");
            else
                Console.WriteLine("nu il divide");

        }

        static bool Pb4()
        {
            int an;
            an = int.Parse(Console.ReadLine());

            if (an % 4 == 0 && an % 100 != 0)
                return true;
            else
                return false;
        }
        static void Pb5()
        {
            int n, k, kextras;
            kextras = 0;
            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a k cifra");
            k = int.Parse(Console.ReadLine());
            while (k > 1)
            {
                n = n / 10;
                k--;

            }
            kextras = n % 10;
            Console.WriteLine(kextras);
        }
        static void Pb6()
        {
            int a, b, c;
            Console.WriteLine("Introduceti un numar");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            c = int.Parse(Console.ReadLine());
            if ((a < b + c) && (b < a + c) && (c < a + b))
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");
        }

        static void Pb7()
        {
            float a, b, aux;
            Console.Write("introduceti a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = float.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("a=" + a + " " + "b=" + b);
        }
        static void Pb8()
        {
            float a, b;
            Console.Write("introduceti a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(a + b - a);
            Console.WriteLine(a + b - b);
        }

        static void Pb9()
        {
            int n;
            Console.Write("Introduceti un numar=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    Console.Write(i + " ");
            Console.WriteLine(n);
        }
        static bool Pb10()
        {
            int n;
            Console.Write("Introduceti un numar=");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                return false;
            if (n == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;


        }
        static int Pb11()
        {
            int n;
            Console.Write("Introduceti un numar=");
            n = int.Parse(Console.ReadLine());
            int aux = 0;
            while (n > 0)
            {
                aux = aux * 10 + n % 10;
                n = n / 10;
            }
            return aux;

        }
        static void Pb12()
        {
            int a, b, n, i;
            Console.Write("introduceti a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            if (a > b)
                for (i = b; i <= a; i++)
                    if (i % n == 0)
                        Console.WriteLine(i + " ");
            if (a < b)
                for (i = a; i <= b; i++)
                    if (i % n == 0)
                        Console.WriteLine(i + " ");
        }




        static void Pb13()
        {
            int y1, y2, i;
            Console.Write("introduceti y1=");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("introduceti y2=");
            y2 = int.Parse(Console.ReadLine());
            if (y1 > y2)
                for (i = y2; i <= y1; i++)
                    if (i % 4 == 0 && i % 100 != 0)
                        Console.Write(i + " ");
            if (y1 < y2)
                for (i = y1; i <= y2; i++)
                    if (i % 4 == 0 && i % 100 != 0)
                        Console.Write(i + " ");

        }









        static void Pb14()
        {
            int n, aux, oglindit;
            oglindit = 0;
            Console.Write("Introduceti un numar=");
            n = int.Parse(Console.ReadLine());
            aux = n;
            while (aux > 0)
            {
                oglindit = oglindit * 10 + aux % 10;
                aux = aux / 10;
            }

            if (n == oglindit)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");
        }

        /* static void descinfp(int n)
         {
             int aux=n,i;
             for (i = 2; i <= n; i++)
                 if (Numarprim(i))
                     while (aux % i == 0)
                     {
                         Console.Write(i + "*");
                         aux = aux / i;
                     }
         }
        */

        static void Pb15()
        {
            int a, b, c;
            Console.Write("introduceti a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti c=");
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                if (b > c)
                    Console.Write(c + " " + b + " " + a);
                else
                    Console.Write(b + " " + c + " " + a);
            if (b > a && b > c)
                if (a > c)
                    Console.Write(c + " " + a + " " + b);
                else
                    Console.Write(a + " " + c + " " + b);
            if (c > a && c > b)
                if (b > a)
                    Console.Write(a + " " + b + " " + c);
                else
                    Console.Write(b + " " + a + " " + c);
            Console.WriteLine();

        }
        static void Pb16()
        {
            int a, b, c, d, e, min, max;
            min = -1;
            max = -1;
            Console.Write("introduceti a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti c=");
            c = int.Parse(Console.ReadLine());
            Console.Write("Introduceti d=");
            d = int.Parse(Console.ReadLine());
            Console.Write("Introduceti e=");
            e = int.Parse(Console.ReadLine());
            if (a < b && a < c && a < d && a < e)
                min = a;
            else
                if (b < a && b < c && b < d && b < e)
                min = b;
            else
                    if (c < a && c < b && c < d && c < e)
                min = c;
            else
                        if (d < a && d < b && d < c && d < e)
                min = d;
            else
                if (e < a && e < b && e < c && e < d)
                min = e;
            if (a > b && a > c && a > d && a > e)
                max = a;
            else
                if (b > a && b > c && b > d && b > e)
                max = b;
            else
                    if (c > a && c > b && c > d && c > e)
                max = c;
            else
                        if (d > a && d > b && d > c && d > e)
                max = d;
            else
                if (e > a && e > b && e > c && e > d)
                max = e;

            for (int i = min; i <= max; i++)
            {
                if (i == a)
                    Console.Write(a + " ");
                if (i == b)
                    Console.Write(b + " ");
                if (i == c)
                    Console.Write(c + " ");
                if (i == d)
                    Console.Write(d + " ");
                if (i == e)
                    Console.Write(e + " ");
            }
        }
        static void Pb17()
        {
            int a, b, x, y;
            Console.Write("introduceti a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("introduceti b=");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;

            }
            Console.Write("CMMDC=");
            Console.WriteLine(a);
            Console.Write("CMMMC=");
            Console.WriteLine((x * y) / a);
        }
        static void Pb18()
        {
            int n, numar;
            numar = 2;
            bool ok = true;
            Console.Write("Introduceti n=");
            n = int.Parse(Console.ReadLine());
            while (n >= 1)
            {
                ok = true;
                for (int i = 2; i <= numar / 2; i++)
                    if (numar % i == 0)
                        ok = false;

                if (n % numar == 0 && ok == true)
                {
                    n = n / numar;
                    Console.Write(numar + " ");
                }
                else
                    numar++;
                if (n == 1)
                    break;
            }
        }
        static void Pb19()
        {
            int n;
            Console.Write("Introduceti un n=");
            n = int.Parse(Console.ReadLine());
            int aux, nr, aux1 = 0, ok = 1;
            nr = n;
            aux = n % 10;
            n = n / 10;
            while (n != 0)
            {
                if (aux != n % 10)
                {
                    aux1 = n % 10;
                    n = n / 10;
                }
                n = n / 10;

            }
            while (nr != 0)
            {
                if (nr % 10 != aux && nr % 10 != aux1)
                {

                    ok = 0;
                    Console.WriteLine("nu e format din 2 cifre");
                    break;
                }
                nr = nr / 10;

            }
            if (ok == 1)
                Console.WriteLine("da");
        }
        static void Pb20()
        {
            int m, n;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
        static void Pb21()
        {
            Random rdn = new Random();
            int x, n;
            x = rdn.Next(1, 1024);
            Console.WriteLine(x);
            do
            {

                n = int.Parse(Console.ReadLine());
                if (n < x)
                    Console.WriteLine("Introduceti un numar mai mare");
                else
                    if (n > x)
                    Console.WriteLine("Introduceti un numar mai mic");
                if (n == x)
                    Console.WriteLine("Felicitari!");
            }
            while (x != n);
        }

        static void Main(string[] args)
        {

            // Pb1();
            // Pb2();
            // Pb3();
            // Pb4();
            //Pb5();
            //Pb6();
            //Pb7();
            //Pb8();
            //Pb9();
            //Console.WriteLine(Pb10());
            //Console.WriteLine(Pb11());
            //Pb12();
            //Pb13();
            // Pb14();
            //Pb15();
            //Pb16();
            //Pb17();
            //Pb18();
            //Pb19();
            // Pb20();
            //Pb21();


        }
    }
}
