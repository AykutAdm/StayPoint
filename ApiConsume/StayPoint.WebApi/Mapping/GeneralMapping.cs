using AutoMapper;
using StayPoint.DtoLayer.Dtos.RoomDtos;
using StayPoint.DtoLayer.Dtos.ServiceDtos;
using StayPoint.DtoLayer.Dtos.StaffDtos;
using StayPoint.DtoLayer.Dtos.SubscribeDtos;
using StayPoint.DtoLayer.Dtos.TestimonialDtos;
using StayPoint.EntityLayer.Concrete;

namespace StayPoint.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Room, ResultRoomDto>().ReverseMap();
            CreateMap<Room, CreateRoomDto>().ReverseMap();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
            CreateMap<Room, GetByIdRoomDto>().ReverseMap();


            CreateMap<Service, ResultServiceDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, GetByIdServiceDto>().ReverseMap();

            CreateMap<Staff, ResultStaffDto>().ReverseMap();
            CreateMap<Staff, CreateStaffDto>().ReverseMap();
            CreateMap<Staff, UpdateStaffDto>().ReverseMap();
            CreateMap<Staff, GetByIdStaffDto>().ReverseMap();

            CreateMap<Subscribe, ResultSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, CreateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, UpdateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, GetByIdSubscribeDto>().ReverseMap();

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetByIdTestimonialDto>().ReverseMap();

        }
    }
}
