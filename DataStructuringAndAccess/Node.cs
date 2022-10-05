using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAccess
{

    class Node<T>

    {

      // fields
        public T data;

        public Node<T> next;

       
      // constructor
        public Node(T d)

        {
            data = d;

            next = null;
        }

    }
}




    