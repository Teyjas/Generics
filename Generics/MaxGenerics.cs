namespace MaximumGenerics;
internal class Maximum<T> where T : IComparable
{
    private T[] array;
    public Maximum(T[] array)
    {
        this.array = array;
    }
    public void Max(params T[] array)
    {
        this.array = array;
        Array.Sort(array);
        Console.WriteLine($"Max value is: {array[2]}");
    }
}