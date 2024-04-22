using System;

public interface IBits<T>
{
    string ToBits(T value);
}

public class BitsConverter : IBits<long>, IBits<int>, IBits<byte>
{
    public string ToBits(long value)
    {
        return Convert.ToString(value, 2);
    }

    public string ToBits(int value)
    {
        return Convert.ToString(value, 2);
    }

    public string ToBits(byte value)
    {
        return Convert.ToString(value, 2);
    }
}

public class Program
{
    public static void Main()
    {
        BitsConverter converter = new BitsConverter();

        long longValue = 123456789;
        int intValue = 987654321;
        byte byteValue = 255;

        string longBits = converter.ToBits(longValue);
        string intBits = converter.ToBits(intValue);
        string byteBits = converter.ToBits(byteValue);

        Console.WriteLine($"Long value in bits: {longBits}");
        Console.WriteLine($"Int value in bits: {intBits}");
        Console.WriteLine($"Byte value in bits: {byteBits}");
    }
}