using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    /*
     * Write an algorithm to remove duplicate elements from a list.
     * Example:
     * Input: 1->2->2->3->4->1
     * Ouput: 1->2->3->4
     */
    public class RemoveDuplicates
    {

        public void RemoveDup(Node head)
        {
            if(head == null) return;    
            HashSet<int> foundValues = new();
            Node current = head;
            foundValues.Add(current.value);

            while(current != null && current.next != null)
            {
                if (!foundValues.Add(current.next.value)) 
                {
                    current.next = current.next.next;
                };

                current = current.next;
            }
        }
    }
}
