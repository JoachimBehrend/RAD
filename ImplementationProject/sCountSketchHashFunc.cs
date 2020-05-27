using System;
using System.Numerics;
namespace ImplementationProject
{
    public class sCountSketchHashFunc
    {
        protected FourUniversal g;
        protected int b;

        public sCountSketchHashFunc(FourUniversal g, int b){
            this.g = g;
            this.b = b;
        }

        public long hash(ulong x){
                            //y = BigInteger.Add((y&this.p), (y >> this.b));


            BigInteger bx = g.hash(x) >> (this.b-1);
            BigInteger sx = 1-2*bx;
            // Console.WriteLine("b({0}): {1}", x, bx);
            return (long)sx;
        }
    }
}