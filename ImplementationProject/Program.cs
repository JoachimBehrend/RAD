using System;
using System.Collections.Generic;
using System.Numerics;
namespace ImplementationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1\n");

            // Opgave 1.a
            Console.WriteLine("Opgave 1.a: Generering af multiply-shift hashing");
            // Creating the uneven random 64 bit number a via random.org by creating a 8 byte number and changing the last bit to 1
            ulong a1 = 0b01011101_00010011_00100101_11111001_00111001_11111101_11000100_11101111;;

            int l1 = 62;
            MultiplyShift ms = new MultiplyShift(a1,l1);

            Console.Write("h(7): ");
            ulong x1 = 7;
            Console.WriteLine(ms.hash(x1));

            // Opgave 1.b
            Console.WriteLine("\nOpgave 1.b");
            // Creating the random 89 bit numbers a and b via random.ord by creating a 12 byte number, and throwing away the first 7 bits

            // Fejl da det er et byte array
            byte[] bytes_a = {0b0, 0b10101001, 0b00101111, 0b01110101, 0b11011101, 0b00011010, 0b00110010, 0b10111001, 0b11111100, 0b01101101, 0b00100001, 0b00001000};
            byte[] bytes_b = {0b1, 0b01011101, 0b00110111, 0b00101011, 0b00111100, 0b00100010, 0b01110101, 0b01100010, 0b11100110, 0b01100011, 0b11100011, 0b00010110};
            BigInteger a2 = new BigInteger(bytes_a);
            BigInteger b2 = new BigInteger(bytes_b);

            int l2 = 63;
            MultiplyModPrime mmp = new MultiplyModPrime(a2, b2, l2);
            
            Console.WriteLine("The value of a2 is {0} (or 0x{0:x}).", a2);
            Console.WriteLine("The value of a2 is {0} (or 0x{0:x}).", b2);

            // Console.Write("h(7): ");
            // ulong x2 = 9;
            // Console.WriteLine(mmp.hash(x2));

            // // Opgave 1.c
            // // Problemer med at itererer igennem stream
            // Console.WriteLine("\nOpgave 1.c");
            // Console.WriteLine("Creating Stream");

        }
    }
}
