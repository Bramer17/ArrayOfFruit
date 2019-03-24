using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofFruit
{   
    class Program
    {//
        public enum Fruit
        {
            None,
            Banana, 
            Apple,
            Pear, 
            Peach, 
            Orange,
            Strawberry        
        }
        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[3];
            string userResponse;
            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine($"Enter Fruit #{index + 1}:");
                userResponse = Console.ReadLine();
                Enum.TryParse(userResponse, out fruits[index]);                
            }
            Console.WriteLine();

            foreach  (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
