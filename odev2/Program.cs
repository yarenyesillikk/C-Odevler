using System;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir?

            double s1, s2, sonuc;
        
            Console.WriteLine("1.sayiyi giriniz :");
            s1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("2.sayiyi giriniz :");

            s2 = Convert.ToInt16(Console.ReadLine());

            sonuc = (s1 + s2) / (s1 - s2);

            Console.WriteLine("Farkın toplama bolumunden kalan : " + sonuc);
            Console.ReadKey();

            //2) Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir ?

            double s3, sonuc1;

            Console.WriteLine("Sayiyi giriniz :");
            s3 = Convert.ToInt16(Console.ReadLine());
            sonuc1 = (s3 - 10 + 20) / 2;
            Console.WriteLine("10 eksiğinin 20 fazlasının 2 ye bölümünden kalan : " + sonuc1);
            Console.ReadKey();

            //3) Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaz

            double Vize, Final, sonuc3;

            Console.WriteLine("Vize notunu giriniz");
            Vize = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz");
            Final = Convert.ToInt16(Console.ReadLine());
            sonuc3 = ((Vize * 0.30) + (Final * 0.70)) / 2;
                Console.WriteLine("Not ortalaması: " + sonuc3);
            Console.ReadKey();

            //4) Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.

            Console.Write("Lütfen ad soyad giriniz");

            string ad, soyad, mail;

            ad = Console.ReadLine();
            soyad = Console.ReadLine();
            mail = (ad +"."+soyad+"@hotmail.com");
            Console.WriteLine("Mail : " + mail);


            //5) Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir?

            int x, y, sonuc4;

            Console.WriteLine("x sayisini giriniz : ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("y sayisini giriniz : ");
            y = Convert.ToInt16(Console.ReadLine());
            sonuc4 = ((x * x + y * y) + (x * x - y * y));
            Console.WriteLine("karelerinin toplami ile karelerinin farki toplami : " + sonuc4);






        }
    }

}
