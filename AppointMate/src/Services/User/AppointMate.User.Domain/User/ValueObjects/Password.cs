using AppointMate.User.Domain.Abstractions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace AppointMate.User.Domain.User.ValueObjects
{
    public sealed class Password : ValueObject
    {
        private const string PasswordValidationPattern = @"^(?=(.*[a-z]))(?=(.*[A-Z]))(?=(.*\d))(?=(.*[@$!%*?&]))[A-Za-z\d@$!%*?&]{12,}$";
        public string HashedPassword { get; } = default!;

        private Password(string hashedPassword)
        {
            HashedPassword = hashedPassword;
        }

        public static Password Of(string plainPassword)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(plainPassword);

            if (!Regex.IsMatch(plainPassword, PasswordValidationPattern))
            {
                throw new ArgumentException("Password does not meet the required strength requirements.",
                    nameof(plainPassword));
            }

            return new Password(HashPassword(plainPassword));
        }

        private static string HashPassword(string plainPassword)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
                return Convert.ToBase64String(bytes);
            }
        }

        public bool IsPasswordValid(string plainPassword) => HashedPassword == HashPassword(plainPassword);

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return HashedPassword;
        }

        public override string ToString() => "*******";
    }
}
