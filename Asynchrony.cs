public class AsyncDemo
{
    public async Task<int> GetSumAsync(int a, int b)
    {
        await Task.Delay(2000);
        return a + b;
    }
}

public class Messeger
{
    public async Task<string> GetMessageAsync()
    {
        await Task.Delay(4000);
        return "Hello World";
    }
}