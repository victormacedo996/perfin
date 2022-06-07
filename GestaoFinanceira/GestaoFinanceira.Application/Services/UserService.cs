using GestaoFinanceira.Application.Interfaces;
using GestaoFinanceira.Domain.Entities;
using GestaoFinanceira.Domain.Interfaces.Repositories;
using GestaoFinanceira.Domain.Interfaces.UnitOfWork;

namespace GestaoFinanceira.Application.Services;

public class UserService : BaseApplication, IUserApplication
{
    #region Private Fields

    private readonly IUserRepository _userRepository;

    #endregion Private Fields

    #region Public Constructors

    public UserService(
        IUnitOfWork unitOfWork,
        IUserRepository userRepository)
        : base(unitOfWork)
    {
        _userRepository = userRepository;
    }

    #endregion Public Constructors

    #region Public Methods

    public async Task<IEnumerable<User?>> GetAll()
    {
        return await _userRepository.GetAllAsync();
    }

    #endregion Public Methods
}