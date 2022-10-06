using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAccess
{
     class Queue<T> 
    {
        //fields
        Node<T> head;

        int count = 0;

        public bool IsEmpty()
        {
            return head == null;
        }


        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            count++;

            if (head == null)

            {
                head = newNode;

            }

            else

            {
                var temp = head;

                while (temp.next != null)

                {

                    temp = temp.next;

                }

                temp.next = newNode;

                newNode.next = null;

            }


        }


           

        public T Dequeue()
        {
         if (IsEmpty())
         {
                throw new InvalidOperationException("queue is empty");
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




        public int Size()
        {
            return count;
        }

    }
}
