using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMari
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.    
            string output;
            DateTime date = new DateTime();

            date = DateTime.Now;
            Console.WriteLine("Enter Your Name ");
            output = Console.ReadLine();
            Console.WriteLine("Name  " + output.ToString() + "  " + date.ToString("G"));




            //2.

            //3.
            int i = 0;


            Console.WriteLine("Enter Number");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("This Number is " + i.ToString());


            if (i % 2 == 1)
            {
                Console.WriteLine("ODD");
                Console.Read();
            }
            else
            {
                Console.WriteLine("EVEN");
                Console.Read();
            }
            try
            {

                {
                    i = -1;
                }
            }
            catch
            {
                Console.WriteLine("0 is not accepted");
                Console.Read();
            }


            //4.

            //5.
            int num1 = 0;
            int num2 = 0;



            int answer = num1 + num2;

            Console.WriteLine("");
            Console.WriteLine("Enter Number1");
            int.TryParse(Console.ReadLine(), out num1);
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number2");
            int.TryParse(Console.ReadLine().ToString(), out num2);

            Console.WriteLine("Number1 + Number2 = " + answer);
            Console.WriteLine("");


            //6
            DateTime day = new DateTime();

            int input;

            Console.WriteLine("Enter Date Time  like 2019-06-07");



            //string output;


            //7
            int num;


            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }


            //8







            Console.ReadKey();




        }

    }
}
