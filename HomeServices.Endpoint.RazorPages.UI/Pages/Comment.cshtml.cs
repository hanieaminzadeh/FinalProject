using HomeService.Core.Contracts.CommentContracts;
using HomeService.Core.Contracts.ExpertContracts;
using HomeService.Core.DTOs;
using HomeService.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeServices.Endpoint.RazorPages.UI.Pages;

[Authorize(Roles = "Customer,Expert")]
public class CommentModel : PageModel
{

    private readonly ICommentAppService _commentAppService;
    private readonly IExpertAppService _expertAppService;

    public CommentModel(ICommentAppService commentAppService, IExpertAppService expertAppService)
    {
        _commentAppService = commentAppService;
        _expertAppService = expertAppService;
    }

    [BindProperty]
    public CommentDto Comment { get; set; }

    [BindProperty]
    public Expert Expert { get; set; }

    public async Task OnGet(int id, CancellationToken cancellationToken)
    {
        Expert = await _expertAppService.GetExpertById(id, cancellationToken);
    }

    public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
    {
        var userId = int.Parse(User.Claims.First(x => x.Type == "userCustomerId").Value);
        Comment.CustomerId = userId;
        await _commentAppService.CreateComment(Comment, cancellationToken);
        return LocalRedirect("~/Index");
    }
}
