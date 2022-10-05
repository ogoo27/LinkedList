using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAccess
{
    class Stack <T> 
    {
        Node<T> head;
        T data;
        int count = 0;


        public bool IsEmpty()
        {
            return head == null;
        }


        public void Push(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                count++;
            }
            Node<T> node = head;

            while (node.next != null)
            {
                node = node.next;

            }
            node = new Node<T>(item);
            count++;

        }


        public void Pop()
        {
            if (IsEmpty())
            {
                return;
            }

            if (head.next == null)
            {
                head = null;
                count--;
            }
            Node<T> node = head.next;
            head = node;
            count--;

        }


        public T Peek()
        {
            Node<T> node = head;
            while (node.next != null)
            {   
                node = node.next;
            }
            return node.data;
        }




        public int Size()
        {
            return count;
        }

    }
}
