---------Students who are assigned to more than course--------------------

Select StudentID, 
Student.LastName, 
Student.FirstName,
Count(*) as TotalCourses
from StudentsPerCourse

JOIN Student
ON STUDENT.ID=StudentsPerCourse.STUDENTID
group by StudentID, Student.LastName, Student.FirstName
Having count(*)>1
ORDER BY Student.LastName;