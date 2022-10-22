using ECommerceAPI.Application.Repositories.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }
        [HttpPost]
        public async void AddRage()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id= Guid.NewGuid(), Name="Product1", Price=100,Stock=10, CreatedDate=DateTime.UtcNow},
                new() {Id= Guid.NewGuid(), Name="Product2", Price=200,Stock=20, CreatedDate=DateTime.UtcNow},
                new() {Id= Guid.NewGuid(), Name="Product3", Price=300,Stock=30, CreatedDate=DateTime.UtcNow},
            });
            var count = await _productWriteRepository.SaveAsync();
        }
    }
}
