using System;
using Domain.Comman;

namespace Applicatino.Interfaces.Repository;

public interface IGenericRepository<T> where T:BaseEntity
{
     Task<List<T>> GetAllAysnc();
    Task<T> GetByIdAsync(int Id);
    Task<T>AddAsync(T entity);

}
