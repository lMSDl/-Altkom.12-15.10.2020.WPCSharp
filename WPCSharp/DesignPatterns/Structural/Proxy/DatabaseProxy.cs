using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    class DatabaseProxy : IDatabase
    {
        public const int NumberOfAvailableConnections = 5;
        private Database Database { get; set; }
        private SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(NumberOfAvailableConnections);

        public DatabaseProxy(Database database)
        {
            Database = database;
        }
        
        public DatabaseProxy()
        {
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if(Database == null)
            {
                Console.WriteLine("New database");
                Database = new Database();
            }

            await _semaphoreSlim.WaitAsync();
            var result = await Database.RequestAsync(parameter);
            _semaphoreSlim.Release();

            if(_semaphoreSlim.CurrentCount == NumberOfAvailableConnections)
            {
                Database = null;
                Console.WriteLine("Database null");
            }

            return result;
        }
    }
}
