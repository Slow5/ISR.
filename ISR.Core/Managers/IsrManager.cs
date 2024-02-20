using ISR.Core.Entites;
using ISR.Core.Managers.Interfaces;
using ISR.Core.Services.Interfaces;

namespace ISR.Core.Managers;

public class IsrManager : IisrManager
{
    private readonly IisrService _service;

    public IsrManager(IisrService service)
    {
        _service = service;
    }

    public Entites.ISR Getisr(Salary salary)
    {
        return _service.ProcessIsr(salary); 
    }
}