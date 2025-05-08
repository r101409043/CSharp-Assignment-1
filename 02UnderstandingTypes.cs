public class 02UnderstandingTypes
{
    public static void One()
    {
        Console.WriteLine($"sbyte size:{sizeof(sbyte)} min:{sbyte.MinValue} max:{sbyte.MaxValue}");
        Console.WriteLine($"byte size:{sizeof(byte)} min:{byte.MinValue} max:{byte.MaxValue}");
        Console.WriteLine($"short size:{sizeof(short)} min:{short.MinValue} max:{short.MaxValue}");
        Console.WriteLine($"ushort size:{sizeof(ushort)} min:{ushort.MinValue} max:{ushort.MaxValue}");
        Console.WriteLine($"int size:{sizeof(int)} min:{int.MinValue} max:{int.MaxValue}");
        Console.WriteLine($"uint size:{sizeof(uint)} min:{uint.MinValue} max:{uint.MaxValue}");
        Console.WriteLine($"long size:{sizeof(long)} min:{long.MinValue} max:{long.MaxValue}");
        Console.WriteLine($"ulong size:{sizeof(ulong)} min:{ulong.MinValue} max:{ulong.MaxValue}");
        Console.WriteLine($"float size:{sizeof(float)} min:{float.MinValue} max:{float.MaxValue}");
        Console.WriteLine($"double size:{sizeof(double)} min:{double.MinValue} max:{double.MaxValue}");
        Console.WriteLine($"decimal size:16 min:{decimal.MinValue} max:{decimal.MaxValue}");
    }

    public static void Two()
    {
        Console.Write("Input: ");
        ulong centuries = ulong.Parse(Console.ReadLine()!);
        ulong years = centuries * 100;
        ulong days = years * 365;
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong milliseconds = seconds * 1000;
        ulong microseconds = milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;

        Console.WriteLine(
            $"Input:{centuries} {centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} " +
            $"minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} " +
            $"microseconds = {nanoseconds} nanoseconds");
    }
}
