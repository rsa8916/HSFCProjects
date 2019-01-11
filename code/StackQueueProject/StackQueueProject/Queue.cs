using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueProject
{
    class Queue
    {

        private int front = 0;//lable for the front
        private int back = 0;//lable for the back
        private int[] items;//array

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
