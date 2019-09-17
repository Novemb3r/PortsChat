using static PortChat.Constants;

namespace PortChat.Service.Validator
{
    public class ValidatorPool
    {
        SimpleValidator simpleValidator = new SimpleValidator();

        public IValidator get(ValidationMode validationMode)
        {
            switch (validationMode)
            {
                case ValidationMode.Simple:
                    return simpleValidator;
                default:
                    throw new PoolException("No validation for providen rule found");
            }
        }
    }
}
