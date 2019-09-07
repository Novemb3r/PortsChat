using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service
{
    public class PoolException : Exception
    {
        public PoolException(string message)
            : base(message)
        { }
    }
}
