using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracttest1
{
  
        class Namelist : List
        {

        //Array Declrtn
            private string[] list;
        //constructor
            public Namelist(string[] list1)
            {
                this.list = list1;
            }
            public void setList(string[] list)
            {
                this.list = list;
            }
            public override void printList(string[] list)

            {
            
            // print the array list

                  this.list = list;
               
            
                 foreach (string i in list)
                {
                    Console.WriteLine(i);

                 }
               
               }
        public override void search(string list)
        {
            // search
            // return true or false

            
            bool found = false;
            foreach (string i in this.list)
            {
                if (i == list)
                {
                    Console.WriteLine("Search name present in the Namelist");

                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Search name not present in the Namelist");

            }
        }
        static void Main(string[] args)
        {
            string[] list = { "Sneha", "Arya", "Sruthy", "Roshni", "Ajanya", "Nisha" };

            Namelist nl = new Namelist(list);   // new nameList(list);
            nl.setList(list);
            nl.printList(list);
            Console.ReadLine();
            nl.search("Sajith");
            Console.ReadLine();



        }

       
    }
    }


