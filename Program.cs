using SimpleWCFService.Implementations;

namespace SimpleWCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloService service = new HelloService();
            string result = service.SayHello("World");
            Console.WriteLine(result);  // Output: Hello, World!
        }
    }
}
