using System;

namespace Day24
{
    class Program
    {
		public static Node removeDuplicates(Node root)
		{
			var cur = root;
			while (cur != null && cur.next != null)
			{
				while (cur.next != null && cur.data == cur.next.data)
				{
					cur.next = cur.next.next;
				}
				cur = cur.next;
			}
			return root;
		}

		public static Node insert(Node head, int data)
		{
			Node p = new Node(data);


			if (head == null)
				head = p;
			else if (head.next == null)
				head.next = p;
			else
			{
				Node start = head;
				while (start.next != null)
					start = start.next;
				start.next = p;

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
		static void Main(String[] args)
		{

			Node head = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				head = insert(head, data);
			}
			head = removeDuplicates(head);
			display(head);
		}
	}
}
