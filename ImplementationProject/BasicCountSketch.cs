using System;

namespace ImplementationProject
{
    public class BasicCountSketch
    {
        protected IHashFunction h;
        protected IHashFunction s;
        protected long[] C;
        protected ulong m;

        public BasicCountSketch(IHashFunction h, IHashFunction s, int t){
            this.m = (ulong) Math.Pow(2,t);
            this.h = h;
            this.s = s;
            this.C = new long[m];
        }

        public void Process(ulong key, int value){
            ulong hValue = this.h.hash(key);
            long sValue = (long) this.s.hash(key);
            this.C[hValue] += sValue*(long)value;
        }

        public double getSecondMoment(){
            double F2 = 0;
            for (ulong i=0; i < m; i++){
                F2 += Math.Pow(this.C[i], 2);
            }
            return F2;
        }
    }
}