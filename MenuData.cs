using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Scool_Assignment_PartB_
{
    public static class MenuData
    {
        public static bool PrivateSchoolMain()
        {
            Console.Clear();
            Console.WriteLine("------------------------------Private School Data---------------------------");
            Console.WriteLine("To Read Database data, Press 1: ");
            Console.WriteLine("To insert data manually, Press 2: ");
            Console.WriteLine("To Exit, Press 3: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReadDatabase();
                    return true;

                case "2":
                    InsertToDatabase();
                    return true;
                case "3":
                    return false;
                default:
                    return true;

            }
        }

        private static void ReadDatabase()
        {
            bool exit = false;
            while (!exit)
            {

                Console.Clear();
                Console.WriteLine("<------------------------Read Database----------------------->\n");
                Console.WriteLine("To display Students:-----------------------------------Press 1: ");
                Console.WriteLine("To display Trainers:-----------------------------------Press 2: ");
                Console.WriteLine("To display Assignments:--------------------------------Press 3: ");
                Console.WriteLine("To display Courses:------------------------------------Press 4: ");
                Console.WriteLine("To display Students per Course:------------------------Press 5: ");
                Console.WriteLine("To display Trainers per Course:------------------------Press 6: ");
                Console.WriteLine("To display Assignments per Course:---------------------Press 7: ");
                Console.WriteLine("To display Assignments per Course Per Student:---------Press 8: ");
                Console.WriteLine("To display Students who have more than one Course:-----Press 9: ");
                Console.WriteLine("\nTo return to Main menu, Press 'Enter'");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("------------------STUDENTS------------------\n");                      
                        Read_Data.StudentSelect();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("<------------------TRAINERS------------------>\n");
                        Read_Data.TrainerSelect();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("---------------ASSIGNMENTS------------------\n");
                        Read_Data.AssignmentSelect();                       
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("------------------COURSES------------------\n");
                        Read_Data.CourseSelect();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("-------------STUDENTS PER COURSE------------\n");
                        Read_Data.StudentsPerCourseSelect();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("--------------TRAINERS PER COURSE------------\n");
                        Read_Data.TrainersPerCourseSelect();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("-------------ASSIGNMENTS PER COURSE-----------\n");
                        Read_Data.AssignmentsPerCourseSelect();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();                       
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("------ASSIGNMENTS PER COURSE PER STUDENT-------\n");
                        Read_Data.AssignmentsPerCoursePerStudentSelect();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("-------STUDENTS WITH MORE THAN ONE COURSE-------\n");
                        Read_Data.StudentsWithMoreThanOneCourse();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    default:
                        exit = true;
                        break;
                }
            }
        }
        private static void InsertToDatabase()
        {
            bool exit = false;
            while (!exit)
            {

                Console.Clear();
                Console.WriteLine("<----------------Insert Data To Database---------------->\n");
                Console.WriteLine("To Insert Student Data:---------------------------Press 1: ");
                Console.WriteLine("To Insert Trainer Data:---------------------------Press 2: ");
                Console.WriteLine("To Insert Assignment Data:------------------------Press 3: ");
                Console.WriteLine("To Insert Courses Data:---------------------------Press 4: ");
                Console.WriteLine("To Insert Students per Course:--------------------Press 5: ");
                Console.WriteLine("To Insert Trainers per Course:--------------------Press 6: ");                             
                Console.WriteLine("To Insert Assignments Per Student Per Course:-----Press 7: ");
                Console.WriteLine("\nTo return to Main menu, Press 'Enter'");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("-----------Student Data Input----------\n");
                        Insert_Data.InsertStudents();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("-------------Trainer Data Input---------\n");
                        Insert_Data.InsertTrainers();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("-----------Assignment Data Input--------- \n");
                        Insert_Data.InsertAssignments();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                       
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("-------------Course Data Input------------ \n");
                        Insert_Data.InsertCourses();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("-------Students per Course Data Input-------\n");
                        Insert_Data.InsertStudentsPerCourse();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("--------Trainers per Course Data Input--------\n");
                        Insert_Data.InsertTrainersPerCourse();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("----Assignments per Student per Course Data Input----\n");
                        Insert_Data.InsertAssignmentsPerStudentPerCourse();
                        Console.WriteLine("\nPress 'Any key' to return");
                        Console.ReadKey();
                        break;
                  
                    default:
                        exit = true;
                        break;
                }

            }

        }
    }
}
