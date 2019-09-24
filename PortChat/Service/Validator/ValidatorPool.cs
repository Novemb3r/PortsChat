using static PortChat.Constants;

namespace PortChat.Service.Validator
{
    public class ValidatorPool
    {
        SimpleValidator simpleValidator = new SimpleValidator();
        LRCValidator lRCValidator = new LRCValidator();
        CRC16Validator cRC16Validator = new CRC16Validator();
        CRC32Validator cRC32Validator = new CRC32Validator();

        public IValidator get(ValidationMode validationMode)
        {
            switch (validationMode)
            {
                case ValidationMode.Simple:
                    return simpleValidator;
                case ValidationMode.LRC:
                    return lRCValidator;
                case ValidationMode.CRC16:
                    return cRC16Validator;
                case ValidationMode.CRC32:
                    return cRC32Validator;

                default:
                    throw new PoolException("No validation for providen rule found");
            }
        }
    }
}
