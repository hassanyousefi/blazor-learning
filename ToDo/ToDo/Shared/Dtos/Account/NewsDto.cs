
namespace ToDo.Shared.Dtos.Account;

public class NewsDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = nameof(AppStrings.RequiredAttribute_ValidationError))]
    [Display(Name = nameof(AppStrings.Title))]
    public string? Title { get; set; }

    [Required(ErrorMessage = nameof(AppStrings.RequiredAttribute_ValidationError))]
    [Display(Name = nameof(AppStrings.Description))]
    public string? Description { get; set; }

    public DateTimeOffset Date { get; set; }
}

