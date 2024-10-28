using System;
using Applicatino.Interfaces.Repository;
using Domain;
using Persistance.Context;

namespace Persistance.Repositories;

public class ProductRepository:GenericRepository<Product>,IProductRepository
{
    public ProductRepository(ApplicationContext applicationContext):base(applicationContext)
    {
        
    }

}
