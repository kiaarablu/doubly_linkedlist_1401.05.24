using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
    }

    public class Operation
    {
        Node head = null;

        public bool IsNull() 
        {
            if (head == null) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFirst(int value) 
        {
            if (IsNull()) 
            {
                Node node = new Node();
                node.value = value;
                node.next = null;
                node.prev = null;
                head = node;
            }
            else
            {
                Node node = new Node();
                Node tempNode = head;
                head.prev = tempNode;
                node.next = head.prev;
                
            }
        }



    }





}
