using System.Runtime.Serialization;

namespace LexiExtract.Exceptions
{
    [Serializable]
    public class LanguageNotFoundException : Exception
    {
        public LanguageNotFoundException()
        {
        }

        public LanguageNotFoundException(string? message) : base(message)
        {
        }

        public LanguageNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LanguageNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
