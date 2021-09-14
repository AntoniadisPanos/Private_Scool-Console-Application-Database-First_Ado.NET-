--------Trainers Per Course--------
SELECT 
Trainer.ID,
Trainer.LastName,
Trainer.FirstName,
Trainer.[Subject],
Course.ID,
Course.Title,
Course.[Type],
Course.Stream

FROM TrainersPerCourse
JOIN Course
ON Course.ID=TrainersPerCourse.CourseID
JOIN Trainer
ON Trainer.ID=TrainersPerCourse.TrainerID
order by Trainer.LastName;