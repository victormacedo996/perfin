using GestaoFinanceira.Domain.Entities;
using GestaoFinanceira.Domain.Interfaces.Repositories;
using GestaoFinanceira.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinanceira.Infra.Repositories;

public class UserRepository : IUserRepository
{
    #region Private Fields

    private readonly GestaoFinanceiraContext _db;
    private readonly DbSet<User?> _users;

    #endregion Private Fields

    #region Public Constructors

    public UserRepository(GestaoFinanceiraContext db)
    {
        _db = db;
        _users = _db.Set<User>();
    }

    #endregion Public Constructors

    #region Public Methods

    public async Task<User?> GetByIdAsync(int id)
    {
        return await _users
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<User?> GetByNameAsync(string name)
    {
        return await _users
            .FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _users
            .FirstOrDefaultAsync(x => x.Email.ToUpper() == email.ToUpper());
    }

    public async Task<IEnumerable<User?>> GetAllAsync()
    {
        return await _users
            .ToListAsync();
    }

    public async Task AddAsyc(User? user)
    {
        await _users.AddAsync(user);
    }

    public void UpdateAsync(User? user)
    {
        _users.Update(user);
    }

    public void Dispose()
    {
        _db.Dispose();
        GC.SuppressFinalize(this);
    }

    #endregion Public Methods
}