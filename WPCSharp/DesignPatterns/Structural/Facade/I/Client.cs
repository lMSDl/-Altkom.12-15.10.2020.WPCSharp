using Newtonsoft.Json;

namespace DesignPatterns.Structural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var item = new Person { Name = "Ewa Ewowska", Age = 32 };

            JsonConvertFacade.Serialize(item);
        }
    }
}
