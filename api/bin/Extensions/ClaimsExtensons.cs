using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.bin.Extensions
{
    public class ClaimsExtensons
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.Claims.SingleOrDefault(x=>x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname")).Value;
        }
    }
}