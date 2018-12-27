using System.Collections.Generic;
using System.Threading.Tasks;
using LocalizeWord.API.Models;

namespace LocalizeWord.API.Repository
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(int id);
    }
}