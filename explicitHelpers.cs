using System;

internal static class explicitHelpers
{
    static void Main()
    {
        int k = 10;
        byte b = (byte)k; //convert int to byte
        short s = (short)k;
        long l = 40333;
        int i1 = (int)l; //Convert long to int
        double d = 23.45;
        int i2 = (int)d; // Convert double to int
        Console.WriteLine(i2);
        long l2 = (long)d; //Convert double to long
    }
}