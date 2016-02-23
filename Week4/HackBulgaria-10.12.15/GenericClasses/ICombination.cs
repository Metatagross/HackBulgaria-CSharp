namespace GenericClasses
{
    public interface ICombination<T, U>
    {
        T A1 { get; }
        T A2 { get; }
        T A3 { get; }
        U B1 { get; }
        U B2 { get; }
        U B3 { get; }

        bool Equals ( object obj );
        int GetHashCode ( );
    }
}