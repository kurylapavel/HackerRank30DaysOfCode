using System;
using System.Collections.Generic;

namespace Day18
{
    class Program
    {
        public Stack<char> MyStack = new Stack<char>();
        public Queue<char> MyQueue = new Queue<char>();
        public void pushCharacter(char c)
        {
            MyStack.Push(c);
        }
        public char popCharacter()
        {
            return MyStack.Pop();
        }

        //Queue
        public void enqueueCharacter(char c)
        {
            MyQueue.Enqueue(c);
        }

        public char dequeueCharacter()
        {
            return MyQueue.Dequeue();
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Program obj = new Program();
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }
            bool isPalindrome = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
