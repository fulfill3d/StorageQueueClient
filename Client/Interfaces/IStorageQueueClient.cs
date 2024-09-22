namespace Client.Interfaces
{
    public interface IStorageQueueClient
    {
        Task SendMessageAsync(string queueName, string message);
    }
}