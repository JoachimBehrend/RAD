using System;
namespace ImplementationProject
{
    public class h : IHashFunction
    {
        protected IHashFunction g;
        protected ulong m;

        public h(IHashFunction g, int t){
            this.g = g;
            this.m = (ulong)Math.Pow(2, t);
        }

        public ulong hash(ulong x){
            ulong hx  = g.hash(x)&(this.m-1); 
            return hx;
        }
    }
}