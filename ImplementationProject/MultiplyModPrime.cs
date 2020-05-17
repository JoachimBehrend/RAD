using System.Numerics;
namespace ImplementationProject
{
    public class MultiplyModPrime
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
            this.p = 2^this.q-1;
        }

        public BigInteger hash(ulong x){

            // Calculating (a*x+b) mod p
            // From exercise 2.7 and 2.8
            BigInteger v1 = (this.a*x + this.b);
            BigInteger y = (v1 & this.p) + (x >> this.q);
            if (y>=this.p){
                y -= this.p;
            }

            // Calculating y mod 2^l
            BigInteger hashvalue = (y&(2^l-1));
            
            return hashvalue;
        }
    }
}