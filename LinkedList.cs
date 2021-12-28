using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)                                                                    
        {
            Node node = new Node(data);                                                                  
            if (this.head == null) //if head is null then we put node (data) -----> head               
            {
                this.head = node; //here 1st node becomes head                                        
            }
            else                                                                                                                                //                                                 70(head)
            {
                Node temp = head;     //we have created another node called temp and call it head now                                           
                while (temp.next != null)    //temp.next ---> pudhcha node null nsel tr                                                    
                {
                    temp = temp.next;     //temp mdhe node(data) aala pahije                                                                                    
                                          // pudhichi jaga = temp.next
                }
                temp.next = node;     //pudhichi jaga = node 

            }
            Console.WriteLine("{0} inserted into LinkedList", node.data);                          
        }

        internal void Display()
        {
            Node temp = this.head; //temp has given starting position 

            if (temp == null)  //has to check stating position null or not 
            {
                Console.WriteLine("LinkedList is Empty");  //if strting position is empty
                return;                                    //return will stop the further code.
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;    //temp == pudhchi jaga

            }
        }

        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        var node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("Inserted value is : " + head);
            return head;
        }

    }
}
