-------Students Per Course List------
Select STUDENT.ID,
STUDENT.LASTNAME,
STUDENT.FIRSTNAME,
COURSE.ID,
COURSE.TITLE,
COURSE.STREAM

FROM StudentsPerCourse
JOIN COURSE
ON COURSE.ID=StudentsPerCourse.CourseID 
JOIN STUDENT
ON STUDENT.ID=StudentsPerCourse.STUDENTID
ORDER BY LastName;