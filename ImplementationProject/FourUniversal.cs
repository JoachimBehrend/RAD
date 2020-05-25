using System;
using System.Numerics;
namespace ImplementationProject
{
    public class FourUniversal : IHashFunction
    {
        protected BigInteger a0;
        protected BigInteger a1;
        protected BigInteger a2;
        protected BigInteger a3;
        protected int q;
        protected int b;
        protected BigInteger p;
        public FourUniversal(BigInteger a0, BigInteger a1, BigInteger a2, BigInteger a3){
            this.a0 = a0;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.q = 4;
            this.b = 89;
            this.p = BigInteger.Pow(2, b)-1;
        }

        public ulong hash(ulong x) {
            BigInteger[] ai = new BigInteger[] {a0, a1, a2, a3};

            BigInteger y =  ai[q - 1];
            Console.WriteLine("2");

            Console.WriteLine("The 0 valueof y is {0}", y);

            for(int i = (q - 2); i >= 0; i--){
                Console.WriteLine("The value of ai is {0}", ai[i]);
                y = y * x + ai[i];
                y = BigInteger.Add((y&this.p), (y >> this.b));
                Console.WriteLine("The 1, {0} valueof y is {1}", i, y);
                if (y >= this.p){
                    y -= this.p;
                }

            }
            Console.WriteLine("The 1 value of y is: {0}", y);
            Console.WriteLine("The 2 value of y is: {0}", y);

            return (ulong)y;
        }
    }
}