using IdentityModel.AspNetCore.AccessTokenManagement;
using System.Collections.Concurrent;
using System.Security.Claims;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8613 // Nullability of reference types in return type doesn't match implicitly implemented member.
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.

namespace ProjetoFinal.Web.Blazor.Identity
{
    public class CustomTokenStore : IUserAccessTokenStore
    {
        readonly ConcurrentDictionary<string, UserAccessToken> _tokens = new();

        public Task ClearTokenAsync(ClaimsPrincipal user, UserAccessTokenParameters? parameters = null)
        {
            var sub = user.FindFirst("sub").Value;
            _tokens.TryRemove(sub, out _);
            return Task.CompletedTask;
        }

        public Task<UserAccessToken> GetTokenAsync(ClaimsPrincipal user, UserAccessTokenParameters? parameters = null)
        {
            var sub = user.FindFirstValue("sub");

            UserAccessToken? value = null;

            if (sub != null)
                _tokens.TryGetValue(sub, out value);

            return Task.FromResult(value);
        }

        public UserAccessToken GetToken(ClaimsPrincipal user, UserAccessTokenParameters? parameters = null)
        {
            var sub = user.FindFirstValue("sub");

            UserAccessToken? value = null;

            if (sub != null)
                _tokens.TryGetValue(sub, out value);

            return value;
        }

        public Task StoreTokenAsync(ClaimsPrincipal user, string accessToken, DateTimeOffset expiration, string? refreshToken = null, UserAccessTokenParameters? parameters = null)
        {
            var sub = user.FindFirst("sub").Value;
            var token = new UserAccessToken
            {
                AccessToken = accessToken,
                Expiration = expiration,
                RefreshToken = refreshToken
            };
            _tokens[sub] = token;
            return Task.CompletedTask;
        }
    }
}

#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8613 // Nullability of reference types in return type doesn't match implicitly implemented member.
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.