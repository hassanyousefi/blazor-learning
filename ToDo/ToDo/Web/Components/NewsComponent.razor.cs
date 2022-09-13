using ToDo.Shared.Dtos.Account;

namespace ToDo.App.Components
{
    public partial class NewsComponent
    {
        [Parameter]
        public NewsDto newsModel { get; set; } = new();
    }
}
