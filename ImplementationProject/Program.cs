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
            // ulong a1 = 0b01011101_00010011_00100101_11111001_00111001_11111101_11000100_11101111;
            // int l1 = 62;

            // // Setting up hash function
            // MultiplyShift ms = new MultiplyShift(a1,l1);

            // Test
            // ulong x1 = 9;
            // Console.WriteLine("h({0}): {1}", x1, ms.hash(x1));



            //********************
            //     Opgave 1.b 
            //********************
            Console.WriteLine("\nOpgave 1.b; Generering af multiply-mod-prime hashing");
            // // Setting up parameters a, b and l
            // // Creating the random 89 bit numbers a and b via random.ord by creating a 12 byte number, and throwing away the first 7 bits
            // // Fejl da det er et byte array?
            // byte[] bytes_a = {0b1, 0b10101001, 0b00101111, 0b01110101, 0b11011101, 0b00011010, 0b00110010, 0b10111001, 0b11111100, 0b01101101, 0b00100001, 0b00001000};
            // byte[] bytes_b = {0b1, 0b01011101, 0b00110111, 0b00101011, 0b00111100, 0b00100010, 0b01110101, 0b01100010, 0b11100110, 0b01100011, 0b11100011, 0b00010110};
            // BigInteger a2 = new BigInteger(bytes_a);
            // BigInteger b2 = new BigInteger(bytes_b);
            // int l2 = 63;

            // // Setting up hash function
            // MultiplyModPrime mmp = new MultiplyModPrime(a2, b2, l2);
            
            // Test
            // ulong x2 = 90;
            // Console.WriteLine("h({0}): {1}", x2, mmp.hash(x2));



            //********************
            //     Opgave 1.c 
            //********************
            Console.WriteLine("\nOpgave 1.c");
            // ulong msSum = 0;

            // IEnumerable<Tuple <ulong,int> > s = Stream.CreateStream(20,9);
            // foreach (var (key,value) in s){
            //     msSum += ms.hash(key);
            // }
            // Console.WriteLine("Sum using multiply-shift: {0}", msSum);

            // ulong mmpSum = 0;
            // foreach (var (key,value) in s){
            //     mmpSum += mmp.hash(key);
            // }
            // Console.WriteLine("Sum using multiply-mod-prime: {0}", mmpSum);


            
            //********************
            //     Opgave 2
            //********************
            Console.WriteLine("\nOpgave 2");
            // Test af opgave 2
            // int l3 = 2;
            // MultiplyModPrime mmp2 = new MultiplyModPrime(a2, b2, l3);
            // HashTable mmpHashTable = new HashTable(mmp2, l3);

            // ulong x1 = 123456;
            // ulong x2 = 4;
            // int v1 = 20;
            // int v2 = -1;

            // Console.WriteLine("Checking if key {0} is in hash table", x1);
            // Console.WriteLine(mmpHashTable.get(x1));

            // Console.WriteLine("\nInserting key {0} with value {1} in table, and checking if it's there", x1, v1);
            // mmpHashTable.set(x1, v1);
            // Console.WriteLine("Placement of {0}: {1}", x1, mmpHashTable.get(x1));

            // Console.WriteLine("\nChecking the value of key {0}", x1);
            // int x1Value = mmpHashTable.get(x1);
            // Console.WriteLine("Value of {0}: {1}", x1, x1Value);

            // Console.WriteLine("\nIncrementing {0} with {1}, and checking its value", x1, v2);
            // mmpHashTable.increment(x1, v2);
            // x1Value = mmpHashTable.get(x1);    
            // Console.WriteLine("Value of {0} = {1}", x1, x1Value);

            // Console.WriteLine("\nInserting key {0} using increment where d={1}", x2, v2);
            // mmpHashTable.increment(x2, v2);
 
            // Console.WriteLine("\nChecking if x2 is in table using get(x2)");
            // Console.WriteLine("Value of key {0}: {1}", x2, mmpHashTable.get(x2));

            // Console.WriteLine("\nChecking number of elements in {0} which {1} hashes to", mmp2.hash(x2), x2);
            // Console.WriteLine("Elements in hashtable[{0}]: {1}", mmp2.hash(x2),  mmpHashTable.getCounterArray()[mmp2.hash(x2)]);


            //********************
            //     Opgave 3
            //********************
            Console.WriteLine("\nOpgave 3");
            // // Creating the stream
            // int stream_l = 9;
            // int stream_n = 56;
            // IEnumerable<Tuple <ulong,int> > stream = Stream.CreateStream(stream_n,stream_l);

            // // Creating ms hashtable
            // ulong ms_a = 0b10100010_10110001_10000101_11011000_01100111_00110101_01111000_01111011;
            // int ms_l = 29;
            // MultiplyShift msHashFunc = new MultiplyShift(ms_a, ms_l);
            // HashTable multiplyShiftTable = new HashTable(msHashFunc, ms_l);

            // // Creating mmp hashtable
            // byte[] mmp_bytes_a = {0b0, 0b01101111, 0b10000110, 0b11010101, 0b10101100, 0b11000111, 0b10010110, 0b01011001, 0b00111010, 0b00110101, 0b10001100, 0b11100111};
            // byte[] mmp_bytes_b = {0b1, 0b00011011, 0b11111000, 0b10111011, 0b11111001, 0b00111111, 0b11011101, 0b11100011, 0b01111100, 0b01100111, 0b11011011, 0b10110011};
            // BigInteger mmp_a = new BigInteger(mmp_bytes_a);
            // BigInteger mmp_b= new BigInteger(mmp_bytes_b);
            // int mmp_l = 20;
            // MultiplyModPrime mmpHashFunc = new MultiplyModPrime(mmp_a, mmp_b, mmp_l);
            // HashTable multiplyModPrimeTable = new HashTable(mmpHashFunc, mmp_l);

            // // Function for calculating S
            // double calculateS(IEnumerable<Tuple <ulong,int>> stream, HashTable hs) {
            //     double S = 0;

            //     // Inserts all elements of stream into hashtable
            //     foreach (var (key,value) in stream){
            //         hs.increment(key, value);
            //     }

            //     // Calculates S
            //     LinkedHashEntry[] hashArray = hs.getTable();
            //     int hashLength = hs.getArrayLength();

            //     for (int i = 0; i < hashLength; i++){
            //         LinkedHashEntry currentEntry = hashArray[i];

            //         // Goes through all elements hashed to i, and adds their values squared
            //         while(currentEntry != null){
            //             S += Math.Pow(currentEntry.getValue(), 2);
            //             currentEntry = currentEntry.getNext();
            //         }
            //     }
            //     return S;
            // }

            // Console.WriteLine("S using multiply shift hashtable: {0}", calculateS(stream, multiplyShiftTable));
            // Console.WriteLine("S using multiply mod prime hashtable: {0}", calculateS(stream, multiplyModPrimeTable));

            //********************
            //     Opgave 4
            //********************
            Console.WriteLine("\nOpgave 4");


            //********************
            //     Test af opgave 4
            //********************


            // Console.WriteLine("S using multiply shift hashtable: {0}", calculateS(stream, multiplyShiftTable));
            // Console.WriteLine("S using multiply mod prime hashtable: {0}", calculateS(stream, multiplyModPrimeTable));

            // Creating 4-universal hashtable

            ulong testKey = 7812718;
            byte[] fourU_bytes_a0 = {0b0, 0b00000100, 0b01100100, 0b01001000, 0b10110111, 0b00100101, 0b00100101, 0b10011000, 0b10110000, 0b00001010, 0b01001110, 0b11010000};
            byte[] fourU_bytes_a1 = {0b0, 0b10000111, 0b11000101, 0b00111011, 0b00000101, 0b10100101, 0b00000110, 0b10100100, 0b10000111, 0b00011000, 0b01011001, 0b11110101};
            byte[] fourU_bytes_a2 = {0b0, 0b01101111, 0b10000110, 0b11010101, 0b10101100, 0b11000111, 0b10010110, 0b01011001, 0b00111010, 0b00110101, 0b10001100, 0b11100111};
            byte[] fourU_bytes_a3 = {0b0, 0b00111000, 0b11101101, 0b01011011, 0b10111101, 0b10101011, 0b11100000, 0b10000010, 0b10011011, 0b00100000, 0b11110101, 0b11100111};
            BigInteger fourU_a0 = new BigInteger(fourU_bytes_a0);
            BigInteger fourU_a1 = new BigInteger(fourU_bytes_a1);
            BigInteger fourU_a2 = new BigInteger(fourU_bytes_a2);
            BigInteger fourU_a3 = new BigInteger(fourU_bytes_a3);

            FourUniversal fourUHashFunc = new FourUniversal(fourU_a0, fourU_a1, fourU_a2, fourU_a3);
            BigInteger fourTestValue = fourUHashFunc.hash(testKey);
            Console.WriteLine("The hash value is {0}", fourTestValue);

            //********************
            //     Opgave 5
            //********************
            Console.WriteLine("\nOpgave 5");

            
            // Function that creates h and s
            Tuple<IHashFunction, IHashFunction>  getCountSketchFunction(IHashFunction g, int t, int b){
                IHashFunction h = new h(g, t);
                IHashFunction s = new s(g, b);
                return Tuple.Create(h,s);
            }

            // TODO: Testing on ms hash function until g is made
            // ulong ms_a = 0b10100010_10110001_10000101_11011000_01100111_00110101_01111000_01111011;
            // int ms_l = 29;
            // IHashFunction g = new MultiplyShift(ms_a, ms_l);

            // // Creating hash functions h and s
            // int t = 60;
            // int b = 89;
            // Tuple<IHashFunction, IHashFunction> hs= getCountSketchFunction(g, t, b);
            // IHashFunction h = hs.Item1;
            // IHashFunction s = hs.Item2;

            // // Testing h and s using stream
            // int stream_l = 9;
            // int stream_n = 56;
            // IEnumerable<Tuple <ulong,int> > stream = Stream.CreateStream(stream_n,stream_l);

 
            // foreach (var (key,value) in stream){
            //     if ((long)s.hash(key)< 0){
            //         Console.WriteLine("h({0}): {1}", key, h.hash(key));
            //         Console.WriteLine("s({0}): {1}\n", key, (long)s.hash(key));
            //     }
            // }

            //********************
            //     Opgave 6
            //********************
            Console.WriteLine("\nOpgave 6");
            // Creating g (Testing on ms until g is implemented)
            ulong ms_a = 0b10100010_10110001_10000101_11011000_01100111_00110101_01111000_01111011;
            int ms_l = 29;
            IHashFunction g = new MultiplyShift(ms_a, ms_l);

            // Creating h and s
            int t = 29;
            int b = 89;
            Tuple<IHashFunction, IHashFunction> hs= getCountSketchFunction(g, t, b);
            IHashFunction h = hs.Item1;
            IHashFunction s = hs.Item2;

            // Creating stream
            int stream_l = 9;
            int stream_n = 56;
            IEnumerable<Tuple <ulong,int> > stream = Stream.CreateStream(stream_n,stream_l);


            // Creating Count Sketch
            BasicCountSketch bsc = new BasicCountSketch(h, s, t);
            foreach (var (key,value) in stream){
                bsc.Process(key, value);
            }
            double X = bsc.getSecondMoment();
            Console.WriteLine("X: {0}", X);
        }
    }
}
