using Manager.Services.DTO;

namespace Manager.Services.Interfaces;
    public interface IUserService 
    {
        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Update(UserDTO userDTO);
        Task Remove(long id);
        Task<UserDTO> Get(long id);
        Task<List<UserDTO>> Get();
        Task<UserDTO> GetByEmail(string email); // busca email específico
        Task<List<UserDTO>> SearchByEmail(string email); // busca geral
        Task<List<UserDTO>> SearchByName(string name);
    }