using AppointMate.User.Domain.Abstractions;
using System.Text.RegularExpressions;

namespace AppointMate.User.Domain.User.ValueObjects
{
    public sealed class Email : ValueObject
    {
        private const string EmailAddressValidationPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public string EmailAddress { get; } = default!;

        private Email(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public static Email Of(string emailAddress)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(emailAddress);

            if (!Regex.IsMatch(emailAddress, EmailAddressValidationPattern))
            {
                throw new ArgumentException("Invalid Email Format.", nameof(emailAddress));
            }

            return new Email(emailAddress);
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return EmailAddress.ToLowerInvariant();
        }

        public override string ToString() => EmailAddress;
    }
}
