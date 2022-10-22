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
    public class StaffController : ControllerBase   
    {

        private readonly IStaffService _StaffService;
        private readonly ILogger<StaffController> _logger;

        public StaffController(IStaffService StaffService, ILogger<StaffController> logger)
        {
            _StaffService = StaffService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllStaffs")]
        public async Task<List<StaffDto>> GetAll()
        {
            var result = await _StaffService.GetAll();
            return result.Select(x => x.ToStaffDto()).ToList();
        }

        [HttpGet("{StaffId}", Name = "GetStaff")]
        public async Task<StaffDto?> Get(int StaffId)
        {
            var result = await _StaffService.GetById(StaffId);
            return result?.ToStaffDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] StaffDto requestDto)
        {
            var StaffModel = requestDto.ToStaffModel();
            return await _StaffService.CreateStaff(StaffModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] StaffDto requestDto)
        {
            await _StaffService.UpdateStaff(requestDto.ToStaffModel());
            return Ok();
        }

        [HttpDelete, Route("{StaffId}")]
        public async Task<IActionResult> Delete(int StaffId)
        {
            await _StaffService.DeleteStaff(StaffId);
            return Ok();
        }
    }
}
