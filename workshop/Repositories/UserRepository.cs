using workshop.Dtos;
using workshop.Entities;
using workshop.Interfaces;

namespace workshop.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly mvcPortalContext _context;
        public UserRepository(mvcPortalContext context)
        {
            _context = context;
        }

        public User Register(User user)
        {
            var userObj = new User();
            userObj.Name = user.Name;
            userObj.Email = user.Email;
            userObj.Phone = user.Phone;
            userObj.Password = user.Password;
            userObj.confirmPassword = user.confirmPassword;
            _context.Users.Add(userObj);
            _context.SaveChanges();
            return user;
        }
    }
}
