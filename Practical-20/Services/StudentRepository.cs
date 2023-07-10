using Practical_20.Data;
using Practical_20.Interface;
using Practical_20.Models;

namespace Practical_20.Services
{
    public class StudentRepository : IStudentRepo
    {
        private readonly AddDbContext _context;

        public StudentRepository(AddDbContext context) 
        {
            _context = context;
        }
        public void Delete(Student student)
        {
            _context.Students.Remove(student);
        }

        public IList<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            return student;
        }

        public void Insert(Student student)
        {
            _context.Students.Add(student);
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
        }
    }
}
