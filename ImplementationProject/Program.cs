using System;
using System.Collections.Generic;
using System.Numerics;
namespace ImplementationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Opgave 1\n");

            // Opgave 1.a
            // Console.WriteLine("Opgave 1.a: Generering af multiply-shift hashing");
            // // Creating the uneven random 64 bit number a via random.org by creating a 8 byte number and changing the last bit to 1
            // ulong a1 = 0b01011101_00010011_00100101_11111001_00111001_11111101_11000100_11101111;;

            // int l1 = 62;
            // MultiplyShift ms = new MultiplyShift(a1,l1);

            // Console.Write("h(7): ");
            // ulong x1 = 7;
            // Console.WriteLine(ms.hash(x1));

            // Opgave 1.b
            Console.WriteLine("\nOpgave 1.b");
            //Creating the random 89 bit numbers a and b via random.ord by creating a 12 byte number, and throwing away the first 7 bits

            //Fejl da det er et byte array
            byte[] bytes_a = {0b0, 0b10101001, 0b00101111, 0b01110101, 0b11011101, 0b00011010, 0b00110010, 0b10111001, 0b11111100, 0b01101101, 0b00100001, 0b00001000};
            byte[] bytes_b = {0b1, 0b01011101, 0b00110111, 0b00101011, 0b00111100, 0b00100010, 0b01110101, 0b01100010, 0b11100110, 0b01100011, 0b11100011, 0b00010110};
            BigInteger a2 = new BigInteger(bytes_a);
            BigInteger b2 = new BigInteger(bytes_b);

            int l2 = 8;
            MultiplyModPrime mmp = new MultiplyModPrime(a2, b2, l2);
            

            // byte[] bytes_test = {0b00, 0b11111100, 0b01101101, 0b00100001, 0b00001000};
            // BigInteger test = new BigInteger(bytes_test);
            // Console.WriteLine(a2.GetByteCount());
            // Console.WriteLine("The value of test is {0} (or 0x{0:x}).", test);
            // Console.WriteLine("The value of a2 is {0} (or 0x{0:x}).", a2);
            // Console.WriteLine("The value of b2 is {0} (or 0x{0:x}).", b2);
            Console.WriteLine("h(7): {0}", mmp.hash(9));

            // Opgave 1.c
            // Console.WriteLine("\nOpgave 1.c");
            // ulong msSum = 0;
            // foreach (var (key,value) in Stream.CreateStream(20,9)){
            //     msSum += ms.hash(key);
            // }
            // Console.WriteLine("Sum using Multiply-shift: {0}", msSum);

            // Console.WriteLine("\nOpgave 2");
            // // Test af opgave 2
            // ulong a1 = 0b01011101_00010011_00100101_11111001_00111001_11111101_11000100_11101111;;
            // int l1 = 3;
            // MultiplyShift ms = new MultiplyShift(a1,l1);

            // HashTable msHashTable = new HashTable(ms, l1);
            // ulong x1 = 123456;
            // ulong x2 = 2;
            // Console.WriteLine(msHashTable.get(x1));
            // msHashTable.set(x1, 20);
            // Console.WriteLine(msHashTable.get(x1));

            // LinkedHashEntry[] arr1 = msHashTable.getTable();
            // int x1Value = arr1[msHashTable.get(x1)].getValue();
            // Console.WriteLine(x1Value);

            // msHashTable.increment(x1, -1);
            // msHashTable.increment(x2, -1);

            // x1Value = arr1[msHashTable.get(x1)].getValue();
            // int x2Value = arr1[msHashTable.get(x2)].getValue();
            // Console.WriteLine("x1 value = {0}", x1Value);
            // Console.WriteLine("x2 value = {0}", x2Value);

        }
    }
}
