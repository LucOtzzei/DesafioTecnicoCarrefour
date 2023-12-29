using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Otzzei.CashFlow.Infrastructure.Context
{
    public class CashFlowContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public CashFlowContext()
        {

        }
    }
}
