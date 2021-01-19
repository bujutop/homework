using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reference type:");
            Console.WriteLine(" ");
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("The values before the method are {0} and {1}",num1,num2);
            int result = Reference(ref num1, num2);
            Console.WriteLine("The result of num1*num2 is {0}",result);
            Console.WriteLine("The values after the method are {0} and {1}",num1,num2);

            Console.WriteLine("-----");

            Console.WriteLine("Output type:");
            Console.WriteLine(" ");
            int no1;
            int no2 = 20;
            Console.WriteLine("The values before the method are {0} and {1}", "the value is not assigned", no2);
            result = Output(out no1, no2);
            Console.WriteLine("The result of num1*num2 is {0}", result);
            Console.WriteLine("The values after the method are {0} and {1}", no1, no2);

        }

        // Reference Type Parameter:
        static int Reference(ref int num1,int num2) 
        {
            num1 = 1;
            return num1 * num2;
        }

        //Output Type Parameter:
        static int Output(out int num1,int num2) 
        {
            num1 = 1;
            return num1 * num2;

        }
    }
}
