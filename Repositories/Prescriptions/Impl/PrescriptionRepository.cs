
namespace EMR.Repo;
using EMR.DbContexts;
using EMR.Models.Entities;
using Microsoft.EntityFrameworkCore;


public class PrescriptionRepo : IPrescriptionRepo
{
    private readonly EmrDbContext _prescDbCtx;
    public PrescriptionRepo(EmrDbContext EmrDbContext)
    {
        _prescDbCtx = EmrDbContext ?? throw new ArgumentException(nameof(EmrDbContext));
    }
    public async Task<IEnumerable<PrescriptionEntity>> getAllPrescriptionsAsync()
    {
        return await _prescDbCtx.Prescriptions.ToListAsync();

    }

}
