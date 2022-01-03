using System;
using System.Collections.Generic;

namespace Datatypes
{



    public class Example
    {

        public static void Main(String[] args  )
        {

           
            string Date = DateTime.Now.ToString("dd-MM-yyyy");

            List<String> name = new List<String>();
            name.Add("Fernando");
            name.Add("Rodolfo");
            name.Add("Alejandro");
            name.Add("Maria");
            name.Add("Rogelio");
            name.Add("Carmina");
            name.Add("Maria");
            name.Add("Nina");
            name.Add("Cesar");
            name.Add("Neska");


           

            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine("Element#{0} = {1}", i, name[i] + "   " + Date);
            }

            Console.WriteLine("        ");

            foreach (string cosa in name) {

                Console.WriteLine("Element = " + cosa + "    " + Date) ;   
            
            }   

                Console.ReadKey();

                Console.WriteLine("        ");

            int a = 0;
            while (a <= name.Count) {

                Console.WriteLine("Element = " + name[a] + "    " + Date);
                  a++;
            }

            Console.ReadKey();

            Console.WriteLine("        ");


            
            do
            {
                Console.WriteLine("Element = " + name[a] + "    " + Date);
                a++;
            }
            while (a <= name.Count);

            Console.ReadKey();



        }
    }
}