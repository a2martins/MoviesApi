using System.Runtime.Serialization;

namespace MoviesApi.Core.CustomException
{
    [Serializable]
    internal class MovieNotDeletedException : Exception
    {
        public MovieNotDeletedException()
        {
        }

        public MovieNotDeletedException(string? message) : base(message)
        {
        }

        public MovieNotDeletedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MovieNotDeletedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}