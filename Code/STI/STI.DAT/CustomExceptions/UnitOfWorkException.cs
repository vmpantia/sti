namespace STI.DAT.CustomExceptions
{
    public class UnitOfWorkException : Exception
    {
        public UnitOfWorkException(string? message) : base(message)
        {
        }
    }
}
