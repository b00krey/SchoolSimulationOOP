Modeling a School
We should reinforce everything we've learned about classes before. And the best way to reinforce it is through a practical application.
Let's write a program for school administration.

About the school, we know:
	- Name (Name)
	- List of students (Students)

A student consists of:
	- First name (FirstName)
	- Last name (LastName)

Application Logic
Let's describe the program's logic:

1) When the program starts, a request is made to enter the school's name.
2) The user enters the school's name.
3) After entering the school's name, a school is created with the entered name and an empty list of students.
The user is shown the message: "School <school name> has been successfully created."

4) Repeat indefinitely:

	- The program displays: "Would you like to view the list of all students at <school name> school?"
	- Get the user's response.
	- If the user responds positively, then display the list of all students.
	- The program displays: "Would you like to add a new student?"
	- Get the user's response.
	- If the user responds positively, then:
	- The program displays: "Enter the student's first name"
	- Get the user's response.
	- The program displays: "Enter t	he student's last name"
	- Get the user's response.
	- The user is shown the message: "Student <student's first name> has been successfully added to <school name> school."