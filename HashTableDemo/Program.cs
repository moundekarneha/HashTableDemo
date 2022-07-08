using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableDemo
{
    internal class Program
    {

        // - in array or arraylist - we can not change the index so its very hard to know which value is stored in which place
        //Hash table - contains user defined key not predefineed
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            //add with key and value
            ht.Add("Name", "Neha");
            ht.Add("Email", "Neha@gmail.com");
            ht.Add("Phone", "1234");


            Console.WriteLine("Emanil of person = " + ht["Email"]);
            Console.WriteLine("Printing keys ");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Key : "+item+" , Hashcode : "+item.GetHashCode());
            }


            Console.WriteLine("Printing value ");

            foreach (var item in ht.Values)
            {
                Console.WriteLine("Value : " + item + " , Hashcode : " + item.GetHashCode());
            }
            Console.ReadLine();

            
        }
    }
}
