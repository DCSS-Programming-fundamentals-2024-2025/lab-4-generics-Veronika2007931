namespace generics.Models
{
    public class Person
    {
        public int Id;
        public string Name;
    }

    public class Student : Person
    {
        public void SubmitWork()
        {
            Console.WriteLine($"Work was submited by {Name}");
        }

        public void SayName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }

    public class Teacher : Person
    {
        public void GradeStudent()
        {
            Console.WriteLine($"Your mark");
        }


        public void ExpelStudent()
        {
            Console.WriteLine($"Example");
        }

        public void ShowPresentStudents()
        {
            Console.WriteLine($"Student");
        }
    }
}
