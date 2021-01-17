using System;

namespace ddd_value_object
{
    class UserName
    {
        public static void Main()
        {
            //
        }
        private readonly string value;

        public UserName(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (value.Length < 3) throw new ArgumentNullException("ユーザー名は3文字以上です。", nameof(value));

            this.value = value;
        }
    }
}
