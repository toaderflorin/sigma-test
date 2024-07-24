using Microsoft.EntityFrameworkCore;
using SigmaTest.Service.Controllers.Entities;

namespace SigmaTest.Service.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
    }    
}