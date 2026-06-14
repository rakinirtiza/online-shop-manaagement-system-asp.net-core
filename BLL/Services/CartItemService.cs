using BLL.DTOs;
using DAL.Entities.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CartItemService
    {
        Repository<CartItem> repo;
        public CartItemService(Repository<CartItem> repo)
        {
            this.repo = repo;
        }
        public List<CartItemDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<CartItemDTO>>(data);
            return ret;
        }
        public CartItemDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<CartItemDTO>(repo.Get(id));
        }
        public bool Create(CartItemDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<CartItem>(c);
            return repo.Create(data);
        }
        public bool Update(CartItemDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<CartItem>(c);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
