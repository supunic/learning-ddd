using System;

namespace ddd_value_object
{
    class User
    {
        public static void Main()
        {
            //
        }
        public UserId Id { get; set; }
        public UserName Name { get; set; }

        public User(UserId Id, UserName Name)
        {
            if (Id == null) throw new ArgumentNullException(nameof(Id));
            if (Name == null) throw new ArgumentNullException(nameof(Name));

            this.Id = Id;
            this.Name = Name;
        }
    }
}
