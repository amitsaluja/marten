using System;

namespace Marten.Services
{
    public class ConcurrentUpdateException : Exception
    {
        public ConcurrentUpdateException(Exception innerException) : base("Write collission detected while commiting the transaction.", innerException)
        {
        }
    }
}