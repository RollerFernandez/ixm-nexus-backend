namespace Ixm.Nexus.Users.Application.Dto.UsersDto.Profiles;
public class UserProfile : Profile
{
    public UserProfile()
    {
        _ = CreateMap<UserEntity, UserDto>();
    }
}
