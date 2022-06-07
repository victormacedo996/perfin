using GestaoFinanceira.Domain.Entities;

namespace GestaoFinanceira.Application.Interfaces;

public interface IUserApplication
{
    #region Public Methods

    Task<IEnumerable<User?>> GetAll();

    #endregion Public Methods
}