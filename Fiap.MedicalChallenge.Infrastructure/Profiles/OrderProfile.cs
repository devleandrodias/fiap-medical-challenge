using AutoMapper;
using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;

namespace Fiap.MedicalChallenge.Infrastructure.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OpenOrderDto, Order>();
            CreateMap<Order, ReadOrderDto>();
        }
    }
}
