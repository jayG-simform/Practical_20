using Practical_20.Data;
using Practical_20.Interface;

namespace Practical_20.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AddDbContext _context;

        public UnitOfWork(AddDbContext context)
        {
           _context = context;
        }
        public IStudentRepo StudentRepo
        {
            get
            {
                return _unitOfWork.StudentRepo ?? new StudentRepository(_context);
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
