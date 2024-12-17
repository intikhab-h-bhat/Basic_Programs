using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.LinkedList
{
    //public class Node
    //{
    //    public int Data; // Data stored in the node
    //    public Node Next; // Reference to the next node

    //    public Node(int data)
    //    {
    //        Data = data;
    //        Next = null; // Initially, the next node is null
    //    }
    //}

    //public class LinkedList
    //{
    //    private Node head; // Head (first node) of the list

    //    // Add a new node to the end of the linked list
    //    public void Add(int data)
    //    {
    //        Node newNode = new Node(data);
    //        if (head == null)
    //        {
    //            head = newNode; // If the list is empty, make this the first node
    //        }
    //        else
    //        {
    //            Node current = head;
    //            while (current.Next != null)
    //            {
    //                current = current.Next; // Traverse to the end of the list
    //            }
    //            current.Next = newNode; // Add the new node at the end
    //        }
    //    }

    //    // Print the linked list
    //    public void PrintList()
    //    {
    //        Node current = head;
    //        while (current != null)
    //        {
    //            Console.Write(current.Data + " -> ");
    //            current = current.Next; // Move to the next node
    //        }
    //        Console.WriteLine("null");
    //    }

    //    // Remove a node by value
    //    public void Remove(int data)
    //    {
    //        if (head == null)
    //        {
    //            Console.WriteLine("List is empty!");
    //            return;
    //        }

    //        // If the head needs to be removed
    //        if (head.Data == data)
    //        {
    //            head = head.Next;
    //            return;
    //        }

    //        Node current = head;
    //        while (current.Next != null && current.Next.Data != data)
    //        {
    //            current = current.Next;
    //        }

    //        if (current.Next == null)
    //        {
    //            Console.WriteLine($"Value {data} not found in the list!");
    //        }
    //        else
    //        {
    //            current.Next = current.Next.Next; // Remove the node
    //        }
    //    }
    //}


    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node head;

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;

            }




        }

        public void Remove(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.Data == data)
            {
                head = head.Next;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;

            }
            if (current.Next == null)
            {
                Console.WriteLine("The number is not in the list");

            }
            else
            {
                current.Next = current.Next.Next;
            }
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"{current.Data} -->");
                current= current.Next;
            }
            Console.WriteLine();
        }

    }   
    

}
