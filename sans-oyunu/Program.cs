using System;
using System.Data;
namespace uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            int[] tahmin = new int[5];
            int b;
            b = 0;
            int k;
            k = 0;
            string sec;

            while (k < 2)
            {
                Console.WriteLine("....hosgeldiniz .....");
                Console.WriteLine("... 5 tane rakam tahmin edip ikramiyeyi kazanmaya hazır mısınız ? ....");
                Console.WriteLine("....Haydi başlayalım....");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i + 1 + "tahmin edilen sayi: ");
                    tahmin[i] = Convert.ToInt32(Console.ReadLine());
                    //Console.Clear();
                }
                //Console.Clear();
                Console.WriteLine("....tahmin edilen değerler....");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("..." + tahmin[i] + "...");
                }
                Console.WriteLine(" ");
                Console.WriteLine("****Çeliliş te çıkan sayılar****");
                for (int i = 0; i < 5; i++)
                {
                    Random rastgele = new Random();
                    int a;
                    a = rastgele.Next(0, 10);
                    sayilar[i] = a;
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("..." + sayilar[i] + "...");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 5; i++)
                {
                    if (sayilar[i] == tahmin[i])
                    {
                        Console.WriteLine(i + 1 + " inci tahmininiz doğru. ");
                        b++;
                    }
                }
                Console.WriteLine("toplamda " + b + " kadar tahmin tuturdunuz");
                if (b == 1)
                {
                    Console.WriteLine("....Tebrikler amorti....");
                }
                if (b == 2)
                {
                    Console.WriteLine("....10.000 tl kazandınız....");
                }
                if (b == 3)
                {
                    Console.WriteLine("....50.000 tl kazandınız....");
                }
                if (b == 3)
                {
                    Console.WriteLine("....100.000 tl kazandınız....");
                }
                if (b == 4)
                {
                    Console.WriteLine("...250.000 tl kazandınız....");
                }
                if (b == 5)
                {
                    Console.WriteLine("....500.000 tl kazandınız....");
                }
                if (b == 0)
                {
                    Console.WriteLine("....Malesef kaybettiniz....");
                }
                Console.WriteLine("....tekrar oynamak ister misiniz....");
                Console.WriteLine("....evet yada hayır yazınız....");
                sec = Console.ReadLine();
                if (sec == "evet")
                {
                    k = 0;
                    Console.Clear();
                }
                if (sec == "hayır")
                {
                    k = 2;
                }
            }
        }
    }
}
