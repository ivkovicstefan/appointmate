using AppointMate.User.Domain.Abstractions;

namespace AppointMate.User.Domain.User.ValueObjects
{
    public sealed class FullName : ValueObject
    {
        public string FirstName { get; } = default!;
        public string LastName { get; } = default!;

        private FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public static FullName Of(string firstName, string lastName)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);

            return new FullName(firstName, lastName);
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
