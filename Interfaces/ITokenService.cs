using Finance_app.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Scalar.AspNetCore;
using Finance_app.Models;

namespace Finance_app.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
