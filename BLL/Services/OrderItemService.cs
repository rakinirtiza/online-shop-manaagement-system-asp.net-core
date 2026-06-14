using BLL.DTOs;
using DAL.Entities.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class OrderItemService
    {
        Repository<OrderItem> repo;
        public OrderItemService(Repository<OrderItem> repo)
        {
            this.repo = repo;
        }
        public List<OrderItemDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<OrderItemDTO>>(data);
            return ret;
        }
        public OrderItemDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<OrderItemDTO>(repo.Get(id));
        }
        public bool Create(OrderItemDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<OrderItem>(c);
            return repo.Create(data);
        }
        public bool Update(OrderItemDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<OrderItem>(c);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }

    }
}
