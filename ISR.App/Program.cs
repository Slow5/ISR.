using ISR.Core.Entites;
using ISR.Core.Managers;
using ISR.Core.Services;

namespace ISR.App;

public static class Program
{
    public static void Main(String[]args)
    {
        float dinero = 0;
        
        System.Console.Write("Ingresa dinero: ");
        Single.TryParse(System.Console.ReadLine(), out dinero);

        var salary = new Salary{money = dinero};
        var service = new IsrService();
        var managers = new IsrManager(service);

        Core.Entites.ISR isr = managers.Getisr(salary);
        
        //System.Console.WriteLine($"BMI {bmi.Index} Type {bmi.BmiType}");
        System.Console.WriteLine($"ISR: {isr.Index}");
    }
}

