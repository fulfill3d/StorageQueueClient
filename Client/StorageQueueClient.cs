using Azure.Storage.Queues;
using Client.Interfaces;
using Client.Options;
using Microsoft.Extensions.Options;

namespace Client
{
    public class StorageQueueClient(IOptions<StorageQueueClientOptions> opt): IStorageQueueClient
    {
        private readonly string connectionString = opt.Value.ConnectionString;
        
        public async Task SendMessageAsync(string queueName, string message)
        {
            var client = await GetQueueClientAsync(queueName);

            await client.SendMessageAsync(message);
        }
        
        private async Task<QueueClient> GetQueueClientAsync(string queueName)
        {
            var queueClient = new QueueClient(connectionString, queueName);
            await queueClient.CreateIfNotExistsAsync();

            return queueClient;
        }
    }
}