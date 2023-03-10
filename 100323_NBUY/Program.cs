using System;

namespace _100323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baba b1 = new baba();
            b1.ad = "osman";
            b1.boy = 190;
            b1.kilo = 92;
            b1.cinsiyet = "erkek";

            anne a1 = new anne();
            a1.ad = "ayse";
            a1.kilo = 57;
            a1.boy = 172;
            a1.cinsiyet = "kadın";

            Console.WriteLine("anne"+" "+a1.ad + " " + a1.boy + " " + a1.kilo + " " + a1.cinsiyet);
            Console.WriteLine("baba"+" "+b1.ad + " " + b1.boy + " " + b1.kilo + " " + b1.cinsiyet);

        }
    }
}
