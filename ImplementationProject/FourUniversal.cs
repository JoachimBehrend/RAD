using System;
using System.Numerics;
namespace ImplementationProject
{
    public class FourUniversal
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

        public BigInteger hash(ulong x) {
            BigInteger[] ai = new BigInteger[] {a0, a1, a2, a3};
            BigInteger y =  ai[q - 1];

            for(int i = (q - 2); i >= 0; i--){
                y = y * x + ai[i];
                y = BigInteger.Add((y&this.p), (y >> this.b));

            }
            if (y >= this.p){
                y -= this.p;
            }

            return y;
        }
    }
}