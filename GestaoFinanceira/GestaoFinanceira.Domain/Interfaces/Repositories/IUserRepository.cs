using GestaoFinanceira.Domain.Entities;

namespace GestaoFinanceira.Domain.Interfaces.Repositories;

public interface IUserRepository : IDisposable
{
    #region Public Methods

    Task AddAsyc(User? user);

    void UpdateAsync(User? user);

    Task<User?> GetByIdAsync(int id);

    Task<User?> GetByNameAsync(string name);

    Task<User?> GetByEmailAsync(string email);

    Task<IEnumerable<User?>> GetAllAsync();

    #endregion Public Methods
}