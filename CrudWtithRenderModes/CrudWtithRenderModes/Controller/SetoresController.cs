using CrudWithRenderModes.Shared.Entities;
using CrudWithRenderModes.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace CrudWtithRenderModes.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetoresController : ControllerBase
    {
        private readonly ISetoresRepository _setoresRepository;

        public SetoresController(ISetoresRepository setoresRepository)
        {
            _setoresRepository = setoresRepository;
        }

        [HttpGet("Setores")]

        public async Task<ActionResult<List<Setores>>> GetAllSetoresAsync()
        {
            var setores = await _setoresRepository.GetAllSetoresAsync();
            return Ok(setores);
        }

        [HttpGet("Setores/{id}")]
        public async Task<ActionResult<List<Setores>>> GetSingleSetoresAsync(int id)
        {
            var setores = await _setoresRepository.GetSetoresByIdAsync(id);
            return Ok(setores);
        }
        [HttpPost("Add-Setores")]
        public async Task<ActionResult<List<Setores>>> AddSetoresAsync(Setores model)
        {
            var setores = await _setoresRepository.AddSetoresAsync(model);
            return Ok(setores);
        }
        [HttpPut("Update-Setores")]
        public async Task<ActionResult<List<Setores>>> UpdateSetoresAsync(Setores model)
        {
            var setores = await _setoresRepository.UpdateSetoresAsync(model);
            return Ok(setores);
        }
        [HttpDelete("Delete-Setores")]
        public async Task<ActionResult<List<Setores>>> DeleteSetoresAsync(int id)
        {
            var setores = await _setoresRepository.DeleteSetoresAsync(id);
            return Ok(setores);
        }
    }
}
