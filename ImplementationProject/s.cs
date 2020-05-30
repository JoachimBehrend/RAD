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
<<<<<<< HEAD
            ulong bx = g.hash(x) >> (t-1);
            //Console.Writeline(bx);
=======
            ulong bx = g.hash(x)>>(this.b-1);
>>>>>>> 4d9c23780ec8df26552b8d59ff91e1c19f9a8e6c
            ulong sx = 1-2*bx;
            // Console.WriteLine("b({0}): {1}", x, bx);
            return sx;
        }
    }
}