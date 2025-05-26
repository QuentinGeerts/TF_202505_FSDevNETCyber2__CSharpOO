namespace ExoSmoothieException.Exceptions;

public class SmoothieNonMixeException : Exception
{
    public SmoothieNonMixeException() 
        : base("Catastrophe ! Vous devez mixer les fruits avant de boire.")
    { }
}
