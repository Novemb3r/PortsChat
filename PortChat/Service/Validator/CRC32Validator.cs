using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Validator
{
    public class CRC32Validator : IValidator
    {
        public string calculate(string message)
        {

            byte[] data = Encoding.ASCII.GetBytes(message);
            uint[] table = new uint[256];
            const uint polynomial = 0xEDB88320;

            uint value;
            uint temp;
            for (uint i = 0; i < table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (uint)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }

            uint crc = 0xFFFFFFFF;
            for (int i = 0; i < data.Length; ++i)
            {
                crc = (uint)((crc >> 8) ^ table[(crc ^ data[i]) & 0xFF]);
            }
            crc ^= 0xFFFFFFFF;
            return crc.ToString();
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
            byte[] tmp = new byte[data.Length - 10];

            Array.Copy(data, tmp, data.Length - 10);

            return Encoding.ASCII.GetString(tmp);
        }

        public string GetCheckSum(string message)
        {
            byte[] tmp = new byte[10];
            Array.Copy(Encoding.ASCII.GetBytes(message), message.Length - 10, tmp, 0, 10);

            return Encoding.ASCII.GetString(tmp);

            //byte[] bytes = Encoding.ASCII.GetBytes(message);
            //  return Encoding.ASCII.GetString(new byte[5] { Encoding.ASCII.GetBytes(message)[message.Length - 2], Encoding.ASCII.GetBytes(message)[message.Length - 1] });
        }
    }
}
