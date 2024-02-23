using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Models;
using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_Api.Repositories;
using RealEstate_Dapper_Api.Tools;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesttController : ControllerBase
    {
       private readonly Context _context;
        public TesttController(Context context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Index(GirisssYap p)
        {
            string query = "SELECT * FROM AppUser WHERE UserName = @UserName and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", p.Username);
            parameters.Add("@password", p.Password);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GirisssYap>(query, parameters);
                if(values != null)
                {
                    return Ok("aaaa");
                }
                else
                {
                    return Ok("bbb");
                }
            }
        }
    }
}
