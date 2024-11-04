using HybridNTierECommerce.DAL.ContextClasses;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Enums;
using HybridNTierECommerce.ENTITIES.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.DAL.Repositories.Concretes.EF
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected HybridECommerceContext _db;
        public BaseRepository(HybridECommerceContext db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public async Task AddAsync(T item)
        {
            await _db.Set<T>().AddAsync(item);
            await SaveAsync();
        }

        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange(list);
            Save();
        }

        public async Task AddRangeAsync(List<T> list)
        {
            await _db.Set<T>().AddRangeAsync(list);
            await SaveAsync();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _db.Set<T>().AnyAsync(exp);
        }

        public void Delete(T item)
        {
            item.Status = DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            T originalEntity = Find(item.ID);
            _db.Entry(originalEntity).CurrentValues.SetValues(item);
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list) Delete(item);

        }

        public void Destroy(T item)
        {
             T trackedEntity = _db.Set<T>().Local.FirstOrDefault(x => x.ID == item.ID);
            _db.Entry(trackedEntity).State =EntityState.Detached;
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(params object[] values)
        {
            return _db.Set<T>().Find(values);
        }

        public async Task<T> FindAsync(params object[] values)
        {
            return await _db.Set<T>().FindAsync(values);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetFirstDatas(int count)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetLastDatas(int count)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == DataStatus.Updated);
        }

        public List<T> GetPasives()
        {
            return Where(x => x.Status == DataStatus.Deleted);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        public async Task UpdateAsync(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.Status = DataStatus.Updated;
            T originalEntity = await FindAsync(item.ID);
            _db.Entry(originalEntity).CurrentValues.SetValues(item);
            Save();
        }

        public async Task UpdateRangeAsync(List<T> list)
        {
            foreach (T item in list) await UpdateAsync(item);
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
