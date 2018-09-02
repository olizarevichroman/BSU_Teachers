using BSU_Teachers.DataLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.DataAccessLayer.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        Task<int> Detete(int id);

        TEntity Context { get;}

        Task<int> Update(TEntity item);

        Task<IEnumerable<TEntity>> GetAll();

        Task<int> Add(TEntity item);
    }
}
