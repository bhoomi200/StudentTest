using StudentTest.Models;

namespace StudentTest.Services
{
    public class Studentservice : IStudentTest
    {
        private readonly StudentTestDbContext _dbContext;

        public Studentservice(StudentTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Student> GetStudents()
        {
            return _dbContext.Students.ToList();
        }
        public Student GetStudent(int id)
        {
            return _dbContext.Students.Where(x => x.StudentId == id).FirstOrDefault();
        }

        public Student PostStudent(Student student)
        {
            var result = _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Student PutStudent(Student student)
        {
            var result = _dbContext.Students.Update(student);
            _dbContext.SaveChanges();
            return result.Entity;
        }
        public bool DeleteStudent(int Id)
        {
            var filteredData = _dbContext.Students.Where(x => x.StudentId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}
