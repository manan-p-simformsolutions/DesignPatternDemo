namespace CircuitBreakerPatternDemo.Repository
{
    public interface IMessageRepository
    {
        Task<string> GetHelloMessage();
        Task<string> GetGoodbyeMessage();
    }
}
