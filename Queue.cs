using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callcenter
{
    public class Queue<T>
    {
        private T[] items;
        private int capacity;
        private int count;
        private int max;
        private int act;
        public Queue() {
            capacity = 10;
            items = new T[capacity];
            count = 0;

        }
        public void Enqueue(T item)
        {
            if(count == capacity)
            {
                int newCapacity =2 * capacity;
                T[] newItems = new T[newCapacity];
                for(int i = 0; i <= capacity; i++)
                {
                    newItems[i] = items[i];
                }
                newItems[capacity+1] = item;
                items = newItems;
                capacity= newCapacity;
            }
            max++;
            count++;
            items[count] = item;
        }
        public T Dequeue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("A fila esta vazia");
            }
            count--;
            return items[count+1];
        }
        public Boolean IsEmpty()
        {
            return count == 0;
        }
        public T getOnTop()
        {
            return items[count];
        }
    }
}
