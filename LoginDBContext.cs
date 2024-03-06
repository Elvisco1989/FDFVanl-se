using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FDFLodsedler.Model
{
    public class LoginDBContext:IdentityDbContext<IdentityUser>
    {
        public LoginDBContext()
        {

        }

        public LoginDBContext(DbContextOptions<LoginDBContext> options) : base(options)
        {

        }
        
    }

}
