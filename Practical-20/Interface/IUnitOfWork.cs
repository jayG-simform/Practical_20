namespace Practical_20.Interface
{
    public interface IUnitOfWork
    {
        IStudentRepo StudentRepo { get; }
        void Save();
    }
}
