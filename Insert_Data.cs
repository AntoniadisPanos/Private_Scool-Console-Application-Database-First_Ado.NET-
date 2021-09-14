using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Scool_Assignment_PartB_
{
    class Insert_Data
    {
        public static int InsertStudents()
        {
            int newId = 0;
            Console.Write("Student FirstName: \n");
            string studentFirstName = Console.ReadLine();
            studentFirstName = SQLHelpers.StringValidation(studentFirstName);
            studentFirstName = studentFirstName.First().ToString().ToUpper() + studentFirstName.Substring(1);
            Console.Clear();

            Console.Write("Student LastName: \n");
            string studentLastName = Console.ReadLine();
            studentLastName = SQLHelpers.StringValidation(studentLastName);
            studentLastName = studentLastName.First().ToString().ToUpper() + studentLastName.Substring(1);
            Console.Clear();

            Console.Write("Student DateOfBirth: yyyy-mm-dd\n");
            string studentDateOfBirth = Console.ReadLine();
            Console.Clear();

            Console.Write("Student TuitionFees: \n");
            string studentTuitionFees = Console.ReadLine();

            string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand insertString = new SqlCommand("INSERT INTO STUDENT(LastName, FirstName, DateOfBirth, TuitionFees) VALUES (@studentLastName, @studentFirstName, @studentDateOfBirth, @studentTuitionFees); SELECT CAST(scope_identity() AS int);", connection);
            SqlParameter studentLastNameParam = new SqlParameter("@studentLastName", studentLastName);
            SqlParameter studentFirstNameParam = new SqlParameter("@studentFirstName", studentFirstName);
            SqlParameter studentDateOfBirthParam = new SqlParameter("@studentDateOfBirth", studentDateOfBirth);
            SqlParameter studentTuitionFeesParam = new SqlParameter("@studentTuitionFees", studentTuitionFees);


            insertString.Parameters.Add(studentLastNameParam);
            insertString.Parameters.Add(studentFirstNameParam);
            insertString.Parameters.Add(studentDateOfBirthParam);
            insertString.Parameters.Add(studentTuitionFeesParam);
            try
            {
                connection.Open();
                newId = (int)insertString.ExecuteScalar();  //Casting to Int
                Console.WriteLine("Saved");
            }
            catch (Exception e)
            {
                Console.WriteLine("Not Saved");
                Console.WriteLine(e.Message);
            }
            finally
            {
               connection.Close();
            }

            return newId;



        }
        public static int InsertTrainers()
        {
            int newId = 0;
            Console.Write("Trainer FirstName: \n");
            string trainerFirstName = Console.ReadLine();
            trainerFirstName = SQLHelpers.StringValidation(trainerFirstName);
            trainerFirstName = trainerFirstName.First().ToString().ToUpper() + trainerFirstName.Substring(1);
            Console.Clear();

            Console.Write("Trainer LastName: \n");
            string trainerLastName = Console.ReadLine();
            trainerLastName = SQLHelpers.StringValidation(trainerLastName);
            trainerLastName = trainerLastName.First().ToString().ToUpper() + trainerLastName.Substring(1);
            Console.Clear();

            Console.Write("Trainer Subject: \n");
            string trainerSubject = Console.ReadLine();
            Console.Clear();

 
            string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand insertString = new SqlCommand("INSERT INTO TRAINER(LastName, FirstName, Subject) VALUES (@trainerLastName, @trainerFirstName, @trainerSubject);  SELECT CAST(scope_identity() AS int);", connection);
            SqlParameter trainerLastNameParam = new SqlParameter("@trainerLastName", trainerLastName);
            SqlParameter trainerFirstNameParam = new SqlParameter("@trainerFirstName", trainerFirstName);
            SqlParameter trainerDateOfBirthParam = new SqlParameter("@trainerSubject", trainerSubject);


            insertString.Parameters.Add(trainerLastNameParam);
            insertString.Parameters.Add(trainerFirstNameParam);
            insertString.Parameters.Add(trainerDateOfBirthParam);
            try
            {
                connection.Open();
                newId = (int)insertString.ExecuteScalar();  //Casting to Int
                Console.WriteLine("Saved");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Saved");
            }
            finally
            {
                connection.Close();
            }
            return newId;
        }
        public static int InsertAssignments()
        {
            int  newassignmentId = 0;

            Console.Write("Assignment Title: \n");
            string assignmentTitle = Console.ReadLine();
            assignmentTitle = SQLHelpers.StringValidation(assignmentTitle);
            assignmentTitle = assignmentTitle.First().ToString().ToUpper() + assignmentTitle.Substring(1);
            Console.Clear();

            Console.Write("Assignment Description: \n");
            string assignmentDescription = Console.ReadLine();
            assignmentDescription = SQLHelpers.StringValidation(assignmentDescription);
            assignmentDescription = assignmentDescription.First().ToString().ToUpper() + assignmentDescription.Substring(1);
            Console.Clear();

            Console.Write("Assignment Sub Date Time: yyyy-mm-dd hh:mm\n");
            string assignmentSubDateTime = Console.ReadLine();
            Console.Clear();

            Console.Write("Assignment Oral Mark: Max 100\n");
            string assignmentOralMark = Console.ReadLine();
            Console.Clear();
            Console.Write("Assignment Total Mark: Max 100\n");
            string assignmentTotalMark = Console.ReadLine();

            string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand insertString = new SqlCommand("INSERT INTO ASSIGNMENT(Title, Description, SubDateTime, OralMark, TotalMark) VALUES (@title, @description, @subDateTime, @oralMark, @totalMark); SELECT CAST(scope_identity() AS int);", connection);
            SqlParameter titleParam = new SqlParameter("@title", assignmentTitle);
            SqlParameter descriptionParam = new SqlParameter("@description", assignmentDescription);
            SqlParameter subDateTimeParam = new SqlParameter("@subDateTime", assignmentSubDateTime);
            SqlParameter oralMarkParam = new SqlParameter("@oralMark", assignmentOralMark);
            SqlParameter totalMarkParam = new SqlParameter("@totalMark", assignmentTotalMark);


            insertString.Parameters.Add(titleParam);
            insertString.Parameters.Add(descriptionParam);
            insertString.Parameters.Add(subDateTimeParam);            
            insertString.Parameters.Add(oralMarkParam);
            insertString.Parameters.Add(totalMarkParam);

            try
            {
                connection.Open();
                newassignmentId = (int)insertString.ExecuteScalar(); Console.WriteLine("Saved");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Saved");
            }
            finally
            {
                connection.Close();
            }
            return newassignmentId;
        }
        public static int InsertCourses()
        {
            int newCourseId = 0;
            Console.Write("Course Title: ");
            string courseTitle = Console.ReadLine();           
            Console.Clear();

            Console.Write("Course Stream: ");
            string courseStream = Console.ReadLine();
            courseStream = SQLHelpers.StringValidation(courseStream);
            courseStream = courseStream.First().ToString().ToUpper() + courseStream.Substring(1);
            Console.Clear();

            Console.Write("Course Type: ");
            string courseType = Console.ReadLine();
            Console.Clear();

            Console.Write("Course Start Date(yyyy-mm-dd): ");
            string courseStartDate = Console.ReadLine();
            Console.Clear();

            Console.Write("Course End Date(yyyy-mm-dd): ");
            string courseEndDate = Console.ReadLine();

            string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand insertString = new SqlCommand("INSERT INTO COURSE(Title, Stream, Type, StartDate, EndDate) VALUES (@title, @stream, @type, @startDate, @endDate);SELECT CAST(scope_identity() AS int);", connection);
            
            SqlParameter titleParam = new SqlParameter("@title", courseTitle);
            SqlParameter streamParam = new SqlParameter("@stream", courseStream);
            SqlParameter typeParam = new SqlParameter("@type", courseType);
            SqlParameter startDateParam = new SqlParameter("@startDate", courseStartDate);
            SqlParameter endDateParam = new SqlParameter("@endDate", courseEndDate);


            insertString.Parameters.Add(titleParam);
            insertString.Parameters.Add(streamParam);
            insertString.Parameters.Add(typeParam);
            insertString.Parameters.Add(startDateParam);
            insertString.Parameters.Add(endDateParam);

            try
            {
                connection.Open();
                newCourseId = (int)insertString.ExecuteScalar();
                Console.WriteLine("Saved");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Saved");
            }
            finally
            {
                connection.Close();
            }

            return newCourseId;
        }
        public static void InsertStudentsPerCourse()
        {
            var studentId = InsertStudents();
            var courseId = InsertCourses();
            
            string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand insertString = new SqlCommand("INSERT INTO StudentsPerCourse (CourseID, StudentID) values (@courseId, @studentId);", connection);
            SqlParameter courseIdParam = new SqlParameter("@courseId", courseId);
            SqlParameter stFirstNameParam = new SqlParameter("@studentId", studentId);
            
            insertString.Parameters.Add(courseIdParam);
            insertString.Parameters.Add(stFirstNameParam);
        

            try
            {
                connection.Open();
                insertString.ExecuteNonQuery();
                Console.WriteLine("Saved");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Saved");
            }
            finally
            {
                connection.Close();
            }
        }
        public static void InsertTrainersPerCourse()
        {
            var trainerId = InsertTrainers();
            var courseId = InsertCourses();

            string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand insertString = new SqlCommand("INSERT INTO TrainersPerCourse (CourseID, TrainerID) values (@courseId, @trainerId);", connection);
            SqlParameter courseIdParam = new SqlParameter("@courseId", courseId);
            SqlParameter trFirstNameParam = new SqlParameter("@trainerId", trainerId);

            insertString.Parameters.Add(courseIdParam);
            insertString.Parameters.Add(trFirstNameParam);


            try
            {
                connection.Open();
                insertString.ExecuteNonQuery();
                Console.WriteLine("Saved");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Saved");
            }
            finally
            {
                connection.Close();
            }
        }
    
        public static void InsertAssignmentsPerStudentPerCourse()
        {
            var assignmentId = InsertAssignments();
            var studentId = InsertStudents();
            var courseId = InsertCourses();

            string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand insertString = new SqlCommand("INSERT INTO AssignmentsPerStudentPerCourse (CourseID, StudentID, AssignmentID) values (@courseId, @studentId, @assignmentId);", connection);
            SqlParameter courseIdParam = new SqlParameter("@courseId", courseId);
            SqlParameter studentIdParam = new SqlParameter("@studentId", studentId);
            SqlParameter assignmentIdParam = new SqlParameter("@assignmentId", assignmentId);

            insertString.Parameters.Add(courseIdParam);
            insertString.Parameters.Add(studentIdParam);
            insertString.Parameters.Add(assignmentIdParam);


            try
            {
                connection.Open();
                insertString.ExecuteNonQuery();
                Console.WriteLine("Saved");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Saved");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
