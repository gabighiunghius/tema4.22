using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapt4_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {



            //Stack myStack = new Stack();

            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);
            //myStack.Push(40);


            //foreach (int i in myStack)
            //{
            //    Console.WriteLine(i);
            //}


            //myStack.Peek();
            //Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());

            //foreach (int i in myStack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            // Create a queue 
            // Using Queue class 
            Queue my_queue = new Queue();

            // Adding elements in Queue 
            // Using Enqueue() method 
            my_queue.Enqueue("GFG");
            my_queue.Enqueue("Geeks");
            my_queue.Enqueue("GeeksforGeeks");
            my_queue.Enqueue("geeks");
            my_queue.Enqueue("Geeks123");


        }
    }
}
