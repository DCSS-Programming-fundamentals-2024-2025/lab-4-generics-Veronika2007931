using generic.Faculty;
using generics.Models;
using generics.Group;

class Program
{
    // Нєма Вероніка КП_41
    static void Main(string[] args)
    {

        Faculty fpm = new Faculty(1, "FPM");


        Group kp41 = new Group { Id = 41, Name = "КП-41" };
        Group kp42 = new Group { Id = 42, Name = "КП-42" };
        Group kp43 = new Group { Id = 43, Name = "КП-43" };


        fpm.AddGroup(kp41);
        fpm.AddGroup(kp42);
        fpm.AddGroup(kp43);


        Student s1 = new Student { Id = 1, Name = "Іван Петренко" };
        Student s2 = new Student { Id = 2, Name = "Марія Коваленко" };
        Student s3 = new Student { Id = 3, Name = "Олександр Бондар" };
        Student s4 = new Student { Id = 4, Name = "Наталія Шевченко" };
        Student s5 = new Student { Id = 5, Name = "Парфенюк Вікторія" };
        Student s6 = new Student { Id = 6, Name = "Кравченко Владислава" };
        Student s7 = new Student { Id = 7, Name = "Ференцюк Назар" };
        Student s8 = new Student { Id = 8, Name = "Нєма Вероніка" };
        Student s9 = new Student { Id = 9, Name = "Карина Дорогій" };
        Student s10 = new Student { Id = 10, Name = "Володимир Костюк" };


        fpm.AddStudentToGroup(41, s1);
        fpm.AddStudentToGroup(41, s2);
        fpm.AddStudentToGroup(42, s3);
        fpm.AddStudentToGroup(43, s4);
        fpm.AddStudentToGroup(41, s5);
        fpm.AddStudentToGroup(41, s6);
        fpm.AddStudentToGroup(42, s7);
        fpm.AddStudentToGroup(43, s8);
        fpm.AddStudentToGroup(43, s9);
        fpm.AddStudentToGroup(42, s10);


        foreach (var group in fpm.GetAllGroups())
        {
            Console.WriteLine($"\nГрупа: {group.Name}");

            var students = fpm.GetAllStudentsInGroup(group.Id);
            foreach (var student in students)
            {
                student.SayName();
            }
        }


    }
}