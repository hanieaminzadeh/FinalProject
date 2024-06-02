using HomeService.Core.Contracts.RequestContracts;
using HomeService.Core.DTOs;
using HomeService.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;

namespace HomeServices.Endpoint.RazorPages.UI.Pages;

public class DisplayRequestsModel : PageModel
{
	private readonly IRequestAppService _requestAppService;

	public DisplayRequestsModel(IRequestAppService requestAppService)
    {
		_requestAppService = requestAppService;
	}

	[BindProperty]
	public ExpertProfileDto Expert { get; set; }

	[BindProperty]
	public List<RequestDto> Orders { get; set; }

	public async Task OnGet(CancellationToken cancellationToken)
	{
		var expertId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "userExpertId").Value);
        Orders = await _requestAppService.GetExpertRequest(expertId, cancellationToken);
	}
}
