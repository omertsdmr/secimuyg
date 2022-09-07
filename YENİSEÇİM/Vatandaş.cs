using System;
using System.Collections.Generic;
using System.Text;

namespace YENİSEÇİM
{
    public class Vatandaş
    {

        bool Kontrol1 = true;

        public string Vatandaşİsim;
        public string VatandaşSoyisim;
        public int VatandaşYaş;
        
       public Vatandaş(string Vatandaşİsim,string VatandaşSoyisim,int VatandaşYaş)
        {
            this.Vatandaşİsim = Vatandaşİsim;
            this.VatandaşSoyisim = VatandaşSoyisim;
            this.VatandaşYaş = VatandaşYaş;
        }

       
        








        public void OyKullan()
        {

            int APartisiOySayısı = 0;
            int BPartisiOySayısı = 0;
            int CPartisiOySayısı = 0;

            while (Kontrol1)
            {

                MenüyüGöster();
                string kosul = Console.ReadLine();
                
                switch (kosul)
                {
                    
                    case "1":
                        Console.WriteLine("A partisi");
                        APartisiOySayısı += 1;
                        Console.WriteLine("A PARTİSİNİN OY SAYISI :" + APartisiOySayısı);
                    
                        break;
                    case "2":
                        Console.WriteLine("B partisi");
                        BPartisiOySayısı += 1;
                        Console.WriteLine("B PARTSİNİN OY SAYISI :" + BPartisiOySayısı);
                   
                        break;
                    case "3":
                        Console.WriteLine("C partisi");
                        CPartisiOySayısı += 1;
                        Console.WriteLine("C partisinin oy sayısı :" + CPartisiOySayısı);
                    
                        Console.WriteLine("");
                        break;
                  /*  case "4":
                        Console.WriteLine(" ");
                        Console.WriteLine("HANGİ PARTİNİN ŞUANA KADAR KAÇ OY ALDIĞINI GÖRMEKTESİNİZ.");
                        Console.WriteLine("A partisinin oy sayısı :" + APartisiOySayısı);
                        Console.WriteLine("B partisinin oy sayısı :" + BPartisiOySayısı);
                        Console.WriteLine("C partisinin oy sayısı :" + CPartisiOySayısı);
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        break;

                    case "5":

                        if (APartisiOySayısı > BPartisiOySayısı && APartisiOySayısı > CPartisiOySayısı)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("KAZANAN A PARTİSİ");
                            Console.WriteLine(" ");
                        }
                        else if (BPartisiOySayısı > APartisiOySayısı && BPartisiOySayısı > CPartisiOySayısı)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("KAZANAN B PARTİSİ");
                            Console.WriteLine(" ");
                        }
                        else if (CPartisiOySayısı > APartisiOySayısı && CPartisiOySayısı > BPartisiOySayısı)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("KAZANAN C PARTİSİ");
                            Console.WriteLine(" ");
                        }
                        break;*/
                    case "6":
                        Kontrol1 = false;
                        break;


                }

            }
        void MenüyüGöster()
        {
            Console.WriteLine("1-A PARTİSİNİ OY VER");
            Console.WriteLine("2-B PARTİSİNE OY VER");
            Console.WriteLine("3-C PARTİSİNE OY VER");
            Console.WriteLine("4-GÜNCEL OY SAYILARINI GÖR");
            Console.WriteLine("5-HANGİ PARTİNİN KAZANDIĞINI GÖR");
            Console.WriteLine("6-ÇIKIŞ YAP");
        }

    }
    }
}
