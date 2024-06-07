namespace Proxy;

internal class Program
{
    static void Main(string[] args)
    {
        var client = new Client();

        Console.WriteLine("Client: Executing the client code with a real subject:");
        var realSubject = new RealSubject();
        client.ClientCode(realSubject);

        Console.WriteLine("Client: Excuting the same client code with a proxy:");
        var proxy = new Proxy(realSubject);
        client.ClientCode(proxy);
    }
}
