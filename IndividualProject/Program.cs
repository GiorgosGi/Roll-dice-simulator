using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();

            Console.WriteLine("How many traines?");
            int tr = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tr; i++)
            {
                List<Trainer> trainers = new List<Trainer>();
                trainers.Add(cpUtils.GetTrainerDetails());

                cpUtils.PrintTrainersList(trainers);
            }


            //List<Course> courses = new List<Course>();
            //courses.Add(cpUtils.GetCourseDetails());
            //cpUtils.PrintCoursesList(courses);

            //List<Student> students = new List<Student>();
            //students.Add(cpUtils.GetStudentDetails());
            //cpUtils.PrintStudentsList(students);

            //List<Assignment> assignments = new List<Assignment>();
            //assignments.Add(cpUtils.GetAssignmentDetails());
            //cpUtils.PrintAssignmentsList(assignments);

        }

       
        // Create appropriate methods in order to ask 
        // from the user data for the four main classes
    }
}
