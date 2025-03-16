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

        var messeger = new Messeger();
        var message = await messeger.GetMessageAsync();
        Console.WriteLine(message);
    }
}

// js question:
// 4 console logs
// first and last is just simple console.log
// second is with a setTimeout
// third is with a promise
// what will be the order of the console logs?
// 1, 4, 2, 3
// code snippet:
// console.log(1);
// setTimeout(() => console.log(2), 0);
// console.log(3);
// new Promise((resolve, reject) => {
//     console.log(4);
//     resolve();
// });

// question on async await C#
// what is the output of the following code snippet?
// var sumAsync = new AsyncDemo();
// var result = await sumAsync.GetSumAsync(1, 2);
// Console.WriteLine(result);
// code snippet:
// public class AsyncDemo
// {
//     public async Task<int> GetSumAsync(int a, int b)
//     {
//         await Task.Delay(1000);
//         return a + b;        
//     }
// }
