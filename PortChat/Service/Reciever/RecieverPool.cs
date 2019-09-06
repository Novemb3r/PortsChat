using static PortChat.Constants;

namespace PortChat.Service.Reciever
{
    public class RecieverPool
    {

        AsciiReciever asciiReciever = new AsciiReciever();
        public IReciever get(TransmissionMode mode)
        {
            if (mode == TransmissionMode.ASCII)
            {
                return asciiReciever;
            }

            return asciiReciever;
        }
    }
}
