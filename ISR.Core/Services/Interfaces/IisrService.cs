using ISR.Core.Entites;
namespace ISR.Core.Services.Interfaces;

public interface IisrService
{
    Entites.ISR ProcessIsr(Salary salary);
}