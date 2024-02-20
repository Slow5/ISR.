using ISR.Core.Entites;
using ISR.Core.Managers.Interfaces;
using ISR.Core.Services.Interfaces;

namespace ISR.Core.Services;

public class IsrService : IisrService
{
     public Entites.ISR ProcessIsr(Salary salary)
     {
          var isr = new Entites.ISR();
          float cobrar = 0;

          if (salary.money >= 0.01 && salary.money <= 7735.00)
          {
               cobrar = salary.money - 0.01f;
               cobrar = cobrar * (1.92f / 100);
               cobrar = cobrar + 0.0f;
               isr.Index = cobrar;
          }
          else if (salary.money >= 7735.01 && salary.money <= 65651.07)
          {
               cobrar = salary.money - 7735.01f;
               cobrar = cobrar * (6.40f / 100);
               cobrar = cobrar + 148.51f;
               isr.Index = cobrar;
          }
          else if (salary.money >= 65651.08 && salary.money <= 115375.90)
          {    cobrar = salary.money - 65651.08f;
               cobrar = cobrar * (10.88f / 100);
               cobrar = cobrar + 3855.14f;
               isr.Index = cobrar;
          }
          else if (salary.money >= 115375.91 && salary.money <= 134119.41)
          {    cobrar = salary.money - 115375.91f;
               cobrar = cobrar * (16.00f / 100);
               cobrar = cobrar + 9265.20f;
               isr.Index = cobrar;

          }
          else if (salary.money >= 134119.42 && salary.money <= 160577.65)
          {
               cobrar = salary.money - 134119.45f;
               cobrar = cobrar * (17.92f / 100);
               cobrar = cobrar + 12264.16f;
               isr.Index = cobrar;
          }else if (salary.money >= 160577.66 && salary.money <= 323862.00)
          {
               cobrar = salary.money - 160577.66f;
               cobrar = cobrar * (21.36f / 100);
               cobrar = cobrar + 17005.47f;
               isr.Index = cobrar;
          }else if (salary.money >= 323862.01 && salary.money <= 510451.00)
          {
               cobrar = salary.money - 323862.01f;
               cobrar = cobrar * (23.52f / 100);
               cobrar = cobrar + 51883.01f;
               isr.Index = cobrar;               
          }else if (salary.money >= 510451.01 && salary.money <= 974535.03)
          {
               cobrar = salary.money - 510451.01f;
               cobrar = cobrar * (30f / 100);
               cobrar = cobrar + 95768.74f;
               isr.Index = cobrar;
               
          }else if (salary.money >= 974535.04 && salary.money <= 1299380.04)
          {
               cobrar = salary.money - 974535.04f;
               cobrar = salary.money * (32f / 100);
               cobrar = cobrar + 234993.95f;
               isr.Index = cobrar;
          }else if (salary.money >= 1299380.05 && salary.money <= 3898140.12) {
               cobrar = salary.money - 115375.91f;
               cobrar = cobrar * (16.00f / 100);
               cobrar = cobrar + 9265.20f;
               isr.Index = cobrar;
          }
          else
          {
               cobrar = salary.money - 3898140.13f;
               cobrar = cobrar * (35f / 100);
               cobrar = cobrar + 1222522.76f;
               isr.Index = cobrar;
          }

          return isr;
     }
}