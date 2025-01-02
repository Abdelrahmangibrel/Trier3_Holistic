using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trier3_Holistic.Dtos;
using Trier3_Holistic.Repositorys.RepoUser;

namespace Trier3_Holistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        public UserController(IUserRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult PostAll(PostAllUserDto dto)
        {
            _repo.PostAllUser(dto);
            return Accepted();
        }

        [HttpPut]
        public IActionResult UpdateAll(int id, PostAllUserDto dto)
        {
            _repo.UpdateAllUser(id, dto);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repo.DeleteAllUser(id);
            return NoContent();
        }
    }
}
