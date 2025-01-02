using Microsoft.EntityFrameworkCore;
using Trier3_Holistic.AppDbContext;
using Trier3_Holistic.Dtos;
using Trier3_Holistic.Models;

namespace Trier3_Holistic.Repositorys.RepoUser
{
    public class UserRepo : IUserRepo
    {
        private readonly dbcontext _context;
        public UserRepo(dbcontext context) 
        {
            _context = context;
        }

        public void DeleteAllUser(int id)
        {   
            var result = _context.Users
                .Include(x => x.Reactions)
                .Include(x => x.BlogPost)
                .Include(x => x.Role)
                .FirstOrDefault(x => x.UserId == id);
            if (result != null)
            {
                _context.Remove(result);
            }
            else
            {
                throw new Exception("User not found");
            }
            _context.SaveChanges();
        }


        public void PostAllUser(PostAllUserDto dto)
        {
            var result = new User
            {
                UserName = dto.UserName,
                UserEmail = dto.UserEmail,
                Phone = dto.Phone,
                Role = new Role
                {
                    RoleName = dto.RoleDto.RoleName,
                },
                BlogPost = dto.BlogPostDto.Select(x=> new BlogPost
                {
                    BlogPostTitle = x.BlogPostTitle,
                    numerofsubscribe = x.numerofsubscribe,
                    DateTime = DateTime.UtcNow,
                }).ToList(),
            };
            _context.Users.Add(result);
            _context.SaveChanges();
        }

        public void UpdateAllUser(int id, PostAllUserDto dto)
        {
            var result = _context.Users.
                Include(x=>x.BlogPost).
                Include(x=>x.Role).
                FirstOrDefault(x=>x.UserId == id);
            if(result != null)
            {
                result.UserEmail = dto.UserEmail;
                result.Phone = dto.Phone;
                result.UserName = dto.UserName; 
                result.BlogPost = dto.BlogPostDto.Select(i=> new BlogPost
                {
                    BlogPostTitle= i.BlogPostTitle,
                    DateTime = DateTime.UtcNow,
                    numerofsubscribe= i.numerofsubscribe,
                }).ToList();
                result.Role = new Role
                {
                    RoleName = dto.RoleDto.RoleName,
                };
            }
            else
            {
                throw new Exception("Id Not Found");
            }
            _context.Users.Update(result);
            _context.SaveChanges();
        }
    }
}
