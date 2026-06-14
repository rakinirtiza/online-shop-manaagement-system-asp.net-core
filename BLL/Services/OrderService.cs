using BLL.DTOs;
using DAL.Entities.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class OrderService
    {
        Repository<Order> repo;
        public OrderService(Repository<Order> repo)
        {
            this.repo = repo;
        }
        public List<OrderDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<OrderDTO>>(data);
            return ret;
        }
        public OrderDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<OrderDTO>(repo.Get(id));
        }
        public bool Create(OrderDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Order>(c);
            return repo.Create(data);
        }
        public bool Update(OrderDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Order>(c);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
