using generics.Repositories;
using generics.Interfaces;
using generics.Models;

namespace generics.Group
{
    public class Group
    {
        public int Id;
        public string Name;

        IRepository<Student, int> _students = new InMemoryRepository<Student, int>();

        public void AddStudent(Student s)
        {
            _students.Add(s.Id, s);
        }

        public void RemoveStudent(int studentId)
        {
            _students.Remove(studentId);
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _students.GetAll();
        }
        public Student FindStudent(int studentId)
        {
            return _students.Get(studentId);
        }
    }


}