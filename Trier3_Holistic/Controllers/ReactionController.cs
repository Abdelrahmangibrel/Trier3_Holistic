using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trier3_Holistic.Dtos;
using Trier3_Holistic.Repositorys.RepoREaction;

namespace Trier3_Holistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactionController : ControllerBase
    {
        private readonly IReactionRepo _repo;

        public ReactionController(IReactionRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult Post(PostReationAll dto)
        {
            _repo.AddAll(dto);
            return Accepted();
        }
    }
}
