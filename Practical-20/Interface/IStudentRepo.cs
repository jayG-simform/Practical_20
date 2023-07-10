using Practical_20.Models;

namespace Practical_20.Interface
{
    public interface IStudentRepo
    {
        IList<Student> GetAll();
        Student GetById (int id);
        void Insert(Student student);
        void Delete(Student student);
        void Update(Student student);
    }
}
