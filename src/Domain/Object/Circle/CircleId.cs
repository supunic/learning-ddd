using System;

public class CircleId
{
    public CircleId(string value)
    {
        if (value == null) throw new ArgumentException(nameof(value));

        Value = value;
    }

    public string Value { get; }
}
