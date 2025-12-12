namespace SchoolSimulationOOP
{
    public class Student {
        public string FirstName;
        public string LastName;
        public int Age;

        public Student(string firstName, string lastName) : this(firstName, lastName, 0)
        { }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
