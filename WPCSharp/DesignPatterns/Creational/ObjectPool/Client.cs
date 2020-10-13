using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            var objectPool = new ObjectPool<Item>(1000, () => new Item());
            var random = new Random();
            while (true)
            {
                var item = objectPool.Acquire();
                if (item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; objectPool.Release(item); });
            }
        }
    }
}
