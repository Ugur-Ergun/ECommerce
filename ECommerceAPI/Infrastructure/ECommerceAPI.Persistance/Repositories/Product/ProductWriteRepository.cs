using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Application.Repositories.Product;
using ECommerceAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistance.Repositories.Product
{
    public class ProductWriteRepository : WriteRepository<ECommerceAPI.Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
