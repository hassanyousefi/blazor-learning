using Humanizer;
using Microsoft.AspNetCore.Mvc;
using ToDo.Api.Models.News;
using ToDo.Shared.Dtos.Account;

namespace ToDo.Api.Controllers;


[Route("api/[controller]/[action]")]
[ApiController]
public partial class NewsController : AppControllerBase
{

    [HttpGet, EnableQuery]
    public IQueryable<NewsDto> Get(CancellationToken cancellationToken)
    {
        return DbContext.NewsItems.
            Where(n => n.UserId == User.GetUserId()).
            ProjectTo<NewsDto>(Mapper.ConfigurationProvider, cancellationToken);
    }

    [HttpPost]
    public async Task PublishNews(NewsDto dto, CancellationToken cancellationToken)
    {
        var newsItem = Mapper.Map<NewsItem>(dto);

        newsItem.UserId = User.GetUserId();

        DbContext.NewsItems.AddAsync(newsItem, cancellationToken);

        DbContext.SaveChangesAsync(cancellationToken);
    }

    // DELETE api/<NewsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

