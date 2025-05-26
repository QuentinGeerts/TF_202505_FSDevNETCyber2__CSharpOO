using DemoInterfaces.Enums;

namespace DemoInterfaces.Interfaces;

public interface IMoyenMotorise : IMoyenLocomotion
{
    int PuissanceMoteur { get; set; }
    TypeCarburant TypeCarburant { get; set; }
}
