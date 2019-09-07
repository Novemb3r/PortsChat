using System;

namespace PortChat.Service
{
    public class PoolException : Exception
    {
        public PoolException(string message)
            : base(message)
        { }
    }
}
