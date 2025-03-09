using System;

public class Program
{
    public static void Main()
    {
        var order = new Order
        {
            Id = 1,
            Amount = 100,
            CustomerEmail = "xahin@gmail.com"
        };

        var orderValidator = new OrderValidator();
        var pricingCalculator = new PricingCalculator();
        var emailService = new EmailService();
        var orderRepository = new OrderRepository();

        var orderProcessor = new OrderProcessor(orderValidator, pricingCalculator, emailService, orderRepository);
        orderProcessor.Process(order);

        var pricingCalculator2 = new PricingCalculator2();
        var orderProcessor2 = new OrderProcessor(orderValidator, pricingCalculator2, emailService, orderRepository);
        orderProcessor2.Process(order);
    }
}