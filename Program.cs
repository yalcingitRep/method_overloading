using System;
namespace method_overloading{
    class Program{
        public static void Main(string[] args){
            string sayi = "999";
            bool sonuc = int.TryParse(sayi,out int outSayi);
            if(sonuc){
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);
            }
            else{
                Console.WriteLine("Basarisiz!");
            }
            Metotlar mt = new Metotlar();
            mt.Topla(4,5,out int toplam);
            Console.WriteLine(toplam);

            mt.EkranaYazdir("hello");
            mt.EkranaYazdir(12);
        }
    }
    class Metotlar{
        public void Topla(int a, int b,out int toplam){
            toplam = a+b;
        }
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }
    }
}