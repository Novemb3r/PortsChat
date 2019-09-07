using static PortChat.Constants;

namespace PortChat.Service.Validator
{
    public class ValidatorPool
    {
        NoneValidator noneValidator = new NoneValidator();

        public IValidator get(ValidationMode validationMode)
        {
            switch (validationMode)
            {
                case ValidationMode.None:
                    return noneValidator;
                default:
                    throw new PoolException("No validation for providen rule found");
            }
        }
    }
}
