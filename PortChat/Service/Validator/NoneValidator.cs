namespace PortChat.Service.Validator
{
    public class NoneValidator : IValidator
    {
        public bool check(string message)
        {
            return true;
        }
    }
}
