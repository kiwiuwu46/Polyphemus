namespace Kiwi.Polyphemus.Persistence.Model;

using Kiwi.Polyphemus.Persistence.Abstractions;

public class Patient : Entity<Guid>
{
  public string FirstName { get; set; } = string.Empty;

  public string LastName { get; set; } = string.Empty;

  /// <summary>
  /// National Securities Identifying Number.
  /// </summary>
  public string NSIN { get; set; } = string.Empty;

  public string SocialSecurityNumber { get; set; } = string.Empty;

  public string PhoneNumber { get; set; } = string.Empty;

  public string Email { get; set; } = string.Empty;
}
