using System;
using System.Collections.Generic;


namespace RamenDeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings");



            Console.WriteLine("Welcome to our service");
            Customer cus = new Customer();

            Console.WriteLine();
            Console.WriteLine("A:\tdo you want to add custmer");
            Console.WriteLine("o:\tdo you want to order.");
            Console.WriteLine("s:\tdo you want search customers");
            Console.WriteLine("h:\tdo you want to see your history");
            Console.WriteLine();
            Console.Write("Enter valid menu option, or \"q\" to quit: ");
            var input = Console.ReadLine();
            if (input == "a")
            {
                Customer mycustm = new Customer();
                mycustm.AddCus();
            
            }
            else if (input == "o")
            {
                Order myorder = new Order();
                // OutputNames();
                Console.WriteLine("we have the following three branches");
                ChooseStore();
           
                  myorder.takeorder();
                
            }
        }


        private static string ChooseStore()
        {
            Console.WriteLine("1,TA");
            Console.WriteLine("2,maryland");
            Console.WriteLine("3,dc");
            Console.WriteLine();
            Console.Write("from which branch do you want to order? ");
            string userIn = Console.ReadLine();
          

            if (userIn == "1" || userIn == "2" || userIn == "3")
            {
                OutputNames();
            }
            else
            {
                Console.WriteLine("Sorry, that's not an option. Try again");
                ChooseStore();
            }

            return userIn;
        }

        public static void OutputNames()
        {
            var dict1 = new Dictionary<string, double>();
       

            dict1.Add("chicken", 10);
            dict1.Add("vegi", 13);
            dict1.Add("beef", 15);
            //DisplayDict(dict1);

            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key + " " + item.Value.ToString("C2"));

            }
           // Console.Write("Which one do you want? ");
            //string chosee = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("How many do you want? ");
            //double quanity = Double.Parse(Console.ReadLine());

        }
    }
}

