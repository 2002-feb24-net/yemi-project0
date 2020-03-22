using System;
using System.Collections.Generic;

namespace RamenDeliverySystem
{
    class Order
    {
        public int OrderId { get; set; }
        public int CustomerPhone { get; set; }
        public int FoodName { get; set; }
        public int FoodPrice { get; set; }
        public int BranchId { get; set; }

        public void takeorder()
        {   
           //FillList();
            IDictionary<int, string> dict = new Dictionary<int, String>();                                                                                   
            dict.Add(10, "beef");
            dict.Add(13, "vegi");
            dict.Add(1, "meat");
           // Console.WriteLine("which food do you want to order?");
            //String userchoes=Console.ReadLine();

         
            string result;
            int price;

            //Console.WriteLine("choose ");
            //price = int.Parse(Console.ReadLine());
            //if (dict.TryGetValue(price, out result))
            //{
            //    Dictionary<int, string> order = new Dictionary<int, string>();
            //    order.Add(price, result);
            //    foreach (var userinput in order)
            //    {
            //        Console.WriteLine(userinput.Key + "  " + userinput.Value);
            //    }
            Console.WriteLine("choose you food");
            price = Console.ReadLine();
            if (dict.TryGetValue(price, out result))
            {
                Dictionary<int, string> order = new Dictionary<int, string>();
               order.Add(price, result);
               foreach (var userinput in order)
                {
                    Console.WriteLine(userinput.Key + "  " + userinput.Value);
                }

        }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }
        }
  

    }
}
        
    
