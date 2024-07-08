using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Enterprise.Abstractions;
using CleanArchitecture.Web.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenericController<Model, DTO> : ControllerBase where Model : IBaseModel, new() where DTO : IBaseDTO, new()
{
    private readonly IGenericService<Model> _genericService;

    public GenericController(IGenericService<Model> genericService)
    {
        _genericService = genericService;
    }

    [HttpGet("all")]
    public async Task<List<DTO>> GetAll(CancellationToken cancellationToken)
    {
        var result = await _genericService.GetAll(cancellationToken);

        return result.Select(x => new DTO()
        {
            Id = x.Id,
        }).ToList();
    }

    [HttpGet]
    public async Task<DTO?> GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = await _genericService.GetById(id, cancellationToken);

        if (result == null)
            throw new Exception();

        return new DTO
        {
            Id = result.Id
        };
    }

    [HttpDelete]
    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        await _genericService.Delete(id, cancellationToken);
    }

    [HttpPut]
    public async Task Update(DTO dto, CancellationToken cancellationToken)
    {
        var model = new Model
        {
            Id = dto.Id
        };

        await _genericService.Update(model, cancellationToken);
    }

    [HttpPost]
    public async Task Create(DTO dto, CancellationToken cancellationToken)
    {
        var model = new Model
        {
            Id = dto.Id
        };

        await _genericService.Create(model, cancellationToken);
    }
}
