using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueProject
{
    class Stacks
    {
        private int top = 0;

        public Stacks(int size)
        {
            items = new int[size];
        }

        private int[] items;


        public void Push(int theNum)
        {
            items[top] = theNum;
            top++;

        }
        public int Pop()
        {

            top--;
            return items[top];

        }
        public int GetTop()
        {
            return items[top];
        }
    }
}
