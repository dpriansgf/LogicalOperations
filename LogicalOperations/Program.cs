using System;

namespace LogicalOperations
{

    class Program
    {

        static void Main(string[] args)
        {

            string Name;
            int Age;

            Console.WriteLine(" Enter your name ");
        Name = Console.ReadLine();
            
            Console.WriteLine(" Enter your age ");
            Age = Convert.ToInt32(Console.ReadLine());

            if (Age <= 5) 
               
            {
                Console.WriteLine(Name + " You are a infant ");

            }  
            
            else if (Age <= 18 )
            {
                Console.WriteLine(Name + " You are a minor");
            }
            else if (Age <= 64 )
                
            {
            
                Console.WriteLine(Name + " You are a adult ");
            
            }
            else if (Age>= 64)
            {
                Console.WriteLine(Name + "You are a senior citizen");
            }
            if (Age <= -1  )
            {
                Console.WriteLine(" Invalid age entered :( ");
            }
            
                
            

        }
    }
}