---------------Assignment Per Course------------------
SELECT 
Assignment.ID,
Assignment.Title,
Assignment.[Description],
Assignment.SubDateTime,
Assignment.OralMark,
Assignment.TotalMark,
Course.ID,
Course.Title,
Course.Stream,
Course.[Type],
Course.StartDate,
Course.EndDate


FROM AssignentsPerCourse
JOIN Course
ON Course.ID=AssignentsPerCourse.CourseID
JOIN Assignment
ON Assignment.ID=AssignentsPerCourse.AssignmentID
ORDER BY SubDateTime;
