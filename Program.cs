using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        // var order = new Order
        // {
        //     Id = 1,
        //     Amount = 100,
        //     CustomerEmail = "xahin@gmail.com"
        // };

        // var orderValidator = new OrderValidator();
        // var pricingCalculator = new PricingCalculator();
        // var emailService = new EmailService();
        // var orderRepository = new OrderRepository();

        // var orderProcessor = new OrderProcessor(orderValidator, pricingCalculator, emailService, orderRepository);
        // orderProcessor.Process(order);

        // var pricingCalculator2 = new PricingCalculator2();
        // var orderProcessor2 = new OrderProcessor(orderValidator, pricingCalculator2, emailService, orderRepository);
        // orderProcessor2.Process(order);

        var sumAsync = new AsyncDemo();
        var result = await sumAsync.GetSumAsync(1, 2);
        Console.WriteLine(result);
    }
}