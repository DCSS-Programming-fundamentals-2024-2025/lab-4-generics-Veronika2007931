using generics.Repositories;
using generics.Interfaces;
using generics.Group;
using generics.Models;

namespace generic.Faculty
{
    public class Faculty
    {
        public int Id;
        public string Name;

        public Faculty(int id, string name)
        {
            Id = id;
            Name = name;
        }

        IRepository<Group, int> _groups = new InMemoryRepository<Group, int>();

        public void AddGroup(Group g)
        {
            _groups.Add(g.Id, g);
        }

        public void RemovGroupe(int groupId)
        {
            _groups.Remove(groupId);
        }

        public IEnumerable<Group> GetAllGroups()
        {
            return _groups.GetAll();
        }
        public Group FindStudent(int groupId)
        {
            return _groups.Get(groupId);
        }

        public Group GetGroup(int id)
        {
            return _groups.Get(id);
        }

        public void AddStudentToGroup(int groupId, Student s)
        {
            var group = GetGroup(groupId);
            if (group != null)
            {
                group.AddStudent(s);
            }
            else
            {
                Console.WriteLine($"Групу з ID {groupId} не знайдено.");
            }
        }


        public void RemoveStudentFromGroup(int groupId, int studentId)
        {
            var group = GetGroup(groupId);
            if (group != null)
            {
                group.RemoveStudent(studentId);
            }
            else
            {
                Console.WriteLine($"Групу з ID {groupId} не знайдено.");
            }
        }


        public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
        {
            var group = GetGroup(groupId);
            if (group != null)
            {
                return group.GetAllStudents();
            }
            else
            {
                return Enumerable.Empty<Student>();
            }
        }


        public Student FindStudentInGroup(int groupId, int studentId)
        {
            var group = GetGroup(groupId);
            if (group != null)
            {
                return group.FindStudent(studentId);
            }
            else
            {
                Console.WriteLine($"Такого студента немає"); ;
            }
            return null;
        }
    }
}