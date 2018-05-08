using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öğrenci_otomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] notlar = new int[10, 3] { { 1, 11, 12 }, { 2, 22, 23 }, { 3, 33, 34 }, { 4, 11, 45 }, { 5, 22, 56 }, { 1, 33, 67 }, { 2, 11, 78 }, { 3, 22, 89 }, { 4, 33, 90 }, { 5, 11, 100 } };
            string[,] dersler = new string[3, 2] { {"11","Programlala" },{"22","Lineer" },{"33","Müzik" } };
            string[,] ogrenci = new string[5, 3] { {"1","Burak","Top" },{"2","Serhat","REYİZ" },{"3","Kağan","Naber" },{"4","İyi","Senden" },{ "5","Batuhan","Koç"} };

            /*
            int[,] notlar = new int[10, 3];
            string[,] dersler = new string[3, 2];
            string[,] ogrenci = new string[5, 3];
            */
            bool kapa = false;
            string h;
            while (!kapa)
            {
                Console.WriteLine("1-Öğrenci kaydet...\n2-Öğrencileri listele...");
                Console.WriteLine("3-Ders gir...\n4-Dersleri listele... ");
                Console.WriteLine("5-Notları gir...\n6-Notları listele...");
                Console.WriteLine("\n***************************************************");
                Console.WriteLine("\n7-Öğrenci not ortalaması...");
                Console.WriteLine("8-Tüm öğrencilerin not ortalaması...");
                Console.WriteLine("\n***************************************************");
                Console.WriteLine("\n0-Çıkış...");
                Console.WriteLine("\nLütfen seçiminizi yapın...");
                h = Console.ReadLine();


                switch (h)
                {
                    case "1":
                        for (int i = 0; i < ogrenci.GetLength(0); i++)
                        {

                            bool yanlis = false;
                            string girdi;
                            do
                            {
                                yanlis = false;
                                Console.WriteLine("{0}. Öğrencinin numarasını giriniz...", i + 1);

                                girdi = Console.ReadLine();
                                for (int j = 0; j < ogrenci.GetLength(0); j++)
                                {
                                    if (ogrenci[j, 0] == girdi)
                                    {
                                        yanlis = true;
                                    }
                                }
                                if (yanlis == true)
                                {
                                    Console.WriteLine("Bu numara daha önce kullanıldı...");
                                }
                            } while (yanlis);
                            ogrenci[i, 0] = girdi;
                            Console.WriteLine("{0}. Öğrencinin adı...", i + 1);
                            ogrenci[i, 1] = Console.ReadLine();
                            Console.WriteLine("{0}. Öğrencinin soyadı...", i + 1);
                            ogrenci[i, 2] = Console.ReadLine();
                            
                        }
                        break;
                    case "2":
                        for (int i = 0; i < ogrenci.GetLength(0); i++)
                            Console.WriteLine("{0,-12}{1,-12}{2,-12}",ogrenci[i,0],ogrenci[i,1],ogrenci[i,2]);
                        break;
                    case "3":
                        for (int i = 0; i < dersler.GetLength(0); i++)
                        {
                            bool yanlis = false;
                            string girdi;
                            do
                            {
                                yanlis = false;
                                Console.WriteLine("{0}. Ders numarasını giriniz...", i + 1);

                                girdi = Console.ReadLine();
                                for (int j = 0; j < dersler.GetLength(0); j++)
                                {
                                    if (dersler[j, 0] == girdi)
                                    {
                                        yanlis = true;
                                    }
                                }
                                if (yanlis == true)
                                {
                                    Console.WriteLine("Bu numara daha önce kullanıldı...");
                                }
                            } while (yanlis);
                            dersler[i, 0] = girdi;
                            Console.WriteLine("{0}. Dersin adı...", i + 1);
                            dersler[i, 1] = Console.ReadLine();
                        }
                        break;
                    case "4":
                        for (int i = 0; i < dersler.GetLength(0); i++)
                            Console.WriteLine("{0,-12}{1,-12}", dersler[i, 0], dersler[i, 1]);
                        break;
                    case "5":
                        for (int i = 0; i < notlar.GetLength(0); i++)
                        {
                            int not;
                            string girdi1;
                            bool yanlis=false;
                            string girdi;
                            do
                            {
                                yanlis = true;
                                Console.WriteLine("{0}. not için Öğrenci numarasını giriniz...", i + 1);
                                girdi = Console.ReadLine();
                                
                                for (int j = 0; j < ogrenci.GetLength(0); j++)
                                {
                                    if (ogrenci[j, 0] == girdi)
                                        yanlis = false;
                                    
                                }
                                if (yanlis==true)
                                {
                                    Console.WriteLine("Böyle bir öğrenci yok...");
                                }
                            } while (yanlis);
                            do {
                                yanlis = true;
                                Console.WriteLine("{0}. not için ders numarası giriniz... ", i + 1);
                                girdi1 = Console.ReadLine();
                                for (int k = 0; k < dersler.GetLength(0); k++)
                                {
                                    if (dersler[k, 0] == girdi1)
                                        yanlis = false;
                                }
                                if (yanlis == true)
                                {
                                    Console.WriteLine("Böyle bir ders numarası yok...");
                                }
                            } while (yanlis);
                            do
                            {
                                yanlis = false;
                                Console.WriteLine("{0}. notu girin...", i + 1);
                                not=Convert.ToInt32(Console.ReadLine());
                                if (not<0||not>100)
                                {
                                    Console.WriteLine("Yanlış bir not girdiniz...");
                                    yanlis = true;
                                }
                            } while (yanlis);
                            notlar[i, 0] = Convert.ToInt32(girdi);
                            notlar[i, 1] = Convert.ToInt32(girdi1);
                            notlar[i, 2] = not;
                        }
                        break;
                    case "6":
                        for (int i = 0; i < notlar.GetLength(0); i++)
                        {
                            for (int j = 0; j < ogrenci.GetLength(0); j++)
                            {
                                if (notlar[i,0]==Convert.ToInt32(ogrenci[j,0]))
                                {
                                    Console.Write("{0,-12} {1,-12}", ogrenci[j, 1], ogrenci[j, 2]);
                                }
                            }
                            for (int j = 0; j < dersler.GetLength(0); j++)
                            {
                                if (notlar[i, 1] == Convert.ToInt32(dersler[j, 0]))
                                    Console.Write("{0,-12}", dersler[j, 1]);
                            }
                            Console.WriteLine("{0,-3} ", notlar[i, 2]);
                        }
                        break;
                    case "7":
                        int girdino;
                        bool hata = true;
                        do
                        {
                            hata = true;
                            Console.Write("Öğrenci numarası giriniz...");
                            girdino = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < ogrenci.GetLength(0); i++)
                            {
                                if (Convert.ToInt32(ogrenci[i, 0]) == girdino)
                                {
                                    hata = false;
                                }
                               
                            }
                            if (hata)
                                Console.WriteLine("Böyle bir öğrenci yoh...");

                        } while (hata);
                        for (int i = 0; i < dersler.GetLength(0); i++)
                        {
                            int toplam=0,adet = 0;
                            for (int j = 0; j < notlar.GetLength(0); j++)
                            {
                                if (Convert.ToInt32(dersler[i,0])==notlar[j,1] &&notlar[j,0]==girdino)
                                {
                                    toplam = toplam + notlar[j, 2];
                                    adet++;
                                }
                            }
                            if (toplam == 0)
                                Console.WriteLine("Öğrenci için {0} adlı derste kayıt bulunamadı...", dersler[i, 1]);
                            else
                                Console.WriteLine("{0}******{1}", dersler[i, 1], (float)toplam / (float)adet);
                        }
                        break;
                    case "8":
                        for (int i = 0; i <ogrenci.GetLength(0); i++)
                        {
                            int toplam = 0, adet = 0;
                            for (int j = 0; j < notlar.GetLength(0); j++)
                            {
                                if (notlar[j,0]==Convert.ToInt32(ogrenci[i,0]))
                                {
                                    toplam = toplam + notlar[j, 2];
                                    adet++;
                                }
                            }
                            if (toplam == 0)
                                Console.WriteLine(" {0}   {1} adlı kayıt bulunamadı...", ogrenci[i, 1],ogrenci[i,2]);
                            else
                                Console.WriteLine("{0}    {1}****{2}", ogrenci[i, 1], ogrenci[i,2], (float)toplam / (float)adet);
                        }
                        break;
                    case "0":
                        kapa = true;
                        break;
                }
                if (!kapa)
                {
                    Console.WriteLine("Menüye dönmek için ENTER'a basınız...");
                    Console.ReadLine();
                    Console.Clear();
                }
                //Nuri Kağan KURUBAŞ 
                //201713709054
            }
        }
    }
}
