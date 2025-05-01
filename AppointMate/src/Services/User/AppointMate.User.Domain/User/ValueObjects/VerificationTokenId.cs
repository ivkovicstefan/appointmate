using AppointMate.User.Domain.Abstractions;

namespace AppointMate.User.Domain.User.ValueObjects
{
    public sealed class VerificationTokenId : ValueObject
    {
        public Guid Value { get; }

        private VerificationTokenId(Guid value) => Value = value;

        public static VerificationTokenId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);

            if (value == Guid.Empty)
            {
                throw new ArgumentException("VerificationTokenId can not be null", nameof(value));
            }

            return new VerificationTokenId(value);
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
