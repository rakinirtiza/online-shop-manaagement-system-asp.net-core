using BLL.DTOs;
using DAL.Entities.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
     public class PaymentService
    {
        Repository<Payment> repo;
        public PaymentService(Repository<Payment> repo)
        {
            this.repo = repo;
        }
        public List<PaymentDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<PaymentDTO>>(data);
            return ret;
        }
        public PaymentDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<PaymentDTO>(repo.Get(id));
        }
        public bool Create(PaymentDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Payment>(c);
            return repo.Create(data);
        }
        public bool Update(PaymentDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Payment>(c);
            return repo.Update(data);
        }
        //public bool Delete(int id)
        //{
        //    return repo.Delete(id);
        //}
    }
}
