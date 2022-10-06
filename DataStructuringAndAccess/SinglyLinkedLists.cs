using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataStructureAndAccess;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataStructureAndAccess
{

    class SinglyLinkedLists<T>
    {






        Node<T> head;
        public SinglyLinkedLists()
        {
            head = null;
        }

        int count = 0;


        public void Add(T item)

        {
            Node<T> newNode = new Node<T>(item);
            count++;

            if (head == null)

            {
                head = newNode;
            }

            else

            {
                Node<T> temp = head;

                while (temp.next != null)

                {

                    temp = temp.next;

                }

                temp.next = newNode;

                newNode.next = null;

            }


        }



        public bool Remove(T item)
        {
            Node<T> temp = head;

            while (temp.next != null)
            {
                if (temp.next.data.Equals(item))
                {
                    temp.next = temp.next.next; return true;

                    count--;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return false;



        } 





        public bool Check(T item)
        {
            Node<T> temp = head;

            while (temp.next != null)
            {
                if (temp.next.data.Equals(item))
                {
                    return true;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return false;

        }





        public int Index(T item)
        {
            var temp = head;

            int index = 0;

            while(temp.next != null)
            {
                if(temp.data.Equals(item))
                {
                    return index;
                }
                index++;

                temp = temp.next;
            }
            return -1;

        }



        public void PrintList()
        {
            var temp = head;

            while (temp != null)

            {
                Console.WriteLine(temp.data);

                temp = temp.next;


            }
        }
    }

}

            

             



























