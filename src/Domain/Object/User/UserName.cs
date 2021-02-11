﻿using System;

public class UserName
{
    public UserName(string value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
        if (value.Length < 3) throw new ArgumentException("ユーザー名は3文字以上です。", nameof(value));
        if (value.Length > 20) throw new ArgumentException("ユーザー名は20文字以下です。", nameof(value));

        Value = value;
    }

    public string Value { get; }
}
