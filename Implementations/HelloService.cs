using SimpleWCFService.Interfaces;

namespace SimpleWCFService.Implementations
{
    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
