using System;

namespace CustomStackSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            
            Console.WriteLine(stack.Peek());

            stack.Pop();

            Console.WriteLine(stack.Peek());
        }
    }
}

