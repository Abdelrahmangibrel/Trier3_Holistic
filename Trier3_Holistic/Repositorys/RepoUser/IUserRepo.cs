using Trier3_Holistic.Dtos;

namespace Trier3_Holistic.Repositorys.RepoUser
{
    public interface IUserRepo
    {
        public void PostAllUser(PostAllUserDto dto);
        public void UpdateAllUser(int id, PostAllUserDto dto);
        public void DeleteAllUser(int id);
    }
}
