using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace MethodsExercise
{
    class Program
    {

        public static int Add(params int[] numbers)
        {
            int sum = 5;
            foreach (int num in numbers)
            {
                sum = sum + num;
            }
            return sum;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return (num1 * num2 * num3);
        }

        static void Main(string[] args)
        {
            var afterDeductable = Add(2, 3, 5, 6);
            Console.WriteLine($"Amount after Deductable:\t ${afterDeductable}.00");

            Console.WriteLine();

            var total = Multiply(21, 4, 5);
            Console.WriteLine($"Amount after taxes and interest:\t ${total}.00");

            Console.WriteLine();

            Console.WriteLine("press any key to continue...");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Hi {userName}! We are gonna play madlips. Type an adjective.");
            var adj = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Give me a food and make it plural.");
            var food1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{food1} are yummy! Give me a verb.");
            var verb = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Give me a saying, please.");
            var saying = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Give me a noun.");
            var noun = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type another food and make it plural too.");
            var food2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Pick a color.");
            var color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Something you would ride in.");
            var trans = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("an animal.");
            var animal = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("A person.");
            var person = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Today I went to my favorite Taco Stand called the {adj} {animal}.\n" +
                $" Unlike most food stands, they cook and prepare the food in a {trans} while you {verb}.\n" +
                $" The best thing on the menu is the {color} {noun}. Instead of ground beef they fill\n" +
                $" the taco with {food1}, cheese, and top it off with a salsa made from {food2}. If that\n" +
                $" doesn't make your mouth water, then it's just like {person} always says: {saying}!");
                          
        
        }
       
       


    }
}
