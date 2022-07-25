using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracttest
{
  
    abstract class List
    {
        // Abstract method (does not have a body)
        public abstract void search();
        


        public void search1()
        {
            Console.WriteLine("Final result");
            Console.ReadLine();
        }

    }


    class NameList : List
    {
        public override void search()
        {
            string[] name = {"Sneha", "Arya", "Sruthy",
                            "Roshni", "Ajanya", "Nisha", "Sarath"};






            Console.WriteLine("Display the array:");

            Console.WriteLine(" ");


            foreach (string i in name)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine(" ");


            Console.Write("Result: ");


            // Using Exists() method

            Console.WriteLine("Is name present in name: {0}",
            
                Array.Exists(name, element => element == "Sneha"));



        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            NameList name = new NameList();

            name.search();

            name.search1();
        }
    }
}




//using System;
//using System.Collections;
//using System.Collections.Generic;


//namespace Abstracttest
//{

//    // Abstract class
//    abstract class List
//    {
//        // Abstract method (does not have a body)
//        public abstract void search();
//        // Regular method
//        public void search1()
//        {
//            Console.WriteLine("----");
//            Console.ReadLine();
//        }

//    }


//    class NameList : List
//    {
//        public override void search()
//        {

//            List<String> name = new List<String>();


//            name.Add("Sneha");
//            name.Add("Arya");
//            name.Add("Sruthy");
//            name.Add("Roshni");
//            name.Add("Ajanya");
//            name.Add("Nisha");
//            name.Add("Sarath");


//            Console.Write(name.Contains("Anu"));

//        }

//    }
//      class Program
//    {
//        static void Main(string[] args)
//        {
//            NameList name = new NameList();  
//            name.search();
//            name.search1();
//        }



//    }

//}