using Microsoft.Extensions.Logging;

namespace ClassLibrary;

public interface ICalculationService
{
    int AddTwoPositiveNumbers(int a, int b);
}

public class CalculationService(ILogger<CalculationService> logger) : ICalculationService
{
    public int AddTwoPositiveNumbers(int a, int b)
    {
        logger.LogInformation("adding");
        var dd = new List<MyClass> { new() { Id = 1, Name = "sdf" }, new() { Id = 112, Name = "sdf" } };
        logger.LogInformation("{@ids}",dd.Select(x=>x.Id));
        if (a <= 0 || b <= 0)
        {
            logger.LogError("Arguments should be both positive.");
            return 0;
        }
        logger.LogInformation("Adding {a} and {b}", a, b);
        return a + b;
    }
}

public class MyClass
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}