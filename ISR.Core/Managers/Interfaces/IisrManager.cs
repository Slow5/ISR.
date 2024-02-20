using ISR.Core.Entites;

namespace ISR.Core.Managers.Interfaces;

public interface IisrManager
{
    Entites.ISR Getisr(Salary salary);
}