using AutoMapper;
using BLL.DTOs;
using DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class MapperConfig
    {
        static MapperConfiguration cfg=new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Category, CategoryDTO>().ReverseMap();
            cfg.CreateMap<Product, ProductDTO>().ReverseMap();
            cfg.CreateMap<Cart, CartDTO>().ReverseMap();
            cfg.CreateMap<User, UserDTO>().ReverseMap();
            cfg.CreateMap<CartItem, CartItemDTO>().ReverseMap();
            cfg.CreateMap<Order, OrderDTO>().ReverseMap();
            cfg.CreateMap<OrderItem, OrderItemDTO>().ReverseMap();
            cfg.CreateMap<Payment, PaymentDTO>().ReverseMap();
        });
        public static Mapper GetMapper()
        {
            return new Mapper(cfg);
        }
    }
}
