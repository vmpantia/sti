namespace STI.DAT.CustomExceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string? message) : base(message)
        {
        }
    }
}
