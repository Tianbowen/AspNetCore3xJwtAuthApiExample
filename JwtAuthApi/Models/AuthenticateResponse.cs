using JwtAuthApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JwtAuthApi.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string JwtToken { get; set; }

        [JsonIgnore]
        public string RefreshToken { get; set; }
        public AuthenticateResponse(User user,string token,string refreshToken)
        {
            Id = user.Id;
            UserName = user.UserName;
            JwtToken = token;
            RefreshToken = refreshToken;
        }
    }
}
