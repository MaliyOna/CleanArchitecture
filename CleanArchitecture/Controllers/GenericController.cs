using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Enterprise.Abstractions;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenericController<Model, DTO> : ControllerBase where Model : IBaseModel
{
    private readonly IMapper _mapper;
    private readonly IGenericService<Model> _genericService;

    public GenericController(IMapper mapper,IGenericService<Model> genericService)
    {
        _mapper = mapper;
        _genericService = genericService;
    }

    [HttpGet("all")]
    public async Task<List<DTO>> GetAll(CancellationToken cancellationToken)
    {
        var result = await _genericService.GetAll(cancellationToken);

        return _mapper.Map<List<DTO>>(result);
    }

    [HttpGet]
    public async Task<DTO?> GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = await _genericService.GetById(id, cancellationToken);

        if (result == null)
            throw new Exception();

        return _mapper.Map<DTO>(result);
    }

    [HttpDelete]
    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        await _genericService.Delete(id, cancellationToken);
    }

    [HttpPut]
    public async Task Update(DTO dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Model>(dto);

        await _genericService.Update(model, cancellationToken);
    }

    [HttpPost]
    public async Task Create(DTO dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Model>(dto);

        await _genericService.Create(model, cancellationToken);
    }
}
