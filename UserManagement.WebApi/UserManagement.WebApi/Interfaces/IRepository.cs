using System.Collections.Generic;
using System.Threading.Tasks;

namespace UserManagement.WebApi.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
