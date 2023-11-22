namespace Kiwi.Polyphemus.Persistence.Abstractions;

using Kritikos.Configuration.Persistence.Contracts.Behavioral;

public abstract class Entity<T> : IEntity<T>
  where T : IComparable<T>, IEquatable<T>
{
  public T Id { get; set; } = default!;
}
