using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollNumber;
                string studentName, address;
                byte age;
                char gender;
                DateTime dob;
                float percentage;
            Student obj = new Student();
            Console.WriteLine("Enter number of students");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] arr = new Student[n];
            for (int i = 0; i<= n; i++)
            {
                Console.WriteLine("Enter Details");
                rollNumber = Convert.ToInt32(Console.ReadLine());
                studentName = Console.ReadLine();
                age= Convert.ToByte(Console.ReadLine());
                gender = Convert.ToChar(Console.ReadLine());
                dob = Convert.ToDateTime(Console.ReadLine());
                percentage= float.Parse(Console.ReadLine());
            }
        }
    }
}
