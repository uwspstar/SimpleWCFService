using System.ServiceModel;

namespace SimpleWCFService.Interfaces
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string SayHello(string name);
    }
}
