using System;
using System.Numerics;
namespace ImplementationProject
{
    public class hCountSketchHashFunc
    {
        protected FourUniversal g;
        protected ulong m;

        public hCountSketchHashFunc(FourUniversal g, int t){
            this.g = g;
            this.m = (ulong)Math.Pow(2, t);
        }

        public ulong hash(ulong x){
            BigInteger hx  = g.hash(x)&(this.m-1); 
            return (ulong)hx;
        }
    }
}