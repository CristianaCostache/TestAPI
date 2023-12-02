using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class PawbookApiContext : DbContext
    {
        public PawbookApiContext(DbContextOptions<PawbookApiContext> options) : base(options)
        { }
    }
}
