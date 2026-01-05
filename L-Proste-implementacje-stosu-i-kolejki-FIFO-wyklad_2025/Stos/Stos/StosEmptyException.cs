namespace StosLib
{
    public class StosEmptyException : Exception
    {
        public StosEmptyException() : base("Stos jest pusty") 
        {
        }
    }
}
