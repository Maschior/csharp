using System;
using System.ComponentModel;

namespace CODE
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is a simple example of using the Console.WriteLine method.
        /// </summary>
        static void Main(string[] args)
        {   
            var text = "Hello, World!";
            Console.WriteLine(text);

            string text2 = "teste";
            var num = 2324m;
            var character = '0';
        
            
            Console.WriteLine(num.GetType());
            Console.WriteLine(num);


            
        }
    }
}


