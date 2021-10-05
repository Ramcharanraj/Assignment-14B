using System;

namespace StackAndQueue
{
        public class Node
        {

            //Data will store the value of Stack
            public int data;

            //Node works as the pointer in stack Show the next Node for operations
            public Node next;

            
            public Node(int data)
            {
                this.data = data;
            }
        }
}
