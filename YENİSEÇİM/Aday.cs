using System;
using System.Collections.Generic;
using System.Text;

namespace YENİSEÇİM
{
    public class Aday



    {
        public string Adayİsim;
        public string AdaySoyisim;
        public string AdayMeslek;

        public Aday(string Adayİsim, string AdaySoyisim,string AdayMeslek  )
        {
            this.Adayİsim = Adayİsim;
            this.AdaySoyisim = AdaySoyisim;
            this.AdayMeslek = AdayMeslek;
        }
        
        public void AdayBilgileriGöster()
        {
            Console.WriteLine("ADAYIN İSMİ : " + Adayİsim);
            Console.WriteLine("ADAYIN SOYİSİMİ : " + AdaySoyisim);
            Console.WriteLine("ADAYIN MESLEĞİ : " + AdayMeslek);
        }
      


    }
}
