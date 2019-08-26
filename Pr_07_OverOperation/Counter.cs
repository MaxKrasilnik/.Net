using System;

public class Counter
{
    public int Seconds { get; set; }

    public static implicit operator Counter(int x)
    {
        return new Counter { Seconds = x };
    }

    public static explicit operator int(Counter counter)
        {
        return counter.Seconds;
        }

    public static explicit operator double(Counter counter)
    {
        return counter.Seconds;
    }

    public Counter()
	{
       
	}
}
