using System;
namespace ImplementationProject
{
    public class s : IHashFunction
    {
        protected IHashFunction g;
        protected int t;

        public s(IHashFunction g, int t){
            this.g = g;
            this.t = t;
        }

        public ulong hash(ulong x){
            ulong bx = g.hash(x) >> (t-1);
            Console.WriteLine(bx);
            ulong sx = 1-2*bx;
            return sx;
        }
    }
}