using Microsoft.EntityFrameworkCore.Internal;
using workshop.Entities;
using workshop.Interfaces;

namespace workshop.Services
{
    public class UserServices:IUserServices
    {
        private IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User RegisterService(User user)
        {
            return _userRepository.Register(user);
        }
    }
}
