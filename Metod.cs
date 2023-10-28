using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Ekim
{
    static class Metod
    {
        public static void Topla(int s1,int s2)
        {

            Console.WriteLine("Sayıların toplamı :"+(s1+s2));





        }

        public static void Karsilastir(int s1, int s2)
        {
            if (s1 > s2)
            {
                Console.WriteLine("Birinci sayı büyük: "+s1);
            }
            else if (s1 == s2)
            {
                Console.WriteLine("Sayılar eşit");
            }
            else
            {
                Console.WriteLine("İkinci sayı daha büyük: "+s2);
            }
        }




    }
}
