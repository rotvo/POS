using POS.Infrastructure.Persistences.Interfaces;
using System.Linq.Dynamic.Core;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected IQueryable<TDTO> Ordering<TDTO>(IQueryable<TDTO> query, string orderBy, string orderDirection)
        {
            if (string.IsNullOrEmpty(orderBy))
            {
                return query;
            }

            if (orderDirection == "asc")
            {
                return query.OrderBy(orderBy);
            }
            else
            {
                return query.OrderDescending();
            }
        }
    }
}
