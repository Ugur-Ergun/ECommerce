using ECommerceAPI.Application.Repositories.Customer;
using ECommerceAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistance.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<ECommerceAPI.Domain.Entities.Customer>, ICustomerReadRepository
    {
        //ReadRepository asking for a context on constructor, and we need to give context to base with contructor
        public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
