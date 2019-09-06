using static PortChat.Constants;


namespace PortChat.Service.Sender
{
    public class SenderPool
    {

        AsciiSender asciiSender = new AsciiSender();
        public ISender get(TransmissionMode mode)
        {
            if (mode == TransmissionMode.ASCII) {
                return asciiSender;
            }

            return asciiSender;
        }
    }
}
