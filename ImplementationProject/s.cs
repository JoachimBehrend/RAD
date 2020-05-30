using System;
namespace ImplementationProject
{
    public class s : IHashFunction
    {
        protected IHashFunction g;
        protected int b;

        public s(IHashFunction g, int b){
            this.g = g;
            this.b = b;
        }

        public ulong hash(ulong x){
            ulong bx = g.hash(x)>>(this.b-1);
            ulong sx = 1-2*bx;
            // Console.WriteLine("b({0}): {1}", x, bx);
            return sx;
        }
    }
}