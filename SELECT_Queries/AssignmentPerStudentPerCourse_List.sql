--------Assignments Per Student Per Course-------
SELECT 
      Assignment.Title,
      Assignment.[Description],
      Assignment.[SubDateTime],
      Assignment.[OralMark],
      Assignment.[TotalMark],
	  

STUDENT.ID,
STUDENT.LASTNAME,
STUDENT.FIRSTNAME,

COURSE.ID,
COURSE.TITLE,
COURSE.STREAM

FROM AssignmentsPerStudentPerCourse
JOIN Course
ON Course.ID=AssignmentsPerStudentPerCourse.CourseID
JOIN Student
ON Student.ID=AssignmentsPerStudentPerCourse.StudentID
JOIN Assignment
ON Assignment.ID=AssignmentsPerStudentPerCourse.AssignmentID;