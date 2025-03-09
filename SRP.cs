public class Order
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string CustomerEmail { get; set; }
}

public interface IOrderValidator
{
    bool ValidateOrder(Order order);
}

public class OrderValidator : IOrderValidator
{
    public bool ValidateOrder(Order order)
    {
        return order.Amount > 0 && !string.IsNullOrEmpty(order.CustomerEmail);
    }
}

public interface IPricingCalculator
{
    decimal CalculatePrice(Order order);
}

public class PricingCalculator : IPricingCalculator
{
    public decimal CalculatePrice(Order order)
    {
        return order.Amount * 0.90M;
    }
}

public class PricingCalculator2 : IPricingCalculator
{
    public decimal CalculatePrice(Order order)
    {
        return order.Amount * 1.2M;
    }
}

public interface IEmaiService
{
    void SendEmail(Order order);
}

public class EmailService : IEmaiService
{
    public void SendEmail(Order order)
    {
        Console.WriteLine($"Email sent to {order.CustomerEmail}");
    }
}

public interface IOrderRepository
{
    void SaveOrder(Order order);
}

public class OrderRepository : IOrderRepository
{
    public void SaveOrder(Order order)
    {
        Console.WriteLine($"Order saved with Id: {order.Id} and Amount: {order.Amount}");
    }
}

public class OrderProcessor
{
    private readonly IOrderValidator _orderValidator;
    private readonly IPricingCalculator _pricingCalculator;
    private readonly IEmaiService _emailService;
    private readonly IOrderRepository _orderRepository;

    public OrderProcessor(IOrderValidator orderValidator, IPricingCalculator pricingCalculator, IEmaiService emailService, IOrderRepository orderRepository)
    {
        _orderValidator = orderValidator;
        _pricingCalculator = pricingCalculator;
        _emailService = emailService;
        _orderRepository = orderRepository;
    }

    public void Process(Order order)
    {
        if (!_orderValidator.ValidateOrder(order))
        {
            Console.WriteLine("Order is not valid");
            return;
        }

        order.Amount = _pricingCalculator.CalculatePrice(order);
        _orderRepository.SaveOrder(order);
        _emailService.SendEmail(order);
    }
}