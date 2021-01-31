using System;

public class UserMailAddress
{
    public UserMailAddress(string value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));

        Value = value;
    }

    public string Value { get; }
}
