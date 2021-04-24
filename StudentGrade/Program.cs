using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>  studentName = new List<string>();

            List<int> studentGrade = new List<int>();

            string choice;

            while(true)
            {
                Console.WriteLine("Student Name: ");
                studentName.Add(Console.ReadLine());

                Console.WriteLine("Student Grade: ");
                studentGrade.Add(int.Parse(Console.ReadLine()));


                Console.WriteLine("Add Another Student? (yes/No)");

                 choice = Console.ReadLine();

                if (choice == "no" )
                {
                    break;

                }

            } 

            for (int i = 0; i < studentName.Count; i++)
            {
                Console.WriteLine("Student Name: " + studentName[i] + ", Student Grade: " + studentGrade[i]);
            }

            Console.WriteLine("Enter the grade to search: ");

            int searchGrade = int.Parse(Console.ReadLine());

            numberOfStudentWithSameGrade(studentGrade, searchGrade);
            
        }

        public static void numberOfStudentWithSameGrade(List<int> student, int grade)
        {

            int count = 0;
           
            foreach (var item in student)
            {
                if (item == grade)
                {

                    count++;
                }

            }
            Console.WriteLine("Number of Student with Grade " + grade + " is : " + count);




        }

    }
}
