using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Implementations
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Comment>> GetAllComments()
        {
            return await _unitOfWork.Comments.GetAllAsync();
        }

        public async Task<Comment> GetCommentById(int id)
        {
            return await _unitOfWork.Comments.GetByIdAsync(id);
        }

        public async Task<Comment> CreateComment(Comment comment)
        {
            if (comment == null)
                throw new ArgumentNullException(nameof(comment));

            await _unitOfWork.Comments.AddAsync(comment);
            await _unitOfWork.SaveChangesAsync();
            return comment;
        }

        public async Task UpdateComment(Comment comment)
        {
            if (comment == null)
                throw new ArgumentNullException(nameof(comment));

            _unitOfWork.Comments.Update(comment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteComment(int id)
        {
            var comment = await _unitOfWork.Comments.GetByIdAsync(id);
            if (comment == null)
                throw new ArgumentException($"Yorum bulunamadı. ID: {id}");

            _unitOfWork.Comments.Remove(comment);
            await _unitOfWork.SaveChangesAsync();
        }
    }
} 