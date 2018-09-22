namespace SayiTahmin
{
    using System;
    class tahmin
    {
        public static void Main()
        {
            int b, a, sabit;
            string cevap;
            for(;;)
            {
            Console.Write("0-100 arası bir sayı giriniz: ");
            b = int.Parse(Console.ReadLine());
                if (b > 100 || b < 0)
                {
                    Console.WriteLine("Girilen Sayı 0 ile 100 arasında değil! Tekrar Giriniz!");
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
            a = 50;
            sabit = 50;
            for (;;)
            {
                
                
                if (sabit != b)
                {

                    if (sabit > 100)
                    {
                        sabit = 100;
                        Console.WriteLine("Bence Tuttuğun Sayı 100'den küçük :) o yüzden AŞAĞI İniyorum.");
                        a = a / 2;
                        sabit = sabit - a - 1;
                    }
                    if (sabit < 0)
                    {
                        sabit = 0;
                        Console.WriteLine("Bence Tuttuğun Sayı 0'dan büyük :) o yüzden YUKARI çıkıyorum.");
                        a = a / 2;
                        sabit = sabit + a + 1;
                    }
                    if (sabit == b)
                    {
                        Console.WriteLine("Buldum tuttuğun sayı bu :  " + sabit + "  :) ");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("Tahminim -- " + sabit + " -- Doğru mu?");
                    Console.Write("Aşağı/Yukarı [A]/[Y]:");
                    cevap = Console.ReadLine().ToUpper();
                    if (cevap != "A" && cevap != "Y")
                    {
                        Console.Clear();
                        Console.WriteLine("Aşağı mı? Yukarı mı? yanlış giriş yaptınız! TEKRAR DENE!");
                    }
                    else if (cevap == "A")
                    {
                        a = a / 2;
                        sabit = sabit - a - 1;
                    }
                    else if (cevap == "Y")
                    {
                        a = a / 2;
                        sabit = sabit + a + 1;
                    }
                    
                }
            }
        }
    }

}