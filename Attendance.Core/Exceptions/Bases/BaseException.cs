using System;

namespace Attendance.Core.Exceptions.Bases
{
    public class BaseException : Exception
    {
        private ExceptionCode Code { get; }
        public override string Message { get; }

        protected BaseException(ExceptionCode code, string message)
        {
            Code = code;
            Message = message;
        }
    }

    public enum ExceptionCode
    {
        EntityNotFound
    }
}