# Exercise 📒

## Create an Academy Management app

The app will have users that can log in and perform some actions.
The users can choose one of the 3 roles and log in:

* Admin
* Trainer
* Student 

After logging in there should be different options for different roles:

* Admins can add/remove Trainers, Students, and other Admins ( can't remove itself )
* Trainer can choose between seeing all students and all subjects
  * When choosing Students, all student names should appear
  * When chosen a name of student, it should print all the subjects
  * When choosing Subjects, all Subject names appear with how many students attend it next to it
* Students (have a current Subject, and Grades) are shown the name of the subject that they are listening to and a list of their grades for each passed subject

> Try and handle all scenarios with exception handling. Handle expected exceptions with special messages.