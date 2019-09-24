using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Validator
{
    public class CRC16Validator : IValidator
    {
        public string calculate(string message)
        {

            byte[] data = Encoding.ASCII.GetBytes(message);
            ushort[] table = new ushort[256];
            const ushort polynomial = 0xA001;

            ushort value;
            ushort temp;
            for (ushort i = 0; i < table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }

            ushort crc = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                byte index = (byte)(crc ^ data[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
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
            byte[] tmp = new byte[data.Length - 5];

            Array.Copy(data, tmp, data.Length - 5);

            return Encoding.ASCII.GetString(tmp);
        }

        public string GetCheckSum(string message)
        {
            byte[] tmp = new byte[5];
            Array.Copy(Encoding.ASCII.GetBytes(message), message.Length - 5, tmp, 0, 5);

            return Encoding.ASCII.GetString(tmp);

            //byte[] bytes = Encoding.ASCII.GetBytes(message);
            //  return Encoding.ASCII.GetString(new byte[5] { Encoding.ASCII.GetBytes(message)[message.Length - 2], Encoding.ASCII.GetBytes(message)[message.Length - 1] });
        }
    }
}
