using FunToaderCoreWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetById(Int32 id);
        Task<T[]> Get();
        Task Create(T entity);
        Task Delete(T entity);

    }
}
