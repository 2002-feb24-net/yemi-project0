using System;
using System.Collections.Generic;
namespace RamenDeliverySystem
{

    public class Customer
    {
        private string fullname = "N/A";

        public string FullName
        {

            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }
        public static List<String> newcustmer = new List<String>();
        public void AddCus()
        {
            Console.WriteLine("Please enter you name?");
            fullname = Console.ReadLine();
           // Console.WriteLine(fullname);
            Console.WriteLine(fullname +" "+"you are successfully registered ");

        }
    }
  
}
