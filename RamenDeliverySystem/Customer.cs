using System;
using System.Collections.Generic;
namespace RamenDeliverySystem
{

    class Customer
    {
        private string name = "N/A";
        private int phonenumber = 0;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int PhoneNumber
        {
            get
            {
                return phonenumber;
            }

            set
            {
                phonenumber = value;
            }


        }
                

        public  void printcustmer()
        { 
    
    
  List<Customer> newcustmer = new List<Customer>();

        
            newcustmer.Add(new Customer { Name = "crank arm", PhoneNumber = 14625347 });
            newcustmer.Add(new Customer { Name = "chain ring", PhoneNumber = 1332423 });
            newcustmer.Add(new Customer { Name = "regular seat", PhoneNumber = 143423 });
            newcustmer.Add(new Customer { Name = "banana seat", PhoneNumber = 14324 });
            newcustmer.Add(new Customer { Name = "cassette", PhoneNumber = 1532412 });
            newcustmer.Add(new Customer { Name = "shift lever", PhoneNumber = 1632423 });

          


           

            foreach (var rsult in newcustmer)
            {
                Console.WriteLine(rsult);
            }
        }


        public override string ToString()
        {
            return "Name = " + Name + ", PhoneNumber = " + PhoneNumber;
        }

    }
}