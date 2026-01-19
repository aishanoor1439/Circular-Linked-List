using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLL clist = new CLL();

            clist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            clist.head.Next = second;
            second.Next = third;
            third.Next = clist.head; 

            clist.InsertAtBeginning(0);
            clist.InsertAfter(second, 5);
            clist.InsertAtEnd(6);

            clist.DeleteNode(3);

            clist.Display();
        }
    }
}
