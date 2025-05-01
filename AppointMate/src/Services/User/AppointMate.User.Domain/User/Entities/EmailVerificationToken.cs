using AppointMate.User.Domain.Abstractions;
using AppointMate.User.Domain.User.ValueObjects;

namespace AppointMate.User.Domain.User.Entities
{
    public sealed class EmailVerificationToken : Entity<VerificationTokenId>
    {
        private const int TokenExpiresInMinutes = 60;

        private EmailVerificationToken(DateTime createdAt) => CreatedAt = createdAt;

        public static EmailVerificationToken Create(DateTime createdAt = default)
        {
            if (createdAt == default)
            {
                createdAt = DateTime.UtcNow;
            }

            return new EmailVerificationToken(createdAt);
        }

        public bool IsValid(VerificationTokenId id) => Id == id && !IsExpired();

        private bool IsExpired()
        {
            DateTime currentDateTime = DateTime.UtcNow;

            return currentDateTime > CreatedAt.Value.AddMinutes(TokenExpiresInMinutes);
        }
    }
}
