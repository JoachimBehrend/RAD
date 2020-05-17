# Implementation of hash tables
using System.Collection.Generic;

namespace Hashtables {
    public class LinkedHashEntry {
        private int key;
        private int value;
        private LinkedHashEntry next;

        LinkedHashEntry(int key, int value) {
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

        public key getKey() {
            return this.key;
        }

        public LinkedHashEntry getNext() {
            return next;
        }

        public void setNext(LinkedHashEntry next) {
            this.next = next
        }
    }
}
