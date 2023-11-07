namespace EMR.DbContexts;

using EMR.Models.Entities;
using Microsoft.EntityFrameworkCore;

public class EmrDbContext : DbContext
{
    public EmrDbContext(DbContextOptions<EmrDbContext> options) : base(options) // : base(options) => options ro mide be class pedar chon baraye class pedar gharar estefade beshe
    {

    }
    public DbSet<PrescriptionEntity> Prescriptions { get; set; } = null!; //= null!; = > khialet rahat bashe handlelesh kardam

}

