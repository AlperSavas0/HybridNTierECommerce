using HybridNTierECommerce.DTO.CommonDTO;
using HybridNTierECommerce.DTO.DomainDTOs;
using HybridNTierECommerce.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Abstracts
{
    public interface IManager<T,D> where T : IEntity where D:BaseDTO
    {
        //List Commands
        List<D> GetAll();
        List<D> GetActives();
        List<D> GetPassives();
        List<D> GetModifieds();

        //Modify Commands
        Task<D> AddAndGetAsync(D item);
        string Add(D item);
        Task<string> AddAsync(D item);
        Task<string> AddRangeAsync(List<D> list);
        string AddRange(List<D> list);
        void Delete(D item);
        string DeleteRange(List<D> list);
        Task<string> UpdateAsync(D item);
        Task UpdateRangeAsync(List<D> list);
        string Destroy(D item);
        string DestroyRange(List<D> list);

        //Linq Commands
        List<D> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        D FirstOrDefault(Expression<Func<T, bool>> exp);
        Task<D> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        //Find Command
        D Find(params object[] values);
        Task<D> FindAsync(params object[] values);

        List<D> GetLastDatas(int count);
        List<D> GetFirstData(int count);

    }
}
