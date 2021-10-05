using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        //Method to Add values to the Stack

        internal void push(int value)
        {
            Console.WriteLine();
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("the value that is pushed   " + value);
        }

        //Method Display
        internal void display()
        {
            Node temp = this.top;

            while (temp != null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.next;
            }
        }
    }
}