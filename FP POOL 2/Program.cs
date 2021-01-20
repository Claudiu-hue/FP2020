using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_POOL_2
{
    class Program
    {
        static void Pb1()
        {
            int n,numar,nr=0;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Introduceti un numar=");
                numar = int.Parse(Console.ReadLine());
                if (numar % 2 == 0)
                    nr++;
                n--;
            }
            while (n != 0);
            Console.WriteLine(nr);
        }
        static void Pb2()
        {
            int n, numar, nr,nr1,nr2;
            nr = 0;
            nr1 = 0;
            nr2 = 0;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Introduceti un numar=");
                numar = int.Parse(Console.ReadLine());
                if (numar<0)
                    nr++;
                if (numar == 0)
                    nr1++;
                if (numar > 0)
                    nr2++;
                n--;
            }
            while (n != 0);
            Console.WriteLine("Numere negative:"+nr+" "+"Numere egale cu 0 :"+nr1+" "+"Numere pozitive:"+nr2);
        }
        static void Pb3()
        {
            long n,numar,suma,produs;
           
            n = long.Parse(Console.ReadLine());
            numar = 1;
            suma = 0;
            produs = 1;
            do
            {
                suma = suma + numar;
                produs = produs * numar;
                numar++;
               
            }
            while (numar <= n);
            Console.WriteLine("Suma este:"+suma);
            Console.WriteLine("Produsul este:"+produs);
        }
        static void Pb4()
        {
            int n, numar,a,nr=-1;
            bool ok = true;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul al carui poz vreti sa o aflati:");
            a = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Introduceti un numar=");
                numar = int.Parse(Console.ReadLine());
                nr++;
                if (a == numar)
                {
                    Console.WriteLine("Numarul este pe pozitia:" + nr);
                    ok = false;
                    break;
                    
                }
            }
            while (nr<n-1);
            if(ok==true)
                Console.WriteLine(-1);
        }
        static void Pb5()
        {
            int n, numar, nr, nr1;
            nr = 0;
            nr1 = 0;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Introduceti un numar=");
                numar = int.Parse(Console.ReadLine());
                if (numar == nr)
                    nr1++;
                nr++;

            }
            while (nr < n);
            Console.WriteLine("Sunt"+" "+ nr1 +" "+"numere");
        }
        static void Pb6()
        {
            int n, numar,numar1, nr = 0;
            bool ok = true;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Citim prima cifra din cele n cifre:");
            numar1 = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Introduceti un numar=");
                numar = int.Parse(Console.ReadLine());
                if (numar1 > numar)
                {
                    ok = false;
                    break;
                }
                numar1 = numar;
                n--;
            }
            while (n>1);
            if(ok==true)
                Console.WriteLine("Ii o secventa crescatoare");
            else
                Console.WriteLine("Nu ii o secventa crescatoare");
        }
        static void Pb7()
        {
            int n, numar,max,min;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Citim prima cifra din cele n cifre:");
            numar = int.Parse(Console.ReadLine());
            max = numar;
            min = numar;
            do
            {
                Console.Write("Introduceti un numar=");
                numar = int.Parse(Console.ReadLine());
                if (numar > max)
                    max = numar;
                if (numar < min)
                    min = numar;


                n--;
            }
            while (n > 1);
            Console.WriteLine("Maximul este:"+max);
            Console.WriteLine("Minimul este:"+min);
        }
        static void Pb8()
        {
            int n,f1,f2,fn;
            fn = 0;
            f1 = 0;
            f2 = 1;
            n = int.Parse(Console.ReadLine());
           for(int i=3;i<=n;i++)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
                //Console.Write(fn+" ");
            }
            Console.WriteLine(fn);

        }
        static void Pb9()
        {
            int n,numar,numar2;
            bool ok = true;
            bool ok1 = true;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti primul numar din cele n numere:");
            numar2 = int.Parse(Console.ReadLine());
            for(int i=2;i<=n;i++)
            {
                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                if (numar2 > numar)
                    ok = false;
                if (numar2 < numar)
                    ok1 = false;
                numar2 = numar;
            }
            if(ok==true && ok1==true)
                Console.WriteLine("Secventa poate fi si crescatoare si descrescatoare");
            else
                if(ok==true)
                    Console.WriteLine("cresc");
            else

            if(ok1==true)
                Console.WriteLine("desc");
            if(ok==false && ok1==false)
                Console.WriteLine("Secventa nu este nici crescatoare nici descrescatoare");
        }
        static void Pb10()
        {
            int n, numar,numar2,nr=0,nrmax=0;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti primul numar din cele n numere:");
            numar2 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                
                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                if (numar2 == numar)
                    nr = nr + 1;
                else
                    nr = 0;
                if (nr > nrmax)
                    nrmax = nr;
                numar2 = numar;
            }
            if(nrmax==0)
                Console.WriteLine(nrmax);
            else
                Console.WriteLine(nrmax+1);
        }
        static void Pb11()
        {
            int n, numar,suma=0;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                suma = 0;
                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                while(numar>0)
                {
                    suma = suma + numar % 10;
                    numar = numar / 10;
                }
                Console.WriteLine(suma+" ");
            }
        }
        static void Pb12()
        {
            int n, numar, numar2, nr = 0,nrmax=0;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {

                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                if (numar==0 && nr>1)
                {
                    nrmax++;
                    nr = 0;
                }
                else
                    nr++;
                
              
            }
            Console.WriteLine(nrmax);
        }
        static void Pb13()
        {
            int n, numar,numar2,aux;
            bool ok = true;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti primul numar din cele n numere:");
            numar2 = int.Parse(Console.ReadLine());
            aux = numar2;
            Console.Write("Introduceti un numar");
            numar2 = int.Parse(Console.ReadLine());
            for (int i = 3; i <= n; i++)
            {

                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                if (numar2 > numar)
                    ok = false;
                numar2 = numar;
                
            }
            if (numar2 > aux)
                ok = false;

            if(ok==true)
                Console.WriteLine("Este o secventa crescatoare rotita. ");
            else
                Console.WriteLine("Nu este o secventa crescatoare rotita. ");
        }
        static void Pb14()
        {
            int n, numar, numar2, aux,nr=0,nr1=0;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti primul numar din cele n numere:");
            numar2 = int.Parse(Console.ReadLine());
            aux = numar2;
            Console.Write("Introduceti un numar");
            numar2 = int.Parse(Console.ReadLine());
            for (int i = 3; i <= n; i++)
            {

                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                if (numar2 > numar)
                
                    
                    nr++;
                
                else
                    if(numar2<numar)
                        nr1++;
                


                numar2 = numar;

            }
            if (numar2 > aux)
            
               
                nr++;
            
            else
                if(numar2<aux)
                    nr1++;
            if(nr!=0 && nr1!=0)
                Console.WriteLine("Secventa nu este monotona rotita");
            else
                Console.WriteLine("Secventa este monotona rotita");
        }
        static void Pb15()
        {
            int n, numar, numar2;
            bool ok = true;
            bool ok1 = true;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti primul numar din cele n numere:");
            numar2 = int.Parse(Console.ReadLine());
            for (int i=2;i<=n;i++)
            {
                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                if (numar2 > numar)
                    ok = false;
                if (numar2 < numar && ok == false)
                    ok1 = false;
                numar2 = numar;


                
            }
            if(ok==false && ok1==true)
                Console.WriteLine("Bitonica");
            else
                Console.WriteLine("Nu e bitonica");
            


        }
        static void Pb16()
        {
            int n, numar, numar2,aux;
            bool ok = true;
            bool ok1 = true;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti primul numar din cele n numere:");
            numar2 = int.Parse(Console.ReadLine());
            aux = numar2;
            numar2 = int.Parse(Console.ReadLine());
            n=n-2;
            while(n>0)
            {
                Console.Write("Introduceti un numar:");
                numar = int.Parse(Console.ReadLine());
                if (numar2 > numar)
                    ok = false;
                if (numar2 < numar && ok == false && n>1)
                    ok1 = false;
                if (aux > numar && n == 1)
                    ok1 = false;

                numar2 = numar;
                n--;


            }
            if (ok == false && ok1 == true)
                Console.WriteLine("Bitonica rot");
            else
                Console.WriteLine("Nu e bitonica rot");

        }
        static void Pb17()
        {
            int n, numar, numar2,nr=0,nrmax=0;
            bool ok = true;
            Console.Write("Cate numere doriti:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti primul numar din cele n numere:");
            numar2 = int.Parse(Console.ReadLine());
            if (numar2 == 1)
                Console.WriteLine("Incorect");
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    Console.Write("Introduceti un numar:");
                    numar = int.Parse(Console.ReadLine());
                    if (numar2 == 0 && numar == 1 && i > 2 && i <= n - 1)
                        nr++;
                    if (numar == 0 && i == n)
                    {
                        Console.WriteLine("Incorect");
                        ok = false;
                    }
                    numar2 = numar;

                }
                if(ok==true)
                    Console.WriteLine(nr);
            }
        }
        static void Main(string[] args)
        {
            // Pb1();
            // Pb2();
            // Pb3();
            //Pb4();
            //Pb5();
            //Pb6();
            //Pb7();
            //Pb8();
            //Pb9();
            //Pb10();
            //Pb11();
            //Pb12();
            //Pb13();
            //Pb14();
            //Pb15();
            //Pb16();
            //Pb17();
        }
    }
}
