using System;
using System.Collections.Generic;
using System.Text;

namespace YENİSEÇİM
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Vatandaş Vatandaş1 = new Vatandaş("AHMET", "BULDU", 19);
            Vatandaş Vatandaş2 = new Vatandaş("MAHMUT", "KIRMIZI", 34);
            Vatandaş Vatandaş3 = new Vatandaş("MISRA", "ŞİMŞEK", 27);
            Vatandaş Vatandaş4 = new Vatandaş("RÜYA", "İÇİCİ", 55);
            Vatandaş Vatandaş5 = new Vatandaş("AKİF", "YILDIZ", 42);
            Vatandaş Vatandaş6 = new Vatandaş("İLHAN", "OSMANOĞLU", 19);
            Vatandaş Vatandaş7 = new Vatandaş("ÖMER", "ENVER", 23);
            Vatandaş Vatandaş8 = new Vatandaş("HARUN", "TAŞÇI", 36);
            Vatandaş Vatandaş9 = new Vatandaş("METİN", "BULUT", 20);
            Vatandaş Vatandaş10 = new Vatandaş("FATİH", "TAN", 29);




            Parti PartiAday1 = new Parti("ALİ", "MERT", "DOKTOR", "A Partisi", "A Partisi idealist bir partidir ve teknoloji gelişimini destekler..", "A Partsisinin Hedefi ülkede büyüyk bir teknoloji reformu gerçekleştirmektir.");
            Parti PartiAday2 = new Parti("MEHMET", "YILMAZ", "AVUKAT", "A Partisi", "A Partisi idealist bir partidir ve teknoloji gelişimini destekler..", "A Partsisinin Hedefi ülkede büyüyk bir teknoloji reformu gerçekleştirmektir.");
            Parti PartiAday3 = new Parti("YUSUF", "DEMİR", "EKONOMİST", "B Partisi", "B Partisi tarım alanında yaptığı reformlarla çiftçiyide destekleyecek", "B Partisinin amacı gelişmiş bir Tarım ülkesi olmaktır.");
            Parti PartiAday4 = new Parti("KAMİL", "YILDIRIM", "YÖNETİCİ", "B Partisi", "B Partisi tarım alanında yaptığı reformlarla çiftçiyide destekleyecek", "B Partisinin amacı gelişmiş bir Tarım ülkesi olmaktır.");
            Parti PartiAday5 = new Parti("FUAT", "MUTLU", "İŞLETMECİ", "C Partisi", "C Partisi devletçi bir partidir sanayi alanında reform yaparak saniyiyi güçlendirme fikrini benimsiyor.", "C Partisinin amacı sanayiyi savunma alanında ağırlıklı olarak güçlendirip devleti daha güçlü bir konuma getirmektir.");
            Parti PartiAday6 = new Parti("CAN", "GÜÇLÜ", "ÖĞRETMEN", "C Partisi", "C Partisi devletçi bir partidir sanayi alanında reform yaparak saniyiyi güçlendirme fikrini benimsiyor.", "C Partisinin amacı sanayiyi savunma alanında ağırlıklı olarak güçlendirip devleti daha güçlü bir konuma getirmektir.");

          /*  Console.WriteLine("A Partisinin Adayları :");
            Console.WriteLine(" ");
            Console.WriteLine("1. Aday Bilgileri");
            Console.WriteLine(" ");
            PartiAday1.AdayBilgileriGöster();
            Console.WriteLine(" ");
            Console.WriteLine("2. Aday Bilgileri ");
            Console.WriteLine(" ");
            PartiAday2.AdayBilgileriGöster();
            Console.WriteLine(" ");
            Console.WriteLine("A Partisinin Bilgileri :");
            Console.WriteLine(" ");
            PartiAday1.PartiBilgileriGöster();
            Console.WriteLine(" ");
            Console.WriteLine(" ");*/ // case lere ayrı ayrı parti bilgilerini  gir

            Vatandaş1.OyKullan();
            Console.WriteLine("1");
            Vatandaş2.OyKullan();
            Console.WriteLine("2");
            Vatandaş3.OyKullan();
            Console.WriteLine("3");
            Vatandaş4.OyKullan();
            Vatandaş5.OyKullan();
            Vatandaş6.OyKullan();
            Vatandaş7.OyKullan();
            Vatandaş8.OyKullan();
            Vatandaş9.OyKullan();
            Vatandaş10.OyKullan();
            
            
            Console.ReadLine();
        }
    }
}
