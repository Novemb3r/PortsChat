using static PortChat.Constants;

namespace PortChat.Service.Reciever
{
    public class RecieverPool
    {

        AsciiReciever asciiReciever = new AsciiReciever();
        HexReciever hexReciever = new HexReciever();

        public IReciever get(TransmissionMode mode)
        {
            switch (mode)
            {
                case TransmissionMode.ASCII:
                    return asciiReciever;
                case TransmissionMode.HEX:
                    return hexReciever;

                default:
                    throw new PoolException("No Reciever for providen mode found");
            }
        }
    }
}