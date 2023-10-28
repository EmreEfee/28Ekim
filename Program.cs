using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Ekim
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            m.Topla(5.4, 1.6);


            m.Topla(5, 4, 1.6, 2.8);

            m.Topla();
            */


            // Örnek
            //Kullanıcıdan 2 adet sayı talep edelim

            //Bir adet işlem türü talep edelim
            //İşlem türüne göre sonucu ekrana yazdıralım
            //Kullanıcı işlem türü girmiyor ise direkt toplama işlemi yaptıralım

            // Not: String bir ifade boş mu diye kontrol etmek için "IsNullOrEmpty" kullanılır.

            /*
            OverLoadMetodlar hesapmakinesi = new OverLoadMetodlar();

            Console.WriteLine("Birinci sayıyı girin: ");
                            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.WriteLine("İşlem türünü seçin (+, -, *, /): ");
            string islemTuru = Console.ReadLine();

            double sonuc = hesapmakinesi.Hesapla(sayi1, sayi2, islemTuru);

            Console.WriteLine("Sonuç : " + sonuc);
            */
            /*
            Console.WriteLine("1. Sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("İşlem türünü seçiniz (+, -, *, /)");
            string secim = Console.ReadLine();

            OverLoadMetodlar islem = new OverLoadMetodlar();

            if (string.IsNullOrEmpty(secim))
            {
                islem.Hesapla(sayi1, sayi2);
            }
            else
            {
                islem.Hesapla(sayi1, sayi2, secim);
            }

            Console.ReadKey();
            */

            // Static Metodlar

            // Şimdiye kadar oluşturduğumuz sınıfları program içerisine dahil etmek için "new" ifadesini kullanıyorduk
            //"new" ifadesi sayesinde çağırdığımız class yapısı içerisindeki fonksiyonlara erişim sağlıyorduk.
            //Metodlarımıza "new" ifadesi olmadan direkt olarak ulaşabiliriz. 
            //Classlara ve içerisindeki metodlara direkt erişim sağlamak için "static" komutunuu kullanırız.
            // !!! DİREKT ERİŞİM SAĞLAMAK İSTEDİĞİNİZ CLASS IN BAŞINA "STATİC" KELİMESİNİ EKLEDİĞİMİZDE 
            // İÇERİSİNDE TANIMLANAN FONKSİYONLARINDA STATİC OLMASI ZORUNLULDUR.!!!

            /*

            Metod.Topla(5, 6);



            */


            //Kullanıcıdan aldığımız 2 sayıdan hangisinin büyük olduğunu metod kullanarak ekrana yazdıralım




            Console.WriteLine("Birinci sayıyı girin: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin: ");
            int s2 = int.Parse(Console.ReadLine());

            Metod.Karsilastir(s1, s2);





            Console.ReadKey();
        }
    }
}
