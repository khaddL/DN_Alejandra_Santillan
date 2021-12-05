using System;

namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a String";
            int age = 23;
            DateTime now = DateTime.Now;

            double amount = 0;

            string string2 = text + "this is a second string" + age + now;

            string string3 = string.Format("The age is {0}, the time is {1}, and the amount is {2} ", age, now, amount);

            string string4 = $"the age is {age}, the time is {now}, the amount is {amount}";

            char samplechar = 'c';

            char[] arraychar = string4.ToCharArray();

            amount = (double)10 / (double)3;

            age = 10 + 3;

            DateTime dateTime = new DateTime(2000, 1, 1);

            var timestamp = now - dateTime;

            Console.WriteLine(timestamp.TotalMilliseconds);

            string test = "15";

            age = int.Parse(test);

            string booleanvalue = "true";
            bool isTrue =bool.Parse (booleanvalue);

            Console.ReadKey();
        }
    }
}
