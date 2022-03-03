namespace MaximumGenerics;
internal static class Maximum<T> where T : IComparable
{
    public static void Max(T var1, T var2, T var3)
    {
        T[] array = new T[] { var1, var2, var3 };
        Array.Sort(array);
        Console.WriteLine($"Max value is: {array[2]}");
    }
}