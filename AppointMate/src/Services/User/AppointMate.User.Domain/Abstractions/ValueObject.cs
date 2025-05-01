namespace AppointMate.User.Domain.Abstractions
{
    public abstract class ValueObject
    {
        private const int HashSeed = 1;
        private const int HashMultiplier = 23;
        protected abstract IEnumerable<object?> GetEqualityComponents();

        public override bool Equals(object? obj)
        {
            if (obj is not ValueObject other)
            {
                return false;
            }

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
            .Aggregate(HashSeed, (current, obj) =>
            {
                return current * HashMultiplier + (obj?.GetHashCode() ?? 0);
            });
        }
    }
}
