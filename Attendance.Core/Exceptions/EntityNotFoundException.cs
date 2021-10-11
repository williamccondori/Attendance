using Attendance.Core.Exceptions.Bases;

namespace Attendance.Core.Exceptions
{
    public class EntityNotFoundException<T> : BaseException
    {
        public EntityNotFoundException() : base(
            ExceptionCode.EntityNotFound, $"Entity {nameof(T)} not found")
        {
        }
    }
}