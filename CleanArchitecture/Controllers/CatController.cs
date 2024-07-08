using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Enterprise.Models;
using CleanArchitecture.Web.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatController : GenericController<CatModel, CatDTO>
{
    public CatController(IGenericService<CatModel> genericService)
        : base(genericService)
    {
        
    }
}
