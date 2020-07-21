using AutoMapper;

namespace MyCar.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<MyCar.Entities.User, ExternalModels.UserDTO>();
            CreateMap<ExternalModels.UserDTO, MyCar.Entities.User>();
        }
    }
}