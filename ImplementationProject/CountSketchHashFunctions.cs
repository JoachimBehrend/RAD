using System;

namespace ImplementationProject
{
    public class CountSketchHashFunctions
    {
        
        protected IHashFunction g;
        protected int t;
        public CountSketchHashFunctions(IHashFunction g, int t){
            this.g = g;
            this.t = t;
        }

        public Tuple<IHashFunction, IHashFunction> getFunctions(){
            IHashFunction h = new h(this.g, this.t);
            IHashFunction s = new s(this.g, this.t);
            return Tuple.Create(h,s);
        }
    }
}