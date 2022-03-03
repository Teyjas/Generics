namespace MaximumGenerics;

internal class Maximum<T> where T : IComparable
{
    private T[] array;
    public Maximum(T[] array)
    {
        this.array = array;
    }
    public void Max(T var1, T var2, T var3)
    {
        array[0] = var1; array[1] = var2; array[2] = var3;
        Array.Sort(array);
        Console.WriteLine($"Max value is: {array[2]}");
    }
}