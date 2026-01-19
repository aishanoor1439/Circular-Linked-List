using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    internal class CLL
    {
        public Node head;

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
            head = newNode;
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void InsertAfter(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be null.");
                return;
            }

            Node newNode = new Node(data);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        public void DeleteNode(int key)
        {
            if (head == null)
                return;

            Node curr = head, prev = null;

            if (curr.Data == key)
            {
                if (curr.Next == head)
                {
                    head = null;
                    return;
                }

                Node temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }

                temp.Next = head.Next;
                head = head.Next;
                return;
            }

            do
            {
                prev = curr;
                curr = curr.Next;
            } while (curr != head && curr.Data != key);

            if (curr.Data == key)
            {
                prev.Next = curr.Next;
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node temp = head;
            Console.Write("Circular Linked List: ");

            do
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine();
        }
    }
}
