using ToDo.Api.Models.News;
using ToDo.Shared.Dtos.Account;

namespace ToDo.Api.Mappers;

public class NewsItemMapperConfiguration : Profile
{
    public NewsItemMapperConfiguration()
    {
        CreateMap<NewsItem, NewsDto>().ReverseMap();
    }
}

