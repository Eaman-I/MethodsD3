/*
 Author: Eaman Iranmanesh
 Date: 1/31/2019
 Comments: This C# app code demonstrates the use of methods. It does so by repeating a users name back to them.
 */
using System;

namespace MethodsD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hell0! Please enter your name."); // user asked to enter name

            try // try catch block to verfiy user input
            {
                // variable declared to gather input
                string input = Console.ReadLine();

                // execute HelloUser method to read back name.
                HelloUser(input);
            }
            catch
            {

            }

        } // End of Main

        // Method used to repeat users name back to them.
        private static void HelloUser(string input)
        {
            // Sets user input to string name
            string name = input;

            Console.WriteLine("Hello " + name + "!"); // greets user by name
            Console.WriteLine("Press any key to exit the application."); // program end message. asks user to exit or not.
            Console.ReadKey(true);
        }
    }
}
