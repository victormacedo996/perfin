using GestaoFinanceira.Domain.Interfaces.UnitOfWork;

namespace GestaoFinanceira.Application;

public abstract class BaseApplication
{
    #region Private Fields

    private readonly IUnitOfWork _unitOfWork;

    #endregion Private Fields

    #region Public Constructors

    public BaseApplication(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    #endregion Public Constructors

    #region Public Methods

    public async Task<bool> CommitAsync()
    {
        try
        {
            if (await _unitOfWork.CommitAsync())
                return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return await Task.FromResult(false);
    }

    #endregion Public Methods
}