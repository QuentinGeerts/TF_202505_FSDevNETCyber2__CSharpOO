namespace ExoSmoothieException.Exceptions;

public class MixeurVideException : Exception
{
    public MixeurVideException() 
        : base("Impossible de mixer! Aucun fruit dans la machine.")
    {
        
    }
}
