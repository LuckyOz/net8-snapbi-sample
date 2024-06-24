
using Microsoft.AspNetCore.Mvc;

namespace Manager.Models.Request
{
    public class AccessTokenHeaderRequest
    {
        [FromHeader(Name = "X-TIMESTAMP")]
        public string? TimeStamp { get; set; }

        [FromHeader(Name = "X-CLIENT-KEY")]
        public string? ClientKey { get; set; }

        [FromHeader(Name = "X-SIGNATURE")]
        public string? Signature { get; set; }
    }
}
