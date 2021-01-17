using System;

namespace ddd_value_object
{
    class UserId
    {
        public static void Main()
        {
            //
        }
        private readonly string value;

        public UserId(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            this.value = value;
        }
    }
}
