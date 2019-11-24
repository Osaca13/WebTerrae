using System.Collections.Generic;

namespace WebTerrae.Data.Services
{
    public interface ITerraeServices<TEntity> where TEntity : class
    {
        void Delete(object id);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity obj);
        void Save();
        void Update(TEntity obj);
    }
}