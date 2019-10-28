using AppServices.Data;
using AppServices.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RemoteConfigController : ControllerBase
    {
        private readonly ILogger<RemoteConfigController> _logger;
        private readonly ApplicationDbContext _context;  
        public RemoteConfigController(ILogger<RemoteConfigController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpPost("App")]
        public  IActionResult GetValue([FromBody]GetValue Data)
        {
            try
            {
                var data = _context.RemoteConfigs
                            .Where(r => r.AppID == Data.App && (string.IsNullOrEmpty(Data.Key) || Data.Key == r.Key))
                            .ToDictionary(x => x.Key, x => x.Value);
                return Ok(data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
