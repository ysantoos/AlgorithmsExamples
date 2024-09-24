using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class SingleLinkedList
    {
        public Node head;
        public void append(int value)
        {
            if(head == null)
            {
                head = new Node(value);
                return;
            }

            Node current = head;

            while (current.next != null) {
                current = current.next;
            }
            current.next = new Node(value);    
        }

        public void deleteNode(int value)
        {
            if (head == null) return;

            if(head.value == value)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.next != null) {
                if(current.next.value == value)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

        public void print()
        {
            if( head == null ) {
                Console.WriteLine("End");
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.value + "  -> ");
                current = current.next;
            }
        }

        public void print(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("End");
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.value + "  -> ");
                current = current.next;
            }
        }
    }
}
