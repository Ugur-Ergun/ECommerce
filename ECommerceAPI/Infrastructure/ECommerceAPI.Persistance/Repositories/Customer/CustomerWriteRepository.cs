using ECommerceAPI.Application.Repositories.Customer;
using ECommerceAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistance.Repositories.Customer
{
    public class CustomerWriteRepository : WriteRepository<ECommerceAPI.Domain.Entities.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
