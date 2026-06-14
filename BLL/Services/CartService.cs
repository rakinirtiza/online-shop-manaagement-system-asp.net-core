using BLL.DTOs;
using DAL.Entities.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CartService
    {
        Repository<Cart> repo;
        public CartService(Repository<Cart> repo)
        {
            this.repo = repo;
        }
        public List<CartDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<CartDTO>>(data);
            return ret;
        }
        public CartDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<CartDTO>(repo.Get(id));
        }
        public bool Create(CartDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Cart>(c);
            return repo.Create(data);
        }
        public bool Update(CartDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Cart>(c);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
