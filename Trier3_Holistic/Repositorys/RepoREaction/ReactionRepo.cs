using Microsoft.EntityFrameworkCore;
using Trier3_Holistic.AppDbContext;
using Trier3_Holistic.Dtos;
using Trier3_Holistic.Models;

namespace Trier3_Holistic.Repositorys.RepoREaction
{
    public class ReactionRepo : IReactionRepo
    {
        private readonly dbcontext _context;

        public ReactionRepo(dbcontext context)
        {
            _context = context;
        }

        public void AddAll(PostReationAll dto)
        {
            var result = new Reaction
            {
                ReactionName = dto.ReactionName,
                Users = dto.UsersDto.Select(x=> new User
                {
                    UserName = x.UserName,
                    Phone = x.Phone,
                    UserEmail = x.UserEmail,
                    BlogPost = x.Posts.Select(t=> new BlogPost
                    {
                        BlogPostTitle = t.BlogPostTitle,
                        DateTime = DateTime.UtcNow,
                        numerofsubscribe = t.numerofsubscribe,
                    }).ToList(),
                    Role = new Role
                    {
                        RoleName = x.RoleDto.RoleName,
                    }
                }).ToList(),
            };
            _context.Reactions.Add(result);
            _context.SaveChanges();
        }
    }
}
