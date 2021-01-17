using System;

namespace ddd_change_value
{
    class FullName
    {
        public static void Main()
        {
            //
        }
        public FullName(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public bool boolEquals(FullName other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(FirstName, other.FirstName) &&
                string.Equals(LastName, other.LastName) &&
                string.Equals(MiddleName, other.MiddleName);

        }
        public bool overrideboolEquals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FullName) obj);
        }
        
        //C#ではEqualsをoverrideする際にGetHashCodeをoverrideするルールがある
        public int overrideintGetHashCode() {
            unchecked
            {
                return ((FirstName != null ? FirstName.GetHashCode() : 0) * 397)
                    ^ (LastName != null ? LastName.GetHashCode() : 0);
            }
        }
    }
}
