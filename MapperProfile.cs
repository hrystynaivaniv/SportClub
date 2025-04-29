using AutoMapper;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateUserModel, User>();
        }
    }
}
