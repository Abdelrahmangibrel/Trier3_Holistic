using Trier3_Holistic.Models;

namespace Trier3_Holistic.Dtos
{
    public class PostReationAll
    {
        public string ReactionName { get; set; }
        public List<UserDto> UsersDto { get; set; }
    }
}
