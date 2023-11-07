namespace EMR.Models.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EMR.Models.Enums;


public class PrescriptionEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }

    [Required]
    public InsuranceCompanyEnum InsuranceCompany { get; set; }

    public PrescriptionEntity(InsuranceCompanyEnum insuranceCompany)
    {
        InsuranceCompany = insuranceCompany;
    }

}

