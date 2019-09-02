using System.Collections.Generic;
using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.UsersRepository;

namespace MoneyTrack.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public User Create(User user)
        {
            return userRepository.Create(user);
        }

        public List<User> Get()
        {
            return userRepository.Get();
        }

        public User Get(string id)
        {
            return userRepository.Get(id);
        }

        public bool Remove(User user)
        {
            return userRepository.Remove(user);
        }

        public bool Remove(string id)
        {
            return userRepository.Remove(id);
        }

        public bool Update(string id, User user)
        {
            return userRepository.Update(id, user);
        }
    }
}
