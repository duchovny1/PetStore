using PetStore.Data;
using PetStore.Data.Models;
using System;
using System.Linq;

namespace PetStore.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly PetStoreDbContext data;

        public UserService(PetStoreDbContext data)
        {
            this.data = data;
        }

        public bool Exists(int userId)
        {
            return this.data.Users.Any(x => x.Id == userId);
        }

        public void Register(string name, string email)
        {
            if(!this.data.Users.Any(x => x.Email == email))
            {
                throw new ArgumentException("There is already a registration with this email!");
            }

            var user = new User()
            {
                Name = name,
                Email = email
            };

            this.data.Users.Add(user);
            this.data.SaveChanges();
        }
    }
}
