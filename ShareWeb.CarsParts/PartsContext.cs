using Microsoft.EntityFrameworkCore;
using ShareWeb.CarsParts.Entities;

namespace ShareWeb.CarsParts
{
    public class PartsContext : DbContext
    {
        public DbSet<PartType> PartTypes { get; set; }
        public DbSet<CarPart> CarParts { get; set; }
    }
}
