using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class node
    {
        public object data;
        public node next;
        public node(object value)
        {
            this.data = value;
            next = null;
        }
        public void print()
        {
            Console.WriteLine(data);
            if (next != null)
            {
                next.print();  
            }
        }
        public void append(object data)
        {
            if (next==null)
            {
                next = new node(data);
            }
            else
            {
                next.append(data);
            }
        }

     

    }
    class Program
    {
        static void Main(string[] args)
        {   
            node mynode = new node("A");
            mynode.next = new node("1");
            mynode.next.next = new node("B");
            mynode.next.next.next = new node("2");
          
          //  Console.WriteLine(mynode.next.next.data); // access 
            mynode.print();
            Console.WriteLine("__________________________________________\a");
            mynode.append("C");
            mynode.append("3");
            mynode.print();

         

        }
     }


}
