using AutoMapper;
using HybridNTierECommerce.DTO.DomainDTOs;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Enums;
using HybridNTierECommerce.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.CommonDTO;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public abstract class BaseManager<T, D> : IManager<T, D> where T : IEntity where D : BaseDTO
    {
        protected readonly IRepository<T> _iRep;
        protected readonly IMapper _mapper;

        protected BaseManager(IRepository<T> iRep, IMapper mapper)
        {
            _iRep = iRep;
            _mapper = mapper;
        }

        bool ItemControl(List<D> list)
        {
            if (list.Count > 10) return false;
            return true;
        }

        public async Task<D> AddAndGetAsync(D item)
        {
            try
            {
                T entity = _mapper.Map<T>(item);
                await _iRep.AddAsync(entity);
                D addedItem = _mapper.Map<D>(entity);
                return addedItem;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while adding: {ex.Message}");
            }
        }
        public virtual string Add(D item)
        {
            try
            {
                T entity = _mapper.Map<T>(item);
                _iRep.Add(entity);
                return "Successfully added";
            }
            catch (Exception ex)
            {
                return $"an error occured while adding: {ex.Message}";
            }
        }

        public virtual async Task<string> AddAsync(D item)
        {
            try
            {
                T entity = _mapper.Map<T>(item);
                await _iRep.AddAsync(entity);
                return "Successfully added";
            }
            catch (Exception ex)
            {
                return $"an error occured while adding: {ex.Message}";
            }
        }

        public string AddRange(List<D> list)
        {
            if (!ItemControl(list)) return "You cannot add 10 or more item.";

            try
            {
                List<T> entities = _mapper.Map<List<T>>(list);
                _iRep.AddRange(entities);
                return "Successfully added";
            }
            catch (Exception ex)
            {
                return $"an error occured while adding: {ex.Message}";
            }
        }

        public async Task<string> AddRangeAsync(List<D> list)
        {
            if (!ItemControl(list)) return "You cannot add 10 or more item.";

            try
            {
                List<T> entities = _mapper.Map<List<T>>(list);
                await _iRep.AddRangeAsync(entities);
                return "Successfully added";
            }
            catch (Exception ex)
            {
                return $"an error occured while adding: {ex.Message}";
            }
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _iRep.Any(exp);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _iRep.AnyAsync(exp);
        }

        public void Delete(D item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item), "item cannot be null");

            T entity = _mapper.Map<T>(item);
            _iRep.Delete(entity);
        }

        public string DeleteRange(List<D> list)
        {
            if (list == null || list.Count == 0) throw new ArgumentNullException(nameof(list), "list cannot be null or empty");

            foreach (D item in list)
            {
                Delete(item);
            }
            return "Deleted successfully";
        }
        public virtual string Destroy(D item)
        {
            T entity = _mapper.Map<T>(item);

            if (entity.Status == DataStatus.Deleted)
            {
                _iRep.Destroy(entity);
                return "Destroyed successfully";
            }
            return "Must be deleted first";
        }

        public virtual string DestroyRange(List<D> list)
        {
            if (list == null || list.Count == 0) throw new ArgumentNullException(nameof(list), "List cannot be null or empty");
            List<D> notDestroyed = new List<D>();

            foreach (var item in list)
            {
                T entity = _mapper.Map<T>(item);
                if (entity.Status != DataStatus.Deleted) notDestroyed.Add(item);
                else _iRep.Destroy(entity);
            }
            if (notDestroyed.Any())
            {
                string notDestroyedNames = string.Join(", ", notDestroyed.Select(x => x.GetDisplayName()));
                return $"{notDestroyedNames} could not be destroyed. The rest were destroyed successfully";
            }
            return "Successfully destroyed";
        }

        public D Find(params object[] values)
        {
            T foundEntity = _iRep.Find(values);
            return _mapper.Map<D>(foundEntity);
        }

        public async Task<D> FindAsync(params object[] values)
        {
            T foundEntity = await _iRep.FindAsync(values);
            return _mapper.Map<D>(foundEntity);
        }

        public D FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            T entity = _iRep.FirstOrDefault(exp);
            return _mapper.Map<D>(entity);
        }

        public async Task<D> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            T entity = await _iRep.FirstOrDefaultAsync(exp);
            return _mapper.Map<D>(entity);
        }

        public List<D> GetActives()
        {
            return _mapper.Map<List<D>>(_iRep.GetActives());
        }

        public List<D> GetAll()
        {
            return _mapper.Map<List<D>>(_iRep.GetAll());
        }

        public List<D> GetFirstData(int count)
        {
            return _mapper.Map<List<D>>(_iRep.GetFirstDatas(count));
        }

        public List<D> GetLastDatas(int count)
        {
            return _mapper.Map<List<D>>(_iRep.GetLastDatas(count));
        }

        public List<D> GetModifieds()
        {
            return _mapper.Map<List<D>>(_iRep.GetModifieds());
        }

        public List<D> GetPassives()
        {
            return _mapper.Map<List<D>>(_iRep.GetPasives());
        }

        public object Select(Expression<Func<T, bool>> exp)
        {
            return _iRep.Select(exp);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _iRep.Select(exp);
        }

        public virtual async Task<string> UpdateAsync(D item)
        {
            T entity = _mapper.Map<T>(item);
            await _iRep.UpdateAsync(entity);
            return "Successfully updated";
        }

        public async Task UpdateRangeAsync(List<D> list)
        {
            foreach (D item in list)
            {
                await UpdateAsync(item);
            }
        }

        public List<D> Where(Expression<Func<T, bool>> exp)
        {
            return _mapper.Map<List<D>>(_iRep.Where(exp));
        }
    }
}
