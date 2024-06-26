﻿using HomeService.Core.DTOs;

namespace HomeService.Core.Contracts.CommentContracts;

public interface ICommentAppService
{
    Task CreateCommentDto(CreateCommentDto model, CancellationToken cancellationToken);
    Task CreateComment(CommentDto model, CancellationToken cancellationToken);
    Task<int> CountComments(CancellationToken cancellationToken);
    Task<bool> IsActive(int id, CancellationToken cancellationToken);
    Task Active(int id, CancellationToken cancellationToken);
    Task DeActive(int id, CancellationToken cancellationToken);
    Task DeleteCommentById(int id, CancellationToken cancellationToken);
    Task<List<CommentDto>> GetAllComments(CancellationToken cancellationToken);
    Task<CommentDto> GetCommentById(int commentId, CancellationToken cancellationToken);
    Task UpdateComment(CommentDto model, CancellationToken cancellationToken);
}
