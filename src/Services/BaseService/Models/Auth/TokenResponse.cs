using System;

namespace BaseService.Models.Auth
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
} 