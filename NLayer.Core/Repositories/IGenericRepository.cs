using System;
using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetByIdAsync(int id);
		IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

		// productRepository.Where(x=> x.id > 5).OrderBy.ToListAsync();
		IQueryable<T> Where(Expression<Func<T, bool>> expression);
		// Just return data has in table true or false 
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entites);

		//Update function don't have a Async attribute because Entity Framewort only change entity state to modify in memory and this operetion not very long so don't need to Async method
		void Update(T entity);

        //Remove function don't have a Async attribute because Entity Framewort only change entity state to modify in memory and this operetion not very long so don't need to Async method
        void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);

	}
}

