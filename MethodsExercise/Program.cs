using System.ComponentModel;

namespace MethodsExercise
{
    class Program
    {
        //Exercise Two___________________________________________________
        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i< list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int Multiply(int num1, int num2, int num3) 
        {
            return num1 * num2 * num3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var amountOfCars = Sum(2, 6);
            var dollars = Multiply(60, 2, 4);
            Console.WriteLine(amountOfCars);
            Console.WriteLine(dollars);
            Console.WriteLine("Press any key to continue...");
            
            var numbers = Console.ReadLine();
            var result = Sum(10, 20);
            Console.WriteLine(result);
            Console.WriteLine("Press any key to enter Mad Lips.");
            Console.ReadLine();
           
                                          
            Console.Clear();



            //Exercise One_______________________________________


            Console.WriteLine("Hi! What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {userName}. My name is Albert. Lets play a game! Tell me the name of a place?");
            var place = Console.ReadLine();

            Console.WriteLine($"cool...{userName}, give me a adjective (a word describing an attribute).");
            var adj1 = Console.ReadLine();

            Console.WriteLine("Interesting... type a second adjective.");
            var adj2 = Console.ReadLine();

            Console.WriteLine("Thats gonna be great! Gimmie the name of a female celeb.");
            var female = Console.ReadLine();

            Console.WriteLine("Whats your favorite male celebrity?");
            var male = Console.ReadLine();

            Console.WriteLine($"{male} is awesome! Now, we are going to do 3 nouns 1 at a time. Unfortunately, I am slow. Type out your first noun (person, place or thing)");
            var noun1 = Console.ReadLine();

            Console.WriteLine("oooh! this is gonna be funny! type your second noun.");
            var noun2 = Console.ReadLine();

            Console.WriteLine("Type noun 3. Working on it, bare with me.");
            var noun3 = Console.ReadLine();

            Console.WriteLine("Great! happy your still with me! We are going to do 4 more nouns, one at a time, but this time we are making them plural. Give me Your first PLURAL noun, please.");
            var plural1 = Console.ReadLine();

            Console.WriteLine("Great job! now give me my second plural noun.");
            var plural2 = Console.ReadLine();

            Console.WriteLine("a third plural noun now.");
            var plural3 = Console.ReadLine();

            Console.WriteLine("I am almost done. Give me my 4th plural noun.");
            var plural4 = Console.ReadLine();

            Console.WriteLine("yum! eating up that data! Last question...\nType in a profession/job title and make that plural too.");
            var proff = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($" Albert Einstein, the son of {female} and {male},\n " +
                $"born in Ulm, Germany, in 1879. In 1902, he had a job\n " +
                $"as assistant {noun1} in the Swiss patent office and attended\n " +
                $"the University of Zurich. There he began studying atoms, molecules\n" +
                $" and {plural1}. He developed the theory of\n " +
                $"{adj1} relativity, which expanded the phenomena of sub-atomic\n" +
                $" {plural2} and {adj2} magnetism. In 1921, he won the Nobel prize for\n" +
                $" {plural3} and was director of theoretical physics at the Kaiser Wilhelm\n " +
                $"{noun2} in Berlin. In 1933, when Hitler became Chancellor of {place},\n " +
                $"Einstein came to America to take a post at Princeton Institute for\n " +
                $"{plural4}, where his theories helped America devise the first\n " +
                $"atomic {noun3}. There is no question about it: Einstein was\n " +
                $"one of the most brilliant {proff} of our time.\n");

        }
    }
}
