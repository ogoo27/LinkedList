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


        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("stack is empty");
            }

            if (head.next == null)
            {
                head = null;
                count--;
            }
            var temp = head;
            head = head.next;
            count--;
            return temp.data;
        }


        public  T Peek()
        {
            
            Node<T> tempNode = head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            
            return tempNode.data;
        }

        public int Size()
        {
            return count;
        }


        public void PrintStack()
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }


    }


  




       
 
}
