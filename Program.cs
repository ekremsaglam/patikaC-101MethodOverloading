using System;

namespace methodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Methods instance =new Methods();
            instance.topla(2,3,out int toplamSonucu);
            instance.ekranaYazdir(toplamSonucu);
            


        }//main end
    }//class program end

    class Methods
    {
        public int topla(int a, int b, out int toplam)
        {
            toplam = a + b;

            return toplam;
        }

                    //Method overloading

        public void ekranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri){
            Console.WriteLine(veri);
        }

    }

}
