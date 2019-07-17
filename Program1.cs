using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

   class LinkedList
{
    Node Head, Orange, Tangerine, Tail;
    public void CreateLikedList()
    {
        Head = new Node();
        Orange = new Node();
        Tangerine = new Node();
        Tail = Tangerine;
        Head.nextlink = Orange;
        Console.WriteLine("hello");

    }
    class Node
    {
        public string studentname;
        public Node next;
        public Node prev;



    }
}
