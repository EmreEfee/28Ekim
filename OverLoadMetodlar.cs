using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Ekim
{
    class OverLoadMetodlar
    {
        /*
        public double Hesapla(double sayi1, double sayi2, string islemTuru)
        {
            double sonuc = 0;

            if (string.IsNullOrEmpty(islemTuru))
            {
                Console.WriteLine("İşlem türü girilmedi, varsayılan olarak toplama yapılıyor.");
                sonuc = sayi1 + sayi2;
            }
            switch (islemTuru)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;

                    }
                    else
                    {
                        Console.WriteLine("Sıfıra bölme hatası!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem türü, varsayılan olarak toplama yapılıyor.");
                    sonuc = sayi1 + sayi2;
                    break;
            }
            return sonuc;
        */


        public void Hesapla (int s1, int s2)
        {
            Console.WriteLine("Geçerli bir işlem türü girmediğiniz için sayılar toplandı");
            Console.WriteLine("Sayıların toplamı: "+(s1+s2));


        }
        public void Hesapla (int s1, int s2, string IslemTuru)
        {
            string format = "{0} {1} {2} = {3}";
            double sonuc = 0;
            switch (IslemTuru)
            {
                case "+":
                    sonuc = s1 + s2;

                    break;
                case "-":
                    sonuc = s1 - s2;
                    break;
                case "*":
                    sonuc = s1 * s2;
                    break;
                case "/":
                    sonuc = s1 / s2;
                    break;

             
            }

            Console.WriteLine(format,s1,IslemTuru,s2, sonuc);

        }

        }

    }








    

