using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public interface IDatabase
    {
        Task<int?> RequestAsync(int parameter);
    }
}
