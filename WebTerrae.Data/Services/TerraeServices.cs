using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebTerrae.Data.Data;

namespace WebTerrae.Data.Services
{
    public class TerraeServices<TEntity> : ITerraeServices<TEntity> where TEntity : class
    {
        private readonly WebterraeContext _webterraeContext;
        private DbSet<TEntity> _dbSet;
        public TerraeServices(WebterraeContext webterraeContext)
        {
            _webterraeContext = webterraeContext;
            _dbSet = _webterraeContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
        public void Insert(TEntity obj)
        {
            _dbSet.Add(obj);
        }
        public void Update(TEntity obj)
        {
            _dbSet.Attach(obj);
            _webterraeContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            TEntity existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
        }
        public void Save()
        {
            _webterraeContext.SaveChanges();
        }
    }
}