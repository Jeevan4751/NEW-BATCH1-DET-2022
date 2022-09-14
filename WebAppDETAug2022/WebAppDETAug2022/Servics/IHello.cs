namespace WebAppDETAug2022.Servics
{
    public interface IHello
    {
        string SayHello(string name);
    }

    public class Hello1 : IHello
    {
        public string SayHello(string name)
        {
            return $"Hello {name}, Welcome to ASP.Net Core";
        }
    }

    public class Hello2 : IHello
    {
        public string SayHello(string name)
        {
            return $"Hai ,Hello {name},Howz the day!!";
        }
    }
}
