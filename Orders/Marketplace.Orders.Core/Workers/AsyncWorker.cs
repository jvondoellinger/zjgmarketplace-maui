namespace Marketplace.Orders.Core.Workers;

public static class AsyncWorker
{
    public static void RunAsync(Func<Task> func)
    {
        RunAsync(func());
    }
    public static void RunAsync(Task task)
    {
        Task.Run(async () =>
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        });
    }
}
