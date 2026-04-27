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
            string? strNull = null;
            string notNull = "";

            Int32 notNullLength = notNull.Length;
            Int64 inteiro = 10;


            if (notNull == null)
            {
                Console.WriteLine("Null: " + strNull);
            } else
            {
                Console.WriteLine("Not Null: " + notNull);
            }
        }
    }
}


