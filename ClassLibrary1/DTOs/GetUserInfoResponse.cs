using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.DTOs
{
    public class GetUserInfoResponse
    {
        public Guid UserId { get; set; }
        public String FullName{ get; set; }
    }
}
