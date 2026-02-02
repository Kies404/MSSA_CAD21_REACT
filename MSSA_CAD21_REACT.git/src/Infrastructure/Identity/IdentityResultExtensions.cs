using MSSA_CAD21_REACT.git.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace MSSA_CAD21_REACT.git.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
