using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Scool_Assignment_PartB_
{
    class Read_Data
    {

        
        public static void StudentSelect()
        {
            

            string queryString = "SELECT STUDENT.LastName, STUDENT.FirstName, STUDENT.DateOfBirth, STUDENT.Tuitionfees FROM STUDENT ORDER BY STUDENT.LastName";

            
            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

            Console.WriteLine($"{SQLHelpers.ColNameStrPadding("FULL NAME:", 24)}\t{SQLHelpers.ColNameStrPadding("BIRTH DATE:", 12)}\t{SQLHelpers.ColNameStrPadding("TUITION FEES:", 13)}");
            while (reader.Read())
            {
               
                
                System.DateTime birthdate = (DateTime)reader[2];
                string birthDateAsString = birthdate.ToString("MM-dd-yyyy");

                Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 14)}\t{SQLHelpers.ReaderStringPadding(reader[1], 10)}\t{SQLHelpers.ReaderStringPadding(birthDateAsString, 12)}\t{SQLHelpers.ReaderStringPadding(reader[3], 13)}");


            }
            reader.Close();
            Console.ReadLine();

        }

        public static void TrainerSelect()
        {
            string queryString = "SELECT TRAINER.FirstName, TRAINER.LastName, TRAINER.Subject FROM TRAINER ORDER BY TRAINER.LastName";
            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

            Console.WriteLine($"{SQLHelpers.ColNameStrPadding("FULL NAME:", 24)}\t{SQLHelpers.ColNameStrPadding("SUBJECT:", 12)}");

            while (reader.Read())
            {
                Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 14)}\t{SQLHelpers.ReaderStringPadding(reader[1], 10)}\t{SQLHelpers.ReaderStringPadding(reader[2], 12)}");


            }
            reader.Close();
            Console.ReadLine();
           
        }

        public static void CourseSelect()
        {
            string queryString = "SELECT COURSE.Title, COURSE.Stream, COURSE.Type, COURSE.StartDate, COURSE.EndDate FROM COURSE";
            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

            Console.WriteLine($"{SQLHelpers.ColNameStrPadding("TITLE:", 6)}\t{SQLHelpers.ColNameStrPadding("STREAM:", 12)}\t{SQLHelpers.ColNameStrPadding("TYPE:", 10)}\t{SQLHelpers.ColNameStrPadding("START DATE:", 12)}\t{SQLHelpers.ColNameStrPadding("END DATE:", 10)}");

            while (reader.Read())
            {
                System.DateTime startDate = (DateTime)reader[3];
                System.DateTime endDate=(DateTime)reader[4];
                string startDateAsString = startDate.ToString("MM-dd-yyyy");
                string endDateAsString = endDate.ToString("MM-dd-yyyy");

                Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 6)}\t{SQLHelpers.ReaderStringPadding(reader[1], 12)}\t{SQLHelpers.ReaderStringPadding(reader[2], 10)}\t{SQLHelpers.ReaderStringPadding(startDateAsString, 12)}\t{SQLHelpers.ReaderStringPadding(endDateAsString, 10)}");

            }
            reader.Close();
            Console.ReadLine();

           
        }

        public static void AssignmentSelect()
        {
            string queryString = "SELECT ASSIGNMENT.Title, ASSIGNMENT.Description, ASSIGNMENT.SubDateTime, ASSIGNMENT.OralMark, ASSIGNMENT.TotalMark FROM ASSIGNMENT";
            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

            Console.WriteLine($"{SQLHelpers.ColNameStrPadding("TITLE:", 18)}\t{SQLHelpers.ColNameStrPadding("DESCRIPTION:", 20)}\t{SQLHelpers.ColNameStrPadding("SUB DATE TIME:", 22)}\t\t{SQLHelpers.ColNameStrPadding("ORAL MARK:", 12)}\t{SQLHelpers.ColNameStrPadding("TOTAL MARK:", 12)}");

            while (reader.Read())
            {

                Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 18)}\t{SQLHelpers.ReaderStringPadding(reader[1], 20)}\t{SQLHelpers.ReaderStringPadding(reader[2], 22)}\t\t{SQLHelpers.ReaderStringPadding(reader[3], 12)}\t{SQLHelpers.ReaderStringPadding(reader[4], 12)}");
            }
            reader.Close();
            Console.ReadLine();
        }

        public static void StudentsPerCourseSelect()
        {
            string queryString = "SELECT STUDENT.LastName, STUDENT.FirstName, STUDENT.DateOfBirth, STUDENT.TuitionFees, COURSE.Title, COURSE.Stream, COURSE.Type, COURSE.StartDate, COURSE.EndDate FROM STUDENTSPERCOURSE INNER JOIN COURSE ON COURSE.ID=STUDENTSPERCOURSE.CourseID INNER JOIN STUDENT ON STUDENT.ID=STUDENTSPERCOURSE.STUDENTID ORDER BY STUDENT.LastName";
            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

            Console.WriteLine($"{SQLHelpers.ColNameStrPadding("FULL NAME:", 24)}\t{SQLHelpers.ColNameStrPadding("DATE OF BIRTH:", 18)}\t{SQLHelpers.ColNameStrPadding("TUITION FEES:", 12)}\t{SQLHelpers.ColNameStrPadding("TITLE:", 6)}\t{SQLHelpers.ColNameStrPadding("STREAM:", 12)}\t{SQLHelpers.ColNameStrPadding("TYPE:", 12)}\t{SQLHelpers.ColNameStrPadding("START DATE:", 12)}\t{SQLHelpers.ColNameStrPadding("END DATE:", 12)}");

            while (reader.Read())
            {

                Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 14)}\t{SQLHelpers.ReaderStringPadding(reader[1], 10)}\t{SQLHelpers.ReaderStringPadding(reader[2], 18)}\t{SQLHelpers.ReaderStringPadding(reader[3], 12)}\t{SQLHelpers.ReaderStringPadding(reader[4], 6)}\t{SQLHelpers.ReaderStringPadding(reader[5], 12)}\t{SQLHelpers.ReaderStringPadding(reader[6], 12)}\t{SQLHelpers.ReaderStringPadding(reader[7], 12)}\t{SQLHelpers.ReaderStringPadding(reader[8], 12)}");
            }
            reader.Close();
            Console.ReadLine();
        }

        public static void TrainersPerCourseSelect()
        {
            string queryString = "SELECT TRAINER.LastName, TRAINER.FirstName, TRAINER.Subject, COURSE.Title, COURSE.Type, COURSE.Stream FROM TRAINERSPERCOURSE INNER JOIN COURSE ON COURSE.ID=TRAINERSPERCOURSE.CourseID INNER JOIN TRAINER ON TRAINER.ID=TRAINERSPERCOURSE.TRAINERID ORDER BY TRAINER.LastName";
            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

              Console.WriteLine($"{SQLHelpers.ColNameStrPadding("TRAINER:", 24)}\t{SQLHelpers.ColNameStrPadding("SUBJECT:",10)}\t{SQLHelpers.ColNameStrPadding("TITLE:",5)}\t{SQLHelpers.ColNameStrPadding("TYPE:",10)}\t{SQLHelpers.ColNameStrPadding("STREAM:",10)}\n");

            while (reader.Read())
            {
               
               Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0],14)}\t{SQLHelpers.ReaderStringPadding(reader[1],10)}\t{SQLHelpers.ReaderStringPadding(reader[2],10)}\t{SQLHelpers.ReaderStringPadding(reader[3],5)}\t{SQLHelpers.ReaderStringPadding(reader[4],10)}\t{SQLHelpers.ReaderStringPadding(reader[5],10)}");

            }
            reader.Close();
            Console.ReadLine();
        }

        public static void AssignmentsPerCourseSelect()
        {
            
                string queryString = "SELECT ASSIGNMENT.Title, ASSIGNMENT.[Description],COURSE.Title, COURSE.Stream, COURSE.Type FROM ASSIGNENTSPERCOURSE JOIN COURSE ON Course.ID=ASSIGNENTSPERCOURSE.CourseID JOIN ASSIGNMENT ON ASSIGNMENT.ID=ASSIGNENTSPERCOURSE.ASSIGNMENTID";
                SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

               Console.WriteLine($"{SQLHelpers.ColNameStrPadding("ASSIGNMENT TITLE:", 20)}\t{SQLHelpers.ColNameStrPadding("ASSIGNMENT DESCRIPTION:", 25)}\t{SQLHelpers.ColNameStrPadding("COURSE TITLE:", 13)}\t{SQLHelpers.ColNameStrPadding("COURSE STREAM:", 15)}\t{SQLHelpers.ColNameStrPadding("COURSE TYPE:", 12)}");

                while (reader.Read())
                {

                    Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 20)}\t{SQLHelpers.ReaderStringPadding(reader[1], 25)}\t{SQLHelpers.ReaderStringPadding(reader[2], 13)}\t{SQLHelpers.ReaderStringPadding(reader[3], 15)}\t{SQLHelpers.ReaderStringPadding(reader[4], 12)}");
                }
                reader.Close();
                Console.ReadLine();
          
        }

        public static void AssignmentsPerCoursePerStudentSelect()
        {
            string queryString = "SELECT ASSIGNMENT.Title, ASSIGNMENT.Description,COURSE.Title,STUDENT.LastName, STUDENT.FirstName FROM AssignmentsPerStudentPerCourse JOIN COURSE ON Course.ID=AssignmentsPerStudentPerCourse.CourseID JOIN ASSIGNMENT ON ASSIGNMENT.ID=AssignmentsPerStudentPerCourse.ASSIGNMENTID JOIN STUDENT ON Student.ID=AssignmentsPerStudentPerCourse.StudentID";
            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

            Console.WriteLine($"{SQLHelpers.ColNameStrPadding("ASSIGNMENT TITLE:", 20)}\t{SQLHelpers.ColNameStrPadding("ASSIGNMENT DESCRIPTION:", 25)}\t{SQLHelpers.ColNameStrPadding("COURSE TITLE:", 13)}\t{SQLHelpers.ColNameStrPadding("STUDENT FULL NAME:", 24)}");

            while (reader.Read())
            {

                Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 20)}\t{SQLHelpers.ReaderStringPadding(reader[1], 25)}\t{SQLHelpers.ReaderStringPadding(reader[2], 13)}\t{SQLHelpers.ReaderStringPadding(reader[3], 12)}\t{SQLHelpers.ReaderStringPadding(reader[4], 12)}");
            }
            reader.Close();
            Console.ReadLine();
        }

        public static void StudentsWithMoreThanOneCourse()
        {
            string queryString = "SELECT STUDENT.LastName, STUDENT.FirstName, COUNT (*) AS TotalCourses FROM StudentsPerCourse JOIN STUDENT ON STUDENT.ID=StudentsPerCourse.STUDENTID GROUP BY StudentID, Student.LastName, Student.FirstName HAVING COUNT (*) >1 ORDER BY STUDENT.LastName";


            SqlDataReader reader = SQLHelpers.GetExecuteDataReader(queryString);

            Console.WriteLine($"{SQLHelpers.ColNameStrPadding("FIRST NAME:", 12)}\t{SQLHelpers.ColNameStrPadding("LAST NAME:", 12)}\t{SQLHelpers.ColNameStrPadding("Total Courses:", 14)}");

            while (reader.Read())
            {

                Console.WriteLine($"-{SQLHelpers.ReaderStringPadding(reader[0], 12)}\t{SQLHelpers.ReaderStringPadding(reader[1], 12)}\t{SQLHelpers.ReaderStringPadding(reader[2], 14)}");
            }
            reader.Close();
            Console.ReadLine();
        }
    }
}
