﻿using System;

public class CircleName
{
    public CircleName(string value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
        if (value.Length < 3) throw new ArgumentException("サークル名は3文字以上です。", nameof(value));
        if (value.Length > 20) throw new ArgumentException("サークル名は20文字以下です。", nameof(value));

        Value = value;
    }

    public string Value { get; }

    public bool Equals(CircleName other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;

        return string.Equals(Value, other.Value);
    }

    public override int GetHashCode()
    {
        return (Value != null ? Value.GetHashCode() : 0);
    }
}
