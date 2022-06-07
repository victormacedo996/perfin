namespace GestaoFinanceira.Domain.Entities;

public class User
{
    #region Public Constructors

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }

    #endregion Public Constructors

    #region Public Properties

    public int Id { get; private set; }
    public string? Name { get; private set; }
    public string? Email { get; private set; }

    #endregion Public Properties
}