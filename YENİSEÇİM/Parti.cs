using System;
using System.Collections.Generic;
using System.Text;

namespace YENİSEÇİM
{
    public class Parti : Aday
    {
        Aday Aday1 = new Aday("ALİ", "MERT", "DOKTOR");
        Aday Aday2 = new Aday("MEHMET", "YILMAZ", "AVUKAT");
        Aday Aday3 = new Aday("YUSUF", "DEMİR", "EKONOMİST");
        Aday Aday4 = new Aday("KAMİL", "YILDIRIM", "YÖNETİCİ");
        Aday Aday5 = new Aday("FUAT", "MUTLU", "İŞLETMECİ");
        Aday Aday6 = new Aday("CAN", "GÜÇLÜ", "ÖĞRETMEN");

        public string Partiİsim;
        public string PartiVaatler;
        public string PartiHedef;
       
        public Parti(string Adayİsim, string AdaySoyisim, string AdayMeslek, string Partiİsim ,string PartiVaatler, string PartiHedef) : base(Adayİsim, AdaySoyisim, AdayMeslek)
        {
            this.Partiİsim = Partiİsim;
            this.PartiVaatler = PartiVaatler;
            this.PartiHedef = PartiHedef;
           

        }
        public void PartiBilgileriGöster()
        {
            Console.WriteLine("Partinin İsmi :" +Partiİsim);
            Console.WriteLine("Partinin vaati :" + PartiVaatler);
            Console.WriteLine("Partinin Hedefi : "+ PartiHedef);
        }
        






        /* public void APartisiBilgiler()
         {
             Console.WriteLine("A Partisi Adaylar :");
             Console.WriteLine(" ");

             Aday1.AdayBilgileriGöster();
             Aday2.AdayBilgileriGöster();
             Console.WriteLine(" ");

             Console.WriteLine("A Partisi Vaatleri");
             Console.WriteLine(" ");
             Console.WriteLine("A Partisi idealist bir partidir ve teknoloji gelişimini destekler..");
             Console.WriteLine(" ");
             Console.WriteLine("A Partisi Hedefi ");
             Console.WriteLine(" ");
             Console.WriteLine("A Partsisinin Hedefi ülkede büyüyk bir teknoloji reformu gerçekleştirmektir.");
             Console.WriteLine(" ");
         }

         public void BPartisİBilgiler()
         {
             Console.WriteLine("B Partisi Adayları");
             Console.WriteLine(" ");

             Aday3.AdayBilgileriGöster();
             Aday4.AdayBilgileriGöster();
             Console.WriteLine(" ");

             Console.WriteLine("B Partisi Vaatleri");
             Console.WriteLine("B Partisi tarım alanında yaptığı reformlarla çiftçiyide destekleyecek");
             Console.WriteLine(" ");
             Console.WriteLine("B Partisinin Hedefi");
             Console.WriteLine(" ");
             Console.WriteLine("B Partisinin amacı gelişmiş bir Tarım ülkesi olmaktır.");
             Console.WriteLine(" ");

         }

         public void CPartisiBilgiler()
         {
             Console.WriteLine("C Partisi Adaylari");
             Console.WriteLine(" ");
             Aday5.AdayBilgileriGöster();
             Aday6.AdayBilgileriGöster();
             Console.WriteLine(" ");

             Console.WriteLine("C Partisi Vaatleri ");
             Console.WriteLine(" ");
             Console.WriteLine("C Partisi devletçi bir partidir sanayi alanında reform yaparak saniyiyi güçlendirme fikrini benimsiyor.");
             Console.WriteLine(" ");
             Console.WriteLine("C Partisi Hedefi");
             Console.WriteLine(" ");
             Console.WriteLine("C Partisinin amacı sanayiyi savunma alanında ağırlıklı olarak güçlendirip devleti daha güçlü bir konuma getirmektir.");
    }*/
    }  
}
