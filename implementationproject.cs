using System;
using System.Numerics;

namespace ImplementationProject {
    public class LinkedHashEntry {
        protected int key;
        protected int value;
        protected LinkedHashEntry next;

        public LinkedHashEntry(int key, int value) {
            this.key = key;
            this.value = value;
            this.next = null;
        }

        public int getValue() {
            return this.value;
        }

        public void setValue(int newValue) {
            this.value = newValue;
        }

        public int getKey() {
            return this.key;
        }

        public LinkedHashEntry getNext() {
            return next;
        }

        public void setNext(LinkedHashEntry next) {
            this.next = next;
        }
    }

    // public class HashTable{
    //     protected int length;
    //     protected BigInteger a;
    //     protected int l;
    //     public HashTable(int len){
    //       this.length = len;
    //       this.a = new BigInteger()
    //     }
    // }

    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Tests\n");
            byte[] bytes = {174, 46, 205, 25, 59, 135, 39, 23};
            System.Numerics.BigInteger a = new BigInteger(bytes);
            Console.WriteLine(a);
        }
    }
}
