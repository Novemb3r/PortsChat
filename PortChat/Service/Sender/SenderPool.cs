using static PortChat.Constants;


namespace PortChat.Service.Sender
{
    public class SenderPool
    {

        AsciiSender asciiSender = new AsciiSender();
        HexSender hexSender = new HexSender();

        public ISender get(TransmissionMode mode)
        {
            switch (mode)
            {
                case TransmissionMode.ASCII:
                    return asciiSender;
                case TransmissionMode.HEX:
                    return hexSender;

                default:
                    throw new PoolException("No Sender for providen mode found");
            }
        }
    }
}
