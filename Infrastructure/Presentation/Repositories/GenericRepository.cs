using System;
using Applicatino.Interfaces.Repository;
using Domain.Comman;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;

namespace Persistance.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
{
    private readonly ApplicationContext _appContext;
    public GenericRepository(ApplicationContext appContext)
    {
        _appContext=appContext;
    }
    public async Task<T> AddAsync(T entity)
    {
        await _appContext.Set<T>().AddAsync(entity);
        await _appContext.SaveChangesAsync();
        return entity;
    }

    public async Task<List<T>> GetAllAysnc()
    {
        return await _appContext.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int Id)
    {
        return await _appContext.Set<T>().FindAsync(Id);
    }
}
