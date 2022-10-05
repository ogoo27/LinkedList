using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAccess
{
      // sub class and super class
     class Queue<T> 
    {
        //fields
        Node<T> head;
        T data;
        int count = 0;

        public bool IsEmpty()
        {
            return head == null;
        }


        public void Enqueue(T item)
        {
            if(head == null)
            {
                head = new Node<T>(item);
                count++;
            }
            Node<T> node = head;

            while(node.next != null)
            {
                node = node.next;

            }
            node = new Node<T>(item);
            count++;

        }


        public void Dequeue()
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
            Node<T> node =head.next;
            head = node;
            count--;

        } 


        public int Size()
        {
            return count;
        }

    }
}
