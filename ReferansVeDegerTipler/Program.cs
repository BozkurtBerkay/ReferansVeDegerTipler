using System;

namespace ReferansVeDegerTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //String referans tiptir çalışma şekli Değer Tip.
            string ReferansStringTipBir = "Eskişehir"; 

            string ReferansStringTipIki = "Antalya";

            ReferansStringTipIki = ReferansStringTipBir;

            ReferansStringTipIki = "Eşkişehir";

            Console.WriteLine(ReferansStringTipBir);

            //Diziler Referans Tip.
            int[] RefIntTypeOne = new int[] { 1, 2, 3, 4 };
            int[] RefIntTypeTwo = new int[] { 5, 6, 7, 8 };

            RefIntTypeTwo = RefIntTypeOne;
            Console.WriteLine("Değişmeden önce 0.indis: " + RefIntTypeOne[0]);
            RefIntTypeTwo[0] = 26;
            Console.WriteLine("Değiştikten Sonra 0.indis: " + RefIntTypeOne[0]);

            //Değer tip int
            int DegerTipIntBir = 7;
            int DegerTipIntIki = 11;
            DegerTipIntIki = DegerTipIntBir;
            DegerTipIntIki = 26;
            Console.WriteLine(DegerTipIntBir);
        }
    }
}
