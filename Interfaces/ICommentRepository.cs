using Finance_app.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Scalar.AspNetCore;
using Finance_app.Models;
using Finance_app.DTOs.Stock;

namespace Finance_app.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();

        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id, Comment commentModel);

        Task<Comment?> DeleteAsync(int id);
    }
}
