using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataStructureAndAccess;
using System.Collections;

namespace DataStructureAndAccess
{
   // public Node<T> singlyLinkedList = new Node<T>();
    class SinglyLinkedLists<T>
    {


        



         Node<T> head;

         //Node<T> previous;

         Node<T> current;

         int count = 0;




        public void Add(T item)

        {

            Node<T> newNode = new Node<T>(item);

            if (head == null)

            {

                head = newNode;

            }

            else

            {

                current = head;

                while (current.next != null)

                {

                    current = current.next;

                }



                current.next = newNode;

            }

            count++;

        }



        public bool Remove(T item)

        {

            Node<T> nodeToRemove = new Node<T>(item);

            current = head;

            if (head.data.Equals(nodeToRemove.data))

            {

                current = head.next;

                head = current;

                return true;

            }

            else

            {

                while (current != null)

                {

                    if (current.data.Equals(nodeToRemove.data))

                    {

                        head.next = current.next;

                        current = head;

                        return true;

                    }

                    else

                    {

                        head = current;

                        current = current.next;

                    }

                }

            }

            count--;

            return false;

        }





        public bool Check(T data)

        {

            var existingNode = new Node<T>(data);



            var current = head;



            while (current != null)

            {

                if (current.data.Equals(existingNode.data))

                {



                    return true;

                }



                current = current.next;

            }
            return false;

        }





        public int Index(T data)

        {

            var existingNode = new Node<T>(data);

            var current = head;

            int index = 0;



            while (current != null)

            {

                if (current.data.Equals(existingNode.data))

                {

                    return index;

                }

                index++;

                current = current.next;

            }



            return -1;

        }



        public void PrintLinkedList()

        {

            var current = head;

            while (current != null)

            {

                Console.WriteLine(current.data);

                current = current.next;


            }
        }
    }

}

            

             



























