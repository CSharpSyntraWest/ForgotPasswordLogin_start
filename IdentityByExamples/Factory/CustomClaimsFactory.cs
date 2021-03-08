using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
//ADDED 35: CustomClaimsFactory class
namespace IdentityByExamples.Factory
{
    public class CustomClaimsFactory: UserClaimsPrincipalFactory<IdentityUser>
    {
        public CustomClaimsFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        { }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("username", user.UserName));
            //identity.AddClaim(new Claim("birthdate", user.));

            return identity;
        }

    }
}
