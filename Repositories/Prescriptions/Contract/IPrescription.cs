namespace EMR.Repo;

using EMR.Models.Entities;

public interface IPrescriptionRepo
{
    public Task<IEnumerable<PrescriptionEntity>> getAllPrescriptionsAsync();

}
