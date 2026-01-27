using System;
using System.Reflection;

namespace MyApp
{
    public interface IGreeting
    {
        void SayHello(string name);
        void SayGoodbye(string name);
    }

    public class Greeting : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye, {name}!");
        }
    }

    public class LoggingProxy<T> : DispatchProxy
    {
        public T Decorated { get; set; }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Console.WriteLine($"[LOG] Method called: {targetMethod.Name}");
            return targetMethod.Invoke(Decorated, args);
        }
    }

    class Program
    {
        static void Main()
        {
            IGreeting greeting = DispatchProxy.Create<IGreeting, LoggingProxy<IGreeting>>();
            ((LoggingProxy<IGreeting>)greeting).Decorated = new Greeting();

            greeting.SayHello("Alice");
            greeting.SayGoodbye("Bob");
        }
    }
}
