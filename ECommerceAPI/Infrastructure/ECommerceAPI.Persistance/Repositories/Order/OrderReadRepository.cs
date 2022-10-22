using ECommerceAPI.Application.Repositories.Order;
using ECommerceAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistance.Repositories.Order
{
    public class OrderReadRepository : ReadRepository<ECommerceAPI.Domain.Entities.Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
