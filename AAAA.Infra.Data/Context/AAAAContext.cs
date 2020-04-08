using AAAA.Domain;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Infra.Data.Context
{
    public class AAAAContext : DbContext
    {
        public AAAAContext(DbContextOptions<AAAAContext> options) : base(options) { }
    }
}
