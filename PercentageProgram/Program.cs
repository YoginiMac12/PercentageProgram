using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total Subjects");
            int marks = Convert.ToInt32(Console.ReadLine());
            int totalmarks, physics, chemistry, maths;
            float percentage;

            Console.WriteLine("Enter physics Marks : ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter chemistry Marks : ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter maths Marks :");
            maths = Convert.ToInt32(Console.ReadLine());

            totalmarks = physics + chemistry + maths;
            percentage = totalmarks/3.0f;

            Console.WriteLine("Total Marks : " + totalmarks);
            Console.WriteLine("Percentage : " + percentage);

            if(percentage >= 80)
            {
                Console.WriteLine("Your Grade is: A");
            }
            else if(percentage >= 70)
            {
                Console.WriteLine("Your Grade is: B");
            }
            else if(percentage >= 60)
            { 
                Console.WriteLine("Your Grade is: C"); 
            }
            else if(percentage <= 60)
            {
                Console.WriteLine("Your Grade is: D");
            }
                   
        }
    }
}
       