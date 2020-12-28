using System;
using System.Collections.Generic;

namespace Day23
{
    class Program
    {
        static void levelOrder(Node root)
        {
            Queue<Node> line = new Queue<Node>();
            line.Enqueue(root);

            while (line.Count != 0)
            {
                var cur = line.Dequeue();

                if (cur != null)
                {
                    Console.Write(cur.data + " ");
                }

                if (cur.left != null)
                {
                    line.Enqueue(cur.left);
                }

                if (cur.right != null)
                {
                    line.Enqueue(cur.right);
                }
            }

        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}
