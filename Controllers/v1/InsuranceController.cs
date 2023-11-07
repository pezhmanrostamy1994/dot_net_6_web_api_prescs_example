namespace EMR.Controller.V1;

using Microsoft.AspNetCore.Mvc;
using EMR.Extensions;
using EMR.Dto;
using EMR.Services.Contracts;


[ApiController]
[Route("api/v{version:apiVersion}/insurances")]
[ApiVersion("1.0")]
public class InsuranceController : ControllerBase
{

    private readonly IInsuranceService _insuranceService;
    public InsuranceController(IInsuranceService insuranceService)
    {
        _insuranceService = insuranceService;
    }

    #region Get all insurances
    [HttpGet]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(ActionResult<MessageDto>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiErrorResponse), StatusCodes.Status404NotFound)]
    public IActionResult GetInsurance()
    {
        var result = _insuranceService.getAllInsurances();
        return EmrResponseExtensions.SuccessRes(result.Data, StatusCodes.Status200OK, result.Messages);
    }
    #endregion
}

