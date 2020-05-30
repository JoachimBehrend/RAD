using System.Numerics;
namespace ImplementationProject
{
    public class MultiplyShift : ISimpleHashFunction
    {
        protected ulong a;
        protected int l;
        public MultiplyShift(ulong a, int l){
            this.l = l;
            this.a = a;
        }

        public ulong hash(ulong x){
            ulong hashvalue  = (this.a * x) >> (64-l);
            return hashvalue;
        }
    }
}