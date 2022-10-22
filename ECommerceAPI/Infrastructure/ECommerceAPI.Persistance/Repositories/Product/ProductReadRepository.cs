using ECommerceAPI.Application.Repositories.Product;
using ECommerceAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistance.Repositories.Product
{
    public class ProductReadRepository : ReadRepository<ECommerceAPI.Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
