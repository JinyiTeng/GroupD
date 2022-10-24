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
    public class StockController : ControllerBase   
    {

        private readonly IStockService _StockService;
        private readonly ILogger<StockController> _logger;

        public StockController(IStockService StockService, ILogger<StockController> logger)
        {
            _StockService = StockService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllStocks")]
        public async Task<List<StockDto>> GetAll()
        {
            var result = await _StockService.GetAll();
            return result.Select(x => x.ToStockDto()).ToList();
        }

        [HttpGet("{StockId}", Name = "GetStock")]
        public async Task<StockDto?> Get(int StockId)
        {
            var result = await _StockService.GetById(StockId);
            return result?.ToStockDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] StockDto requestDto)
        {
            var StockModel = requestDto.ToStockModel();
            return await _StockService.CreateStock(StockModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] StockDto requestDto)
        {
            await _StockService.UpdateStock(requestDto.ToStockModel());
            return Ok();
        }

        [HttpDelete, Route("{StockId}")]
        public async Task<IActionResult> Delete(int StockId)
        {
            await _StockService.DeleteStock(StockId);
            return Ok();
        }
    }
}
