using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques
{
    public class Queue
    {
        private int front = 0;
        private int back = 0;
        private int[] items;
        public Queue(int size)
        {
            items = new int[size];

        }

        public void EnQueue(int theNum)
        {
            items[back] = theNum;
            back++;
        }

        public int DeQueue()
        {
            int temp = items[front];
            front++;
            return temp;
            
        }

    }
}
