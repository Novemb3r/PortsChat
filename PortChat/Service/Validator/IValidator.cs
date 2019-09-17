namespace PortChat.Service.Validator
{
    public interface IValidator
    {
        bool check(string message);

        string removeCheckSum(string message);

        string calculate(string message);
    }
}
