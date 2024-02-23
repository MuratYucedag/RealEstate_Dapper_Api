using Dapper;
using Microsoft.AspNetCore.Identity;
using RealEstate_Dapper_Api.Models;
using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_Api.Tools;
using System.Reflection;

namespace RealEstate_Dapper_Api.Repositories
{
    public class LoginRepo : ILoginRepo
    {
        private readonly Context _context;
        public LoginRepo(Context context)
        {
            _context = context;
        }
        public string GirisYapmaMetodu(GirisssYap p)
        {
            string query = "SELECT * FROM AppUser WHERE UserName = @UserName and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", p.Username);
            parameters.Add("@password", p.Password);
            using (var connection = _context.CreateConnection())
            {
                connection.ExecuteAsync(query, parameters);
            }
            if (query != null)
            {
                return("aaa");
            }
            else
            {
                return "bbb";
            }
        }
    }
}