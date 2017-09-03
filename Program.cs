using System;

namespace problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("This program will ask you to enter the number two times");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Please type the number 1");
            int number1  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type a number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2){
                Console.WriteLine("number1 is greater than number2");
            }
            else if(number1 == number2){
                Console.WriteLine("Both number are equal");

            }
            else{
                Console.WriteLine("number2 is greater than number1");
            }
            Console.ReadKey();


            


        }
    }
}
