namespace Attendance.Core.Repositories.Bases
{
    public interface IOperationRepository<T>
    { 
        T Create(T entity);
        T Update(object id, T entity);
        T Delete(object id);
    }
}