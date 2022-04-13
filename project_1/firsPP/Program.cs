using System;

namespace firsPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, include digit");
            int  number = Convert.ToInt32(Console.ReadLine());
            
            if(number%2 == 0){
                Console.WriteLine("This digit is even"); }
            else
            {
                Console.WriteLine("This digit is odd");
            }
            
        }
    }
}
