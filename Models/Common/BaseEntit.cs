namespace lab12.Models.Common
{
    public class BaseEntity
    {
        public Guid Id { get; init; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
