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
            stack.Push("qwe");
            // object based stack allow us to
            // add any value but it will throw
            // Err on runtime



            Console.WriteLine(stack.Peek());

            stack.Pop();

            Console.WriteLine(stack.Peek());

            AnotherStack<int> GenericStack = new AnotherStack<int>();

            GenericStack.Push(1);
            GenericStack.Push(2);
            GenericStack.Push(3);
            // GenericStack.Push("qwe");

            // ide don't allow us to push non T
            // value

            // with generic we're happy


            Console.WriteLine(stack.Peek());

            stack.Pop();

            Console.WriteLine(stack.Peek());

        }
    }
}

