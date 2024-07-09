using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Enterprise.Models;
using CleanArchitecture.Web.DTOs;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FarmController : GenericController<FarmModel, FarmDTO>
{
    public FarmController(IMapper mapper, IGenericService<FarmModel> genericService)
        :base(mapper, genericService)
    {
        
    }
}
