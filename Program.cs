using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("programowanie ");
            Console.WriteLine("w jezyku C#");
            //komentarzyk
            /*
             * komentarz  wlieu liniach o o
            */


            //TYPY DANYCH + sposoby wyswiatlania stringow ookok
            /*
             * byte 0 do 255 (8 bitów => 1 bajt)
             * sbyte -128 do 127 (8 bitów => 1 bajt)
             * 
             * short -32768 do 32767 (16 bitów => 2 bajt)
             * ushort 0 do 65535 (16 bitów => 2 bajty)
             * 
             * int -2 147 483 648 do  2 147 483 647 (32 bity => 4 bajty, to samo co Int32)
             * uint 0 do 4 294 967 295 (32 bity => 4 bajty)
             * 
             * Int64 => System.Int64 => long
             * 
             * long  -9,223,372,036,854,775,808 do 9,223,372,036,854,775,807 (64 bity => 8 bajtów)
             * ulong 0 do 18 446 744 073 709 551 616 (64 bity => 8 bajtów)
             * 
             * float -3,4 * 10^38 do 3,4  * 10^38 (32 bity)
             * double (64 bity)
             * decimal (9126 bitów)
             * 
             * char U+0000 do U+FFFF (16 bitowy znak z tablicy Unicode)
             * string
             * 
             * bool
            */

            byte b = 0;
            Console.WriteLine("zmienna b wynosi: " + b);

            sbyte sb = 127;
            Console.WriteLine($"zmienna sb wynosi: {sb}");

            short s = -20000;
            ushort us = 10000;
            Console.WriteLine("zmienna s wynosi: {0}, zmienna us wynosi: {1}", s, us);

            Int16 i = 32767; //to samo co short
            Int16 i1 = -32767; //to samo co short

            System.Int64 i2 = 22222222;

            int i2 = 10;
            Int32 i3 = 10;
            System.Int32 i4 = 10; // te trzy to jest to samo okok?!?!?!??!

            Console.WriteLine("rozmiar typu bool: " + sizeof(bool)); //1 bajt

            float f=10.5F;
            Console.WriteLine(f); //10,5

            float f1 = 10;
            Console.WriteLine("f1: " + f1); //10

            long l = 10L;
            Console.WriteLine(l);

            ulong ul = 10UL;
            Console.WriteLine(ul);

            Console.WriteLine("rozmiar typu float: " + sizeof(float)); //4 bajty => 32 bity
            Console.WriteLine("rozmiar typu double: " + sizeof(double)); //8 bajty => 64 bity
            Console.WriteLine("rozmiar typu decimal: " + sizeof(decimal)); //16 bajty => 128 bity

            Console.WriteLine("rozmiar typu char: " + sizeof(char)); // 2 bajty

            Console.ReadKey();

        }
    }
}
