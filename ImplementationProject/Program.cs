using System;
using System.Collections.Generic;
using System.Numerics;
namespace ImplementationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1");
            //********************
            //     Opgave 1.a
            //********************
            Console.WriteLine("Opgave 1.a: Generering af multiply-shift hashing");
            // Defining a and l parameters
            // Creating the uneven random 64 bit number a via random.org by creating a 8 byte number and changing the last bit to 1
            ulong a1 = 0b01011101_00010011_00100101_11111001_00111001_11111101_11000100_11101111;
            int l1 = 62;

            // Setting up hash function
            MultiplyShift ms = new MultiplyShift(a1,l1);

            // Test
            // ulong x1 = 9;
            // Console.WriteLine("h({0}): {1}", x1, ms.hash(x1));



            //********************
            //     Opgave 1.b 
            //********************
            Console.WriteLine("\nOpgave 1.b; Generering af multiply-mod-prime hashing");
            // Setting up parameters a, b and l
            // Creating the random 89 bit numbers a and b via random.ord by creating a 12 byte number, and throwing away the first 7 bits
            // Fejl da det er et byte array?
            byte[] bytes_a = {0b1, 0b10101001, 0b00101111, 0b01110101, 0b11011101, 0b00011010, 0b00110010, 0b10111001, 0b11111100, 0b01101101, 0b00100001, 0b00001000};
            byte[] bytes_b = {0b1, 0b01011101, 0b00110111, 0b00101011, 0b00111100, 0b00100010, 0b01110101, 0b01100010, 0b11100110, 0b01100011, 0b11100011, 0b00010110};
            BigInteger a2 = new BigInteger(bytes_a);
            BigInteger b2 = new BigInteger(bytes_b);
            int l2 = 63;

            // Setting up hash function
            MultiplyModPrime mmp = new MultiplyModPrime(a2, b2, l2);
            
            // Test
            // ulong x2 = 90;
            // Console.WriteLine("h({0}): {1}", x2, mmp.hash(x2));



            //********************
            //     Opgave 1.c 
            //********************
            Console.WriteLine("\nOpgave 1.c");
            ulong msSum = 0;
            foreach (var (key,value) in Stream.CreateStream(20,9)){
                msSum += ms.hash(key);
            }
            Console.WriteLine("Sum using multiply-shift: {0}", msSum);

            ulong mmpSum = 0;
            foreach (var (key,value) in Stream.CreateStream(20,9)){
                mmpSum += mmp.hash(key);
            }
            Console.WriteLine("Sum using multiply-mod-prime: {0}", mmpSum);


            
            //********************
            //     Opgave 2
            //********************
            Console.WriteLine("\nOpgave 2");
            // Test af opgave 2
            int l3 = 2;
            MultiplyModPrime mmp2 = new MultiplyModPrime(a2, b2, l3);
            HashTable mmpHashTable = new HashTable(mmp2, l3);

            ulong x1 = 123456;
            ulong x2 = 4;
            int v1 = 20;
            int v2 = -1;

            Console.WriteLine("Checking if key {0} is in hash table", x1);
            Console.WriteLine(mmpHashTable.get(x1));

            Console.WriteLine("\nInserting key {0} with value {1} in table, and checking if it's there", x1, v1);
            mmpHashTable.set(x1, v1);
            Console.WriteLine("Placement of {0}: {1}", x1, mmpHashTable.get(x1));

            Console.WriteLine("\nChecking the value of key {0}", x1);
            LinkedHashEntry[] arr1 = mmpHashTable.getTable();
            int x1Value = arr1[mmpHashTable.get(x1)].getValue();
            Console.WriteLine("Value of {0}: {1}", x1, x1Value);

            Console.WriteLine("\nIncrementing {0} with {1}, and checking its value", x1, v2);
            mmpHashTable.increment(x1, v2);
            x1Value = arr1[mmpHashTable.get(x1)].getValue();    
            Console.WriteLine("Value of {0} = {1}", x1, x1Value);

            Console.WriteLine("\nInserting key {0} using increment where d={1}", x2, v2);
            mmpHashTable.increment(x2, v2);
 
            Console.WriteLine("\nChecking if x2 is in table");
            Console.WriteLine("Placement of key {0}: {1}", x2, mmpHashTable.get(x2));

            Console.WriteLine("\nChecking number of elements in {0}", mmpHashTable.get(x2));
            Console.WriteLine("Elements in hashtable[{0}]: {1}", mmpHashTable.get(x2),  mmpHashTable.getCounterArray()[mmpHashTable.get(x2)]);
        }
    }
}
