using System;
using System.Numerics;
namespace ImplementationProject
{
    public class MultiplyModPrime : IHashFunction
    {
        protected BigInteger a;
        protected BigInteger b;
        protected int l;
        protected int q;
        protected BigInteger p;
        public MultiplyModPrime(BigInteger a, BigInteger b, int l){
            this.a = a;
            this.b = b;
            this.l = l;
            this.q = 89;
            this.p = BigInteger.Pow(2, q)-1;
        }

        public ulong hash(ulong x){

            // Calculating (a*x+b) mod p by ((a*x+b)&p) + (x>>q)
            // From exercise 2.7 and 2.8
            BigInteger v1 =BigInteger.Add(BigInteger.Multiply(this.a, x), this.b); //((this.a*x + this.b);
            BigInteger y = BigInteger.Add((v1&this.p),(x >> this.q));

            if (y>=this.p){
                y -= this.p;
            }

            // Calculating y mod 2^l by y&(2^l-1)
            BigInteger hashvalue = (y&(BigInteger.Pow(2, this.l)-1));
            return (ulong)hashvalue;
        }
    }
}