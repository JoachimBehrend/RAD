namespace ImplementationProject
{
    public class LinkedHashEntry
    {
        protected ulong key;
        protected int value;
        protected LinkedHashEntry next;

        public LinkedHashEntry(ulong key, int value) {
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

        public ulong getKey() {
            return this.key;
        }

        public LinkedHashEntry getNext() {
            return next;
        }

        public void setNext(LinkedHashEntry next) {
            this.next = next;
        }  
    }
}