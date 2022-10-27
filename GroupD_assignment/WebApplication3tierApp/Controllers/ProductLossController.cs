using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductLossController : ControllerBase   
    {

        private readonly IProductLossService _ProductLossService;
        private readonly ILogger<ProductLossController> _logger;

        public ProductLossController(IProductLossService ProductLossService, ILogger<ProductLossController> logger)
        {
            _ProductLossService = ProductLossService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllProductLosss")]
        public async Task<List<ProductLossDto>> GetAll()
        {
            var result = await _ProductLossService.GetAll();
            return result.Select(x => x.ToProductLossDto()).ToList();
        }

        [HttpGet("{ProductLossId}", Name = "GetProductLoss")]
        public async Task<ProductLossDto?> Get(int ProductLossId)
        {
            var result = await _ProductLossService.GetById(ProductLossId);
            return result?.ToProductLossDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] ProductLossDto requestDto)
        {
            var ProductLossModel = requestDto.ToProductLossModel();
            return await _ProductLossService.CreateProductLoss(ProductLossModel);
        }

        [HttpPut, Route("{ProductLossId}")]
        public async Task<IActionResult> Update([FromBody] ProductLossDto requestDto)
        {
            await _ProductLossService.UpdateProductLoss(requestDto.ToProductLossModel());
            return Ok();
        }

        [HttpDelete, Route("{ProductLossId}")]
        public async Task<IActionResult> Delete(int ProductLossId)
        {
            await _ProductLossService.DeleteProductLoss(ProductLossId);
            return Ok();
        }
    }
}
