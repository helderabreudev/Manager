using Manager.Domain.Entities;

namespace Manager.Infra.Interfaces;
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email); // busca email específico
        Task<List<User>> SearchByEmail(string email); // busca geral
        Task<List<User>> SearchByName(string name);
    } 