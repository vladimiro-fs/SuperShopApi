namespace SuperShopApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SuperShopApi.Repositories;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts() 
        {
            return Ok(_productRepository.GetAllWithUsers());
        }
    }
}
