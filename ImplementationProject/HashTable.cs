using System;
using System.Numerics;
namespace ImplementationProject
{
    public class HashTable
    {   
        protected IHashFunction h;
        protected double arrayLength; 
        protected LinkedHashEntry[] array;
        public HashTable(IHashFunction hashFunction, double l){
            this.h = hashFunction;
            this.arrayLength = Math.Pow(2.0, l);
            this.array = new LinkedHashEntry[(int)arrayLength];
        }

        public LinkedHashEntry[] getTable(){
            return this.array;
        }

        public ulong get(ulong x){
            ulong hx = this.h.hash(x);
            LinkedHashEntry currentEntry = this.array[hx];

            while(currentEntry != null){
                if (currentEntry.getKey() == x){
                    return hx;
                } else {
                    currentEntry = currentEntry.getNext();
                }
            }

            return 0;
        }

        public void set(ulong x, int v){
            ulong hx = this.h.hash(x);
            LinkedHashEntry previousEntry = null;
            LinkedHashEntry currentEntry = this.array[hx];

            int xFound = 0;

            while(currentEntry != null & xFound == 0){
                if (currentEntry.getKey() == x){
                    currentEntry.setValue(v);
                    xFound = 1;
                } else {
                    previousEntry = currentEntry;
                    currentEntry = previousEntry.getNext();
                }
            }

            if (xFound == 0){
                LinkedHashEntry newEntry = new LinkedHashEntry(x, v);
                
                if (previousEntry == null){
                    this.array[hx] = newEntry;
                } else {
                     previousEntry.setNext(newEntry);
                }
            }
        }

        public void increment(ulong x, int d){
            ulong hx = this.h.hash(x);
            LinkedHashEntry previousEntry = null;
            LinkedHashEntry currentEntry = this.array[hx];

            int xFound = 0;

            while(currentEntry != null & xFound == 0){
                if (currentEntry.getKey() == x){
                    currentEntry.setValue(currentEntry.getValue() + d);
                    xFound = 1;
                } else {
                    previousEntry = currentEntry;
                    currentEntry = previousEntry.getNext();
                }
            }

            if (xFound == 0){
                LinkedHashEntry newEntry = new LinkedHashEntry(x, d);
                
                if (previousEntry == null){
                    this.array[hx] = newEntry;
                } else {
                     previousEntry.setNext(newEntry);
                }
            }
        }
    }
}