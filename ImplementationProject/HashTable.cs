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
            // Initializes hashfunction and creates array
            this.h = hashFunction;
            this.arrayLength = Math.Pow(2.0, l);
            this.array = new LinkedHashEntry[(int)arrayLength];
        }

        // Used for checking correctness of methods
        public LinkedHashEntry[] getTable(){
            return this.array;
        }

        // Returns the value x has hashed to if it is in table
        // If x is not in table, 0 is returned
        public ulong get(ulong x){
            ulong hx = this.h.hash(x);
            LinkedHashEntry currentEntry = this.array[hx];

            // Goes through all elements that hashed to x
            while(currentEntry != null){
                if (currentEntry.getKey() == x){
                    return hx;
                } else {
                    currentEntry = currentEntry.getNext();
                }
            }
            return 0;
        }

        // Sets a key x to value v
        // If x is not in the table it is inserted with value v
        public void set(ulong x, int v){
            ulong hx = this.h.hash(x);
            LinkedHashEntry previousEntry = null;
            LinkedHashEntry currentEntry = this.array[hx];

            int xFound = 0;

            // Goes through all elements that hash to x
            while(currentEntry != null & xFound == 0){
                if (currentEntry.getKey() == x){
                    currentEntry.setValue(v);
                    xFound = 1;
                } else {
                    previousEntry = currentEntry;
                    currentEntry = previousEntry.getNext();
                }
            }

            // Inserts x in table with value v if x is not found
            // If there are no other elements that hash to x, then x is inserted as first element
            if (xFound == 0){
                LinkedHashEntry newEntry = new LinkedHashEntry(x, v);
                
                if (previousEntry == null){
                    this.array[hx] = newEntry;
                } else {
                     previousEntry.setNext(newEntry);
                }
            }
        }

        // Increments the value of x with d
        // If x is not in the table, it is inserted with value d
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

            // Inserts x in table with value d if x is not found
            // If there are no other elements that hash to x, then x is inserted as first element
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