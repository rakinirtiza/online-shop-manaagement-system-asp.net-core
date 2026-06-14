using BLL.DTOs;
using DAL.Entities.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class UserService
    {
        Repository<User> repo;
        public UserService(Repository<User> repo)
        {
            this.repo = repo;
        }
        public List<UserDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<UserDTO>>(data);
            return ret;
        }
        public UserDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<UserDTO>(repo.Get(id));
        }
        public bool Create(UserDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<User>(c);
            return repo.Create(data);
        }
        public bool Update(UserDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<User>(c);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
