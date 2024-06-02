using HomeService.Core.Contracts.BidContracts;
using HomeService.Core.DTOs;
using HomeService.Core.Entities;

namespace HomeService.Core.Services.AppServices;

public class BidAppService : IBidAppService
{
    #region Fields
    private readonly IBidService _bidService;
    #endregion

    #region Ctors
    public BidAppService(IBidService bidService)
    {
        _bidService = bidService;
    }
    #endregion

    #region Implementations
    public async Task CreateBid(BidDto model, CancellationToken cancellationToken)
   => await _bidService.CreateBid(model, cancellationToken);

    public async Task<int> CountBids(CancellationToken cancellationToken)
        => await _bidService.CountBids(cancellationToken);

    public async Task<bool> IsActive(int id, CancellationToken cancellationToken)
        => await _bidService.IsActive(id, cancellationToken);

    public async Task Active(int id, CancellationToken cancellationToken)
    {
        await _bidService.Active(id, cancellationToken);
    }

    public async Task DeActive(int id, CancellationToken cancellationToken)
    {
        await _bidService.DeActive(id, cancellationToken);
    }
    public async Task AcceptRequest(int id, CancellationToken cancellationToken)
    {
        await _bidService.AcceptRequest(id, cancellationToken);
    }

    public async Task DeleteBidById(int id, CancellationToken cancellationToken)
    {
        await _bidService.DeleteBidById(id, cancellationToken);
    }

    public async Task<List<BidDto>> GetAllBids(CancellationToken cancellationToken)
        => await _bidService.GetAllBids(cancellationToken);

    public async Task<Bid>? GetBidById(int id, CancellationToken cancellationToken)
        => await _bidService.GetBidById(id, cancellationToken);

    public async Task UpdateBid(BidDto model, CancellationToken cancellationToken)
    {
        await _bidService.UpdateBid(model, cancellationToken);
    }

    public async Task<List<BidDto>> GetBidsByOrderId(int orderId, CancellationToken cancellationToken)
        => await _bidService.GetBidsByOrderId(orderId, cancellationToken);

    public async Task CreateBidByRequestId(CreateBidDto model, CancellationToken cancellationToken)
        => await _bidService.CreateBidByRequestId(model, cancellationToken);

    #endregion
}
