using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class UsersTokenCache
    {
        public int TokenId { get; set; }
        public byte[] CacheBits { get; set; }
        public string UserId { get; set; }
        public string Uniquecookie { get; set; }
    }
}
