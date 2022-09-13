using ToDo.Shared.Dtos.Account;
namespace ToDo.App.Pages;

public partial class NewsPage
{
    public NewsDto AddNews { get; set; } = new();
    public List<NewsDto> TestNews = new List<NewsDto>();
    
    public NewsPage()
    {
        TestNews.Add(new NewsDto { Title = "title 0", Description = "des 0" });
        TestNews.Add(new NewsDto { Title = "title 1", Description = "des 1" });
        TestNews.Add(new NewsDto { Title = "title 2", Description = "des 2" });
        TestNews.Add(new NewsDto { Title = "title 3", Description = "des 3" });
        TestNews.Add(new NewsDto { Title = "title 4", Description = "des 4" });
        TestNews.Add(new NewsDto { Title = "title 5", Description = "des 5" });
    }

    private void Submit()
    {

    }
}

