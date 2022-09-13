using ToDo.Shared.Dtos.Account;

namespace ToDo.App.Components
{
    public partial class NewsComponent
    {
        [Parameter]
        public NewsDto newsModel { get; set; } = new();

        [Parameter]
        public EventCallback<int> OnRemove { get; set; }

        public async Task OnRemoveButton()
        {
            await OnRemove.InvokeAsync(newsModel.Id);
        }
    }
}
