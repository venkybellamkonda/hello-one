using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1

{
   public  class customer
    {
        // Member Variables    
        public int CustID;
        public string Name;
        public string Address;

        //constuctor for initializing fields    
        customer()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }

        //method for displaying customer records (functionality)    
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }


        // Code for entry point
        
           public class Class1
        {
            public static void Main()
            {
                //object instantiation
                customer obj = new customer();

                //Method Calling
                //obj.displayData();

                //fields calling
                Console.WriteLine(obj.CustID);
            }
        } 
    }
}
