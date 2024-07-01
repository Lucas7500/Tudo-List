﻿using Tudo_List.Domain.Core.Interfaces.Repositories;
using Tudo_List.Domain.Core.Interfaces.Services;
using Tudo_List.Domain.Entities;

namespace Tudo_List.Domain.Services
{
    public class UserService(IUserRepository repository) : IUserService
    {
        private readonly IUserRepository _repository = repository;

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetById(int id)
        {
            return _repository.Get(id);
        }

        public void Register(User user)
        {
            _repository.Register(user);
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
