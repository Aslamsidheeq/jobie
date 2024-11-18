using workshop.Dtos;
using workshop.Entities;

namespace workshop.Interfaces
{
    public interface IUserRepository
    {
        public User Register(User user);
    }
}
