﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Diagnostics;
namespace ImplementationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Opgave 1");
            //********************
            //     Opgave 1.a
            //********************
            // Console.WriteLine("Opgave 1.a: Generering af multiply-shift hashing");
            // Defining a and l parameters
            // Creating the uneven random 64 bit number a via random.org by creating a 8 byte number and changing the last bit to 1
            ulong ms_a = 0b10100010_10110001_10000101_11011000_01100111_00110101_01111000_01111011;
            int ms_l = 29;

            // Setting up hash function
            MultiplyShift msHashFunc = new MultiplyShift(ms_a, ms_l);


            //********************
            //     Opgave 1.b 
            //********************
            // Console.WriteLine("\nOpgave 1.b; Generering af multiply-mod-prime hashing");
            // // Setting up parameters a, b and l
            byte[] mmp_bytes_a = {0b0, 0b01101111, 0b10000110, 0b11010101, 0b10101100, 0b11000111, 0b10010110, 0b01011001, 0b00111010, 0b00110101, 0b10001100, 0b11100111};
            byte[] mmp_bytes_b = {0b1, 0b00011011, 0b11111000, 0b10111011, 0b11111001, 0b00111111, 0b11011101, 0b11100011, 0b01111100, 0b01100111, 0b11011011, 0b10110011};
            BigInteger mmp_a = new BigInteger(mmp_bytes_a);
            BigInteger mmp_b= new BigInteger(mmp_bytes_b);
            int mmp_l = 29;

            // // Setting up hash function
            MultiplyModPrime mmpHashFunc = new MultiplyModPrime(mmp_a, mmp_b, mmp_l);


            //********************
            //     Opgave 1.c 
            //********************
            // Console.WriteLine("\nOpgave 1.c");
            // Stopwatch stopwatch = new Stopwatch();
            // stopwatch.Start();
            // ulong msSum = 0;
            // IEnumerable<Tuple <ulong,int> > stream = Stream.CreateStream(200000,9);
            // foreach (var (key,value) in s){
            //     msSum += msHashFunc.hash(key);
            // }
            // Console.WriteLine("Sum using multiply-shift: {0}", msSum);
            // stopwatch.Stop();
            // Console.WriteLine("Time in millisec, multiply-shift: {0} \n", stopwatch.Elapsed.TotalMilliseconds);


            // stopwatch.Restart();
            // ulong mmpSum = 0;
            // foreach (var (key,value) in s){
            //    mmpSum += mmpHashFunc.hash(key);
            // }
            // Console.WriteLine("Sum using multiply-mod-prime: {0}", mmpSum);
            // stopwatch.Stop();
            // Console.WriteLine("Time in millisec, multiply-mod-prime: {0}", stopwatch.Elapsed.TotalMilliseconds);

            
            
            


            
            //********************
            //     Opgave 2
            //********************
            // Console.WriteLine("\nOpgave 2");
            // Creating ms hashtable
            HashTable multiplyShiftTable = new HashTable(msHashFunc, ms_l);

            // Creating mmp hashtable
            HashTable multiplyModPrimeTable = new HashTable(mmpHashFunc, mmp_l);


            //********************
            //     Opgave 3
            //********************
            // Console.WriteLine("\nOpgave 3");
            // // Creating the stream
            int stream_n = 1000000;
            int stream_l = 29;
            IEnumerable<Tuple <ulong,int> > stream = Stream.CreateStream(stream_n,stream_l);


            // // Function for calculating S
            double calculateS(IEnumerable<Tuple <ulong,int>> stream, HashTable hs) {
                double S = 0;

                // Inserts all elements of stream into hashtable
                foreach (var (key,value) in stream){
                    hs.increment(key, value);
                }

                // Calculates S
                LinkedHashEntry[] hashArray = hs.getTable();
                int hashLength = hs.getArrayLength();

                for (int i = 0; i < hashLength; i++){
                    LinkedHashEntry currentEntry = hashArray[i];

                    // Goes through all elements hashed to i, and adds their values squared
                    while(currentEntry != null){
                        S += Math.Pow(currentEntry.getValue(), 2);
                        currentEntry = currentEntry.getNext();
                    }
                }
                return S;
            }

            // double correctS = calculateS(stream, multiplyShiftTable);

            // Console.WriteLine("S using multiply shift hashtable: {0}", calculateS(stream, multiplyShiftTable));
            // Console.WriteLine("S using multiply mod prime hashtable: {0}", calculateS(stream, multiplyModPrimeTable));

            // //********************
            // //     Opgave 4
            // //********************
            // //Console.WriteLine("\nOpgave 4");
            // // Creating 4-universal hashtable
            // // ulong testKey = 78;
            // byte[] fourU_bytes_a0 = {0b0, 0b00000100, 0b01100100, 0b01001000, 0b10110111, 0b00100101, 0b00100101, 0b10011000, 0b10110000, 0b00001010, 0b01001110, 0b11010000};
            // byte[] fourU_bytes_a1 = {0b0, 0b10000111, 0b11000101, 0b00111011, 0b00000101, 0b10100101, 0b00000110, 0b10100100, 0b10000111, 0b00011000, 0b01011001, 0b11110101};
            // byte[] fourU_bytes_a2 = {0b0, 0b01101111, 0b10000110, 0b11010101, 0b10101100, 0b11000111, 0b10010110, 0b01011001, 0b00111010, 0b00110101, 0b10001100, 0b11100111};
            // byte[] fourU_bytes_a3 = {0b0, 0b00111000, 0b11101101, 0b01011011, 0b10111101, 0b10101011, 0b11100000, 0b10000010, 0b10011011, 0b00100000, 0b11110101, 0b11100111};
            // BigInteger fourU_a0 = new BigInteger(fourU_bytes_a0);
            // BigInteger fourU_a1 = new BigInteger(fourU_bytes_a1);
            // BigInteger fourU_a2 = new BigInteger(fourU_bytes_a2);
            // BigInteger fourU_a3 = new BigInteger(fourU_bytes_a3);

            // FourUniversal fourUHashFunc = new FourUniversal(fourU_a0, fourU_a1, fourU_a2, fourU_a3);
            // // BigInteger fourTestValue = fourUHashFunc.hash(testKey);
            // //Console.WriteLine("The hash value is {0}", fourTestValue);

            // //********************
            // //     Opgave 5
            // //********************
            // //Console.WriteLine("\nOpgave 5");            
            // // // Function that creates h and s
            Tuple<hCountSketchHashFunc, sCountSketchHashFunc>  getCountSketchFunction(FourUniversal g, int t, int b){
                hCountSketchHashFunc h = new hCountSketchHashFunc(g, t);
                sCountSketchHashFunc s = new sCountSketchHashFunc(g, b);
                return Tuple.Create(h,s);
            }


            // //********************
            // //     Opgave 6
            // //********************
            // Console.WriteLine("\nOpgave 6");

            // // Creating h and s
            // int t = 29;
            // int b = 89;
            // Tuple<hCountSketchHashFunc, sCountSketchHashFunc> hs= getCountSketchFunction(fourUHashFunc, t, b);
            // hCountSketchHashFunc h = hs.Item1;
            // sCountSketchHashFunc s = hs.Item2;

            // // Creating stream
            // // int stream_l = 9;
            // // int stream_n = 56;
            // // IEnumerable<Tuple <ulong,int> > stream = Stream.CreateStream(stream_n,stream_l);


            // // Creating Count Sketch
            // BasicCountSketch bsc = new BasicCountSketch(h, s, t);
            // foreach (var (key,value) in stream){
            //     bsc.Process(key, value);
            // }
            // double X = bsc.getSecondMoment();
            // Console.WriteLine("X: {0}", X);




            // //********************
            // //     Opgave 7
            // //********************
            Console.WriteLine("\nOpgave 7");
            // Console.WriteLine("Correct answer: {0}", correctS);

            double calculateCountSketchEstimator(IEnumerable<Tuple <ulong,int>> stream, BigInteger a0, BigInteger a1, BigInteger a2, BigInteger a3, int t){
                // Setting up functions
                int b = 89;
                FourUniversal g = new FourUniversal(a0, a1, a2, a3);
                Tuple<hCountSketchHashFunc, sCountSketchHashFunc> hs= getCountSketchFunction(g, t, b);
                hCountSketchHashFunc h = hs.Item1;
                sCountSketchHashFunc s = hs.Item2;

                BasicCountSketch bsc = new BasicCountSketch(h, s, t);
                foreach (var (key,value) in stream){
                    bsc.Process(key, value);
                }
                double X = bsc.getSecondMoment();
                return X;
            }

            // Array for estimators
            double[] X = new double[100];

            // Function that performs experiment
            void performExperiment (IEnumerable<Tuple <ulong,int>> stream, int t){
                int [] randomVariables = new int[4];
                
                // Prints results in to text file
                string fileName = "./experiment" + t + ".csv";
                using (StreamWriter file = new StreamWriter(fileName)){
                    // Formats so points can easily be copy pasted as csv file
                    // file.WriteLine("Experiment;Estimation");

                    // Reads through file randomBits to get the random variables
                    using (StreamReader sr = new StreamReader("./randomBits.txt"))
                    {
                        // Counter is number of experiments. idx is index for randomvariables
                        int counter = 0;
                        int idx = 0;

                        // Reads through file
                        while(sr.Peek() >= 0 && counter < 100){
                            string byte_string = ""; 
                            int i = 0; 
                            while(i < 89) {
                                if(sr.Peek() >= 0){
                                    char c = (char)sr.Read();
                                    if(c != '\n'){
                                        byte_string = byte_string + (char)sr.Read();
                                        i++; 
                                    }
                                }
                            }
                            byte[] b = Encoding.ASCII.GetBytes(byte_string);
                            Array.Reverse(b);

                            int ival = BitConverter.ToInt32(b, 0);
                            randomVariables[idx] = ival;

                            // Performs new experiment when 4 random variables have been acquired 
                            if (idx == 3){
                                X[counter] = calculateCountSketchEstimator(stream,randomVariables[0], randomVariables[1], randomVariables[2], randomVariables[3], t);
                                idx = 0;
                                file.WriteLine("{0};{1}", counter, X[counter]);
                                counter++;

                            } else {
                                idx++;
                            }
                        }
                    }
                }
            }

            // Print so points can easily be copy pasted as csv file
            int t = 20;
            Console.WriteLine("t = {0}", t);
            performExperiment(stream, t);
            Console.WriteLine("Experiment done");



            // //********************
            // //     Opgave 8
            // //********************
            Console.WriteLine("\nOpgave 8");
            t = 5;
            Console.WriteLine("t = {0}", t);
            performExperiment(stream, t);
            Console.WriteLine("Experiment done");


            t = 10;
            Console.WriteLine("t = {0}", t);
            performExperiment(stream, t);
            Console.WriteLine("Experiment done");

            t = 30;
            Console.WriteLine("t = {0}", t);
            performExperiment(stream, t);
            Console.WriteLine("Experiment done");

        }
            
    }
}
