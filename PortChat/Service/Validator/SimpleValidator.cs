using System;
using System.Linq;
using System.Text;

namespace PortChat.Service.Validator
{
    public class SimpleValidator : IValidator
    {
        public Array SerialPortBufferTemp { get; private set; }

        public string calculate(string message)
        {
            byte res = 0;
            foreach (byte ch in Encoding.ASCII.GetBytes(message))
            {
                res ^= ch;
            }
            return Encoding.ASCII.GetString(new byte[1] { res });
        }

        public bool check(string message)
        {
            var externalCheckSum = this.GetCheckSum(message);

            var internalCheckSum = this.calculate(removeCheckSum(message));

            return externalCheckSum == internalCheckSum;
        }

        public string removeCheckSum(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            byte[] tmp = new byte[data.Length - 1];

            Array.Copy(data, tmp, data.Length - 1);

            return Encoding.ASCII.GetString(tmp);
        }

        public string GetCheckSum(string message)
        {
            return Encoding.ASCII.GetString(new byte[1] { Encoding.ASCII.GetBytes(message)[message.Length - 1] });
        }
    }
}
