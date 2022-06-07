using GestaoFinanceira.Domain.Interfaces.UnitOfWork;
using GestaoFinanceira.Infra.Context;

namespace GestaoFinanceira.Infra.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    #region Private Fields

    private readonly GestaoFinanceiraContext _context;

    #endregion Private Fields

    #region Public Constructors

    public UnitOfWork(GestaoFinanceiraContext context)
    {
        _context = context;
    }

    #endregion Public Constructors

    #region Public Methods

    public async Task<bool> CommitAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    #endregion Public Methods
}