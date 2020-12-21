using System;

namespace Day15
{
    class Program
    {

        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }


        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node nHead = head;
                while (nHead.next != null)
                {
                    nHead = nHead.next;
                }
                nHead.next = new Node(data);
            }
            return head;

        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }


    }
}
