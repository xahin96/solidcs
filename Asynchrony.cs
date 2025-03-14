public class AsyncDemo
{
    public async Task<int> GetSumAsync(int a, int b)
    {
        return a + b;
    }
}

public class Messeger
{
    public async Task<string> GetMessageAsync()
    {
        await Task.Delay(2000);
        return "Hello World";
    }
}