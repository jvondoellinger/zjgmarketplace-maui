namespace Marketplace.Users.Core.Worker;

public class AsyncWorker
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
