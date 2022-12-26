using StudentTest.Models;

namespace StudentTest.Services
{
    public interface IStudentTest
    {
        public List<Student>GetStudents();
        public Student GetStudent(int id);
        public Student PostStudent(Student student);
        public Student PutStudent(Student student);
        public bool DeleteStudent(int id);
    }
}
